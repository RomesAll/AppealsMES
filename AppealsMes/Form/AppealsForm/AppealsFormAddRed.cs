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
    public partial class AppealsFormAddRed : Form
    {
        static public bool myappeals;
        public AppealsFormAddRed()
        {
            InitializeComponent();
            ClassAppeals.SelectKlient();
            KlientCm.DataSource = ClassAppeals.Dtklient;
            KlientCm.DisplayMember = "Fioc";
            KlientCm.ValueMember = "id_customers";

            ClassAppeals.SelectEmployee();
            EmploerCm.DataSource = ClassAppeals.Dtemployee;
            EmploerCm.DisplayMember = "Fioe";
            EmploerCm.ValueMember = "id_employee";

            ClassAppeals.SelectStatus();
            StatusCm.DataSource = ClassAppeals.DtStatus;
            StatusCm.ValueMember = "id_statuses";
            StatusCm.DisplayMember = "statuses";

            ClassAppeals.SelectMethodAppeals();
            MethodCm.DataSource = ClassAppeals.DtMethodAppeals;
            MethodCm.ValueMember = "id_method_treatment";
            MethodCm.DisplayMember = "method_treatmentcol";


            if (MyAppeaslAdd.Checked == true)
            {
                ClassProblemAppeals.SelectAppealsRed(ClassAuthorization.NomerUser.ToString());
                AppealsDgAdd.DataSource = ClassProblemAppeals.DtSelectAppealsRed;
            }
            else if (MyAppeaslAdd.Checked == false)
            {
                ClassProblemAppeals.SelectAppealsAllRed();
                AppealsDgAdd.DataSource = ClassProblemAppeals.DtSelectAppealsAllRed;
            }
        }
        private void AddStatus_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<StatusFormAddRed>().Any())
                new StatusFormAddRed().Show();
        }
        private void AddMethodAppeals_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<MethodTreatmentFormAddRed>().Any())
                new MethodTreatmentFormAddRed().Show();
        }
        private void monthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateTx.Texts = e.Start.ToString("yyyy.MM.dd");
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (DateTx.Texts != "")
            {
                if (ClassAppeals.AppealsAdd(EmploerCm.SelectedValue.ToString(), KlientCm.SelectedValue.ToString(), MethodCm.SelectedValue.ToString(), StatusCm.SelectedValue.ToString(), DateTx.Texts, NoteTx.Texts) == true)
                {

                    if (MyAppeaslAdd.Checked == true)
                    {
                        ClassProblemAppeals.SelectAppeals(ClassAuthorization.NomerUser.ToString());
                        ClassProblemAppeals.SelectAppealsRed(ClassAuthorization.NomerUser.ToString());
                        AppealsDgAdd.DataSource = ClassProblemAppeals.DtSelectAppealsRed;
                    }
                    else if (MyAppeaslAdd.Checked == false)
                    {
                        ClassProblemAppeals.SelectAppealsAllRed();
                        ClassProblemAppeals.SelectAppealsAll();
                        AppealsDgAdd.DataSource = ClassProblemAppeals.DtSelectAppealsAllRed;
                    }
                    MessageBox.Show("Запись добавленна", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Неудалось добавить запись", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Выберите дату обращения", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void MyAppeasl_CheckedChanged(object sender, EventArgs e)
        {
            if (MyAppeaslAdd.Checked == true)
            {
                ClassProblemAppeals.SelectAppealsRed(ClassAuthorization.NomerUser.ToString());
                AppealsDgAdd.DataSource = ClassProblemAppeals.DtSelectAppealsRed;
            }
            else if (MyAppeaslAdd.Checked == false)
            {
                ClassProblemAppeals.SelectAppealsAllRed();
                AppealsDgAdd.DataSource = ClassProblemAppeals.DtSelectAppealsAllRed;
            }
        }

        private void AddKlient_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<ClientFormAdd>().Any())
                new ClientFormAdd().Show();
        }

        private void AddEmploer_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<EmployeeFormAdd>().Any())
                new EmployeeFormAdd().Show();
        }

        private void AppealsDgAdd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AppealsDgAdd.Rows[e.RowIndex].Selected = true;
        }
    }
}
