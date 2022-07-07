using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV.Model
{
    class ItemOrder
    {
        int _idOrder;
        int _idBook;
        int _quant;

        public ItemOrder(int idBook, int quant)
        {
            IdBook = idBook;
            Quant = quant;
        }
        public ItemOrder(int idOrder,int idBook, int quant)
        {
            IdOrder = idOrder;
            IdBook = idBook;
            Quant = quant;

        }

        public int IdOrder
        {
            set
            {
                _idOrder = value;
            }
            get
            {
                return _idOrder;
            }
        }
        public int IdBook
        {
            set
            {
                _idBook = value;
            }
            get
            {
                return _idBook;
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

    }
}
