using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV.Model
{
    public class Login
    {
        
        public int _idLogin;
        public string _loginUser;
        public string _password;

        
        public Login(string loginUser, string password)
        {
            LoginUser = loginUser;
            Password = password;
        }

        public Login(int idLogin, string loginUser, string password)
        {
            IdLogin = idLogin;
            LoginUser = loginUser;
            Password = password;
        }

        public int IdLogin { get; set; }
        public string LoginUser
        {
            set
            {
                if(String.IsNullOrEmpty(value))
                    throw new Exception ("Login nao pode ser vazio!");

                if(value.Length <6)
                    throw new Exception ("Login deve conter mais de 6 caracteres!");
                _loginUser = value;
            }
            get
            {
                return _loginUser;
            }
        }

        public string Password
        {
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new Exception("Senha nao pode ser vazia!");

                if (value.Length < 6)
                    throw new Exception("Senha muito fraca!!");
                _password = value;
            }
            get
            {
                return _loginUser;
            }
        }



    }
}
