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
    public partial class SolvingProblemRedForm : Form
    {
        static private string NomerSolvingProblem;
        static private string NomerProblem;
        static private string Description;
        static private string Data;
        static private string Status;
        static private bool Myappeal;
        public SolvingProblemRedForm(bool myappeal,params string [] par)
        {
            InitializeComponent();
            NomerSolvingProblem = par[0];
            NomerProblem = par[1];
            Description = par[2];
            DateTime dt = Convert.ToDateTime(par[3]);
            Data = dt.ToString("yyyy.MM.dd");
            Status = par[4];
            Myappeal = myappeal;
            if (par[5] == "Viewing")
            {
                AddBtn.Enabled = false;
                DescriptionTx.Enabled = false;
                StatusCm.Enabled = false;
                DateOtvet.Enabled = false;
                AddGuidStatus.Enabled = false;
                AddBtn.Text = "Режим просмотра";
            }
        }

        private void SolvingProblemRedForm_Load(object sender, EventArgs e)
        {
            ClassGuide.StatusesSelect();
            StatusCm.DataSource = ClassGuide.DtStatuses;
            StatusCm.ValueMember = "id_statuses";
            StatusCm.DisplayMember = "statuses";

            userControlTextBox1.Texts = NomerSolvingProblem;
            NomerAppealsTx.Texts = NomerProblem;
            DateOtvet.Text = Data;
            StatusCm.Text = Status;
            DescriptionTx.Texts = Description;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (ClassSolvingProbleam.RedSolvingProblem(NomerAppealsTx.Texts, DescriptionTx.Texts, DateOtvet.Text, StatusCm.SelectedValue.ToString(), userControlTextBox1.Texts)==true)
            {
                MessageBox.Show("Запись обновленна", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (Myappeal == true)
                {
                    ClassSolvingProbleam.SelectSolvingProblem(ClassAuthorization.NomerUser.ToString());
                }
                else
                {
                    ClassSolvingProbleam.SelectSolvingProblem("");
                }
                this.Close();
            }
        }

        private void AddGuidStatus_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<StatusFormAddRed>().Any())
                new StatusFormAddRed().Show();
        }
    }
}
