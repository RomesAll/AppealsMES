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
    public partial class AnswerLetterForm : Form
    {
        public AnswerLetterForm(string nomer)
        {
            InitializeComponent();
            NomerLetters.Texts = nomer;
            ClassGuide.StatusesSelect();
            StatusCm.DataSource = ClassGuide.DtStatuses;
            StatusCm.ValueMember = "id_statuses";
            StatusCm.DisplayMember = "statuses";
            ClassAppeals.SelectEmployee();
            EmploerCm.DataSource = ClassAppeals.Dtemployee;
            EmploerCm.DisplayMember = "Fioe";
            EmploerCm.ValueMember = "id_employee";
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (ClassLetters.AddOtver(NomerLetters.Texts, EmploerCm.SelectedValue.ToString(), StatusCm.SelectedValue.ToString(), DescriptionTx.Texts, DateOtvet.Text) ==true)
            {
                MessageBox.Show("Запись добавленна","Успешно",MessageBoxButtons.OK,MessageBoxIcon.Information);
                ClassLetters.SelectOtvet(NomerLetters.Texts);
                this.Close();
            }
        }

        private void AddStatus_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<StatusFormAddRed>().Any())
                new StatusFormAddRed();
        }

        private void AddEmploer_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<EmployeeFormAdd>().Any())
                new EmployeeFormAdd();
        }
    }
}
