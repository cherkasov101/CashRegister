using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashRegister
{
    public partial class LoginForm : Form
    {
        public static bool adminRights = false;
        public static UserClass _userClass;

        public LoginForm()
        {
            InitializeComponent();

            //переменные, создающие текст в полях ввода до нажатия
            loginTextBox.Text = "Штрих-код сотрудника";
            passwordTextBox.Text = "Пароль";
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

        //скрывает текст в поле ввода логина при нажатии
        private void loginTextBox_Click(object sender, EventArgs e)
        {
            loginTextBox.Text = "";
        }

        //скрывает текст в поле ввода пароля при нажатии
        private void passwordTextBox_Click(object sender, EventArgs e)
        {
            passwordTextBox.Text = "";
        }

        //прохождение регистрации и вход в рабочую зону приложения
        private void LoginButton_Click(object sender, EventArgs e)
        {
            string id = loginTextBox.Text;
            string password = passwordTextBox.Text;
            Authorization authorization = new Authorization(id, password);
            if (authorization.Start())
            {
                _userClass = authorization._userClass;
                this.Hide();
                WorkingForm workingForm = new WorkingForm();
                workingForm.Show();
            }
            else
            {
                MessageBox.Show("Неверный штрих-код или пароль");
            }
        }
    }
}
