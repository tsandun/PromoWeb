using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using PromoWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.AspNet.Identity.Owin;


namespace PromoWeb.Controllers
{
    [RoutePrefix("api/Account")]
    public class AccountController : ApiController
    {
        private ApplicationUserManager _userManager;
        public ISecureDataFormat<AuthenticationTicket> AccessTokenFormat { get; private set; }
        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? Request.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }

        public AccountController()
        {

        }
        public AccountController(ApplicationUserManager userManager,
            ISecureDataFormat<AuthenticationTicket> accessTokenFormat)
        {
            UserManager = userManager;
            AccessTokenFormat = accessTokenFormat;
        }



        // POST api/Account/Register
        [AllowAnonymous]
        [Route("Register")]
        public async Task<IHttpActionResult> Register(RegisterBindingModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var user = new ApplicationUser() { UserName = model.Email, Email = model.Email, FirstName = model.FirstName, LastName = model.LastName };


            var result = await UserManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                //var code = await UserManager.GenerateEmailConfirmationTokenAsync(user.Id);
                //code = System.Web.HttpUtility.UrlEncode(code);
                ////service endpoint
                //string serviceEndpoint = System.Configuration.ConfigurationManager.AppSettings["ResetPasswordServiceEndpoint"];
                //var callbackUrl = serviceEndpoint + "AccountView/ConfirmEmail/?";


                //// ("ConfirmEmail", "AccountView", new { userId = user.Id, code = code }, protocol: Request.Url.Scheme);

                //var url = callbackUrl + "userId=" + user.Id + "&code=" + code;

                //await UserManager.SendEmailAsync(user.Id, "Verify your email", "Please <a href=" + url + ">click here</a> to verify your email address.");

            }

            if (!result.Succeeded)
            {
                return GetErrorResult(result);
            }

            return GetSucessResult(result);
        }

        private IHttpActionResult GetErrorResult(IdentityResult result)
        {
            return Ok(result);

        }

        private IHttpActionResult GetSucessResult(IdentityResult result)
        {

            return Ok(result);

        }
    }
}
