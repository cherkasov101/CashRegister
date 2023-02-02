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
    public partial class AddProductForm : Form
    {

        public AddProductForm()
        {
            InitializeComponent();
            nameField.Text = "Название";
            priceField.Text = "Цена";
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

        private void nameField_Click(object sender, EventArgs e)
        {
            nameField.Text = "";
        }

        private void priceField_Click(object sender, EventArgs e)
        {
            priceField.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string file = File.ReadAllText("ProductDB.txt");
            string name = nameField.Text;
            if (name.Contains(" "))
            {
                MessageBox.Show("Используйте '_' вместо пробела");
            }
            else
            {
                string price = priceField.Text;
                string[] lines = File.ReadAllLines("ProductDB.txt");
                string[] parts = lines[lines.Length - 1].Split(';');
                string id = parts[0];
                int newId = Int32.Parse(id) + 1;
                id = newId.ToString();
                string line = "\n" + id + ";" + name + ";" + price;
                File.WriteAllText("ProductDB.txt", file + line);
                MessageBox.Show("Товар добавлен\n" + "Штрих код: " + id);
                nameField.Text = "";
                priceField.Text = "";
            }
        }
    }
}
