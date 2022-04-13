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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Appeals_Mes
{
    public partial class AppealsForm : Form
    {
        public AppealsForm()
        {
            InitializeComponent();
            if (MyAppeasl.Checked == true)
            {
                ClassProblemAppeals.SelectAppeals(ClassAuthorization.NomerUser.ToString());
                AppealsDg.DataSource = ClassProblemAppeals.DtAppeals;
            }
            else
            {
                ClassProblemAppeals.SelectAppealsAll();
                AppealsDg.DataSource = ClassProblemAppeals.DtAppeals;
            }
            CountAppeals.Text = AppealsDg.RowCount.ToString() + " записей";

            ClassAppeals.SelectStatus();
            OtborStatusCm.DataSource = ClassAppeals.DtStatus;
            OtborStatusCm.ValueMember = "id_statuses";
            OtborStatusCm.DisplayMember = "statuses";

            ClassAppeals.SelectMethodAppeals();
            OtborTypeCm.DataSource = ClassAppeals.DtMethodAppeals;
            OtborTypeCm.ValueMember = "id_method_treatment";
            OtborTypeCm.DisplayMember = "method_treatmentcol";

        }


        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<WorkAppeals>().Any())
            {
                WorkAppeals work = new WorkAppeals("AppealsForm");
                work.Show();
            }
        }

        private void RedBtn_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<AppealsFormRed>().Any())
            {
                AppealsFormRed appealsFormRed = new AppealsFormRed(MyAppeasl.Checked, AppealsDg.CurrentRow.Cells[0].Value.ToString(),
                    AppealsDg.CurrentRow.Cells[1].Value.ToString(),
                    AppealsDg.CurrentRow.Cells[2].Value.ToString(),
                    AppealsDg.CurrentRow.Cells[3].Value.ToString(),
                    AppealsDg.CurrentRow.Cells[4].Value.ToString(),
                    AppealsDg.CurrentRow.Cells[5].Value.ToString(),
                    AppealsDg.CurrentRow.Cells[6].Value.ToString(), "");
                appealsFormRed.Show();
            }
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            if (AppealsDg.RowCount > 0)
            {
                DialogResult res = MessageBox.Show("Вы точно хотите удалить запись?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    if (ClassAppeals.AppealsDel(AppealsDg.CurrentRow.Cells[0].Value.ToString()) == true)
                    {
                        ClassAppeals.SelectAppeals();
                        MessageBox.Show("Запись удаленна", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (MyAppeasl.Checked == true)
                        {
                            ClassProblemAppeals.SelectAppeals(ClassAuthorization.NomerUser.ToString());
                            AppealsDg.DataSource = ClassProblemAppeals.DtAppeals;
                        }
                        else
                        {
                            ClassProblemAppeals.SelectAppealsAll();
                            AppealsDg.DataSource = ClassProblemAppeals.DtAppeals;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Неудалось удалить запись", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void AppealsDg_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!Application.OpenForms.OfType<AppealsFormRed>().Any())
            {
                AppealsFormRed appealsFormRed = new AppealsFormRed(MyAppeasl.Checked, AppealsDg.CurrentRow.Cells[0].Value.ToString(),
                    AppealsDg.CurrentRow.Cells[1].Value.ToString(),
                    AppealsDg.CurrentRow.Cells[2].Value.ToString(),
                    AppealsDg.CurrentRow.Cells[3].Value.ToString(),
                    AppealsDg.CurrentRow.Cells[4].Value.ToString(),
                    AppealsDg.CurrentRow.Cells[5].Value.ToString(),
                    AppealsDg.CurrentRow.Cells[6].Value.ToString(), "Viewing");
                appealsFormRed.Show();
            }
        }

        private void AppealsDg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AppealsDg.Rows[e.RowIndex].Selected = true;
            ClassProblemAppeals.SelectProblem(AppealsDg.CurrentRow.Cells[0].Value.ToString());
            SelectProblemDg.DataSource = ClassProblemAppeals.DtProblemAppeals;
            SelectProblemDg.CurrentCell = null;
            ProblemAppealsCount.Text = SelectProblemDg.RowCount.ToString() + " записей";
        }

        private void AppealsDg_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            CountAppeals.Text = AppealsDg.RowCount.ToString() + " записей";
        }

        private void AppealsDg_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            CountAppeals.Text = AppealsDg.RowCount.ToString() + " записей";
        }

        private void SelectProblemDg_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            ProblemAppealsCount.Text = SelectProblemDg.RowCount.ToString() + " записей";
        }

        private void SelectProblemDg_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            ProblemAppealsCount.Text = SelectProblemDg.RowCount.ToString() + " записей";
        }

        private void MyAppeasl_CheckedChanged(object sender, EventArgs e)
        {
            if (MyAppeasl.Checked == true)
            {
                ClassProblemAppeals.SelectAppeals(ClassAuthorization.NomerUser.ToString());
                AppealsDg.DataSource = ClassProblemAppeals.DtAppeals;
            }
            else
            {
                ClassProblemAppeals.SelectAppealsAll();
                AppealsDg.DataSource = ClassProblemAppeals.DtAppeals;
            }
        }


        private void OtmenaOtborAppeals_Click(object sender, EventArgs e)
        {
            if (OtmenaOtborAppeals.IconChar == FontAwesome.Sharp.IconChar.Search)
            {
                dateTimePickerS.Enabled = false;
                dateTimePickerPo.Enabled = false;
                ItsRange.Text = "*Свой диапозон";
                OtmenaOtborAppeals.IconChar = FontAwesome.Sharp.IconChar.MinusCircle;
                OtmenaOtborStatus.IconChar = FontAwesome.Sharp.IconChar.Search;
                if (MyAppeasl.Checked == true)
                {
                    ClassAppeals.OtborMethot(OtborTypeCm.SelectedValue.ToString(), ClassAuthorization.NomerUser.ToString());
                    AppealsDg.DataSource = ClassAppeals.DtOtbor;
                }
                else
                {
                    ClassAppeals.OtborMethot(OtborTypeCm.SelectedValue.ToString(), "");
                    AppealsDg.DataSource = ClassAppeals.DtOtbor;
                }
            }
            else if (OtmenaOtborAppeals.IconChar == FontAwesome.Sharp.IconChar.MinusCircle)
            {
                OtmenaOtborAppeals.IconChar = FontAwesome.Sharp.IconChar.Search;
                if (MyAppeasl.Checked == true)
                {
                    ClassProblemAppeals.SelectAppeals(ClassAuthorization.NomerUser.ToString());
                    AppealsDg.DataSource = ClassProblemAppeals.DtAppeals;
                }
                else
                {
                    ClassProblemAppeals.SelectAppealsAll();
                    AppealsDg.DataSource = ClassProblemAppeals.DtAppeals;
                }
            }
        }

        private void OtmenaOtborStatus_Click(object sender, EventArgs e)
        {
            if (OtmenaOtborStatus.IconChar == FontAwesome.Sharp.IconChar.Search)
            {
                dateTimePickerS.Enabled = false;
                dateTimePickerPo.Enabled = false;
                ItsRange.Text = "*Свой диапозон";
                OtmenaOtborStatus.IconChar = FontAwesome.Sharp.IconChar.MinusCircle;
                OtmenaOtborAppeals.IconChar = FontAwesome.Sharp.IconChar.Search;
                if (MyAppeasl.Checked == true)
                {
                    ClassAppeals.OtborStatus(OtborStatusCm.SelectedValue.ToString(), ClassAuthorization.NomerUser.ToString());
                    AppealsDg.DataSource = ClassAppeals.DtOtbor;
                }
                else
                {
                    ClassAppeals.OtborStatus(OtborStatusCm.SelectedValue.ToString(), "");
                    AppealsDg.DataSource = ClassAppeals.DtOtbor;
                }
            }
            else if (OtmenaOtborStatus.IconChar == FontAwesome.Sharp.IconChar.MinusCircle)
            {
                OtmenaOtborStatus.IconChar = FontAwesome.Sharp.IconChar.Search;
                if (MyAppeasl.Checked == true)
                {
                    ClassProblemAppeals.SelectAppeals(ClassAuthorization.NomerUser.ToString());
                    AppealsDg.DataSource = ClassProblemAppeals.DtAppeals;
                }
                else
                {
                    ClassProblemAppeals.SelectAppealsAll();
                    AppealsDg.DataSource = ClassProblemAppeals.DtAppeals;
                }
            }
        }

        private void ItsRange_Click(object sender, EventArgs e)
        {
            if (ItsRange.Text == "Отбор")
            {
                DateTime dtS = Convert.ToDateTime(dateTimePickerS.Text);
                DateTime dtPo = Convert.ToDateTime(dateTimePickerPo.Text);
                OtmenaOtborAppeals.IconChar = FontAwesome.Sharp.IconChar.Search;
                OtmenaOtborStatus.IconChar = FontAwesome.Sharp.IconChar.Search;
                if (MyAppeasl.Checked == true)
                {
                    ClassAppeals.OtborDate(dtS.ToString("yyyy.MM.dd"), dtPo.ToString("yyyy.MM.dd"), "", ClassAuthorization.NomerUser.ToString());
                    AppealsDg.DataSource = ClassAppeals.DtOtbor;
                }
                else
                {
                    ClassAppeals.OtborDate(dtS.ToString("yyyy.MM.dd"), dtPo.ToString("yyyy.MM.dd"), "", "");
                    AppealsDg.DataSource = ClassAppeals.DtOtbor;
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
                ClassProblemAppeals.SelectAppeals(ClassAuthorization.NomerUser.ToString());
                AppealsDg.DataSource = ClassProblemAppeals.DtAppeals;
            }
            else
            {
                ClassProblemAppeals.SelectAppealsAll();
                AppealsDg.DataSource = ClassProblemAppeals.DtAppeals;
            }
        }
        private void SearchRecords_TextChanged(object sender, EventArgs e)
        {
            Search(AppealsDg, AppealsDg.CurrentCellAddress);
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
        private void SelectProblemDg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AppealsDg.Rows[e.RowIndex].Selected = true;
            AppealsDg.CurrentCell = null;
        }

        private void Today_Click(object sender, EventArgs e)
        {
            ItsRange.Text = "*Свой диапозон";
            dateTimePickerS.Enabled = false;
            dateTimePickerPo.Enabled = false;
            DateTime dtTodat = DateTime.Now;
            OtmenaOtborAppeals.IconChar = FontAwesome.Sharp.IconChar.Search;
            OtmenaOtborStatus.IconChar = FontAwesome.Sharp.IconChar.Search;
            if (MyAppeasl.Checked == true)
            {
                ClassAppeals.OtborDate("", "", dtTodat.ToString("yyyy.MM.dd"), ClassAuthorization.NomerUser.ToString());
                AppealsDg.DataSource = ClassAppeals.DtOtbor;
            }
            else
            {
                ClassAppeals.OtborDate("", "", dtTodat.ToString("yyyy.MM.dd"), "");
                AppealsDg.DataSource = ClassAppeals.DtOtbor;
            }
        }

        private void Last7days_Click(object sender, EventArgs e)
        {
            ItsRange.Text = "*Свой диапозон";
            dateTimePickerS.Enabled = false;
            dateTimePickerPo.Enabled = false;
            OtmenaOtborAppeals.IconChar = FontAwesome.Sharp.IconChar.Search;
            OtmenaOtborStatus.IconChar = FontAwesome.Sharp.IconChar.Search;
            if (MyAppeasl.Checked == true)
            {
                ClassAppeals.OtborDate("", "", "last7", ClassAuthorization.NomerUser.ToString());
                AppealsDg.DataSource = ClassAppeals.DtOtbor;
            }
            else
            {
                ClassAppeals.OtborDate("", "", "last7", "");
                AppealsDg.DataSource = ClassAppeals.DtOtbor;
            }
        }

        private void Last30days_Click(object sender, EventArgs e)
        {
            ItsRange.Text = "*Свой диапозон";
            dateTimePickerS.Enabled = false;
            dateTimePickerPo.Enabled = false;
            OtmenaOtborAppeals.IconChar = FontAwesome.Sharp.IconChar.Search;
            OtmenaOtborStatus.IconChar = FontAwesome.Sharp.IconChar.Search;
            if (MyAppeasl.Checked == true)
            {
                ClassAppeals.OtborDate("", "", "last30", ClassAuthorization.NomerUser.ToString());
                AppealsDg.DataSource = ClassAppeals.DtOtbor;
            }
            else
            {
                ClassAppeals.OtborDate("", "", "last30", "");
                AppealsDg.DataSource = ClassAppeals.DtOtbor;
            }
        }
    }
}
