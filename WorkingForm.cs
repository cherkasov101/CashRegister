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
    public partial class WorkingForm : Form
    {
        private int countOfGood = 1; //колличество товара
        private string idProductField = ""; //отображаемый штрих-код товара
        private bool adminRights; //права администратора
        public static UserClass user;
        public ProductsDB db = new ProductsDB();
        Receipt receipt;

        public WorkingForm()
        {
            InitializeComponent();
            nameEmployee.Text = LoginForm._userClass.name;
            idProduct.Text = "Штрих-код";
            countProduct.Text = Convert.ToString(countOfGood);
            adminRights = LoginForm._userClass.adminRights;
            user = LoginForm._userClass;
        }

        //кнопка закрытия приложения
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        //кнопка сворачивания приложения
        private void CollapseButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        Point lastPoint; //задаёт координаты

        //создаёт возможность перемещать окно по экрану
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        //создаёт начало перемещения окна по экрану нажатием левой кнопки мыши
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        //Добавить сотрудника
        private void addEmployee_Click(object sender, EventArgs e)
        {
            if (adminRights)
            {
                AddEmployeeForm addEmployeeForm = new AddEmployeeForm();
                addEmployeeForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Недостаточно прав");
            }
        }

        //Добавить товар
        private void addProduct_Click(object sender, EventArgs e)
        {
            if (adminRights)
            {
                AddProductForm addProductForm = new AddProductForm();
                addProductForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Недостаточно прав");
            }
        }

        //Увеличивает колличество товара
        private void btnPlus_Click(object sender, EventArgs e)
        {
            countOfGood++;
            countProduct.Text = countOfGood.ToString();
        }

        //Уменьшает колличество товара
        private void btnMinus_Click(object sender, EventArgs e)
        {
            countOfGood--;
            if (countOfGood >= 0)
            {
                countProduct.Text = countOfGood.ToString();
            }
            else
            {
                countProduct.Text = "0";
                countOfGood = 0;
            }
        }

        //клавиатура
        private void btnOne_Click(object sender, EventArgs e)
        {
            addToIdProductField("1");
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            addToIdProductField("2");
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            addToIdProductField("3");
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            addToIdProductField("4");
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            addToIdProductField("5");
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            addToIdProductField("6");
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            addToIdProductField("7");
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            addToIdProductField("8");
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            addToIdProductField("9");
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            addToIdProductField("0");
        }

        //добавляет цифру с клавиатуры в поле штрих-кода
        private void addToIdProductField(string number)
        {
            idProductField += number;
            idProduct.Text = idProductField;
        }

        //Выход из рабочей зоны на форму авторизации
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();    
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }

        private void receiptTextBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Введите штрих-код и колличество товара");
        }

        //Добавление товара в чек
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(receipt == null)
            {
                receipt = new Receipt(db.GetProduct(idProductField), countOfGood);
            }
            else
            {
                receipt.addProduct(db.GetProduct(idProductField), countOfGood);
            }
            if(db.GetProduct(idProductField).productId == "0")
            {
                MessageBox.Show("Тован не найден");
            }
            receiptTextBox.Text = receipt.getReceipt();
            idProduct.Text = "";
            idProductField = "";
        }

        //Удаление товара
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(receipt == null)
            {
                MessageBox.Show("Чек пуст");
            }
            else
            {
                receipt.deleteProduct(idProductField, countOfGood);
            }
            receiptTextBox.Text = receipt.getReceipt();
            idProduct.Text = "";
            idProductField = "";
        }

        private void btnPayInCash_Click(object sender, EventArgs e)
        {
            CashForm cashForm = new CashForm();
            cashForm.ShowDialog();
            receipt = null;
            receiptTextBox.Text = "";
        }

        private void btnPayInCard_Click(object sender, EventArgs e)
        {
            receiptTextBox.Text = "";
            receipt = null;
            MessageBox.Show(File.ReadAllText("Receipt.txt"));
        }
    }
}
