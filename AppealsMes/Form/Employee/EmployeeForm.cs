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
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
            ClassEmployee.SelectEmployee();
            dataGridView1.DataSource = ClassEmployee.DtEmployee;
        }

        private void AddClients_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<EmployeeFormAdd>().Any())
            {
                EmployeeFormAdd employeeFormAdd = new EmployeeFormAdd();
                employeeFormAdd.Show();
            }
        }

        private void RedCLients_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<EmployeeFormRed>().Any())
            {
                EmployeeFormRed employeeFormAdd = new EmployeeFormRed(
                    dataGridView1.CurrentRow.Cells[0].Value.ToString(),
                    dataGridView1.CurrentRow.Cells[1].Value.ToString(),
                    dataGridView1.CurrentRow.Cells[2].Value.ToString(),
                    dataGridView1.CurrentRow.Cells[3].Value.ToString(),
                    dataGridView1.CurrentRow.Cells[4].Value.ToString(),
                    dataGridView1.CurrentRow.Cells[5].Value.ToString(),
                    dataGridView1.CurrentRow.Cells[6].Value.ToString(),
                    dataGridView1.CurrentRow.Cells[7].Value.ToString(),
                    dataGridView1.CurrentRow.Cells[8].Value.ToString(),
                    dataGridView1.CurrentRow.Cells[9].Value.ToString()
                    );
                employeeFormAdd.Show();
            }
        }

        private void SearchRecords_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1, dataGridView1.CurrentCellAddress);
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

        private void DeleteClients_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
            {
                DialogResult res = MessageBox.Show("Вы точно хотите удалить запись?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    if (ClassEmployee.DelEmployee(dataGridView1.CurrentRow.Cells[0].Value.ToString()) == true)
                    {
                        ClassEmployee.SelectEmployee();
                        MessageBox.Show("Запись удаленна", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
