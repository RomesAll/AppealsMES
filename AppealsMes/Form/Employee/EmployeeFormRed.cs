using Appeals_Mes.Class;
using AppealsMes.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppealsMes
{
    public partial class EmployeeFormRed : Form
    {
        private string Nomer;
        private string Post;
        private string Surname;
        private string Nameuser;
        private string Patronymic;
        private string Date_birth;
        private string Email;
        private string Telephone;
        private string Login;
        private string Password;
        public EmployeeFormRed(params string [] par)
        {
            InitializeComponent();
            Nomer = par[0];
            Post = par[1];
            Surname = par[2];
            Nameuser = par[3];
            Patronymic = par[4];
            Date_birth = par[5];
            Email = par[6];
            Telephone = par[7];
            Login = par[8];
            Password = par[9];
        }
        private void RedClients_Click(object sender, EventArgs e)
        {
            if (isValidEmail(EmailTx.Texts) == true)
            {
                if (SurnameTx.Texts != "" & NameTx.Texts != "" & PatronymicTx.Texts != "" & EmailTx.Texts != "" & TelephoneTx.Text != "" & comboBox1.SelectedValue.ToString() != "")
                {
                    if (ClassEmployee.RedEmployee(comboBox1.SelectedValue.ToString(), 
                        SurnameTx.Texts, NameTx.Texts, 
                        PatronymicTx.Texts, dateTimePicker1.Text, 
                        EmailTx.Texts, TelephoneTx.Text, Nomer, 
                        LoginTx.Texts, PasswordTx.Texts) == true)
                    {
                        MessageBox.Show("Запись обновленна", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClassEmployee.SelectEmployee();
                        this.Close();
                    }
                }
                else
                    MessageBox.Show("Заполните поля", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Неверный формат почты", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public static bool isValidEmail(string inputEmail)
        {
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(inputEmail))
                return (true);
            else
                return (false);
        }

        private void EmployeeFormRed_Load(object sender, EventArgs e)
        {
            ClassGuide.PostSelect();
            comboBox1.DataSource = ClassGuide.DtPost;
            comboBox1.ValueMember = "id_post";
            comboBox1.DisplayMember = "post";

            SurnameTx.Texts = Surname;
            NameTx.Texts = Nameuser;
            PatronymicTx.Texts = Patronymic;
            comboBox1.Text = Post;
            EmailTx.Texts = Email;
            TelephoneTx.Text = Telephone;
            dateTimePicker1.Text = Date_birth;
            LoginTx.Texts = Login;
            PasswordTx.Texts = Password;
        }

        private void SurnameTx__TextChanged(object sender, EventArgs e)
        {
            string Char = $@"a b c d e f g h i j k l m n o p q r s t u v w x y z 1 2 3 4 5 6 7 8 9 0 ! @ # $ % ^ & * ( ) _ + № ; : ? - = [ ] , . / \ ' ; ~";
            foreach (var s in Char.Split(' '))
            {
                SurnameTx.Texts = SurnameTx.Texts.Replace(s, "");
            }
        }

        private void NameTx__TextChanged(object sender, EventArgs e)
        {
            string Char = $@"a b c d e f g h i j k l m n o p q r s t u v w x y z 1 2 3 4 5 6 7 8 9 0 ! @ # $ % ^ & * ( ) _ + № ; : ? - = [ ] , . / \ ' ; ~";
            foreach (var s in Char.Split(' '))
            {
                NameTx.Texts = NameTx.Texts.Replace(s, "");
            }
        }

        private void PatronymicTx__TextChanged(object sender, EventArgs e)
        {
            string Char = $@"a b c d e f g h i j k l m n o p q r s t u v w x y z 1 2 3 4 5 6 7 8 9 0 ! @ # $ % ^ & * ( ) _ + № ; : ? - = [ ] , . / \ ' ; ~";
            foreach (var s in Char.Split(' '))
            {
                PatronymicTx.Texts = PatronymicTx.Texts.Replace(s, "");
            }
        }
    }
}
