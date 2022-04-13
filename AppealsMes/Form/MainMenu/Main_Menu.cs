using Appeals_Mes.Class;
using AppealsMes;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Appeals_Mes
{
    public partial class Main_Menu : Form
    {
        //AppealsForm appelsForm = new AppealsForm();
        //WorkAppeals statisticsForm = new WorkAppeals();
        //ProblemAppealsForm problemAppealsForm = new ProblemAppealsForm();
        //SolvingProblemForm solvingProblemForm = new SolvingProblemForm();
        //LettersForm lettersForm = new LettersForm();
        //GuideForm guid = new GuideForm();
        public Main_Menu(string Nameform)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            switch (Nameform)
            {
                case "AppealsForm":
                    AppealsFormOpen(new AppealsForm());
                    break;
                //case "WorkAppeals":
                //    StatisticsReportsFormOpen();
                //    break;
                case "GuidForm":
                    GuideBtnFormOpen(new GuideForm());
                    break;
            }
            //ClassAppeals.SelectAppealsTest();
            //dataGridView1.DataSource = ClassAppeals.DtSelectAppealsTest;
        }

        //Переход по формам на panelNavigator
        #region
        private void MapRequestsBtn_Click(object sender, EventArgs e) => AppealsFormOpen(new AppealsForm());
        //private void StatisticsReportsBtn_Click(object sender, EventArgs e) => StatisticsReportsFormOpen(statisticsForm);
        private void StatisticsReportsFormOpen(Form form)
        {
            BtnStyleClickPanelNavigator(StatisticsReportsBtn, MapRequestsBtn, GuideBtn, StaffBtn, ProfilBtn, MapsAppelsBtn, KlientBtn);
            panelDesktop.Controls.Clear();
            NavigatorMenuClick(form);
            labelTitle.Text = StatisticsReportsBtn.Text;
            iconPictureBoxTitle.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
        }
        private void GuideBtn_Click(object sender, EventArgs e) => GuideBtnFormOpen(new GuideForm());
        private void GuideBtnFormOpen(Form form)
        {
            if (ClassAuthorization.Post.ToString() == "Руководитель it отдела")
            {
                BtnStyleClickPanelNavigator(GuideBtn, StatisticsReportsBtn, MapRequestsBtn, StaffBtn, ProfilBtn, MapsAppelsBtn, KlientBtn);
                panelDesktop.Controls.Clear();
                NavigatorMenuClick(form);
                labelTitle.Text = GuideBtn.Text;
                iconPictureBoxTitle.IconChar = FontAwesome.Sharp.IconChar.Book;
            }
        }
        private void StatisticsReportsBtn_Click(object sender, EventArgs e) => StatisticsReportsOpen(new ReportsForm());

        private void StatisticsReportsOpen(Form form)
        {
            if (ClassAuthorization.Post.ToString() == "Руководитель it отдела")
            {
                BtnStyleClickPanelNavigator(StatisticsReportsBtn, GuideBtn, MapRequestsBtn, StaffBtn, ProfilBtn, MapsAppelsBtn, KlientBtn);
                panelDesktop.Controls.Clear();
                NavigatorMenuClick(form);
                labelTitle.Text = StatisticsReportsBtn.Text;
                iconPictureBoxTitle.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            }
        }

        private void KlientBtn_Click(object sender, EventArgs e) => ClientBtnFormOpen(new ClientForm());
        private void ClientBtnFormOpen(Form form)
        {
            BtnStyleClickPanelNavigator(KlientBtn, GuideBtn, StatisticsReportsBtn, MapRequestsBtn, StaffBtn, ProfilBtn, MapsAppelsBtn);
            panelDesktop.Controls.Clear();
            NavigatorMenuClick(form);
            labelTitle.Text = KlientBtn.Text;
            iconPictureBoxTitle.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
        }
        private void StaffBtn_Click(object sender, EventArgs e) => EmployeeBtnFormOpen(new EmployeeForm());
        private void EmployeeBtnFormOpen(Form form)
        {
            if (ClassAuthorization.Post.ToString() == "Руководитель it отдела")
            {
                BtnStyleClickPanelNavigator(StaffBtn, KlientBtn, GuideBtn, StatisticsReportsBtn, MapRequestsBtn, ProfilBtn, MapsAppelsBtn);
                panelDesktop.Controls.Clear();
                NavigatorMenuClick(form);
                labelTitle.Text = StaffBtn.Text;
                iconPictureBoxTitle.IconChar = FontAwesome.Sharp.IconChar.UserAstronaut;
            }
        }
        #endregion

        //Переход по формам на panelHeading
        #region
        private void MapRequestsHeadingBtn_Click(object sender, EventArgs e) => AppealsFormOpen(new AppealsForm());
        private void AppealsFormOpen(Form form)
        {
            BtnStyleClickPanelNavigator(MapRequestsBtn, StatisticsReportsBtn, GuideBtn, StaffBtn, ProfilBtn, MapsAppelsBtn, KlientBtn);
            BtnStyleClickPanelHeading(false, MapRequestsHeadingBtn, ProblemAppealsBtn, SolvingProblemBtn, LettersBtn);
            panelDesktop.Controls.Clear();
            NavigatorMenuClick(form);
            labelTitle.Text = MapRequestsBtn.Text;
            iconPictureBoxTitle.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
        }
        private void ProblemAppealsBtn_Click_1(object sender, EventArgs e)=> ProblemAppealsFormOpen(new ProblemAppealsForm());
        private void ProblemAppealsFormOpen(Form form)
        {
            BtnStyleClickPanelNavigator(MapRequestsBtn, StatisticsReportsBtn, GuideBtn, StaffBtn, ProfilBtn, MapsAppelsBtn, KlientBtn);
            BtnStyleClickPanelHeading(false, ProblemAppealsBtn, SolvingProblemBtn, LettersBtn, MapRequestsHeadingBtn);
            panelDesktop.Controls.Clear();
            NavigatorMenuClick(form);
        }
        private void SolvingProblemBtn_Click_1(object sender, EventArgs e)=> SolvingProblemFormOpen(new SolvingProblemForm());
        private void SolvingProblemFormOpen(Form form)
        {
            BtnStyleClickPanelNavigator(MapRequestsBtn, StatisticsReportsBtn, GuideBtn, StaffBtn, ProfilBtn, MapsAppelsBtn, KlientBtn);
            BtnStyleClickPanelHeading(false,SolvingProblemBtn, LettersBtn, MapRequestsHeadingBtn, ProblemAppealsBtn);
            panelDesktop.Controls.Clear();
            NavigatorMenuClick(form);
        }
        private void LettersBtn_Click_1(object sender, EventArgs e) => LettersFormOpen(new LettersForm());
        private void LettersFormOpen(Form form)
        {
            BtnStyleClickPanelNavigator(MapRequestsBtn, StatisticsReportsBtn, GuideBtn, StaffBtn, ProfilBtn, MapsAppelsBtn, KlientBtn);
            BtnStyleClickPanelHeading(false, LettersBtn, MapRequestsHeadingBtn, ProblemAppealsBtn, SolvingProblemBtn);
            panelDesktop.Controls.Clear();
            NavigatorMenuClick(form);
        }
        #endregion

        /// <summary>
        /// Метод для оформления стилей кнопок при нажатии на panelHeading
        /// </summary>
        /// <param name="btn"></param>
        public void BtnStyleClickPanelHeading(bool clear,params Button [] btn)
        {
            for (int i = 0;i<btn.Length;i++)
            {
                if (btn[i] == btn[0] & clear == false)
                {
                    btn[i].BackColor = Color.FromArgb(255, 192, 128);
                    btn[i].Enabled = false;
                }
                else
                {
                    btn[i].BackColor = Color.Transparent;
                    btn[i].Enabled = true;
                }
            }
        }
        /// <summary>
        /// Метод для оформления стилей кнопок при нажатии на panelNavigator
        /// </summary>
        /// <param name="btn"></param>
        public void BtnStyleClickPanelNavigator(params Button [] btn)
        {
            for (int i = 0; i < btn.Length; i++)
            {
                if (btn[i] == btn[0])
                {
                    btn[i].BackColor = Color.FromArgb(211, 211, 211);
                    btn[i].ImageAlign = ContentAlignment.MiddleRight;
                    btn[i].TextAlign = ContentAlignment.MiddleRight;
                    btn[i].Font = new Font("Segoe UI", 9, FontStyle.Bold);
                    btn[i].TextImageRelation = TextImageRelation.TextBeforeImage;
                }
                else
                {
                    btn[i].BackColor = Color.FromArgb(255, 255, 255);
                    btn[i].ImageAlign = ContentAlignment.MiddleLeft;
                    btn[i].TextAlign = ContentAlignment.MiddleLeft;
                    btn[i].Font = new Font("Segoe UI", 10);
                    btn[i].TextImageRelation = TextImageRelation.ImageBeforeText;
                    BtnStyleClickPanelHeading(true, LettersBtn, MapRequestsHeadingBtn, ProblemAppealsBtn, SolvingProblemBtn, LettersBtn);
                }
            }
        }
        /// <summary>
        /// Метод для навигации по формам
        /// </summary>
        /// <param name="form"></param>
        public void NavigatorMenuClick(Form form)
        {
            form.TopLevel = false;
            form.Anchor = AnchorStyles.Top;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(form);
            panelDesktop.Tag = form;
            form.BringToFront();
            form.Show();
        }

        private void iconButtonExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            new User_Menu().Show();
        }
        private int count = 0;
        private void Main_Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            count++;
            if (count == 1)
            {
                ClassConnection.CloseForm();
            }
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }



        
    }
}
