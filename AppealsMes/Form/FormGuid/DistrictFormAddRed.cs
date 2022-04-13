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
    public partial class DistrictFormAddRed : Form
    {
        public DistrictFormAddRed()
        {
            InitializeComponent();
            SelectModeCm.SelectedIndex = 0;
            ClassGuide.DistrictSelect();
            SelectStatusDg.DataSource = ClassGuide.DtDistrict;
            
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            switch (SelectModeCm.SelectedIndex)
            {
                case 0:
                    if (NameTb.Texts != "")
                    {
                        if (Checking_duplication(NameTb.Texts) ==false)
                        {
                            if (ClassGuide.DistrictAdd(NameTb.Texts) == true)
                            {
                                MessageBox.Show("Запись добавленна");
                                ClassGuide.DistrictSelect();
                            }
                            else
                            {
                                MessageBox.Show("Неудалось добавить запись");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Запись уже существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Заполните все поля", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;
                case 1:
                    if (NameTb.Texts != "")
                    {
                        if (Checking_duplication(NameTb.Texts) == false)
                        {
                            if (ClassGuide.DistrictRed(NomerTb.Texts, NameTb.Texts) == true)
                            {
                                MessageBox.Show("Запись обновленна");
                                ClassGuide.DistrictSelect();
                            }
                            else
                            {
                                MessageBox.Show("Неудалось обновить запись");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Запись уже существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Заполните все поля", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;
                case 2:
                    DialogResult res = MessageBox.Show("Вы точно хотите удалить запись?","Предупреждение", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                    if (res == DialogResult.Yes)
                    {
                        if (ClassGuide.DistrictDel(NomerTb.Texts) == true)
                        {
                            MessageBox.Show("Запись удаленна");
                            ClassGuide.DistrictSelect();
                            NomerTb.Texts = "";
                            NameTb.Texts = "";
                        }
                        else
                        {
                            MessageBox.Show("Неудалось удалить запись");
                        }
                    }
                    break;
            }
        }
        private bool Checking_duplication(string name)
        {
            bool res = false;
            for (int i = 0; i < SelectStatusDg.RowCount; i++)
            {
                if (SelectStatusDg["Column2", i].Value.ToString() == name)
                    res = true;
            }
            if (res == true)
                return true;
            else
                return false;
        }

        private void SelectModeCm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectModeCm.SelectedIndex == 0)
            {
                label1.Visible = false;
                NomerTb.Visible = false;
                NameTb.Enabled = true;
                AddBtn.Text = "Добавить запись";
                SelectStatusDg.CurrentCell = null;
                NomerTb.Texts = "";
                NameTb.Texts = "";
            }
            else if (SelectModeCm.SelectedIndex == 1)
            {
                label1.Visible = true;
                NomerTb.Visible = true;
                AddBtn.Text = "Редактировать запись";
                SelectStatusDg.CurrentCell = null;
                NomerTb.Texts = "";
                NameTb.Texts = "";
                NameTb.Enabled = true;
            }
            else if (SelectModeCm.SelectedIndex == 2)
            {
                label1.Visible = true;
                NomerTb.Visible = true;
                NameTb.Enabled = false;
                AddBtn.Text = "Удалить запись";
                SelectStatusDg.CurrentCell = null;
                NomerTb.Texts = "";
                NameTb.Texts = "";
            }
        }

        private void SelectStatusDg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (SelectModeCm.SelectedIndex == 1)
            {
                NomerTb.Texts = SelectStatusDg.CurrentRow.Cells[0].Value.ToString();
                NameTb.Texts = SelectStatusDg.CurrentRow.Cells[1].Value.ToString();
            }
            else if (SelectModeCm.SelectedIndex == 2)
            {
                NomerTb.Texts = SelectStatusDg.CurrentRow.Cells[0].Value.ToString();
                NameTb.Texts = SelectStatusDg.CurrentRow.Cells[1].Value.ToString();
            }
        }

        private void DistrictFormAddRed_Load(object sender, EventArgs e)
        {
            SelectStatusDg.CurrentCell = null;
        }

        private void NameTb__TextChanged(object sender, EventArgs e)
        {
            string Char = $@"a b c d e f g h i j k l m n o p q r s t u v w x y z 1 2 3 4 5 6 7 8 9 0 ! @ # $ % ^ & * ( ) _ + № ; : ? - = [ ] , . / \ ' ; ~";
            foreach (var s in Char.Split(' '))
            {
               NameTb.Texts = NameTb.Texts.Replace(s, "");
            }
        }
    }
}
