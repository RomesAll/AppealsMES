using Appeals_Mes.Class;
using AppealsMes;
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
    public partial class User_Menu : Form
    {
        AutoCompleteStringCollection source = new AutoCompleteStringCollection()
            {
                "Сотрудники",
                "Обращения потребителей",
                "Статистика | Отчёты",
                "Справочники",
                "Профиль",
                "Карта обращений",
                "Клиенты"
            };
        
        public User_Menu()
        {
            InitializeComponent();
           
            label1.Text += ClassAuthorization.FioUser.ToString();
            label2.Text += ClassAuthorization.Post.ToString();
            page_search.AutoCompleteCustomSource = source;
            page_search.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            page_search.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        private void iconButtonExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Authorization().Show();
        }

        private void MapRequestsBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Main_Menu("AppealsForm").Show();
        }

        private void StatisticsReportsBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Main_Menu("WorkAppeals").Show();
        }

        private void GuideBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Main_Menu("GuidForm").Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) //Переделать!!!!!!!!!!!!
        {
            switch (page_search.Text)
            {
                case "Сотрудники":
                    StaffBtn.BackColor = Color.FromArgb(255, 192, 128);
                    MapRequestsBtn.BackColor = Color.FromArgb(255, 224, 192);
                    StatisticsReportsBtn.BackColor = Color.FromArgb(255, 224, 192);
                    GuideBtn.BackColor = Color.FromArgb(255, 224, 192);
                    ProfilBtn.BackColor = Color.FromArgb(255, 224, 192);
                    MapsAppelsBtn.BackColor = Color.FromArgb(255, 224, 192);
                    KlientBtn.BackColor = Color.FromArgb(255, 224, 192);
                    break;
                case "Обращения потребителей":
                    MapRequestsBtn.BackColor = Color.FromArgb(255, 192, 128);
                    StaffBtn.BackColor = Color.FromArgb(255, 224, 192);
                    StatisticsReportsBtn.BackColor = Color.FromArgb(255, 224, 192);
                    GuideBtn.BackColor = Color.FromArgb(255, 224, 192);
                    ProfilBtn.BackColor = Color.FromArgb(255, 224, 192);
                    MapsAppelsBtn.BackColor = Color.FromArgb(255, 224, 192);
                    KlientBtn.BackColor = Color.FromArgb(255, 224, 192);
                    break;
                case "Статистика | Отчёты":
                    StatisticsReportsBtn.BackColor = Color.FromArgb(255, 192, 128);
                    MapRequestsBtn.BackColor = Color.FromArgb(255, 224, 192);
                    StaffBtn.BackColor = Color.FromArgb(255, 224, 192);
                    GuideBtn.BackColor = Color.FromArgb(255, 224, 192);
                    ProfilBtn.BackColor = Color.FromArgb(255, 224, 192);
                    MapsAppelsBtn.BackColor = Color.FromArgb(255, 224, 192);
                    KlientBtn.BackColor = Color.FromArgb(255, 224, 192);
                    break;
                case "Справочники":
                    GuideBtn.BackColor = Color.FromArgb(255, 192, 128);
                    MapRequestsBtn.BackColor = Color.FromArgb(255, 224, 192);
                    StaffBtn.BackColor = Color.FromArgb(255, 224, 192);
                    ProfilBtn.BackColor = Color.FromArgb(255, 224, 192);
                    MapsAppelsBtn.BackColor = Color.FromArgb(255, 224, 192);
                    KlientBtn.BackColor = Color.FromArgb(255, 224, 192);
                    StatisticsReportsBtn.BackColor = Color.FromArgb(255, 224, 192);
                    break;
                case "Профиль":
                    ProfilBtn.BackColor = Color.FromArgb(255, 192, 128);
                    MapRequestsBtn.BackColor = Color.FromArgb(255, 224, 192);
                    GuideBtn.BackColor = Color.FromArgb(255, 224, 192);
                    StaffBtn.BackColor = Color.FromArgb(255, 224, 192);
                    MapsAppelsBtn.BackColor = Color.FromArgb(255, 224, 192);
                    KlientBtn.BackColor = Color.FromArgb(255, 224, 192);
                    StatisticsReportsBtn.BackColor = Color.FromArgb(255, 224, 192);
                    break;
                case "Карта обращений":
                    MapsAppelsBtn.BackColor = Color.FromArgb(255, 192, 128);
                    MapRequestsBtn.BackColor = Color.FromArgb(255, 224, 192);
                    GuideBtn.BackColor = Color.FromArgb(255, 224, 192);
                    StaffBtn.BackColor = Color.FromArgb(255, 224, 192);
                    ProfilBtn.BackColor = Color.FromArgb(255, 224, 192);
                    KlientBtn.BackColor = Color.FromArgb(255, 224, 192);
                    StatisticsReportsBtn.BackColor = Color.FromArgb(255, 224, 192);
                    break;
                case "Клиенты":
                    KlientBtn.BackColor = Color.FromArgb(255, 192, 128);
                    MapRequestsBtn.BackColor = Color.FromArgb(255, 224, 192);
                    GuideBtn.BackColor = Color.FromArgb(255, 224, 192);
                    StaffBtn.BackColor = Color.FromArgb(255, 224, 192);
                    ProfilBtn.BackColor = Color.FromArgb(255, 224, 192);
                    MapsAppelsBtn.BackColor = Color.FromArgb(255, 224, 192);
                    StatisticsReportsBtn.BackColor = Color.FromArgb(255, 224, 192);
                    break;
                case "":
                    KlientBtn.BackColor = Color.FromArgb(255, 224, 192);
                    MapRequestsBtn.BackColor = Color.FromArgb(255, 224, 192);
                    GuideBtn.BackColor = Color.FromArgb(255, 224, 192);
                    StaffBtn.BackColor = Color.FromArgb(255, 224, 192);
                    ProfilBtn.BackColor = Color.FromArgb(255, 224, 192);
                    MapsAppelsBtn.BackColor = Color.FromArgb(255, 224, 192);
                    StatisticsReportsBtn.BackColor = Color.FromArgb(255, 224, 192);
                    break;

            }
        }
        private void User_Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void User_Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            ClassConnection.CloseForm();
        }
    }
}
