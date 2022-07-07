using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV.Model
{
    public class Adm
    {
        string _login;
        string _name;
        string _password;

        public Adm(string login, string password)
        {
            Login = login;
            Password = password;
        }
        public Adm( string login, string name, string password)
        {
            Login = login;
            Name = name;
            Password = password;
        }
        public Adm(int id, string login, string name, string password)
        {
            Id = id;
            Login = login;
            Name = name;
            Password = password;
        }

        public int Id{ get; set; }
        public string Name
        {
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new Exception("Nome nao pode ser nulo ou vazio!!");

                _name = value;
            }
            get
            {
                return _name;
            }
        }
        public string Login
        {
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new Exception("Login nao pode ser vazio!");

                if (value.Length < 1)
                    throw new Exception("Login deve conter mais de 1 caracteres!");
                _login = value;
            }
            get
            {
                return _login;
            }
        }
        public string Password
        {
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new Exception("Senha nao pode ser nulo ou vazio!!");
                _password = value;
            }
            get
            {
                return _password;
            }
        }
    }
}
