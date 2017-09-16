using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPCS.Data
{
    [Serializable]
    public class Product
    {
        #region Constructor

        public Product(int id, string productName, double price, double cost, int quantity)
        {
            ID = id;
            ProductName = productName;
            Price = price;
            Cost = cost;
            Quantity = quantity;
            NumSold = 0;
        }

        #endregion

        #region Properties
        
        public int ID { get; set; }
        
        public string ProductName { get; set; }
        
        public double Price { get; set; }

        public double Cost { get; set; }

        public int Quantity { get; set; }

        public int NumSold { get; set; }

        #endregion

        #region Members

        public int Stock { get { return Quantity - NumSold; } }

        public double CurrentSale { get { return Price * NumSold; } }

        public double CurrentGain { get { return (Price - Cost) * NumSold; } }

        public double ExpectedSale { get { return Price * Quantity; } }

        public double ExpectedGain { get { return (Price - Cost) * Quantity; } }

        public double TotalCost { get { return Cost * Quantity; } }

        #endregion
    }
}
