using Appeals_Mes;
using Appeals_Mes.Class;
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
    public partial class AnswerLetterFormRed : Form
    {
        static private string NomerAnswer;
        static private string Litters;
        static private string Description;
        static private string Status;
        static private string Date;
        static private string Emploer;
        public AnswerLetterFormRed(params string [] par)
        {
            InitializeComponent();
            NomerAnswer = par[0];
            Litters = par[1];
            Description = par[4];
            Emploer = par[2];
            Status = par[3];
            DateTime dt = Convert.ToDateTime(par[5]);
            Date = dt.ToString("yyyy.MM.dd");
        }

        private void AnswerLetterFormRed_Load(object sender, EventArgs e)
        {
            ClassGuide.StatusesSelect();
            StatusCm.DataSource = ClassGuide.DtStatuses;
            StatusCm.ValueMember = "id_statuses";
            StatusCm.DisplayMember = "statuses";
            
            NomerAppealsTx.Texts = NomerAnswer;
            NomerLetters.Texts = Litters;
            StatusCm.Text = Status;
            DescriptionTx.Texts = Description;
            DateOtvet.Text = Date;
            EmploerCm.Text = Emploer;
        }

        private void AddEmploer_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<EmployeeFormAdd>().Any())
                new EmployeeFormAdd();
        }

        private void AddStatus_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<StatusFormAddRed>().Any())
                new StatusFormAddRed();
        }
    }
}
