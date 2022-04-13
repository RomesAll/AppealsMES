using Appeals_Mes.Class;
using AppealsMes.Properties;
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

namespace Appeals_Mes
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
            ClassConnection.Connection();
        }

        private void PasswordChar_Click(object sender, EventArgs e)
        {
            if (PasswordTextBox.PasswordChar == true)
            {
                PasswordTextBox.PasswordChar = false;
                PasswordChar.Image = Resources.hidden1;
            }
            else if (PasswordTextBox.PasswordChar == false)
            {
                PasswordTextBox.PasswordChar = true;
                PasswordChar.Image = Resources.view1;
            }
        }

        private void EnterBtn_Click(object sender, EventArgs e)
        {
            if (СheckingTextboxNull(LoginTextBox.Texts, PasswordTextBox.Texts))
            {
                if (ClassAuthorization.Authorization(LoginTextBox.Texts, PasswordTextBox.Texts))
                {
                    MessageBox.Show("Добро пожаловать, " + ClassAuthorization.FioUser.ToString(), "Авторизация пользователя", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    //DateTime dtNow = DateTime.Now;
                    //string path = @"D:\Дипломный проект\AppealsMes\History.txt";
                    //string text = dtNow.ToString() + " " + ClassAuthorization.FioUser + " вошёл в системы\n";
                    //// полная перезапись файла 
                    //using (StreamWriter writer = new StreamWriter(path, true))
                    //{
                    //    writer.WriteLine(text);
                    //}
                    LoginTextBox.Texts = "";
                    PasswordTextBox.Texts = "";
                    this.Hide();
                    new User_Menu().Show();
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль", "Авторизация пользователя", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LoginTextBox.Texts = "";
                    PasswordTextBox.Texts = "";
                }
            }
        }
        private bool СheckingTextboxNull(string log, string password)
        {
            if (string.IsNullOrEmpty(log)==true & string.IsNullOrEmpty(password)==true)
            {
                MessageBox.Show("Введите логин и пароль", "Авторизация пользователя", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (string.IsNullOrEmpty(log) == true)
            {
                MessageBox.Show("Введите логин", "Авторизация пользователя", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (string.IsNullOrEmpty(password) == true)
            {
                MessageBox.Show("Введите пароль", "Авторизация пользователя", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
