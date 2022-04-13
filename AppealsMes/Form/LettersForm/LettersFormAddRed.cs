using Appeals_Mes.Class;
using AppealsMes;
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

namespace Appeals_Mes
{
    public partial class LettersFormAddRed : Form
    {
        public LettersFormAddRed()
        {
            InitializeComponent();
            if (MyAppeaslAdd.Checked == true)
            {
                ClassLetters.SelectSolvingProblem(ClassAuthorization.NomerUser.ToString());
                SolvingProblem.DataSource = ClassLetters.DtSelectSolvingProblem;
            }
            else
            {
                ClassLetters.SelectSolvingProblem("");
                SolvingProblem.DataSource = ClassLetters.DtSelectSolvingProblem;
            }
            ClassAppeals.SelectEmployee();
            EmploerCm.DataSource = ClassAppeals.Dtemployee;
            EmploerCm.DisplayMember = "Fioe";
            EmploerCm.ValueMember = "id_employee";
        }

        private void MyAppeaslAdd_CheckedChanged(object sender, EventArgs e)
        {
            if (MyAppeaslAdd.Checked == true)
            {
                ClassLetters.SelectSolvingProblem(ClassAuthorization.NomerUser.ToString());
                SolvingProblem.DataSource = ClassLetters.DtSelectSolvingProblem;
            }
            else
            {
                ClassLetters.SelectSolvingProblem("");
                SolvingProblem.DataSource = ClassLetters.DtSelectSolvingProblem;
            }
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            NomerAppealsTx.Texts = SolvingProblem.CurrentRow.Cells[0].Value.ToString();
            AddBtn.Enabled = true;
            EmploerCm.Enabled = true;
            AddEmploer.Enabled = true;
            DateOtvet.Enabled = true;
            DescriptionTx.Enabled = true;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (NomerAppealsTx.Texts != "")
            {
                if (ClassLetters.AddLetters(NomerAppealsTx.Texts, EmploerCm.SelectedValue.ToString(), DateOtvet.Text, DescriptionTx.Texts) ==true)
                {
                    MessageBox.Show("Запись добавленна", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (MyAppeaslAdd.Checked == true)
                    {
                        ClassLetters.SelectSolvingProblem(ClassAuthorization.NomerUser.ToString());
                        ClassLetters.SelectLetters(ClassAuthorization.NomerUser.ToString());
                        SolvingProblem.DataSource = ClassLetters.DtSelectSolvingProblem;
                    }
                    else
                    {
                        ClassLetters.SelectSolvingProblem("");
                        ClassLetters.SelectLetters("");
                        SolvingProblem.DataSource = ClassLetters.DtSelectSolvingProblem;
                    }

                }
            }
        }

        private void AddEmploer_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<EmployeeFormAdd>().Any())
                new EmployeeFormAdd();
        }

        private void SolvingProblem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SolvingProblem.Rows[e.RowIndex].Selected = true;
        }
    }
}
