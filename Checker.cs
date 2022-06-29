using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace приложение
{
    public partial class CheckerForm : Form
    {
        public CheckerForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] names = {"Алексей", "Артём", "Илья", "Мария"};
            string password = "1230";

            string login = loginText.Text;
            string key = passwordText.Text;

            if (key == null || login == null) // если хотя бы ->
                // -> одно из полей пустое
            {
                return; // тогда ничего не делать
            }
            else // иначе
            {
                Check(names, password, login, key); // проверка
            }
        }

        private void Check(string[] names, string password, string login, string key)
        {
            #region Проверка логина
            bool loginCheck = false;

            foreach (string name in names)
            {
                if (name == login)
                {
                    loginCheck = true;
                }
            }
            #endregion
            #region Проверка пароля
            bool passwordCheck = false;
            if (key == password)
            {
                passwordCheck = true;
            }
            #endregion
            #region Итоговая проверка
            if (loginCheck && passwordCheck)
            {
                MainForm main = new MainForm();
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль");
            }
            #endregion
        }

        private void passwordText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }
    }
}
