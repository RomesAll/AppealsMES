using Appeals_Mes.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppealsMes.Class
{
    class ClassSolvingProbleam : ClassConnection
    {
        static public DataTable DtSolvingProblem = new DataTable();
        static public DataTable DtLetters = new DataTable();
        static public DataTable DtOtbor = new DataTable();
        static public DataTable DtSolvingUser = new DataTable();
        static public void SelectSolvingProblem(string nomeruser)
        {
            if (nomeruser != "")
                Mycommand.CommandText = $"SELECT solving_problem.id_solving_problem, solving_problem.id_problem_appeals, solving_problem.Description, solving_problem.Data_solving_problem, sp_statuses.statuses, solving_problem.LettersCh FROM solving_problem, employee, sp_statuses, problem_appeals, appeals WHERE solving_problem.id_problem_appeals = problem_appeals.id_problem_appeals AND problem_appeals.id_appeals = appeals.id_appeals AND solving_problem.id_statuses = sp_statuses.id_statuses AND appeals.id_employee = employee.id_employee AND appeals.id_employee = '{nomeruser}'";
            else if (nomeruser == "")
                Mycommand.CommandText = $"SELECT solving_problem.id_solving_problem, solving_problem.id_problem_appeals, solving_problem.Description, solving_problem.Data_solving_problem, sp_statuses.statuses, solving_problem.LettersCh FROM solving_problem, employee, sp_statuses, problem_appeals, appeals WHERE solving_problem.id_problem_appeals = problem_appeals.id_problem_appeals AND problem_appeals.id_appeals = appeals.id_appeals AND solving_problem.id_statuses = sp_statuses.id_statuses AND appeals.id_employee = employee.id_employee";
            
            DtSolvingProblem.Clear();
            Mydata.Fill(DtSolvingProblem);
        }

        static public bool DeleteSolving(string nomer)
        {
            try
            {
                Mycommand.CommandText = $"DELETE FROM solving_problem WHERE id_solving_problem = '{nomer}'";
                if (Mycommand.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Запись используеться в других таблицах", "Ошибка", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
        }

        static public void OtborStatus(string status, string nomeruser)
        {
            if (nomeruser != "")
                Mycommand.CommandText = $"SELECT solving_problem.id_solving_problem, solving_problem.id_problem_appeals, solving_problem.Description, solving_problem.Data_solving_problem, sp_statuses.statuses, solving_problem.LettersCh FROM solving_problem, employee, sp_statuses, problem_appeals, appeals WHERE solving_problem.id_problem_appeals = problem_appeals.id_problem_appeals AND problem_appeals.id_appeals = appeals.id_appeals AND solving_problem.id_statuses = sp_statuses.id_statuses AND appeals.id_employee = employee.id_employee AND appeals.id_employee = '{nomeruser}' AND sp_statuses.id_statuses = '{status}'";
            else if(nomeruser == "")
                Mycommand.CommandText = $"SELECT solving_problem.id_solving_problem, solving_problem.id_problem_appeals, solving_problem.Description, solving_problem.Data_solving_problem, sp_statuses.statuses, solving_problem.LettersCh FROM solving_problem, employee, sp_statuses, problem_appeals, appeals WHERE solving_problem.id_problem_appeals = problem_appeals.id_problem_appeals AND problem_appeals.id_appeals = appeals.id_appeals AND solving_problem.id_statuses = sp_statuses.id_statuses AND appeals.id_employee = employee.id_employee AND sp_statuses.id_statuses = '{status}'";

            DtOtbor.Clear();
            Mydata.Fill(DtOtbor);
        }
        static public void SelectLetters(string nomer)
        {
            Mycommand.CommandText = $"SELECT letter.id_letter, letter.id_solving_problem, CONCAT(employee.Surname_employee,' ',employee.Name_employee,' ',employee.Patronymic_employee)AS Fioe, letter.Date_outgoing, letter.Description, letter.AnswerCh FROM letter, solving_problem, employee WHERE letter.id_solving_problem = solving_problem.id_solving_problem AND letter.id_employee = employee.id_employee AND letter.id_solving_problem = '{nomer}'";
            DtLetters.Clear();
            Mydata.Fill(DtLetters);
        }
        static public void OtborProblemDates(string dates, string datepo, string last, string nomeruser)
        {
            DateTime dt = DateTime.Now;
            if (dates != "" & datepo != "")
            {
                if (nomeruser != "")
                {
                    Mycommand.CommandText = $"SELECT solving_problem.id_solving_problem, solving_problem.id_problem_appeals, solving_problem.Description, solving_problem.Data_solving_problem, sp_statuses.statuses, solving_problem.LettersCh FROM solving_problem, employee, sp_statuses, problem_appeals, appeals WHERE solving_problem.id_problem_appeals = problem_appeals.id_problem_appeals AND problem_appeals.id_appeals = appeals.id_appeals AND solving_problem.id_statuses = sp_statuses.id_statuses AND appeals.id_employee = employee.id_employee AND solving_problem.Data_solving_problem BETWEEN '{dates}'AND '{datepo}' AND appeals.id_employee = '{nomeruser}'";
                    DtOtbor.Clear();
                    Mydata.Fill(DtOtbor);
                }
                else if (nomeruser == "")
                {
                    Mycommand.CommandText = $"SELECT solving_problem.id_solving_problem, solving_problem.id_problem_appeals, solving_problem.Description, solving_problem.Data_solving_problem, sp_statuses.statuses, solving_problem.LettersCh FROM solving_problem, employee, sp_statuses, problem_appeals, appeals WHERE solving_problem.id_problem_appeals = problem_appeals.id_problem_appeals AND problem_appeals.id_appeals = appeals.id_appeals AND solving_problem.id_statuses = sp_statuses.id_statuses AND appeals.id_employee = employee.id_employee AND solving_problem.Data_solving_problem BETWEEN '{dates}'AND '{datepo}'";
                    DtOtbor.Clear();
                    Mydata.Fill(DtOtbor);
                }
            }
            else if (last == dt.ToString("yyyy.MM.dd"))
            {
                if (nomeruser != "")
                {
                    Mycommand.CommandText = $"SELECT solving_problem.id_solving_problem, solving_problem.id_problem_appeals, solving_problem.Description, solving_problem.Data_solving_problem, sp_statuses.statuses, solving_problem.LettersCh FROM solving_problem, employee, sp_statuses, problem_appeals, appeals WHERE solving_problem.id_problem_appeals = problem_appeals.id_problem_appeals AND problem_appeals.id_appeals = appeals.id_appeals AND solving_problem.id_statuses = sp_statuses.id_statuses AND appeals.id_employee = employee.id_employee AND solving_problem.Data_solving_problem = '{last}' AND appeals.id_employee = '{nomeruser}'";
                    DtOtbor.Clear();
                    Mydata.Fill(DtOtbor);
                }
                else if (nomeruser == "")
                {
                    Mycommand.CommandText = $"SELECT solving_problem.id_solving_problem, solving_problem.id_problem_appeals, solving_problem.Description, solving_problem.Data_solving_problem, sp_statuses.statuses, solving_problem.LettersCh FROM solving_problem, employee, sp_statuses, problem_appeals, appeals WHERE solving_problem.id_problem_appeals = problem_appeals.id_problem_appeals AND problem_appeals.id_appeals = appeals.id_appeals AND solving_problem.id_statuses = sp_statuses.id_statuses AND appeals.id_employee = employee.id_employee AND solving_problem.Data_solving_problem = '{last}'";
                    DtOtbor.Clear();
                    Mydata.Fill(DtOtbor);
                }
            }
            else if (last == "last7")
            {
                if (nomeruser != "")
                {
                    Mycommand.CommandText = $"SELECT solving_problem.id_solving_problem, solving_problem.id_problem_appeals, solving_problem.Description, solving_problem.Data_solving_problem, sp_statuses.statuses, solving_problem.LettersCh FROM solving_problem, employee, sp_statuses, problem_appeals, appeals WHERE solving_problem.id_problem_appeals = problem_appeals.id_problem_appeals AND problem_appeals.id_appeals = appeals.id_appeals AND solving_problem.id_statuses = sp_statuses.id_statuses AND appeals.id_employee = employee.id_employee AND solving_problem.Data_solving_problem > NOW() - INTERVAL 7 DAY AND appeals.id_employee = '{nomeruser}'";
                    DtOtbor.Clear();
                    Mydata.Fill(DtOtbor);
                }
                else if (nomeruser == "")
                {
                    Mycommand.CommandText = $"SELECT solving_problem.id_solving_problem, solving_problem.id_problem_appeals, solving_problem.Description, solving_problem.Data_solving_problem, sp_statuses.statuses, solving_problem.LettersCh FROM solving_problem, employee, sp_statuses, problem_appeals, appeals WHERE solving_problem.id_problem_appeals = problem_appeals.id_problem_appeals AND problem_appeals.id_appeals = appeals.id_appeals AND solving_problem.id_statuses = sp_statuses.id_statuses AND appeals.id_employee = employee.id_employee AND solving_problem.Data_solving_problem > NOW() - INTERVAL 7 DAY";
                    DtOtbor.Clear();
                    Mydata.Fill(DtOtbor);
                }
            }
            else if (last == "last30")
            {
                if (nomeruser != "")
                {
                    Mycommand.CommandText = $"SELECT solving_problem.id_solving_problem, solving_problem.id_problem_appeals, solving_problem.Description, solving_problem.Data_solving_problem, sp_statuses.statuses, solving_problem.LettersCh FROM solving_problem, employee, sp_statuses, problem_appeals, appeals WHERE solving_problem.id_problem_appeals = problem_appeals.id_problem_appeals AND problem_appeals.id_appeals = appeals.id_appeals AND solving_problem.id_statuses = sp_statuses.id_statuses AND appeals.id_employee = employee.id_employee AND solving_problem.Data_solving_problem > NOW() - INTERVAL 30 DAY AND appeals.id_employee = '{nomeruser}'";
                    DtOtbor.Clear();
                    Mydata.Fill(DtOtbor);
                }
                else if (nomeruser == "")
                {
                    Mycommand.CommandText = $"SELECT solving_problem.id_solving_problem, solving_problem.id_problem_appeals, solving_problem.Description, solving_problem.Data_solving_problem, sp_statuses.statuses, solving_problem.LettersCh FROM solving_problem, employee, sp_statuses, problem_appeals, appeals WHERE solving_problem.id_problem_appeals = problem_appeals.id_problem_appeals AND problem_appeals.id_appeals = appeals.id_appeals AND solving_problem.id_statuses = sp_statuses.id_statuses AND appeals.id_employee = employee.id_employee AND solving_problem.Data_solving_problem > NOW() - INTERVAL 30 DAY";
                    DtOtbor.Clear();
                    Mydata.Fill(DtOtbor);
                }
            }

        }
        static public void SelectProblemUser(string nomer)
        {
            Mycommand.CommandText = $@"SELECT problem_appeals.id_problem_appeals, problem_appeals.Date_delayed_response, sp_statuses.statuses, sp_priorities.priorities,
                                        sp_type_appeal.type_appeal, CONCAT(sp_district.district,' Улица ',street.Street,' Дом ',address_premises.Home,' Корпус ',address_premises.Korpys,' Квартира ',address_premises.Kvartira) AS Adres, problem_appeals.Description, problem_appeals.Note, problem_appeals.SolvingCh FROM problem_appeals, sp_priorities, sp_statuses, sp_type_appeal, address_premises, street, sp_district, appeals
                                        WHERE problem_appeals.id_appeals = appeals.id_appeals AND problem_appeals.id_statuses = sp_statuses.id_statuses AND
                                        problem_appeals.id_priorities = sp_priorities.id_priorities AND problem_appeals.id_type_appeal = sp_type_appeal.id_type_appeal AND
                                        problem_appeals.id_address_premises = address_premises.id_address_premises AND
                                        address_premises.id_street = street.id_street AND street.id_district = sp_district.id_district AND appeals.id_employee = '{nomer}'";
            DtSolvingUser.Clear();
            Mydata.Fill(DtSolvingUser);
        }
        static public void SelectProblemAll()
        {
            Mycommand.CommandText = $@"SELECT problem_appeals.id_problem_appeals, problem_appeals.Date_delayed_response, sp_statuses.statuses, sp_priorities.priorities,
                                        sp_type_appeal.type_appeal, CONCAT(sp_district.district,' Улица ',street.Street,' Дом ',address_premises.Home,' Корпус ',address_premises.Korpys,' Квартира ',address_premises.Kvartira) AS Adres, problem_appeals.Description, problem_appeals.Note, problem_appeals.SolvingCh FROM problem_appeals, sp_priorities, sp_statuses, sp_type_appeal, address_premises, street, sp_district, appeals
                                        WHERE problem_appeals.id_appeals = appeals.id_appeals AND problem_appeals.id_statuses = sp_statuses.id_statuses AND
                                        problem_appeals.id_priorities = sp_priorities.id_priorities AND problem_appeals.id_type_appeal = sp_type_appeal.id_type_appeal AND
                                        problem_appeals.id_address_premises = address_premises.id_address_premises AND
                                        address_premises.id_street = street.id_street AND street.id_district = sp_district.id_district";
            DtSolvingUser.Clear();
            Mydata.Fill(DtSolvingUser);
        }


        static public bool AddSolvingProbleam(params string [] par)
        {
            DateTime dt = Convert.ToDateTime(par[2]);  
            Mycommand.CommandText = $"INSERT INTO solving_problem VALUES(null, '{par[0]}','{par[1]}','{dt.ToString("yyyy.MM.dd")}','{par[3]}','{0}')";
            if (Mycommand.ExecuteNonQuery() > 0)
                return true;
            else
                return false;
        }
        static public bool RedSolvingProblem(params string [] par)
        {
            DateTime dt = Convert.ToDateTime(par[2]);
            Mycommand.CommandText = $"UPDATE solving_problem SET id_problem_appeals = '{par[0]}', Description = '{par[1]}', Data_solving_problem = '{dt.ToString("yyyy.MM.dd")}', id_statuses = '{par[3]}' WHERE id_solving_problem = '{par[4]}'";
            if (Mycommand.ExecuteNonQuery() > 0)
                return true;
            else
                return false;
        }
    }
}
