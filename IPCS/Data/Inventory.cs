using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.ComponentModel;

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

        public void AddProduct(Product product)
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

        public Product GetRow(int rowId)
        {
            return Products[rowId];
        }

        public T GetColumn<T>(Columns columnId)
        {
            object value;
            switch (columnId)
            {
                case Columns.ID:
                    value = Products.Select(row => row.ID).ToArray();
                    break;
                case Columns.ProductName:
                    value = Products.Select(row => row.ProductName).ToArray();
                    break;
                case Columns.Price:
                    value = Products.Select(row => row.Price).ToArray();
                    break;
                case Columns.Cost:
                    value = Products.Select(row => row.Cost).ToArray();
                    break;
                case Columns.Stock:
                    value = Products.Select(row => row.Stock).ToArray();
                    break;
                case Columns.CurrentSale:
                    value = Products.Select(row => row.CurrentSale).ToArray();
                    break;
                case Columns.CurrentGain:
                    value = Products.Select(row => row.CurrentGain).ToArray();
                    break;
                case Columns.ExpextedSale:
                    value = Products.Select(row => row.ExpectedSale).ToArray();
                    break;
                case Columns.ExpectedGain:
                    value = Products.Select(row => row.ExpectedGain).ToArray();
                    break;
                default:
                    value = default(T);
                    break;
            }
            return (T)value;
        }
        
        public DataTable AddColumn<T>(DataTable data, T[] column)
        {
            DataColumn tableColumn = new DataColumn("XomeName", typeof(T));
            data.Columns.Add(tableColumn);
            return data;
        }

        public DataTable InventoryTable(params Columns[] columns)
        {
            DataTable table = new DataTable();



            return table;
        }
        
        #endregion
    }
}
