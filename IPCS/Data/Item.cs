using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPCS.Data
{
    public class Item
    {
        public Item(Data.Product product, int quantity)
        {
            Product = product;
            Quantity = quantity;
            Total = quantity * product.Price;
        }

        public Data.Product Product;
        private int _Quantity;
        public int Quantity
        {
            get
            {
                return _Quantity;
            }
            set
            {
                Total = value * Product.Price;
                _Quantity = value;
            }
        }
        public double Total;
    }
}
