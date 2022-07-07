using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV.Model
{
    public class Order
    {
        string _payForm;
        int _idClient;
        DateTime _date;
        float _amount;
        int _idAdm;

        public Order(int Id_Order)
        {
            IdOrder = Id_Order;
        }
        public Order(int Id_Order, int id_Client, int id_Adm)
        {
            IdOrder = Id_Order;
            IdClient = id_Client;
            IdAdm = id_Adm;
        }
        public Order(string payForm)
        {
            PayForm = payForm;
        }
        public Order(string payForm, int idClient, DateTime date, float amount, int idAdm)
        {
            PayForm = payForm;
            IdClient = idClient;
            Date = date;
            Amount = amount;
            IdAdm = idAdm;
        }
        public Order(int idOrder,string payForm, int idClient, DateTime date, float amount, int idAdm)
        {
            IdOrder = idOrder;
            PayForm = payForm;
            IdClient = idClient;
            Date = date;
            Amount = amount;
            IdAdm = idAdm;
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
        public int IdAdm
        {
            set
            {

                _idAdm = value;
            }
            get
            {
                return _idAdm;
            }
        }
    }
}
