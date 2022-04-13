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
    public partial class ClientFormRed : Form
    {
        static private string Nomer;
        public ClientFormRed(params string [] par)
        {
            InitializeComponent();
            Nomer = par[0];
            SurnameTx.Texts = par[1];
            NameTx.Texts = par[2];
            PatronymicTx.Texts = par[3];
            EmailTx.Texts = par[4];
            TelephoneTx.Text = par[5];
            AdresTx.Text = par[6];
            NoteTx.Texts = par[7];
        }

        private void AddClients_Click(object sender, EventArgs e)
        {
            if (isValidEmail(EmailTx.Texts) == true)
            {
                if (SurnameTx.Texts != "" & NameTx.Texts != "" & PatronymicTx.Texts != "" & EmailTx.Texts != "" & TelephoneTx.Text != "" & AdresTx.Text != "")
                {
                    if (ClassClient.RedClient(SurnameTx.Texts, NameTx.Texts, PatronymicTx.Texts, EmailTx.Texts, TelephoneTx.Text, AdresTx.Text, NoteTx.Texts, Nomer) == true)
                    {
                        MessageBox.Show("Запись обновленна", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
