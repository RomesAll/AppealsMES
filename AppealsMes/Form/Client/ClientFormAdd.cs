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
    public partial class ClientFormAdd : Form
    {
        public ClientFormAdd()
        {
            InitializeComponent();
        }

        private void AddClients_Click(object sender, EventArgs e)
        {
            if (isValidEmail(EmailTx.Texts) == true)
            {
                if (SurnameTx.Texts != "" & NameTx.Texts != "" & PatronymicTx.Texts != "" & EmailTx.Texts != "" & TelephoneTx.Text != "" & AdresTx.Text != "")
                {
                    if (ClassClient.AddClient(SurnameTx.Texts, NameTx.Texts, PatronymicTx.Texts, EmailTx.Texts, TelephoneTx.Text, AdresTx.Text, NoteTx.Texts) == true)
                    {
                        MessageBox.Show("Запись добавленна", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClassClient.SelectClient();
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
        private void SurnameTx__TextChanged(object sender, EventArgs e)
        {
            string Char = $@"a b c d e f g h i j k l m n o p q r s t u v w x y z 1 2 3 4 5 6 7 8 9 0 ! @ # $ % ^ & * ( ) _ + № ; : ? - = [ ] , . / \ ' ; ~";
            foreach(var s in Char.Split(' '))
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
