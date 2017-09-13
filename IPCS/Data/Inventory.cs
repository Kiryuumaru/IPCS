using System;
using System.Collections.Generic;

namespace IPCS.Data
{
    [Serializable]
    public class Inventory
    {
        #region Constructor

        public Inventory()
        {
            Products = new List<Product>();
        }

        #endregion

        #region Properties
        
        public List<Product> Products { get; set; }

        #endregion

        #region Members

        public void NewProduct(Product product)
        {
            Products.Add(product);
        }

        public void DeleteProduct(int id)
        {
            for(int i = 0; i < Products.Count; i++)
            {
                if (Products[i].ID.Equals(id)) Products.RemoveAt(i);
            }
        }

        #endregion
    }
}
