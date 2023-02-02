using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashRegister
{
    public class ProductsDB
    {
        public string[] dataText = File.ReadAllLines("ProductDB.txt");
        public List<string[]> dataLines = new List<string[]>();
        public List<Product> dataProducts = new List<Product>();

        public ProductsDB()
        {
            for (int i = 0; i < dataText.Length; i++)
            {
                string[] line = dataText[i].Split(';');
                dataLines.Add(line);
                Product product = new Product(dataLines[i][0], dataLines[i][1], dataLines[i][2]);
                dataProducts.Add(product);
            }
        }

        public Product GetProduct(string id)
        {
            Product product = new Product("0", "Неверный штрих-код", "0");
            for (int i = 0; i < dataProducts.Count; i++)
            {
                if (dataProducts[i].productId == id)
                {
                    product = dataProducts[i];
                }
            }
            return product;
        }
    }
}
