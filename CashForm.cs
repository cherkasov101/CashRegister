using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashRegister
{
    public partial class CashForm : Form
    {
        string money = "";
        string receipt = File.ReadAllText("Receipt.txt");
        int cost;

        public CashForm()
        {
            InitializeComponent();
            makeCost();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CollapseButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        Point lastPoint;

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            
            lastPoint = new Point(e.X, e.Y);
            
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            addToMoneyField("1");
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            addToMoneyField("2");
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            addToMoneyField("3");
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            addToMoneyField("4");
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            addToMoneyField("5");
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            addToMoneyField("6");
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            addToMoneyField("7");
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            addToMoneyField("8");
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            addToMoneyField("9");
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            addToMoneyField("0");
        }

        private void addToMoneyField(string number)
        {
            money += number;
            moneyField.Text = money;
        }

        private void makeCost() 
        {
            string[] receiptParts = receipt.Split(' ');
            string price = receiptParts[receiptParts.Length - 1];
            cost = Int32.Parse(receiptParts[receiptParts.Length - 1]);
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            try
            {
                int payedMoney = Int32.Parse(money);
                int change = 0;
                if (payedMoney < cost)
                {
                    MessageBox.Show("Недостаточно денег");
                    this.Close();
                }
                else
                {
                    change = payedMoney - cost;
                    receipt += "\n \nОплачено: " + money.ToString() + "\nСдача: " + change.ToString();
                    MessageBox.Show(receipt);
                    this.Close();
                    File.WriteAllText("Receipt.txt", receipt);
                }
            }
            catch
            {
                MessageBox.Show("Некорректный ввод суммы");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            moneyField.Text = "";
            money = "";
        }
    }
}
