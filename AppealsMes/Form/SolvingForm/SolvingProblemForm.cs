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
    public partial class SolvingProblemForm : Form
    {
        public SolvingProblemForm()
        {
            InitializeComponent();
            ClassSolvingProbleam.SelectSolvingProblem(ClassAuthorization.NomerUser.ToString());
            SolvingProblem.DataSource = ClassSolvingProbleam.DtSolvingProblem;
            label10.Text = SolvingProblem.RowCount.ToString() + " записей";

            ClassGuide.StatusesSelect();
            OtborStatusCm.DataSource = ClassGuide.DtStatuses;
            OtborStatusCm.ValueMember = "id_statuses";
            OtborStatusCm.DisplayMember = "statuses";

            Today.Click += (s, e) =>
            {
                ItsRange.Text = "*Свой диапозон";
                dateTimePickerS.Enabled = false;
                dateTimePickerPo.Enabled = false;
                DateTime dtTodat = DateTime.Now;
                OtmenaOtborStatus.IconChar = FontAwesome.Sharp.IconChar.Search;
                if (MyAppeasl.Checked == true)
                {
                    ClassSolvingProbleam.OtborProblemDates("", "", dtTodat.ToString("yyyy.MM.dd"), ClassAuthorization.NomerUser.ToString());
                    SolvingProblem.DataSource = ClassSolvingProbleam.DtOtbor;
                }
                else
                {
                    ClassSolvingProbleam.OtborProblemDates("", "", dtTodat.ToString("yyyy.MM.dd"), "");
                    SolvingProblem.DataSource = ClassSolvingProbleam.DtOtbor;
                }
            };
            Last7days.Click += (s, e) =>
            {
                ItsRange.Text = "*Свой диапозон";
                dateTimePickerS.Enabled = false;
                dateTimePickerPo.Enabled = false;
                OtmenaOtborStatus.IconChar = FontAwesome.Sharp.IconChar.Search;
                if (MyAppeasl.Checked == true)
                {
                    ClassSolvingProbleam.OtborProblemDates("", "", "last7", ClassAuthorization.NomerUser.ToString());
                    SolvingProblem.DataSource = ClassSolvingProbleam.DtOtbor;
                }
                else
                {
                    ClassSolvingProbleam.OtborProblemDates("", "", "last7", "");
                    SolvingProblem.DataSource = ClassSolvingProbleam.DtOtbor;
                }
            };
            Last30days.Click += (s, e) =>
            {
                ItsRange.Text = "*Свой диапозон";
                dateTimePickerS.Enabled = false;
                dateTimePickerPo.Enabled = false;
                OtmenaOtborStatus.IconChar = FontAwesome.Sharp.IconChar.Search;
                if (MyAppeasl.Checked == true)
                {
                    ClassSolvingProbleam.OtborProblemDates("", "", "last30", ClassAuthorization.NomerUser.ToString());
                    SolvingProblem.DataSource = ClassSolvingProbleam.DtOtbor;
                }
                else
                {
                    ClassSolvingProbleam.OtborProblemDates("", "", "last30", "");
                    SolvingProblem.DataSource = ClassSolvingProbleam.DtOtbor;
                }
            };
        }

        private void SolvingProblem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SolvingProblem.Rows[e.RowIndex].Selected = true;
            ClassSolvingProbleam.SelectLetters(SolvingProblem.CurrentRow.Cells[0].Value.ToString());
            LettersDg.DataSource = ClassSolvingProbleam.DtLetters;
            label4.Text = LettersDg.RowCount.ToString() + " записей";
        }

        private void MyAppeasl_CheckedChanged(object sender, EventArgs e)
        {
            if (MyAppeasl.Checked == true)
            {
                ClassSolvingProbleam.SelectSolvingProblem(ClassAuthorization.NomerUser.ToString());
                SolvingProblem.DataSource = ClassSolvingProbleam.DtSolvingProblem;
            }
            else
            {
                ClassSolvingProbleam.SelectSolvingProblem("");
                SolvingProblem.DataSource = ClassSolvingProbleam.DtSolvingProblem;
            }
        }

        private void OtmenaOtborStatus_Click(object sender, EventArgs e)
        {
            if (OtmenaOtborStatus.IconChar == FontAwesome.Sharp.IconChar.Search)
            {
                dateTimePickerS.Enabled = false;
                dateTimePickerPo.Enabled = false;
                OtmenaOtborStatus.IconChar = FontAwesome.Sharp.IconChar.MinusCircle;
                ItsRange.Text = "*Свой диапозон";
                if (MyAppeasl.Checked == true)
                {
                    ClassSolvingProbleam.OtborStatus(OtborStatusCm.SelectedValue.ToString(), ClassAuthorization.NomerUser.ToString());
                    SolvingProblem.DataSource = ClassSolvingProbleam.DtOtbor;
                }
                else
                {
                    ClassSolvingProbleam.OtborStatus(OtborStatusCm.SelectedValue.ToString(), "");
                    SolvingProblem.DataSource = ClassSolvingProbleam.DtOtbor;
                }
            }
            else if (OtmenaOtborStatus.IconChar == FontAwesome.Sharp.IconChar.MinusCircle)
            {
                OtmenaOtborStatus.IconChar = FontAwesome.Sharp.IconChar.Search;
                if (MyAppeasl.Checked == true)
                {
                    ClassSolvingProbleam.SelectSolvingProblem(ClassAuthorization.NomerUser.ToString());
                    SolvingProblem.DataSource = ClassSolvingProbleam.DtSolvingProblem;
                }
                else
                {
                    ClassSolvingProbleam.SelectSolvingProblem("");
                    SolvingProblem.DataSource = ClassSolvingProbleam.DtSolvingProblem;
                }
            }
        }

        private void ItsRange_Click(object sender, EventArgs e)
        {
            if (ItsRange.Text == "Отбор")
            {
                DateTime dtS = Convert.ToDateTime(dateTimePickerS.Text);
                DateTime dtPo = Convert.ToDateTime(dateTimePickerPo.Text);
                OtmenaOtborStatus.IconChar = FontAwesome.Sharp.IconChar.Search;
                if (MyAppeasl.Checked == true)
                {
                    ClassSolvingProbleam.OtborProblemDates(dtS.ToString("yyyy.MM.dd"), dtPo.ToString("yyyy.MM.dd"), "", ClassAuthorization.NomerUser.ToString());
                    SolvingProblem.DataSource = ClassSolvingProbleam.DtOtbor;
                }
                else
                {
                    ClassSolvingProbleam.OtborProblemDates(dtS.ToString("yyyy.MM.dd"), dtPo.ToString("yyyy.MM.dd"), "", "");
                    SolvingProblem.DataSource = ClassSolvingProbleam.DtOtbor;
                }
            }
            else if (ItsRange.Text == "*Свой диапозон")
            {
                dateTimePickerS.Enabled = true;
                dateTimePickerPo.Enabled = true;
                ItsRange.Text = "Отбор";
            }
        }

        private void userControlButton1_Click(object sender, EventArgs e)
        {
            ItsRange.Text = "*Свой диапозон";
            dateTimePickerS.Enabled = false;
            dateTimePickerPo.Enabled = false;
            if (MyAppeasl.Checked == true)
            {
                ClassSolvingProbleam.SelectSolvingProblem(ClassAuthorization.NomerUser.ToString());
                SolvingProblem.DataSource = ClassSolvingProbleam.DtSolvingProblem;
            }
            else
            {
                ClassSolvingProbleam.SelectSolvingProblem("");
                SolvingProblem.DataSource = ClassSolvingProbleam.DtSolvingProblem;
            }
        }

        private void SolvingProblem_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            label10.Text = SolvingProblem.RowCount.ToString() + " записей";
        }

        private void SolvingProblem_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            label10.Text = SolvingProblem.RowCount.ToString() + " записей";
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<WorkAppeals>().Any())
            {
                WorkAppeals work = new WorkAppeals("SolvingProblem");
                work.Show();
            }
        }

        private void userControlButton5_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<AppealsMes.SolvingProblemRedForm>().Any())
            {
                SolvingProblemRedForm solvingProblemRedForm = new SolvingProblemRedForm(MyAppeasl.Checked, SolvingProblem.CurrentRow.Cells[0].Value.ToString(),
                SolvingProblem.CurrentRow.Cells[1].Value.ToString(),
                SolvingProblem.CurrentRow.Cells[2].Value.ToString(),
                SolvingProblem.CurrentRow.Cells[3].Value.ToString(),
                SolvingProblem.CurrentRow.Cells[4].Value.ToString(),"");
                solvingProblemRedForm.Show();
            }
        }

        private void SolvingProblem_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!Application.OpenForms.OfType<AppealsMes.SolvingProblemRedForm>().Any())
            {
                SolvingProblemRedForm solvingProblemRedForm = new SolvingProblemRedForm(MyAppeasl.Checked, SolvingProblem.CurrentRow.Cells[0].Value.ToString(),
                SolvingProblem.CurrentRow.Cells[1].Value.ToString(),
                SolvingProblem.CurrentRow.Cells[2].Value.ToString(),
                SolvingProblem.CurrentRow.Cells[3].Value.ToString(),
                SolvingProblem.CurrentRow.Cells[4].Value.ToString(), "Viewing"
                );
                solvingProblemRedForm.Show();
            }
        }

        private void SearchRecords_TextChanged(object sender, EventArgs e)
        {
            Search(SolvingProblem, SolvingProblem.CurrentCellAddress); ;
        }
        private void Search(DataGridView Dg, System.Drawing.Point column)
        {
            for (int i = 0; i < Dg.RowCount; i++)
            {
                if (Dg[column.X, i].FormattedValue.ToString().Contains(SearchRecords.Text.Trim()))
                {
                    Dg.CurrentCell = Dg[column.X, i];
                    return;
                }
            }
        }

        private void LettersDg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LettersDg.Rows[e.RowIndex].Selected = true;
            SolvingProblem.CurrentCell = null;
        }

        private void userControlButton6_Click(object sender, EventArgs e)
        {
            if (SolvingProblem.RowCount > 0)
            {
                DialogResult res = MessageBox.Show("Вы точно хотите удалить запись?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    if (ClassSolvingProbleam.DeleteSolving(SolvingProblem.CurrentRow.Cells[0].Value.ToString()) == true)
                    {
                        ClassProblemAppeals.SelectProblemAll();
                        MessageBox.Show("Запись удаленна", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (MyAppeasl.Checked == true)
                        {
                            ClassSolvingProbleam.SelectSolvingProblem(ClassAuthorization.NomerUser.ToString());
                            SolvingProblem.DataSource = ClassSolvingProbleam.DtSolvingProblem;
                        }
                        else
                        {
                            ClassSolvingProbleam.SelectSolvingProblem("");
                            SolvingProblem.DataSource = ClassSolvingProbleam.DtSolvingProblem;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Неудалось удалить запись", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
