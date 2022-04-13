using Appeals_Mes.Class;
using AppealsMes;
using AppealsMes.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Appeals_Mes
{
    public partial class ProblemAppealsFormAddRed : Form
    {
        public static string[] Files = new string[20];
        public static string[] FilesName = new string[20];
        public static string Adres;
        static public string NomerProblemAppeal;
        public ProblemAppealsFormAddRed()
        {
            InitializeComponent();
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

            if (MyAppeaslAdd.Checked == true)
            {
                ClassProblemAppeals.SelectAppealsRed(ClassAuthorization.NomerUser.ToString());
                AppealsDg.DataSource = ClassProblemAppeals.DtSelectAppealsRed;
            }
            else if (MyAppeaslAdd.Checked == false)
            {
                ClassProblemAppeals.SelectAppealsAllRed();
                AppealsDg.DataSource = ClassProblemAppeals.DtSelectAppealsAllRed;
            }
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

        private void AddDocx_Click(object sender, EventArgs e)
        {
            if (AddBtn.Text == "Добавить запись")
            {
                string[] filename = new string[] { };
                string[] file = new string[] { };
                OpenFileDialog OPF = new OpenFileDialog();
                OPF.Multiselect = true;
                if (OPF.ShowDialog() == DialogResult.OK)
                {
                    filename = OPF.SafeFileNames;
                    file = OPF.FileNames;
                }

                if (FilesName != null)
                {
                    int num2 = filename.Length;
                    for (int i = 0, g = 0; g < num2 & i < FilesName.Length; i++)
                    {
                        if (FilesName[i] == null)
                        {
                            FilesName[i] = filename[g];
                            Files[i] = file[g];
                            g++;
                        }
                    }
                }
                Docx.Items.AddRange(filename);
            }
        }

        private void DeleteDocx_Click(object sender, EventArgs e)
        {
            if (AddBtn.Text == "Добавить запись")
            {
                if (Docx.SelectedIndex != -1)
                {
                    int selected = Docx.SelectedIndex;
                    Docx.Items.RemoveAt(selected);
                    List<string> temp = FilesName.ToList();
                    temp.RemoveAt(selected);
                    FilesName = temp.ToArray();
                }
            }
        }

        private void AddAdres_Click(object sender, EventArgs e)
        {
            if (AdresTx.Texts == "")
            {
                if (!Application.OpenForms.OfType<SelectAdresForm>().Any())
                    new SelectAdresForm(0).Show();
            }
            else if (AdresTx.Texts != "")
            {
                if (!Application.OpenForms.OfType<SelectAdresForm>().Any())
                    new SelectAdresForm(1, AdresTx.Texts).Show();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            AdresTx.Texts = Adres;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (NomerAppealsTx.Texts != "" & AdresTx.Texts != "")
            {
                if (ClassProblemAppeals.AddProblemAppeals(FilesName, Files, NomerAppealsTx.Texts,
                    DateOtvet.Text, DescriptionTx.Texts, StatusCm.SelectedValue.ToString(),
                    PrioritetCm.SelectedValue.ToString(), TypeAppealsCm.SelectedValue.ToString(),
                    ClassProblemAppeals.NomerAdres.ToString(), NoteTx.Texts) == true)
                {
                    MessageBox.Show("Запись добавленна", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (MyAppeaslAdd.Checked == true)
                    {
                        ClassProblemAppeals.SelectProblemUserAdd(ClassAuthorization.NomerUser.ToString());
                        ClassProblemAppeals.SelectProblemUser(ClassAuthorization.NomerUser.ToString());
                        //SelectProblemDg.DataSource = ClassProblemAppeals.DtSelectProblemUserAdd;
                    }
                    else if (MyAppeaslAdd.Checked == false)
                    {
                        ClassProblemAppeals.SelectProblemAllAdd();
                        ClassProblemAppeals.SelectProblemAll();
                        //SelectProblemDg.DataSource = ClassProblemAppeals.DtSelectProblemAllAdd;
                    }
                    Adres = "";
                    NomerAppealsTx.Texts = "";
                    DescriptionTx.Texts = "";
                    NoteTx.Texts = "";
                    Docx.Items.Clear();
                }
            }
        }

        private void MyAppeaslAdd_CheckedChanged(object sender, EventArgs e)
        {
            if (MyAppeaslAdd.Checked == true)
            {
                ClassProblemAppeals.SelectAppealsRed(ClassAuthorization.NomerUser.ToString());
                AppealsDg.DataSource = ClassProblemAppeals.DtSelectAppealsRed;
            }
            else if (MyAppeaslAdd.Checked == false)
            {
                ClassProblemAppeals.SelectAppealsAllRed();
                AppealsDg.DataSource = ClassProblemAppeals.DtSelectAppealsAllRed;
            }
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            NomerAppealsTx.Texts = AppealsDg.CurrentRow.Cells[0].Value.ToString();
            AddBtn.Enabled = true;
            AddDocx.Enabled = true;
            DeleteDocx.Enabled = true;
            AddAdres.Enabled = true;
        }

        private void AppealsDg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AppealsDg.Rows[e.RowIndex].Selected = true;
        }
    }
}
