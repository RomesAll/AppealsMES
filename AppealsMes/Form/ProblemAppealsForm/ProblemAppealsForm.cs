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
    public partial class ProblemAppealsForm : Form
    {
        public ProblemAppealsForm()
        {
            InitializeComponent();
            if (MyAppeasl.Checked == true)
            {
                ClassProblemAppeals.SelectProblemUser(ClassAuthorization.NomerUser.ToString());
                SelectProblemDg.DataSource = ClassProblemAppeals.DtProblemAppeals;
                ProblemAppealsCount.Text = SelectProblemDg.RowCount.ToString() + " записей";
            }
            else
            {
                ClassProblemAppeals.SelectProblemAll();
                SelectProblemDg.DataSource = ClassProblemAppeals.DtProblemAppeals;
                ProblemAppealsCount.Text = SelectProblemDg.RowCount.ToString() + " записей";
            }
            
            ClassGuide.StatusesSelect();
            OtborStatusCm.DataSource = ClassGuide.DtStatuses;
            OtborStatusCm.ValueMember = "id_statuses";
            OtborStatusCm.DisplayMember = "statuses";
            
            ClassGuide.TypeAppealSelect();
            OtborTypeAppealsCm.DataSource = ClassGuide.DtTypeAppeal;
            OtborTypeAppealsCm.ValueMember = "id_type_appeal";
            OtborTypeAppealsCm.DisplayMember = "type_appeal";
            
            ClassGuide.PrioritiesSelect();
            OtborPrioritetCm.DataSource = ClassGuide.DtPriorities;
            OtborPrioritetCm.ValueMember = "id_priorities";
            OtborPrioritetCm.DisplayMember = "priorities";

            Today.Click += (s, e) =>
            {
                ItsRange.Text = "*Свой диапозон";
                dateTimePickerS.Enabled = false;
                dateTimePickerPo.Enabled = false;
                DateTime dtTodat = DateTime.Now;
                OtmenaOtborPrioritet.IconChar = FontAwesome.Sharp.IconChar.Search;
                OtmenaOtborTypeAppeals.IconChar = FontAwesome.Sharp.IconChar.Search;
                OtmenaOtborStatus.IconChar = FontAwesome.Sharp.IconChar.Search;
                if (MyAppeasl.Checked == true)
                {
                    ClassProblemAppeals.OtborProblemDates("", "", dtTodat.ToString("yyyy.MM.dd"), ClassAuthorization.NomerUser.ToString());
                    SelectProblemDg.DataSource = ClassProblemAppeals.DtOtbor;
                }
                else
                {
                    ClassProblemAppeals.OtborProblemDates("", "", dtTodat.ToString("yyyy.MM.dd"), "");
                    SelectProblemDg.DataSource = ClassProblemAppeals.DtOtbor;
                }
            };
            Last7days.Click += (s, e) =>
            {
                ItsRange.Text = "*Свой диапозон";
                dateTimePickerS.Enabled = false;
                dateTimePickerPo.Enabled = false;
                OtmenaOtborPrioritet.IconChar = FontAwesome.Sharp.IconChar.Search;
                OtmenaOtborTypeAppeals.IconChar = FontAwesome.Sharp.IconChar.Search;
                OtmenaOtborStatus.IconChar = FontAwesome.Sharp.IconChar.Search;
                if (MyAppeasl.Checked == true)
                {
                    ClassProblemAppeals.OtborProblemDates("", "", "last7", ClassAuthorization.NomerUser.ToString());
                    SelectProblemDg.DataSource = ClassProblemAppeals.DtOtbor;
                }
                else
                {
                    ClassProblemAppeals.OtborProblemDates("", "", "last7", "");
                    SelectProblemDg.DataSource = ClassProblemAppeals.DtOtbor;
                }
            };
            Last30days.Click += (s, e) =>
            {
                ItsRange.Text = "*Свой диапозон";
                dateTimePickerS.Enabled = false;
                dateTimePickerPo.Enabled = false;
                OtmenaOtborPrioritet.IconChar = FontAwesome.Sharp.IconChar.Search;
                OtmenaOtborTypeAppeals.IconChar = FontAwesome.Sharp.IconChar.Search;
                OtmenaOtborStatus.IconChar = FontAwesome.Sharp.IconChar.Search;
                if (MyAppeasl.Checked == true)
                {
                    ClassProblemAppeals.OtborProblemDates("", "", "last30", ClassAuthorization.NomerUser.ToString());
                    SelectProblemDg.DataSource = ClassProblemAppeals.DtOtbor;
                }
                else
                {
                    ClassProblemAppeals.OtborProblemDates("", "", "last30", "");
                    SelectProblemDg.DataSource = ClassProblemAppeals.DtOtbor;
                }
            };
        }

        private void MyAppeasl_CheckedChanged(object sender, EventArgs e)
        {
            if (MyAppeasl.Checked == true)
            {
                ClassProblemAppeals.SelectProblemUser(ClassAuthorization.NomerUser.ToString());
                SelectProblemDg.DataSource = ClassProblemAppeals.DtProblemAppeals;
            }
            else
            {
                ClassProblemAppeals.SelectProblemAll();
                SelectProblemDg.DataSource = ClassProblemAppeals.DtProblemAppeals;
            }
        }

        private void SelectProblemDg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectProblemDg.Rows[e.RowIndex].Selected = true;
            ClassProblemAppeals.SelectSolvingProblem(SelectProblemDg.CurrentRow.Cells[0].Value.ToString());
            SolvingProblem.DataSource = ClassProblemAppeals.DtSovlingProblem;
            SolvingProblem.CurrentCell = null;
            label10.Text = SolvingProblem.RowCount.ToString() + " записей";
        }

        private void OtmenaOtborStatus_Click(object sender, EventArgs e)
        {
            if (OtmenaOtborStatus.IconChar == FontAwesome.Sharp.IconChar.Search)
            {
                dateTimePickerS.Enabled = false;
                dateTimePickerPo.Enabled = false;
                OtmenaOtborStatus.IconChar = FontAwesome.Sharp.IconChar.MinusCircle;
                OtmenaOtborPrioritet.IconChar = FontAwesome.Sharp.IconChar.Search;
                OtmenaOtborTypeAppeals.IconChar = FontAwesome.Sharp.IconChar.Search;
                ItsRange.Text = "*Свой диапозон";
                if (MyAppeasl.Checked == true)
                {
                    ClassProblemAppeals.OtborProblemStatus(OtborStatusCm.SelectedValue.ToString(), ClassAuthorization.NomerUser.ToString());
                    SelectProblemDg.DataSource = ClassProblemAppeals.DtOtbor;
                }
                else
                {
                    ClassProblemAppeals.OtborProblemStatus(OtborStatusCm.SelectedValue.ToString(), "");
                    SelectProblemDg.DataSource = ClassAppeals.DtOtbor;
                }
            }
            else if (OtmenaOtborStatus.IconChar == FontAwesome.Sharp.IconChar.MinusCircle)
            {
                OtmenaOtborStatus.IconChar = FontAwesome.Sharp.IconChar.Search;
                if (MyAppeasl.Checked == true)
                {
                    ClassProblemAppeals.SelectProblemUser(ClassAuthorization.NomerUser.ToString());
                    SelectProblemDg.DataSource = ClassProblemAppeals.DtProblemAppeals;
                }
                else
                {
                    ClassProblemAppeals.SelectProblemAll();
                    SelectProblemDg.DataSource = ClassProblemAppeals.DtProblemAppeals;
                }
            }
        }

        private void OtmenaOtborPrioritet_Click(object sender, EventArgs e)
        {
            if (OtmenaOtborPrioritet.IconChar == FontAwesome.Sharp.IconChar.Search)
            {
                dateTimePickerS.Enabled = false;
                dateTimePickerPo.Enabled = false;
                OtmenaOtborPrioritet.IconChar = FontAwesome.Sharp.IconChar.MinusCircle;
                OtmenaOtborStatus.IconChar = FontAwesome.Sharp.IconChar.Search;
                OtmenaOtborTypeAppeals.IconChar = FontAwesome.Sharp.IconChar.Search;
                ItsRange.Text = "*Свой диапозон";
                if (MyAppeasl.Checked == true)
                {
                    ClassProblemAppeals.OtborProblemPrioritet(OtborPrioritetCm.SelectedValue.ToString(), ClassAuthorization.NomerUser.ToString());
                    SelectProblemDg.DataSource = ClassProblemAppeals.DtOtbor;
                }
                else
                {
                    ClassProblemAppeals.OtborProblemPrioritet(OtborPrioritetCm.SelectedValue.ToString(), "");
                    SelectProblemDg.DataSource = ClassAppeals.DtOtbor;
                }
            }
            else if (OtmenaOtborPrioritet.IconChar == FontAwesome.Sharp.IconChar.MinusCircle)
            {
                OtmenaOtborPrioritet.IconChar = FontAwesome.Sharp.IconChar.Search;
                if (MyAppeasl.Checked == true)
                {
                    ClassProblemAppeals.SelectProblemUser(ClassAuthorization.NomerUser.ToString());
                    SelectProblemDg.DataSource = ClassProblemAppeals.DtProblemAppeals;
                }
                else
                {
                    ClassProblemAppeals.SelectProblemAll();
                    SelectProblemDg.DataSource = ClassProblemAppeals.DtProblemAppeals;
                }
            }
        }

        private void OtmenaOtborTypeAppeals_Click(object sender, EventArgs e)
        {
            if (OtmenaOtborTypeAppeals.IconChar == FontAwesome.Sharp.IconChar.Search)
            {
                dateTimePickerS.Enabled = false;
                dateTimePickerPo.Enabled = false;
                OtmenaOtborTypeAppeals.IconChar = FontAwesome.Sharp.IconChar.MinusCircle;
                OtmenaOtborStatus.IconChar = FontAwesome.Sharp.IconChar.Search;
                OtmenaOtborPrioritet.IconChar = FontAwesome.Sharp.IconChar.Search;
                ItsRange.Text = "*Свой диапозон";
                if (MyAppeasl.Checked == true)
                {
                    ClassProblemAppeals.OtborProblemTypeAppeals(OtborTypeAppealsCm.SelectedValue.ToString(), ClassAuthorization.NomerUser.ToString());
                    SelectProblemDg.DataSource = ClassProblemAppeals.DtOtbor;
                }
                else
                {
                    ClassProblemAppeals.OtborProblemTypeAppeals(OtborTypeAppealsCm.SelectedValue.ToString(), "");
                    SelectProblemDg.DataSource = ClassAppeals.DtOtbor;
                }
            }
            else if (OtmenaOtborTypeAppeals.IconChar == FontAwesome.Sharp.IconChar.MinusCircle)
            {
                OtmenaOtborTypeAppeals.IconChar = FontAwesome.Sharp.IconChar.Search;
                if (MyAppeasl.Checked == true)
                {
                    ClassProblemAppeals.SelectProblemUser(ClassAuthorization.NomerUser.ToString());
                    SelectProblemDg.DataSource = ClassProblemAppeals.DtProblemAppeals;
                }
                else
                {
                    ClassProblemAppeals.SelectProblemAll();
                    SelectProblemDg.DataSource = ClassProblemAppeals.DtProblemAppeals;
                }
            }
        }

        private void SelectProblemDg_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            ProblemAppealsCount.Text = SelectProblemDg.RowCount.ToString() + " записей";
        }

        private void SelectProblemDg_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            ProblemAppealsCount.Text = SelectProblemDg.RowCount.ToString() + " записей";
        }

        private void ItsRange_Click(object sender, EventArgs e)
        {
            if (ItsRange.Text == "Отбор")
            {
                DateTime dtS = Convert.ToDateTime(dateTimePickerS.Text);
                DateTime dtPo = Convert.ToDateTime(dateTimePickerPo.Text);
                OtmenaOtborPrioritet.IconChar = FontAwesome.Sharp.IconChar.Search;
                OtmenaOtborTypeAppeals.IconChar = FontAwesome.Sharp.IconChar.Search;
                OtmenaOtborStatus.IconChar = FontAwesome.Sharp.IconChar.Search;
                if (MyAppeasl.Checked == true)
                {
                    ClassProblemAppeals.OtborProblemDates(dtS.ToString("yyyy.MM.dd"), dtPo.ToString("yyyy.MM.dd"), "", ClassAuthorization.NomerUser.ToString());
                    SelectProblemDg.DataSource = ClassProblemAppeals.DtOtbor;
                }
                else
                {
                    ClassProblemAppeals.OtborProblemDates(dtS.ToString("yyyy.MM.dd"), dtPo.ToString("yyyy.MM.dd"), "", "");
                    SelectProblemDg.DataSource = ClassProblemAppeals.DtOtbor;
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
                ClassProblemAppeals.SelectProblemUser(ClassAuthorization.NomerUser.ToString());
                SelectProblemDg.DataSource = ClassProblemAppeals.DtProblemAppeals;
            }
            else
            {
                ClassProblemAppeals.SelectProblemAll();
                SelectProblemDg.DataSource = ClassProblemAppeals.DtProblemAppeals;
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<WorkAppeals>().Any())
            {
                WorkAppeals work = new WorkAppeals("ProbleamAppeals");
                work.Show();
            }
        }

        private void userControlButton5_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<AppealsMes.ProblemAppealsFormAdd>().Any())
            {
                ProblemAppealsFormAdd problemAppealsFormAdd = new ProblemAppealsFormAdd(MyAppeasl.Checked, SelectProblemDg.CurrentRow.Cells[0].Value.ToString(),
                SelectProblemDg.CurrentRow.Cells[1].Value.ToString(),
                SelectProblemDg.CurrentRow.Cells[2].Value.ToString(),
                SelectProblemDg.CurrentRow.Cells[3].Value.ToString(),
                SelectProblemDg.CurrentRow.Cells[4].Value.ToString(),
                SelectProblemDg.CurrentRow.Cells[5].Value.ToString(),
                SelectProblemDg.CurrentRow.Cells[6].Value.ToString(),
                SelectProblemDg.CurrentRow.Cells[7].Value.ToString(), ""
                );
                problemAppealsFormAdd.Show();
            }
        }

        private void SearchRecords_TextChanged(object sender, EventArgs e)
        {
            Search(SelectProblemDg, SelectProblemDg.CurrentCellAddress);
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

        private void SelectProblemDg_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!Application.OpenForms.OfType<AppealsMes.ProblemAppealsFormAdd>().Any())
            {
                ProblemAppealsFormAdd problemAppealsFormAdd = new ProblemAppealsFormAdd(MyAppeasl.Checked, SelectProblemDg.CurrentRow.Cells[0].Value.ToString(),
                SelectProblemDg.CurrentRow.Cells[1].Value.ToString(),
                SelectProblemDg.CurrentRow.Cells[2].Value.ToString(),
                SelectProblemDg.CurrentRow.Cells[3].Value.ToString(),
                SelectProblemDg.CurrentRow.Cells[4].Value.ToString(),
                SelectProblemDg.CurrentRow.Cells[5].Value.ToString(),
                SelectProblemDg.CurrentRow.Cells[6].Value.ToString(),
                SelectProblemDg.CurrentRow.Cells[7].Value.ToString(), "Viewing"
                );
                problemAppealsFormAdd.Show();
            }
        }
        private void SolvingProblem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectProblemDg.Rows[e.RowIndex].Selected = true;
            SelectProblemDg.CurrentCell = null;
        }

        private void userControlButton6_Click(object sender, EventArgs e)
        {
            if (SelectProblemDg.RowCount > 0)
            {
                DialogResult res = MessageBox.Show("Вы точно хотите удалить запись?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    if (ClassProblemAppeals.DeleteProblem(SelectProblemDg.CurrentRow.Cells[0].Value.ToString()) == true)
                    {
                        ClassProblemAppeals.SelectProblemAll();
                        MessageBox.Show("Запись удаленна", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (MyAppeasl.Checked == true)
                        {
                            ClassProblemAppeals.SelectProblemUser(ClassAuthorization.NomerUser.ToString());
                            SelectProblemDg.DataSource = ClassProblemAppeals.DtProblemAppeals;
                        }
                        else
                        {
                            ClassProblemAppeals.SelectProblemAll();
                            SelectProblemDg.DataSource = ClassProblemAppeals.DtProblemAppeals;
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
