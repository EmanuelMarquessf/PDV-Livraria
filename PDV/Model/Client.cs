using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV.Model
{
    public class Client
    {
        public int _id;
        public string _name;
        public string _cpf;
        public string _email;
        public string _fone;
        public bool _status;

        public Client(int id)
        {
            Id = id;
        }
        public Client(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public Client(string name, string cpf, string email, string fone)
        {
            Name = name;
            Cpf = cpf;
            Email = email;
            Fone = fone;
        }

        public Client(int id, string name, string cpf, string email, string fone)
        {
            Id = id;
            Name = name;
            Cpf = cpf;
            Email = email;
            Fone = fone;
        }
        public Client(int id, string name, string cpf)
        {
            Id = id;
            Name = name;
            Cpf = cpf;
        }

        public Client(int id, string name, string cpf, string email, string fone, bool status)
        {
            Id = id;
            Name = name;
            Cpf = cpf;
            Email = email;
            Fone = fone;
            Status = status;
        }

        public int Id
        {
            set
            {
                _id = value;
            }
            get
            {
                return _id;
            }
        }

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
        public string Cpf
        {
            set
            {
                if (String.IsNullOrEmpty(value))
                    _cpf = "";

                if (value.Length < 11 && value.Length != 0)
                    throw new Exception("CPF deve conter 11 digitos!!");

                //if(!Validation.ValidateCpf(value))
                //    throw new Exception("CPF inválido");

                _cpf = value;
            }
            get
            {
                return _cpf;
            }
        }
        public string Email
        {
            set
            {
                if (String.IsNullOrEmpty(value))
                    _email = "";
                else if (!value.Contains('@'))
                    throw new Exception("Email Invalido!!");
                _email = value;
            }
            get
            {
                return _email;
            }
        }
        public string Fone
        {
            set
            {
                if (String.IsNullOrEmpty(value))
                    _fone = "";
                else if (value.Length != 11)
                    throw new Exception("Telefone deve ter 11 digitos!!");
                _fone = value;
            }
            get
            {
                return _fone;
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
    }
}
