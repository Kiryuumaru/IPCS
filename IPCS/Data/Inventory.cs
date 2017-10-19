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

        public int ProductCount { get { return Products.Count; } }

        public Product GetProduct(int id)
        {
            for (int i = 0; i < Products.Count; i++)
            {
                if (Products[i].ID.Equals(id)) return Products[i];
            }
            return null;
        }

        public int GetID(int listIndex)
        {
            return listIndex + 1;
        }

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public void DeleteProduct(int id)
        {
            for (int i = 0; i < Products.Count; i++)
            {
                if (Products[i].ID.Equals(id)) Products.RemoveAt(i);
            }
            UpdateId();
        }

        public void ReplaceProduct(int id, Product product)
        {
            for (int i = 0; i < Products.Count; i++)
            {
                if (Products[i].ID.Equals(id)) Products[i] = product;
            }
            UpdateId();
        }

        public void UpdateId()
        {
            for (int i = 0; i < Products.Count; i++)
            {
                Products[i].ID = i + 1;
            }
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

        public void SetDataGridTable(DataGridView dataGridView)
        {
            List<object> data;
            Columns column;
            dataGridView.Rows.Clear();
            foreach (Product product in Products)
            {
                data = new List<object>();
                for (int i = 0; i < dataGridView.ColumnCount; i++)
                {
                    column = (Columns)dataGridView.Columns[i].Tag;
                    switch (column)
                    {
                        case Columns.ID:
                            data.Add(product.ID.ToString("0000"));
                            break;
                        case Columns.ProductName:
                            data.Add(product.ProductName);
                            break;
                        case Columns.Price:
                            data.Add(product.Price.ToString("0.00"));
                            break;
                        case Columns.Cost:
                            data.Add(product.Cost.ToString("0.00"));
                            break;
                        case Columns.Stock:
                            data.Add(product.Stock);
                            break;
                        case Columns.CurrentGain:
                            data.Add(product.CurrentGain.ToString("0.00"));
                            break;
                        case Columns.CurrentSale:
                            data.Add(product.CurrentSale.ToString("0.00"));
                            break;
                        case Columns.ExpectedGain:
                            data.Add(product.ExpectedGain.ToString("0.00"));
                            break;
                        case Columns.ExpextedSale:
                            data.Add(product.ExpectedSale.ToString("0.00"));
                            break;
                        case Columns.None:
                            data.Add(null);
                            break;
                    }
                }
                dataGridView.Rows.Add(data.ToArray());
            }
        }
        
        #endregion
    }
}
