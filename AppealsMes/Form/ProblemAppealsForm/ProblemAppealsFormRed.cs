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
    public partial class ProblemAppealsFormAdd : Form
    {
        static private string NomerAppeals = "";
        static private string NomerProblem = "";
        static private string DateOtveta = "";
        static private string TypeAppeals = "";
        static private string Description = "";
        static private string Status = "";
        static private string Prioritet = "";
        static private string Adres = "";
        static private string NomerAdres = "";
        static private string Notes = "";
        static private bool MyAppeal;
        public static string Adres1;
        public ProblemAppealsFormAdd(bool myappeals, params string[] par)
        {
            InitializeComponent();
            NomerProblem = par[0];
            DateTime dt = Convert.ToDateTime(par[1]);
            DateOtveta = dt.ToString("yyyy.MM.dd");
            TypeAppeals = par[4];
            Description = par[6];
            Status = par[2];
            Prioritet = par[3];
            Adres = par[5];
            Notes = par[7];
            MyAppeal = myappeals;
            NomerAdres = ClassProblemAppeals.SelectAdes(NomerProblem);
            NomerAppeals = ClassProblemAppeals.SelectNomerAppeals(NomerProblem);
            if (par[8] == "Viewing")
            {
                AddDocx.Enabled = false;
                DeleteDocx.Enabled = false;
                AddAdres.Enabled = false;
                AddBtn.Enabled = false;
                AddBtn.Text = "Режим просмотра";
            }
        }
        private void AddAdres_Click(object sender, EventArgs e)
        {
            if (AdresTx.Texts == "")
            {
                if (!Application.OpenForms.OfType<SelectAdresForm>().Any())
                    new SelectAdresForm(0).Show();
            }
            else if (AddBtn.Text == "Редактировать запись")
            {
                if (!Application.OpenForms.OfType<SelectAdresForm>().Any())
                    new SelectAdresForm(1, NomerProblem, userControlTextBox1.Texts).Show();
            }
        }

        private void ProblemAppealsFormAdd_Load(object sender, EventArgs e)
        {
            ClassGuide.TypeAppealSelect();
            TypeAppealsCm.DataSource = ClassGuide.DtTypeAppeal;
            TypeAppealsCm.ValueMember = "id_type_appeal";
            TypeAppealsCm.DisplayMember = "type_appeal";

            ClassGuide.StatusesSelect();
            StatusCm.DataSource = ClassGuide.DtStatuses;
            StatusCm.ValueMember = "id_statuses";
            StatusCm.DisplayMember = "statuses";

            ClassGuide.PrioritiesSelect();
            PrioritetCm.DataSource = ClassGuide.DtPriorities;
            PrioritetCm.ValueMember = "id_priorities";
            PrioritetCm.DisplayMember = "priorities";

            NomerAppealsTx.Texts = NomerAppeals;
            userControlTextBox1.Texts = NomerProblem;
            DateOtvet.Text = DateOtveta;
            TypeAppealsCm.Text = TypeAppeals;
            StatusCm.Text = Status;
            PrioritetCm.Text = Prioritet;
            DescriptionTx.Texts = Description;
            NoteTx.Texts = Notes;
            AdresTx.Texts = Adres;

            ClassProblemAppeals.SelectFile(NomerProblem);
            Docx.DataSource = ClassProblemAppeals.DtDocx;
            Docx.ValueMember = "id_application_documents";
            Docx.DisplayMember = "Heading";
        }

        private void AddDocx_Click(object sender, EventArgs e)
        {
            OpenFileDialog OPF = new OpenFileDialog();
            OPF.Multiselect = true;
            if (OPF.ShowDialog() == DialogResult.OK)
            {
                ClassProblemAppeals.AddFileProbleamAppeals(NomerProblem, OPF.SafeFileNames, OPF.FileNames);
                ClassProblemAppeals.SelectFile(NomerProblem);
            }
        }

        private void DeleteDocx_Click(object sender, EventArgs e)
        {
            if (Docx.SelectedIndex != -1)
            {
                ClassProblemAppeals.DeleteFile(Docx.SelectedValue.ToString());
                ClassProblemAppeals.SelectFile(NomerProblem);
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (NomerAppealsTx.Texts != "" & AdresTx.Texts != "")
            {
                if (ClassProblemAppeals.RedProbleamAppeals(DateOtvet.Text, DescriptionTx.Texts, StatusCm.SelectedValue.ToString(),
                PrioritetCm.SelectedValue.ToString(), TypeAppealsCm.SelectedValue.ToString(), NomerAdres, NoteTx.Texts, NomerProblem) == true)
                {
                    MessageBox.Show("Запись обновленна", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (MyAppeal == true)
                    {
                        ClassProblemAppeals.SelectProblemUserAdd(ClassAuthorization.NomerUser.ToString());
                        ClassProblemAppeals.SelectProblemUser(ClassAuthorization.NomerUser.ToString());
                    }
                    else if (MyAppeal == false)
                    {
                        ClassProblemAppeals.SelectProblemAllAdd();
                        ClassProblemAppeals.SelectProblemAll();
                    }
                    this.Close();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ClassProblemAppeals.Adres != null)
                AdresTx.Texts = ClassProblemAppeals.Adres.ToString();
        }

        private void AddGuidTypeAppeals_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<TypeAppealFormAddRed>().Any())
                new TypeAppealFormAddRed().Show();
        }

        private void AddGuidStatus_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<StatusFormAddRed>().Any())
                new StatusFormAddRed().Show();
        }

        private void AddGuidPrioritet_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<PrioritiesFormAddRed>().Any())
                new PrioritiesFormAddRed().Show();
        }
    }
}
