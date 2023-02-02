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
    public partial class AddEmployeeForm : Form
    {
        List<string> ids = new List<string>();

        public AddEmployeeForm()
        {
            InitializeComponent();

            surnameField.Text = "Фамилия";
            nameField.Text = "Имя";
            patronymicField.Text = "Отчество";
            passwordField.Text = "Пароль";
            adminField.Text = "Кассир";
            makeIds();

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

        private void makeIds()
        {
            string[] lines = File.ReadAllLines("UserDB.txt");
            foreach (string line in lines)
            {
                string[] l = line.Split(';');
                ids.Add(l[0]);
            }
        }

        private void surnameField_Click(object sender, EventArgs e)
        {
            surnameField.Text = "";
        }

        private void nameField_Click(object sender, EventArgs e)
        {
            nameField.Text = "";
        }

        private void patronymicField_Click(object sender, EventArgs e)
        {
            patronymicField.Text = "";
        }

        private void passwordField_Click(object sender, EventArgs e)
        {
            passwordField.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string file = File.ReadAllText("UserDB.txt");
            string name = surnameField.Text + " " + nameField.Text + " " + patronymicField.Text;
            string password = passwordField.Text;
            string isAdmin = "0";
            if (adminField.Text == "Администратор") 
            {
                isAdmin = "1";
            }
            int id = Int32.Parse(ids[ids.Count - 1]) + 1;
            string line = "\n" + id.ToString() + ";" + password + ";" + name + ";" + isAdmin;
            File.WriteAllText("UserDB.txt", file + line);
            MessageBox.Show("Вы добавили нового сотрудника\nШтрих код: " 
                + id.ToString() 
                + "\nПароль: " 
                + password);
            this.Close();
        }
    }
}
