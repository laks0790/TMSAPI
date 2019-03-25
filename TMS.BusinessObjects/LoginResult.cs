using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.BusinessObjects
{
    public class LoginResult
    {
        public bool isLoggedIn { get; set; }
        public string message { get; set; }
        public string userId { get; set; }
        public string loggedinTime { get; set; }
        public string token { get; set; }
    }

    public class LoginRequest
    {
       
        public string username { get; set; }
        public string password { get; set; }
        public string companyname { get; set; }
        
    }
}
