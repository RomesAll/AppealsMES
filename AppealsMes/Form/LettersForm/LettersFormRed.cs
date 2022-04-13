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
    public partial class LettersFormRed : Form
    {
        static private string idletter = "";
        static private string idsolvingproblem = "";
        static private string idemployee = "";
        static private string Dateoutgoing = "";
        static private string Description = "";
        static private bool Myappeals;
        public LettersFormRed(bool myappeals, params string [] par)
        {
            InitializeComponent();
            idletter = par[0];
            idsolvingproblem = par[1];
            idemployee = par[2];
            Dateoutgoing = par[3];
            Description = par[4];
            Myappeals = myappeals;
            if (par[5] == "Viewing")
            {
                userControlTextBox1.Enabled = false;
                NomerAppealsTx.Enabled = false;
                EmploerCm.Enabled = false;
                DateOtvet.Enabled = false;
                DescriptionTx.Enabled = false;
                AddBtn.Enabled = false;
                AddBtn.Text = "Режим просмотра";
            }
        }

        private void LettersFormRed_Load(object sender, EventArgs e)
        {
            ClassAppeals.SelectEmployee();
            EmploerCm.DataSource = ClassAppeals.Dtemployee;
            EmploerCm.DisplayMember = "Fioe";
            EmploerCm.ValueMember = "id_employee";

            userControlTextBox1.Texts = idletter;
            NomerAppealsTx.Texts = idsolvingproblem;
            EmploerCm.Text = idemployee;
            DateOtvet.Text = Dateoutgoing;
            DescriptionTx.Texts = Description;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (ClassLetters.RedLetters(NomerAppealsTx.Texts, EmploerCm.SelectedValue.ToString(), DateOtvet.Text, DescriptionTx.Texts, userControlTextBox1.Texts) ==true)
            {
                MessageBox.Show("Запись обновленна", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (Myappeals == true)
                {
                    ClassLetters.SelectLetters(ClassAuthorization.NomerUser.ToString());
                }
                else
                {
                    ClassLetters.SelectLetters("");
                }
            }
        }

        private void AddEmploer_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<EmployeeFormAdd>().Any())
                new EmployeeFormAdd();
        }
    }
}
