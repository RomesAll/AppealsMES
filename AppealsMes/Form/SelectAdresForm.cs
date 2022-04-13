using Appeals_Mes;
using Appeals_Mes.Class;
using AppealsMes.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppealsMes
{
    public partial class SelectAdresForm : Form
    {
        static private string NomerProblem;
        public SelectAdresForm(byte mode, params string [] par)
        {
            InitializeComponent();
            ClassGuide.DistrictSelect();
            DistrictCm.DataSource = ClassGuide.DtDistrict;
            DistrictCm.ValueMember = "id_district";
            DistrictCm.DisplayMember = "district";
            DistrictCm.SelectedIndex = 0;

            ClassProblemAppeals.SelectStreet("1");
            StreetCm.DataSource = ClassProblemAppeals.DtStreet;
            StreetCm.ValueMember = "id_street";
            StreetCm.DisplayMember = "Street";

            switch (mode)
            {
                case 0:
                    AddAdresBtn.Text = "Добавить адрес";
                    break;
                case 1:
                    AddAdresBtn.Text = "Редактировать адрес";
                    NomerProblem = par[1];
                    //DistrictCm.Text = par[0];
                    //StreetCm.Text = par[0];
                    //HomeCm.Text = par[0];
                    //KorpysCm.Text = par[0];
                    //KvCm.Text = par[0];
                    break;
            }
        }

        private void AddAdresBtn_Click(object sender, EventArgs e)
        {
            if (DistrictCm.Text != "" & StreetCm.Text != "" & HomeCm.Texts != "" & KorpysCm.Texts != "" & KvCm.Texts != "" & AddAdresBtn.Text == "Добавить адрес")
            {
                ClassProblemAppeals.SelectStreet(DistrictCm.SelectedValue.ToString(),StreetCm.Text);
                if (ClassProblemAppeals.AddAdres(ClassProblemAppeals.NomerStreet.ToString(), HomeCm.Texts, KorpysCm.Texts, KvCm.Texts)==true)
                {
                    MessageBox.Show("Адрес добавлен","Успешно",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else if (StreetCm.Text != "" & HomeCm.Texts != "" & KorpysCm.Texts != "" & KvCm.Texts != "" & AddAdresBtn.Text == "Редактировать адрес")
            {
                ClassProblemAppeals.SelectStreet(DistrictCm.SelectedValue.ToString(), StreetCm.Text);
                if (ClassProblemAppeals.RedAdres(ClassProblemAppeals.NomerStreet.ToString(), HomeCm.Texts, KorpysCm.Texts, KvCm.Texts, NomerProblem) == true)
                {
                    MessageBox.Show("Адрес добавлен", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                    this.Close();
                }
            }
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            if (StreetCm.Text != "")
            {
                if (ClassProblemAppeals.AddStreet(DistrictCm.SelectedValue.ToString(),StreetCm.Text)==true)
                {
                    MessageBox.Show("Улица - " + StreetCm.Text + " добавленна","Успешно", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    ClassProblemAppeals.SelectStreet(DistrictCm.SelectedValue.ToString());
                }
            }
            else
            {
                MessageBox.Show("Заполните поле с улицой", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AddProblemIco_Click(object sender, EventArgs e)
        {
            if (DistrictCm.Text != "")
            {
                if (ClassGuide.DistrictAdd(DistrictCm.Text) == true)
                {
                    MessageBox.Show("Район - " + DistrictCm.Text + " добавленн", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClassGuide.DistrictSelect();
                }
            }
            else
            {
                MessageBox.Show("Заполните поле с районом", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DistrictCm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DistrictCm.SelectedValue != null)
            {
                ClassProblemAppeals.SelectStreet(DistrictCm.SelectedValue.ToString());
                StreetCm.DataSource = ClassProblemAppeals.DtStreet;
                StreetCm.ValueMember = "id_street";
                StreetCm.DisplayMember = "Street";
            }
        }

        private void SelectAdresForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (ClassProblemAppeals.Adres != null)
                ProblemAppealsFormAddRed.Adres = ClassProblemAppeals.Adres.ToString();
        }
    }
}
