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
        int _idProduct;
        int _quant;

        public ItemOrder(int idProduct, int quant)
        {
            IdProduct = idProduct;
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
        public int IdProduct
        {
            set
            {
                _idProduct = value;
            }
            get
            {
                return _idProduct;
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
