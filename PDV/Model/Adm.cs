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
        string _office;
        bool _status;

        public Adm(int id)
        {
            Id = id;
        }
        public Adm(int id, string password)
        {
            Id = id;
            Password = password;
        }
        public Adm(string login, string password)
        {
            Login = login;
            Password = password;
        }
        public Adm(int id, string login, string password)
        {
            Id = id;
            Login = login;
            Password = password;
        }
        public Adm( string login, string name, string password, string office, bool status)
        {
            Login = login;
            Name = name;
            Password = password;
            Office = office;
            Status = status;
        }
        public Adm(int id, string login, string name, string password, string office)
        {
            Id = id;
            Login = login;
            Name = name;
            Password = password;
            Office = office;
        }

        public Adm(int id, string login, string name, string password, string office, bool status)
        {
            Id = id;
            Login = login;
            Name = name;
            Password = password;
            Office = office;
            Status = status;
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
        public string Office
        {
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new Exception("Cargo não pode ser vazio!");

                _office = value;
            }
            get
            {
                return _office;
            }
        }
        public bool Status
        {
            set
            {
                _status = value;
            }
            get
            {
                return _status;
            }
        }

        public object Security { get; internal set; }
    }
}
