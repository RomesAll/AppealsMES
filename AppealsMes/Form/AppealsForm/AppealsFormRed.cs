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
    public partial class AppealsFormRed : Form
    {
        static private string Nomer;
        static private string Klient;
        static private string Emploer;
        static private string Status;
        static private string Method;
        static private string Date;
        static private string Note;
        static private bool Myappeals;

        public AppealsFormRed(bool myappeals,params string [] par)
        {
            InitializeComponent();
            Nomer = par[0];
            Klient = par[2];
            Emploer = par[1];
            Status = par[4];
            Method = par[3];
            DateTime dt = Convert.ToDateTime(par[5]);
            Date = dt.ToString("yyyy.MM.dd");
            Note = par[6];
            Myappeals = myappeals;
            if (par[7] == "Viewing")
            {
                KlientCm.Enabled = false;
                EmploerCm.Enabled = false;
                StatusCm.Enabled = false;
                MethodCm.Enabled = false;
                DateTx.Enabled = false;
                NoteTx.Enabled = false;
                monthCalendar.Enabled = false;
                AddBtn.Enabled = false;
                AddBtn.Text = "Режим просмотра";
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (DateTx.Texts != "")
            {
                if (ClassAppeals.AppealsRed(EmploerCm.SelectedValue.ToString(), KlientCm.SelectedValue.ToString(), MethodCm.SelectedValue.ToString(), StatusCm.SelectedValue.ToString(), DateTx.Texts, NoteTx.Texts, Nomer) == true)
                {
                    if (Myappeals == true)
                        ClassProblemAppeals.SelectAppeals(ClassAuthorization.NomerUser.ToString());
                    else if (Myappeals == false)
                        ClassProblemAppeals.SelectAppealsAll();
                    MessageBox.Show("Запись обновленна", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Неудалось обносить запись", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Выберите дату обращения", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AppealsFormRed_Load(object sender, EventArgs e)
        {
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

            KlientCm.Text = Klient;
            EmploerCm.Text = Emploer;
            StatusCm.Text = Status;
            MethodCm.Text = Method;
            DateTx.Texts = Date;
            NoteTx.Texts = Note;
        }

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTx.Texts = e.Start.ToString("yyyy.MM.dd");
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
    }
}
