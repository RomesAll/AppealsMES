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
    class ClassClient : ClassConnection
    {
        static public DataTable DtClient = new DataTable();
        static public void SelectClient ()
        {
            try
            {
                Mycommand.CommandText = $@"SELECT id_customers, Surname_customers, Name_customers, Patronymic_customers, Email_customers, Telephone, Address_correspondence, Note FROM customers";
                DtClient.Clear();
                Mydata.Fill(DtClient);
            }
            catch
            {
                MessageBox.Show("Неудалось вывести записи","Ошибка");
            }
        }
        static private object FioD;
        static private object EmailD;
        static private object TelephoneD;
        static public bool AddClient(params string[] par)
        {
            try
            {
                Mycommand.CommandText = $"SELECT COUNT(id_customers) AS fio FROM customers WHERE Surname_customers = '{par[0]}' AND Name_customers = '{par[1]}' AND Patronymic_customers = '{par[2]}'";
                FioD = Mycommand.ExecuteScalar();
                if (Convert.ToInt32(FioD) == 0)
                {
                    Mycommand.CommandText = $"SELECT COUNT(id_customers) AS fio FROM customers WHERE Email_customers = '{par[3]}'";
                    EmailD = Mycommand.ExecuteScalar();
                    if (Convert.ToInt32(EmailD) == 0)
                    {
                        Mycommand.CommandText = $"SELECT COUNT(id_customers) AS fio FROM customers WHERE Telephone = '{par[4]}'";
                        TelephoneD = Mycommand.ExecuteScalar();
                        if (Convert.ToInt32(TelephoneD) == 0)
                        {
                            Mycommand.CommandText = $"INSERT INTO customers VALUES(null, '{par[0]}', '{par[1]}', '{par[2]}', '{par[3]}', '{par[4]}', '{par[5]}', '{par[6]}')";
                            if (Mycommand.ExecuteNonQuery() > 0)
                                return true;
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
        static public bool RedClient(params string[] par)
        {
            try
            {
                string Fio = string.Concat(par[0],' ',par[1],' ',par[2]);
                Mycommand.CommandText = $"SELECT CONCAT(Surname_customers,' ',Name_customers,' ', Patronymic_customers) AS fio FROM customers WHERE Surname_customers = '{par[0]}' AND Name_customers = '{par[1]}' AND Patronymic_customers = '{par[2]}'";
                FioD = Mycommand.ExecuteScalar();
                if (FioD == null)
                {
                    Mycommand.CommandText = $"UPDATE customers SET Surname_customers = '{par[0]}', Name_customers = '{par[1]}', Patronymic_customers = '{par[2]}' WHERE id_customers = '{par[7]}'";
                    if (Mycommand.ExecuteNonQuery() > 0)
                        return true;
                    else
                        return false;
                }
                //Mycommand.ExecuteNonQuery();
                Mycommand.CommandText = $"SELECT Email_customers FROM customers WHERE Email_customers = '{par[3]}'";
                EmailD = Mycommand.ExecuteScalar();
                if (EmailD.ToString() == null)
                {
                    Mycommand.CommandText = $"UPDATE customers SET Email_customers = '{par[3]}' WHERE id_customers = '{par[7]}'";
                    if (Mycommand.ExecuteNonQuery() > 0)
                        return true;
                    else
                        return false;
                }
                //Mycommand.ExecuteNonQuery();
                Mycommand.CommandText = $"SELECT Telephone FROM customers WHERE Telephone = '{par[4]}'";
                TelephoneD = Mycommand.ExecuteScalar();
                if (TelephoneD == null)
                {
                    Mycommand.CommandText = $"UPDATE customers SET Telephone = '{par[4]}' WHERE id_customers = '{par[7]}'";
                    if (Mycommand.ExecuteNonQuery() > 0)
                        return true;
                    else
                        return false;
                }
                Mycommand.CommandText = $"SELECT Telephone FROM customers WHERE Telephone = '{par[4]}'";
                TelephoneD = Mycommand.ExecuteScalar();
                if (TelephoneD == null)
                {
                    Mycommand.CommandText = $"UPDATE customers SET Telephone = '{par[4]}' WHERE id_customers = '{par[7]}'";
                    if (Mycommand.ExecuteNonQuery() > 0)
                        return true;
                    else
                        return false;
                }
                if (par[5] != null)
                {
                    Mycommand.CommandText = $"UPDATE customers SET Address_correspondence = '{par[5]}' WHERE id_customers = '{par[7]}'";
                    Mycommand.ExecuteNonQuery();
                }
                if (par[6] != null)
                {
                    Mycommand.CommandText = $"UPDATE customers SET Note = '{par[6]}' WHERE id_customers = '{par[7]}'";
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
        static public bool DelClient(string nomer)
        {
            try
            {
                Mycommand.CommandText = $"DELETE FROM customers WHERE id_customers = '{nomer}'";
                if (Mycommand.ExecuteNonQuery() > 0)
                    return true;
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
