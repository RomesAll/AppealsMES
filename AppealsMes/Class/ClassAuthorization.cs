using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appeals_Mes.Class
{
    class ClassAuthorization : ClassConnection
    {
        static public object NomerUser;
        static public object FioUser;
        static public object Post;
        static public bool Authorization(string login, string password)
        {
            try
            {
                Mycommand.CommandText = $"SELECT " +
                    $"CONCAT(employee.Surname_employee,' ', employee.Name_employee,' ',employee.Patronymic_employee) AS Fio " +
                    $"FROM employee, user_authorization" +
                    $" WHERE employee.id_employee = user_authorization.id_employee AND employee.id_employee = user_authorization.id_employee AND user_authorization.login = '{login}' AND user_authorization.password = md5('{password}')";
                FioUser = Mycommand.ExecuteScalar();
                Mycommand.CommandText = $@"SELECT employee.id_employee FROM employee, user_authorization WHERE employee.id_employee = user_authorization.id_employee AND user_authorization.login = '{login}' AND user_authorization.password = md5('{password}')";
                NomerUser = Mycommand.ExecuteScalar();
                Mycommand.CommandText = $"SELECT sp_post.post FROM employee, user_authorization, sp_post" +
                    $" WHERE employee.id_post = sp_post.id_post AND employee.id_employee = user_authorization.id_employee AND user_authorization.login = '{login}' AND user_authorization.password = md5('{password}')";
                Post = Mycommand.ExecuteScalar();
                if (FioUser != null & Post != null & NomerUser != null)
                    return true;
                else
                    return false;
        }
            catch
            {
                return false;
            }
        }
    }
}
