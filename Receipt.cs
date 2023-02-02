using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashRegister
{
    internal class Receipt
    {
        public List<Product> productsInReceipt; //товара, добавленные в чек
        private string receiptFile = "Receipt.txt"; //файл, в который записывается текст чека

        public Receipt(Product product, int count) 
        {
            productsInReceipt = new List<Product>();
            for (int i = 0; i < count; i++)
            {
                productsInReceipt.Add(product);
            }        
        }

        //добавить новый товар в чек
        public void addProduct(Product product, int count) 
        {
            for (int i = 0; i < count; i++)
            {
                productsInReceipt.Add(product);
            }
        }

        //удалить товар из чека
        public void deleteProduct(string id, int count)
        {
            for(int j = 0; j < count; j++)
            {
                for(int i = 0; i < productsInReceipt.Count; i++) 
                { 
                    if(productsInReceipt[i].productId == id)
                    {
                        productsInReceipt.RemoveAt(i);
                        break;
                    }
                }
            }
        }

        //Создаёт текст чека
        public string getReceipt()
        {
            string receipt = "";
            int cost = 0;
            
            foreach (Product product in productsInReceipt)
            {
                if (product.productId == "0")
                {
                    continue;
                }
                receipt += product.productName + " ";
                receipt += product.productPrice + "\n";
                try
                {
                    cost += Int32.Parse(product.productPrice);
                }
                catch 
                { 
                    cost += 0; 
                }
            }
            File.WriteAllText(receiptFile, receipt);
            receipt = improveReceipt();
            receipt += "\nИтого: " + Convert.ToString(cost);
            File.WriteAllText(receiptFile, receipt);
            return receipt;
        }

        //улучшает текст чека (добавляет в него подсчёт количества одинакового товара и его общую стоимость)
        private string improveReceipt()
        {
            string receipt = "";
            string[] lines = File.ReadAllLines(receiptFile);
            foreach (string line in lines)
            {
                int count = 0;
                string[] posicionInReceipt = line.Split(' ');
                int price = 0;
                try
                {
                    price = Convert.ToInt32(posicionInReceipt[1]);
                }
                catch 
                { 
                    price = 0;
                }
                foreach (string posicion in lines)
                {
                    if (line.Equals(posicion))
                    {
                        count++;
                    }
                }
                price = price * count;
                receipt += posicionInReceipt[0] + " " + price.ToString() + " ";
                receipt += count.ToString() + " шт.\n";
            }
            string[] finalPositions = receipt.Split('\n');
            receipt = "";
            for (int i = 0; i < finalPositions.Length; i++)
            {
                int index = i;
                int count = 0;
                for (int j = 0; j < finalPositions.Length; j++)
                {
                    if (finalPositions[i].Equals(finalPositions[j]))
                    {
                        count++;
                        index = j;
                    }
                }
                if (count > 1 && index == i)
                {
                    receipt += finalPositions[i] + "\n";
                }
                if (count == 1)
                {
                    receipt += finalPositions[i] + "\n";
                }
            }
            return receipt;
        }
    }
}
