using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashRegister
{
    public class Product
    {
        public string productId;
        public string productName;
        public string productPrice;

        public Product(string id, string name, string price) 
        { 
            productId = id; 
            productName = name; 
            productPrice = price; 
        }
    }
}
