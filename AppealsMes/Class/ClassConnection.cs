using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appeals_Mes.Class
{
    class ClassConnection
    {
        static public string ConLine = "Database = customer_requests; DataSource = localhost; user = root; password = qwerty; charset = utf8";
        static public MySqlConnection Myconnect;
        static public MySqlCommand Mycommand;
        static public MySqlDataAdapter Mydata;

        static public void Connection()
        {
            try
            {
                Myconnect = new MySqlConnection(ConLine);
                Myconnect.Open();
                Mycommand = new MySqlCommand() { Connection = Myconnect };
                Mydata = new MySqlDataAdapter(Mycommand);
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Ошибка подключения к бд");
            }
        }
        static public void CloseForm()
        {
            //DateTime dtNow = DateTime.Now;
            //string path = @"F:\Дипломный проект\AppealsMes\History.txt";
            //string text = dtNow.ToString() + " " + ClassAuthorization.FioUser + " вышел из системы\n";
            //// полная перезапись файла 
            //using (StreamWriter writer = new StreamWriter(path, true))
            //{
            //    writer.WriteLine(text);
            //}
        }
    }
}
