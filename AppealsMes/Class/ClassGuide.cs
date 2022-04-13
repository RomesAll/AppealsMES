using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Appeals_Mes.Class
{
    class ClassGuide : ClassConnection
    {
        static public DataTable DtStatuses = new DataTable();
        static public DataTable DtPriorities = new DataTable();
        static public DataTable DtPost = new DataTable();
        static public DataTable DtMethodTreatment = new DataTable();
        static public DataTable DtDistrict = new DataTable();
        static public DataTable DtTypeAppeal = new DataTable();

        //Вывод справочников 
        #region 
        static public void StatusesSelect()
        {
            try
            {
                Mycommand.CommandText = "SELECT id_statuses, statuses FROM sp_statuses";
                DtStatuses.Clear();
                Mydata.Fill(DtStatuses);
            }
            catch
            {
                MessageBox.Show("Неудалось вывести записи из справочника статусов", "Ошибка", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        static public void PrioritiesSelect()
        {
            try
            {
                Mycommand.CommandText = "SELECT id_priorities, priorities FROM sp_priorities";
                DtPriorities.Clear();
                Mydata.Fill(DtPriorities);
            }
            catch
            {
                MessageBox.Show("Неудалось вывести записи из справочника приоритетов", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        static public void PostSelect()
        {
            try
            {
                Mycommand.CommandText = "SELECT id_post, post FROM sp_post";
                DtPost.Clear();
                Mydata.Fill(DtPost);
            }
            catch
            {
                MessageBox.Show("Неудалось вывести записи из справочника должностей", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        static public void MethodTreatmentSelect()
        {
            try
            {
                Mycommand.CommandText = "SELECT id_method_treatment, method_treatmentcol FROM sp_method_treatment";
                DtMethodTreatment.Clear();
                Mydata.Fill(DtMethodTreatment);
            }
            catch
            {
                MessageBox.Show("Неудалось вывести записи из справочника способы обращения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        static public void DistrictSelect()
        {
            try
            {
                Mycommand.CommandText = "SELECT id_district, district FROM sp_district";
                DtDistrict.Clear();
                Mydata.Fill(DtDistrict);
            }
            catch
            {
                MessageBox.Show("Неудалось вывести записи из справочника районов", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        static public void TypeAppealSelect()
        {
            try
            {
                Mycommand.CommandText = "SELECT id_type_appeal, type_appeal FROM sp_type_appeal";
                DtTypeAppeal.Clear();
                Mydata.Fill(DtTypeAppeal);
            }
            catch
            {
                MessageBox.Show("Неудалось вывести записи из справочника тип обращений", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        //Добавление записи в справочник 
        #region
        static public bool StatusesAdd(string name)
        {
            try
            {
                Mycommand.CommandText = $"INSERT INTO sp_statuses VALUES(null, '{name}')";
                if (Mycommand.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch
            {
                MessageBox.Show("Неудалось добавить запись в справочник статусов", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        static public bool PrioritiesAdd(string name)
        {
            try
            {
                Mycommand.CommandText = $"INSERT INTO sp_priorities VALUES(null, '{name}')";
                if (Mycommand.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch
            {
                MessageBox.Show("Неудалось добавить запись в справочник приоритетов", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        static public bool PostAdd(string name)
        {
            try
            {
                Mycommand.CommandText = $"INSERT INTO post VALUES(null, '{name}')";
                if (Mycommand.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch
            {
                MessageBox.Show("Неудалось добавить запись в справочник должностей", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        static public bool MethodTreatmentAdd(string name)
        {
            try
            {
                Mycommand.CommandText = $"INSERT INTO sp_method_treatment VALUES(null, '{name}')";
                if (Mycommand.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch
            {
                MessageBox.Show("Неудалось добавить запись в справочник способы обращения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        static public bool DistrictAdd(string name)
        {
            try
            {
                Mycommand.CommandText = $"INSERT INTO sp_district VALUES(null, '{name}')";
                if (Mycommand.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch
            {
                MessageBox.Show("Запись уже существует","Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        static public bool TypeAppealAdd(string name)
        {
            try
            {
                Mycommand.CommandText = $"INSERT INTO sp_type_appeal VALUES(null, '{name}')";
                if (Mycommand.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch
            {
                MessageBox.Show("Неудалось добавить запись в справочник тип обращений", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        #endregion

        //Редактирование записи в справочнике 
        #region
        static public bool StatusesRed(string nomer, string name)
        {
            try
            {
                Mycommand.CommandText = $"UPDATE sp_statuses SET statuses = '{name}' WHERE id_statuses = '{nomer}'";
                if (Mycommand.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch
            {
                MessageBox.Show("Неудалось обновить запись в справочнике статусов", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        static public bool PrioritiesRed(string nomer, string name)
        {
            try
            {
                Mycommand.CommandText = $"UPDATE sp_priorities SET priorities = '{name}' WHERE id_priorities = '{nomer}'";
                if (Mycommand.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch
            {
                MessageBox.Show("Неудалось обновить запись в справочнике приоритетов", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        static public bool PostRed(string nomer, string name)
        {
            try
            {
                Mycommand.CommandText = $"UPDATE sp_post SET post = '{name}' WHERE id_post = '{nomer}'";
                if (Mycommand.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch
            {
                MessageBox.Show("Неудалось обновить запись в справочнике должностей", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        static public bool MethodTreatmentRed(string nomer, string name)
        {
            try
            {
                Mycommand.CommandText = $"UPDATE sp_method_treatment SET method_treatmentcol = '{name}' WHERE id_method_treatment = '{nomer}'";
                if (Mycommand.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch
            {
                MessageBox.Show("Неудалось обновить запись в справочнике способы обращения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        static public bool DistrictRed(string nomer, string name)
        {
            try
            {
                Mycommand.CommandText = $"UPDATE sp_district SET district = '{name}' WHERE id_district = '{nomer}'";
                if (Mycommand.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch
            {
                MessageBox.Show("Неудалось обновить запись в справочнике районов", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        static public bool TypeAppealRed(string nomer, string name)
        {
            try
            {
                Mycommand.CommandText = $"UPDATE sp_type_appeal SET type_appeal = '{name}' WHERE id_type_appeal = '{nomer}'";
                if (Mycommand.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch
            {
                MessageBox.Show("Неудалось обновить запись в справочнике тип обращений", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        #endregion

        //Удаление записи из справочника
        #region
        static public bool StatusesDel(string nomer)
        {
            try
            {
                Mycommand.CommandText = $"DELETE FROM sp_statuses WHERE id_statuses = '{nomer}'";
                if (Mycommand.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch
            {
                MessageBox.Show("Неудалось удалить запись в справочнике статусов", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        static public bool PrioritiesDel(string nomer)
        {
            try
            {
                Mycommand.CommandText = $"DELETE FROM sp_priorities WHERE id_priorities = '{nomer}'";
                if (Mycommand.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch
            {
                MessageBox.Show("Неудалось удалить запись в справочнике приоритетов", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        static public bool PostDel(string nomer)
        {
            try
            {
                Mycommand.CommandText = $"DELETE FROM sp_post WHERE id_post = '{nomer}'";
                if (Mycommand.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch
            {
                MessageBox.Show("Неудалось удалить запись в справочнике должностей", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        static public bool MethodTreatmentDel(string nomer)
        {
            try
            {
                Mycommand.CommandText = $"DELETE FROM sp_method_treatment WHERE id_method_treatment = '{nomer}'";
                if (Mycommand.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch
            {
                MessageBox.Show("Неудалось удалить запись в справочнике способы обращения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        static public bool DistrictDel(string nomer)
        {
            try
            {
                Mycommand.CommandText = $"DELETE FROM sp_district WHERE id_district = '{nomer}'";
                if (Mycommand.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch
            {
                MessageBox.Show("Неудалось удалить запись в справочнике районов", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        static public bool TypeAppealDel(string nomer)
        {
            try
            {
                Mycommand.CommandText = $"DELETE FROM sp_type_appeal WHERE id_type_appeal = '{nomer}'";
                if (Mycommand.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch
            {
                MessageBox.Show("Неудалось обновить запись в справочнике тип обращений", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        #endregion
    }
}
