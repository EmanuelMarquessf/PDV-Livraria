using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV.Model
{
    class Order
    {
        string _payForm;
        int _idClient;
        DateTime _date = DateTime.Today;
        float _amount;

        public Order(string payForm, int idClient, DateTime date, float amount)
        {
            PayForm = payForm;
            IdClient = idClient;
            Date = date;
            Amount = amount;
        }

        public int IdOrder { get; set; }

        public string PayForm
        {
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new Exception("Forma nao pode ser nulo ou vazio!!");
                _payForm = value;
            }
            get
            {
                return _payForm;
            }
        }

        public int IdClient
        {
            set
            {
    
                _idClient = value;
            }
            get
            {
                return _idClient;
            }
        }
        public DateTime Date
        {
            set
            {
                _date = DateTime.Today;
            }
            get
            {
                return _date;
            }
        }
        public float Amount
        {
            set
            {
                _amount = value;
            }
            get
            {
                return _amount;
            }
        }
    }
}
