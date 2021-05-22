using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class LoginForm
    {
        private readonly UserLoginType loginType;

        public string UserName { get; set; }
        public String PassWord { get; set; }
        public UserLoginType LoginType { get; set; }

        public UserLoginType LoginType1 => loginType;

        public LoginForm(string Username, string Password, UserLoginType LoginType )
        {
            UserName = UserName;
            PassWord = PassWord;
            LoginType = loginType;
        }
         
    }

    public enum UserLoginType
    {
        OWNER,EMPLOYEE
    }
}
