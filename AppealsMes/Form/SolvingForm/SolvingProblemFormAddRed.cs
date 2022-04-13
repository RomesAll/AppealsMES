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

namespace Appeals_Mes
{
    public partial class SolvingProblemFormAddRed : Form
    {
        public SolvingProblemFormAddRed()
        {
            InitializeComponent();
            if (MyAppeaslAdd.Checked == true)
            {
                ClassSolvingProbleam.SelectProblemUser(ClassAuthorization.NomerUser.ToString());
                SelectProblemDg.DataSource = ClassSolvingProbleam.DtSolvingUser;
            }
            else
            {
                ClassSolvingProbleam.SelectProblemAll();
                SelectProblemDg.DataSource = ClassSolvingProbleam.DtSolvingUser;
            }
            ClassGuide.StatusesSelect();
            StatusCm.DataSource = ClassGuide.DtStatuses;
            StatusCm.ValueMember = "id_statuses";
            StatusCm.DisplayMember = "statuses";
        }

        private void MyAppeaslAdd_CheckedChanged(object sender, EventArgs e)
        {
            if (MyAppeaslAdd.Checked == true)
            {
                ClassSolvingProbleam.SelectProblemUser(ClassAuthorization.NomerUser.ToString());
                SelectProblemDg.DataSource = ClassSolvingProbleam.DtSolvingUser;
            }
            else
            {
                ClassSolvingProbleam.SelectProblemAll();
                SelectProblemDg.DataSource = ClassSolvingProbleam.DtSolvingUser;
            }
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            NomerAppealsTx.Texts = SelectProblemDg.CurrentRow.Cells[0].Value.ToString();
            AddBtn.Enabled = true;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (NomerAppealsTx.Texts != "")
            {
                if (ClassSolvingProbleam.AddSolvingProbleam(NomerAppealsTx.Texts, DescriptionTx.Texts, DateOtvet.Text, StatusCm.SelectedValue.ToString()) == true)
                {
                    MessageBox.Show("Запись добавленна", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NomerAppealsTx.Texts = "";
                    DescriptionTx.Texts = "";

                    if (MyAppeaslAdd.Checked == true)
                    {
                        ClassSolvingProbleam.SelectProblemUser(ClassAuthorization.NomerUser.ToString());
                        ClassProblemAppeals.SelectProblemUser(ClassAuthorization.NomerUser.ToString());
                        SelectProblemDg.DataSource = ClassSolvingProbleam.DtSolvingUser;
                    }
                    else
                    {
                        ClassSolvingProbleam.SelectProblemAll();
                        ClassProblemAppeals.SelectProblemAll();
                        SelectProblemDg.DataSource = ClassSolvingProbleam.DtSolvingUser;
                    }
                }
            }
        }

        private void SolvingProblemFormAddRed_Load(object sender, EventArgs e)
        {

        }

        private void AddGuidStatus_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<StatusFormAddRed>().Any())
                new StatusFormAddRed().Show();
        }

        private void SelectProblemDg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectProblemDg.Rows[e.RowIndex].Selected = true;
        }
    }
}
