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
    public partial class LettersForm : Form
    {
        public LettersForm()
        {
            InitializeComponent();
            ClassLetters.SelectLetters(ClassAuthorization.NomerUser.ToString());
            SelectLetters.DataSource = ClassLetters.DtLetters;

            Today.Click += (s, e) =>
            {
                ItsRange.Text = "*Свой диапозон";
                dateTimePickerS.Enabled = false;
                dateTimePickerPo.Enabled = false;
                DateTime dtTodat = DateTime.Now;
                if (MyAppeasl.Checked == true)
                {
                    ClassLetters.OtborProblemDates("", "", dtTodat.ToString("yyyy.MM.dd"), ClassAuthorization.NomerUser.ToString());
                    SelectLetters.DataSource = ClassLetters.DtOtbor;
                }
                else
                {
                    ClassLetters.OtborProblemDates("", "", dtTodat.ToString("yyyy.MM.dd"), "");
                    SelectLetters.DataSource = ClassLetters.DtOtbor;
                }
            };
            Last7days.Click += (s, e) =>
            {
                ItsRange.Text = "*Свой диапозон";
                dateTimePickerS.Enabled = false;
                dateTimePickerPo.Enabled = false;
                if (MyAppeasl.Checked == true)
                {
                    ClassLetters.OtborProblemDates("", "", "last7", ClassAuthorization.NomerUser.ToString());
                    SelectLetters.DataSource = ClassLetters.DtOtbor;
                }
                else
                {
                    ClassLetters.OtborProblemDates("", "", "last7", "");
                    SelectLetters.DataSource = ClassLetters.DtOtbor;
                }
            };
            Last30days.Click += (s, e) =>
            {
                ItsRange.Text = "*Свой диапозон";
                dateTimePickerS.Enabled = false;
                dateTimePickerPo.Enabled = false;
                if (MyAppeasl.Checked == true)
                {
                    ClassLetters.OtborProblemDates("", "", "last30", ClassAuthorization.NomerUser.ToString());
                    SelectLetters.DataSource = ClassLetters.DtOtbor;
                }
                else
                {
                    ClassLetters.OtborProblemDates("", "", "last30", "");
                    SelectLetters.DataSource = ClassLetters.DtOtbor;
                }
            };

        }

        private void LettersForm_Load(object sender, EventArgs e)
        {

        }



        private void SelectLetters_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectLetters.Rows[e.RowIndex].Selected = true;
            ClassLetters.SelectOtvet(SelectLetters.CurrentRow.Cells[0].Value.ToString());
            SelectOtvet.DataSource = ClassLetters.DtOtvet;
            SelectOtvet.CurrentCell = null;
            label4.Text = SelectOtvet.RowCount.ToString() + " записей";
        }

        private void MyAppeasl_CheckedChanged(object sender, EventArgs e)
        {
            if (MyAppeasl.Checked == true)
            {
                ClassLetters.SelectLetters(ClassAuthorization.NomerUser.ToString());
                SelectLetters.DataSource = ClassLetters.DtLetters;
            }
            else
            {
                ClassLetters.SelectLetters("");
                SelectLetters.DataSource = ClassLetters.DtLetters;
            }
        }

        private void userControlButton8_Click(object sender, EventArgs e)
        {
            if (ItsRange.Text == "Отбор")
            {
                DateTime dtS = Convert.ToDateTime(dateTimePickerS.Text);
                DateTime dtPo = Convert.ToDateTime(dateTimePickerPo.Text);
                if (MyAppeasl.Checked == true)
                {
                    ClassLetters.OtborProblemDates(dtS.ToString("yyyy.MM.dd"), dtPo.ToString("yyyy.MM.dd"), "", ClassAuthorization.NomerUser.ToString());
                    SelectLetters.DataSource = ClassLetters.DtOtbor;
                }
                else
                {
                    ClassLetters.OtborProblemDates(dtS.ToString("yyyy.MM.dd"), dtPo.ToString("yyyy.MM.dd"), "", "");
                    SelectLetters.DataSource = ClassLetters.DtOtbor;
                }
            }
            else if (ItsRange.Text == "*Свой диапозон")
            {
                dateTimePickerS.Enabled = true;
                dateTimePickerPo.Enabled = true;
                ItsRange.Text = "Отбор";
            }
        }

        private void userControlButton2_Click(object sender, EventArgs e)
        {
            ItsRange.Text = "*Свой диапозон";
            dateTimePickerS.Enabled = false;
            dateTimePickerPo.Enabled = false;
            if (MyAppeasl.Checked == true)
            {
                ClassLetters.SelectLetters(ClassAuthorization.NomerUser.ToString());
                SelectLetters.DataSource = ClassLetters.DtLetters;
            }
            else
            {
                ClassLetters.SelectLetters("");
                SelectLetters.DataSource = ClassLetters.DtLetters;
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void SelectLetters_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            ProblemAppealsCount.Text = SelectLetters.RowCount.ToString() + " записей";
        }

        private void SelectLetters_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            ProblemAppealsCount.Text = SelectLetters.RowCount.ToString() + " записей";
        }

        private void Addleters_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<WorkAppeals>().Any())
            {
                WorkAppeals work = new WorkAppeals("Letters");
                work.Show();
            }
        }

        private void RedLetters_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<AppealsMes.LettersFormRed>().Any())
            {
                LettersFormRed lettersFormRed = new LettersFormRed(MyAppeasl.Checked, 
                    SelectLetters.CurrentRow.Cells[0].Value.ToString(),
                    SelectLetters.CurrentRow.Cells[1].Value.ToString(),
                    SelectLetters.CurrentRow.Cells[2].Value.ToString(),
                    SelectLetters.CurrentRow.Cells[3].Value.ToString(),
                    SelectLetters.CurrentRow.Cells[4].Value.ToString(),"");
                lettersFormRed.Show();
            }
        }

        private void SelectLetters_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!Application.OpenForms.OfType<AppealsMes.LettersFormRed>().Any())
            {
                LettersFormRed lettersFormRed = new LettersFormRed(MyAppeasl.Checked,
                    SelectLetters.CurrentRow.Cells[0].Value.ToString(),
                    SelectLetters.CurrentRow.Cells[1].Value.ToString(),
                    SelectLetters.CurrentRow.Cells[2].Value.ToString(),
                    SelectLetters.CurrentRow.Cells[3].Value.ToString(),
                    SelectLetters.CurrentRow.Cells[4].Value.ToString(), "Viewing");
                lettersFormRed.Show();
            }
        }

        private void AddAnswer_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<AnswerLetterForm>().Any())
            {
                AnswerLetterForm answerLetterForm = new AnswerLetterForm(SelectLetters.CurrentRow.Cells[0].Value.ToString());
                answerLetterForm.Show();
            }
        }

        private void RedAnswer_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<AnswerLetterFormRed>().Any())
            {
                AnswerLetterFormRed answerLetterForm = new AnswerLetterFormRed(
                    SelectOtvet.CurrentRow.Cells[0].Value.ToString(),
                    SelectOtvet.CurrentRow.Cells[1].Value.ToString(),
                    SelectOtvet.CurrentRow.Cells[2].Value.ToString(),
                    SelectOtvet.CurrentRow.Cells[3].Value.ToString(),
                    SelectOtvet.CurrentRow.Cells[4].Value.ToString(),
                    SelectOtvet.CurrentRow.Cells[5].Value.ToString()
                    );
                answerLetterForm.Show();
            }
        }

        private void userControlButton6_Click(object sender, EventArgs e)
        {
            if (SelectLetters.RowCount > 0)
            {
                DialogResult res = MessageBox.Show("Вы точно хотите удалить запись?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    if (ClassLetters.DeletLetters(SelectLetters.CurrentRow.Cells[0].Value.ToString()) == true)
                    {
                        ClassLetters.SelectLetters("");
                        MessageBox.Show("Запись удаленна", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Неудалось удалить запись", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void DelAnswer_Click(object sender, EventArgs e)
        {
            if (SelectOtvet.RowCount > 0)
            {
                DialogResult res = MessageBox.Show("Вы точно хотите удалить запись?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    if (ClassLetters.DeletAnswer(SelectOtvet.CurrentRow.Cells[0].Value.ToString()) == true)
                    {
                        ClassLetters.SelectOtvet(SelectLetters.CurrentRow.Cells[0].Value.ToString());
                        MessageBox.Show("Запись удаленна", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (MyAppeasl.Checked == true)
                        {
                            ClassLetters.SelectLetters(ClassAuthorization.NomerUser.ToString());
                            SelectLetters.DataSource = ClassLetters.DtLetters;
                        }
                        else
                        {
                            ClassLetters.SelectLetters("");
                            SelectLetters.DataSource = ClassLetters.DtLetters;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Неудалось удалить запись", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void SearchRecords_TextChanged(object sender, EventArgs e)
        {
            Search(SelectLetters, SelectLetters.CurrentCellAddress);
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

        private void SelectOtvet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectOtvet.Rows[e.RowIndex].Selected = true;
        }
    }
}
