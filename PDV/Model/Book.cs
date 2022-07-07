using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV.Model
{
    public class Book
    {
        public int _id;
        public string _title;
        public int _quant;
        public float _value;
        public string _author;
        public string _company;
        public int _pages;
        public string _gender;
        public int _volume;
        public string _edition;
        public string _isbn;
        public string _language;
        public string _cover;
        public string _releaseDate;
        public bool _status;
        

        public Book(int id)
        {
            Id = id;
        }

        public Book(int id,string title, int quant, float value)
        {
            Id = id;
            Title = title;
            Quant = quant;
            Value = value;
        }

        public Book(string title, int quant, float value, string author, string company, int pages, string gender, int volume, string edition, string isbn, string language, string cover, string releaseDate)
        {
            Title = title;
            Quant = quant;
            Value = value;
            Author = author;
            Company = company;
            Pages = pages;
            Gender = gender;
            Volume = volume;
            Edition = edition;
            Isbn = isbn;
            Language = language;
            Cover = cover;
            ReleaseDate = releaseDate;
        }


        public Book(int id, string title, int quant, float value, string author, string company, int pages, string gender, int volume, string edition, string isbn, string language, string cover, string releaseDate, bool status)
        {
            Id = id;
            Title = title;
            Quant = quant;
            Value = value;
            Author = author;
            Company = company;
            Pages = pages;
            Gender = gender;
            Volume = volume;
            Edition = edition;
            Isbn = isbn;
            Language = language;
            Cover = cover;
            ReleaseDate = releaseDate;
            Status = status;
            
        }
        public Book(int id, string title, int quant, float value, string author, string company, int pages, string gender, int volume, string edition, string isbn, string language, string cover, bool status)
        {
            Id = id;
            Title = title;
            Quant = quant;
            Value = value;
            Author = author;
            Company = company;
            Pages = pages;
            Gender = gender;
            Volume = volume;
            Edition = edition;
            Isbn = isbn;
            Language = language;
            Cover = cover;
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

        public string Title
        {
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new Exception("Titulo nao pode ser nulo ou vazio!!");
                _title = value;
            }
            get
            {
                return _title;
            }
        }
        public int Quant
        {
            set
            {
                _quant = value;
            }
            get
            {
                return _quant;
            }
        }

        public float Value
        {
            set
            {
                if (value.Equals(0))
                    throw new Exception("Preco não pode ser 0!!");
                if (value.Equals(null))
                    throw new Exception("Preco não pode ser vazio!!");
                _value = value;
            }
            get
            {
                return _value;
            }
        }

        public string Author
        {
            set
            {
                if (String.IsNullOrEmpty(value))
                    _author = "";
                _author = value;
            }
            get
            {
                return _author;
            }
        }

        public string Company
        {
            set
            {
                if (String.IsNullOrEmpty(value))
                    _company = "";
                _company = value;
            }
            get
            {
                return _company;
            }
        }

        public int Pages
        {
            set
            {
                if (value.Equals(0))
                    _pages = 0;
                if (value.Equals(null))
                    throw new Exception("Numero de paginas não pode ser vazio!!");
                _pages = value;
            }
            get
            {
                return _pages;
            }
        }

        public string Gender
        {
            set
            {
                if (String.IsNullOrEmpty(value))
                    _gender = "";
                _gender = value;
            }
            get
            {
                return _gender;
            }
        }

        public int Volume
        {
            set
            {
                if (value.Equals(null))
                    _volume = 1;
                _volume = value;
            }
            get
            {
                return _volume;
            }
        }

        public string Edition
        {
            set
            {
                if (String.IsNullOrEmpty(value))
                    _edition = "";
                _edition = value;
            }
            get
            {
                return _edition;
            }
        }

        public string Isbn
        {
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new Exception("Isbn nao pode ser nulo ou vazio!!");
                _isbn = value;
            }
            get
            {
                return _isbn;
            }
        }

        public string Language
        {
            set
            {
                if (String.IsNullOrEmpty(value))
                    _language = "";
                _language = value;
            }
            get
            {
                return _language;
            }
        }

        public string Cover
        {
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new Exception("Tipo de capa não pode ser nulo ou vazio!!");
                _cover = value;
            }
            get
            {
                return _cover;
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
        public string ReleaseDate
        {
            set
            {
                if (String.IsNullOrEmpty(value))
                    _releaseDate = "";
                _releaseDate = value;
            }
            get
            {
                return _releaseDate;
            }
        }
    }
}
