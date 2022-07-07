using System;

namespace PDV.Model
{
    public class Product
    {
        public int _id;
        public string _description;
        public int _quant;
        public float _value;

        public Product(string description, int quant, float value)
        {
            Description = description;
            Quant = quant;
            Value = value;
        }

        public Product(int id, string description, int quant, float value)
        {
            Id = id;
            Description = description;
            Quant = quant;
            Value = value;
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

        public string Description
        {
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new Exception("Descrição nao pode ser nulo ou vazio!!");
                _description = value;
            }
            get
            {
                return _description;
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
    }
}
