using Appeals_Mes.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace AppealsMes.Class
{
    class ClassEmployee : ClassConnection
    {
        static public DataTable DtEmployee = new DataTable();
        static public void SelectEmployee()
        {
            Mycommand.CommandText = $@"SELECT employee.id_employee, sp_post.post,
            employee.Surname_employee, employee.Name_employee, 
            employee.Patronymic_employee, employee.Date_birth, 
            employee.Email, employee.Telephone, user_authorization.login, user_authorization.password
            FROM employee, sp_post, user_authorization WHERE employee.id_employee = user_authorization.id_employee AND employee.id_post = sp_post.id_post";
            DtEmployee.Clear();
            Mydata.Fill(DtEmployee);
        }
        static private object FioD;
        static private object EmailD;
        static private object TelephoneD;
        static public bool AddEmployee(params string[] par)
        {
            try
            {
                object nomer;
                DateTime dt = Convert.ToDateTime(par[4]);
                Mycommand.CommandText = $"SELECT COUNT(id_employee) AS fio FROM employee WHERE Surname_employee = '{par[1]}' AND Name_employee = '{par[2]}' AND Patronymic_employee = '{par[3]}'";
                FioD = Mycommand.ExecuteScalar();
                if (Convert.ToInt32(FioD) == 0)
                {
                    Mycommand.CommandText = $"SELECT COUNT(id_employee) AS fio FROM employee WHERE Email = '{par[5]}'";
                    EmailD = Mycommand.ExecuteScalar();
                    if (Convert.ToInt32(EmailD) == 0)
                    {
                        Mycommand.CommandText = $"SELECT COUNT(id_employee) AS fio FROM employee WHERE Telephone = '{par[6]}'";
                        TelephoneD = Mycommand.ExecuteScalar();
                        if (Convert.ToInt32(TelephoneD) == 0)
                        {
                            Mycommand.CommandText = $"INSERT INTO employee VALUES(null, '{par[0]}', '{par[1]}', '{par[2]}', '{par[3]}', '{dt.ToString("yyyy.MM.dd")}', '{par[5]}', '{par[6]}')";
                            if (Mycommand.ExecuteNonQuery() > 0)
                            {
                                Mycommand.CommandText = $"SELECT id_employee FROM employee ORDER BY id_employee DESC LIMIT 1";
                                nomer = Mycommand.ExecuteScalar();
                                if (nomer != null)
                                {
                                    Mycommand.CommandText = $"INSERT INTO user_authorization VALUES(null,'{nomer.ToString()}', '{par[7]}', md5('{par[8]}'))";
                                    if (Mycommand.ExecuteNonQuery() > 0)
                                        return true;
                                    else
                                        return false;
                                }
                                else
                                    return false;
                            }
                            else
                                return false;
                        }
                        else
                        {
                            MessageBox.Show("Клиент с таких телефоном уже существует", "Ошибка");
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Клиент с таких email уже существует", "Ошибка");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Клиент с таких Фио уже существует", "Ошибка");
                    return false;
                }
            }
            catch
            {
                MessageBox.Show("Неудалось добавить запись", "Ошибка");
                return false;
            }
        }
        static public bool RedEmployee(params string[] par)
        {
            try
            {
                string Fio = string.Concat(par[1], ' ', par[2], ' ', par[3]);
                Mycommand.CommandText = $"SELECT CONCAT(Surname_employee,' ',Name_employee,' ', Patronymic_employee) AS fio FROM employee WHERE Surname_employee = '{par[1]}' AND Name_employee = '{par[2]}' AND Patronymic_employee = '{par[3]}'";
                FioD = Mycommand.ExecuteScalar();
                if (FioD == null)
                {
                    Mycommand.CommandText = $"UPDATE employee SET Surname_employee = '{par[1]}', Name_employee = '{par[2]}', Patronymic_employee = '{par[3]}' WHERE id_employee = '{par[7]}'";
                    Mycommand.ExecuteNonQuery();
                }
                //Mycommand.ExecuteNonQuery();
                Mycommand.CommandText = $"SELECT Email FROM employee WHERE id_employee = '{par[5]}'";
                EmailD = Mycommand.ExecuteScalar();
                if (EmailD == null)
                {
                    Mycommand.CommandText = $"UPDATE employee SET Email = '{par[5]}' WHERE id_employee = '{par[7]}'";
                    Mycommand.ExecuteNonQuery();
                }
                //Mycommand.ExecuteNonQuery();
                Mycommand.CommandText = $"SELECT Telephone FROM employee WHERE Telephone = '{par[6]}'";
                TelephoneD = Mycommand.ExecuteScalar();
                if (TelephoneD == null)
                {
                    Mycommand.CommandText = $"UPDATE employee SET Telephone = '{par[6]}' WHERE id_employee = '{par[7]}'";
                    Mycommand.ExecuteNonQuery();
                }

                if (par[0] != null)
                {
                    Mycommand.CommandText = $"UPDATE employee SET id_post = '{par[0]}' WHERE id_employee = '{par[7]}'";
                    Mycommand.ExecuteNonQuery();
                }
                if (par[4] != null)
                {
                    DateTime dt = Convert.ToDateTime(par[4]);
                    Mycommand.CommandText = $"UPDATE employee SET Date_birth = '{dt.ToString("yyyy.MM.dd")}' WHERE id_employee = '{par[7]}'";
                    Mycommand.ExecuteNonQuery();
                }
                if (par[8] != null)
                {
                    Mycommand.CommandText = $"UPDATE user_authorization SET login = '{par[8]}' WHERE id_employee = '{par[7]}'";
                    Mycommand.ExecuteNonQuery();
                }
                if (par[9] != null)
                {
                    Mycommand.CommandText = $"UPDATE user_authorization SET password = md5('{par[9]}') WHERE id_employee = '{par[7]}'";
                    Mycommand.ExecuteNonQuery();
                }
                return true;
            }
            catch
            {
                MessageBox.Show("Неудалось обновить запись", "Ошибка");
                return false;
            }
        }
        static public bool DelEmployee(string nomer)
        {
            try
            {
                Mycommand.CommandText = $"DELETE FROM user_authorization WHERE id_employee = '{nomer}'";
                if (Mycommand.ExecuteNonQuery() > 0)
                {
                    Mycommand.CommandText = $"DELETE FROM employee WHERE id_employee = '{nomer}'";
                    if (Mycommand.ExecuteNonQuery() > 0)
                        return true;
                    else
                        return false;
                }
                else
                    return false;
            }
            catch
            {
                MessageBox.Show("Запись присутствует в других таблицах", "Ошибка");
                return false;
            }
        }
    }
}
