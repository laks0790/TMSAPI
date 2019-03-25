using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
 
using System.Web.Http.Results;
using TMS.BusinessObjects;
using TMS.Data;

namespace TMS.Api.Controllers
{
    [System.Web.Http.Cors.EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
   [System.Web.Http.Route("api/login")]
    public class LoginController : ApiController
    {
        [System.Web.Http.HttpPost]
       // [AllowAnonymous]
        //[Route("Token")]
        public LoginResult Token([FromBody] LoginRequest loginRequest)//[FromBody]string username, [FromBody]string password, [FromBody]string companyname
        {
            UserAccessDL userAccessDL = new UserAccessDL();
            var result = new LoginResult();
            //  var isauth = userAccessDL.isAuthorized(username, companyname);
            if (true) {
                var userInfo = userAccessDL.Login(loginRequest.username, loginRequest.password);
                if (userInfo == null)
                {
                    result.message = "user not found";
                    result.isLoggedIn = false;
                    result.token = string.Empty;
                }
                else
                {
                    result.message = "success";
                    result.token = JwtManager.GenerateToken(loginRequest.username);
                    result.loggedinTime = Convert.ToString(userInfo.lastlogindate.Value);
                    result.isLoggedIn = true;
                    result.userId = Convert.ToString(userInfo.userkey);
                }
                return result;
            }

        }
        [HttpPost]
        [Route("ResetPassword")]
        [AllowAnonymous]
        public string ResetPassword(string username, string newPassword)
        {
            UserAccessDL userAccessDL = new UserAccessDL();
            bool success = userAccessDL.resetPassword(username, newPassword);
            if (!success)
            {
                return  "User Not found!" ;
            }
            else
            {
                return "Password Updated!";
            }
        }
    }
    }
