using Appeals_Mes.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppealsMes.Class
{
    class ClassLetters : ClassConnection
    {
        static public DataTable DtOtvet = new DataTable();
        static public DataTable DtLetters = new DataTable();
        static public DataTable DtOtbor = new DataTable();
        static public DataTable DtSelectSolvingProblem = new DataTable();
        static public void SelectLetters(string nomer)
        {
            if (nomer != "")
            {
                Mycommand.CommandText = $@"SELECT letter.id_letter, letter.id_solving_problem, CONCAT(employee.Surname_employee,' ',employee.Name_employee,' ',employee.Patronymic_employee)AS Fioe, letter.Date_outgoing, letter.Description, letter.AnswerCh 
                                            FROM letter, solving_problem, employee WHERE letter.id_solving_problem = solving_problem.id_solving_problem AND letter.id_employee = employee.id_employee AND letter.id_employee = '{nomer}'";
                DtLetters.Clear();
                Mydata.Fill(DtLetters);
            }
            else if (nomer == "")
            {
                Mycommand.CommandText = $@"SELECT letter.id_letter, letter.id_solving_problem, CONCAT(employee.Surname_employee,' ',employee.Name_employee,' ',employee.Patronymic_employee)AS Fioe, letter.Date_outgoing, letter.Description, letter.AnswerCh 
                                            FROM letter, solving_problem, employee WHERE letter.id_solving_problem = solving_problem.id_solving_problem AND letter.id_employee = employee.id_employee";
                DtLetters.Clear();
                Mydata.Fill(DtLetters);
            }
        }
        static public bool DeletLetters(string nomer)
        {
            try
            {
                Mycommand.CommandText = $"DELETE FROM letter WHERE id_letter = '{nomer}'";
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
        static public bool DeletAnswer(string nomer)
        {
            try
            {
                Mycommand.CommandText = $"DELETE FROM answer_letter WHERE id_answer_letter = '{nomer}'";
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
        static public void SelectOtvet(string nomer)
        {
            Mycommand.CommandText = $@"SELECT answer_letter.id_answer_letter, answer_letter.id_letter, CONCAT(employee.Surname_employee,' ',employee.Name_employee,' ',employee.Patronymic_employee)AS Fioe, sp_statuses.statuses, answer_letter.Description, answer_letter.DateAnsewer
                                        FROM answer_letter, letter, sp_statuses, employee
                                        WHERE answer_letter.id_statuses = sp_statuses.id_statuses AND answer_letter.id_letter = letter.id_letter AND answer_letter.id_employee = employee.id_employee AND answer_letter.id_letter = '{nomer}'";
            DtOtvet.Clear();
            Mydata.Fill(DtOtvet);
        }
        static public bool AddOtver(params string [] par)
        {
            DateTime dt = Convert.ToDateTime(par[4]);
            Mycommand.CommandText = $"INSERT answer_letter VALUES(null, '{par[0]}','{par[1]}','{par[2]}','{par[3]}','{dt.ToString("yyyy.MM.dd")}')";
            if (Mycommand.ExecuteNonQuery() > 0)
                return true;
            else
                return false;
        }
        static public bool RedOtvet(params string [] par)
        {
            DateTime dt = Convert.ToDateTime(par[4]);
            Mycommand.CommandText = $"UPDATE answer_letter SET id_letter = '{par[0]}', id_employee = '{par[1]}', id_statuses = '{par[2]}', Description = '{par[3]}', DateAnsewer = '{dt.ToString("yyyy.MM.dd")}' WHERE id_answer_letter = '{par[5]}'";
            if (Mycommand.ExecuteNonQuery() > 0)
                return true;
            else
                return false;
        }

        static public void OtborProblemDates(string dates, string datepo, string last, string nomeruser)
        {
            DateTime dt = DateTime.Now;
            if (dates != "" & datepo != "")
            {
                if (nomeruser != "")
                {
                    Mycommand.CommandText = $@"SELECT letter.id_letter, letter.id_solving_problem, CONCAT(employee.Surname_employee,' ',employee.Name_employee,' ',employee.Patronymic_employee)AS Fioe, letter.Date_outgoing, letter.Description, letter.AnswerCh 
                                            FROM letter, solving_problem, employee WHERE letter.id_solving_problem = solving_problem.id_solving_problem AND letter.id_employee = employee.id_employee AND letter.Date_outgoing BETWEEN '{dates}'AND '{datepo}' AND letter.id_employee = '{nomeruser}'";
                    DtOtbor.Clear();
                    Mydata.Fill(DtOtbor);
                }
                else if (nomeruser == "")
                {
                    Mycommand.CommandText = $@"SELECT letter.id_letter, letter.id_solving_problem, CONCAT(employee.Surname_employee,' ',employee.Name_employee,' ',employee.Patronymic_employee)AS Fioe, letter.Date_outgoing, letter.Description, letter.AnswerCh 
                                            FROM letter, solving_problem, employee WHERE letter.id_solving_problem = solving_problem.id_solving_problem AND letter.id_employee = employee.id_employee AND letter.Date_outgoing BETWEEN '{dates}'AND '{datepo}'";
                    DtOtbor.Clear();
                    Mydata.Fill(DtOtbor);
                }
            }
            else if (last == dt.ToString("yyyy.MM.dd"))
            {
                if (nomeruser != "")
                {
                    Mycommand.CommandText = $@"SELECT letter.id_letter, letter.id_solving_problem, CONCAT(employee.Surname_employee,' ',employee.Name_employee,' ',employee.Patronymic_employee)AS Fioe, letter.Date_outgoing, letter.Description, letter.AnswerCh 
                                            FROM letter, solving_problem, employee WHERE letter.id_solving_problem = solving_problem.id_solving_problem AND letter.id_employee = employee.id_employee AND letter.Date_outgoing = '{last}' AND letter.id_employee = '{nomeruser}'";
                    DtOtbor.Clear();
                    Mydata.Fill(DtOtbor);
                }
                else if (nomeruser == "")
                {
                    Mycommand.CommandText = $@"SELECT letter.id_letter, letter.id_solving_problem, CONCAT(employee.Surname_employee,' ',employee.Name_employee,' ',employee.Patronymic_employee)AS Fioe, letter.Date_outgoing, letter.Description, letter.AnswerCh 
                                            FROM letter, solving_problem, employee WHERE letter.id_solving_problem = solving_problem.id_solving_problem AND letter.id_employee = employee.id_employee AND letter.Date_outgoing = '{last}'";
                    DtOtbor.Clear();
                    Mydata.Fill(DtOtbor);
                }
            }
            else if (last == "last7")
            {
                if (nomeruser != "")
                {
                    Mycommand.CommandText = $@"SELECT letter.id_letter, letter.id_solving_problem, CONCAT(employee.Surname_employee,' ',employee.Name_employee,' ',employee.Patronymic_employee)AS Fioe, letter.Date_outgoing, letter.Description, letter.AnswerCh 
                                            FROM letter, solving_problem, employee WHERE letter.id_solving_problem = solving_problem.id_solving_problem AND letter.id_employee = employee.id_employee AND letter.Date_outgoing > NOW() - INTERVAL 7 DAY AND letter.id_employee = '{nomeruser}'";
                    DtOtbor.Clear();
                    Mydata.Fill(DtOtbor);
                }
                else if (nomeruser == "")
                {
                    Mycommand.CommandText = $@"SELECT letter.id_letter, letter.id_solving_problem, CONCAT(employee.Surname_employee,' ',employee.Name_employee,' ',employee.Patronymic_employee)AS Fioe, letter.Date_outgoing, letter.Description, letter.AnswerCh 
                                            FROM letter, solving_problem, employee WHERE letter.id_solving_problem = solving_problem.id_solving_problem AND letter.id_employee = employee.id_employee AND letter.Date_outgoing > NOW() - INTERVAL 7 DAY";
                    DtOtbor.Clear();
                    Mydata.Fill(DtOtbor);
                }
            }
            else if (last == "last30")
            {
                if (nomeruser != "")
                {
                    Mycommand.CommandText = $@"SELECT letter.id_letter, letter.id_solving_problem, CONCAT(employee.Surname_employee,' ',employee.Name_employee,' ',employee.Patronymic_employee)AS Fioe, letter.Date_outgoing, letter.Description, letter.AnswerCh 
                                            FROM letter, solving_problem, employee WHERE letter.id_solving_problem = solving_problem.id_solving_problem AND letter.id_employee = employee.id_employee AND letter.Date_outgoing > NOW() - INTERVAL 30 DAY AND letter.id_employee = '{nomeruser}'";
                    DtOtbor.Clear();
                    Mydata.Fill(DtOtbor);
                }
                else if (nomeruser == "")
                {
                    Mycommand.CommandText = $@"SELECT letter.id_letter, letter.id_solving_problem, CONCAT(employee.Surname_employee,' ',employee.Name_employee,' ',employee.Patronymic_employee)AS Fioe, letter.Date_outgoing, letter.Description, letter.AnswerCh 
                                            FROM letter, solving_problem, employee WHERE letter.id_solving_problem = solving_problem.id_solving_problem AND letter.id_employee = employee.id_employee AND letter.Date_outgoing > NOW() - INTERVAL 30 DAY";
                    DtOtbor.Clear();
                    Mydata.Fill(DtOtbor);
                }
            }
        }
        static public void SelectSolvingProblem(string nomeruser)
        {
            if (nomeruser != "")
                Mycommand.CommandText = $"SELECT solving_problem.id_solving_problem, solving_problem.id_problem_appeals, solving_problem.Description, solving_problem.Data_solving_problem, sp_statuses.statuses, solving_problem.LettersCh FROM solving_problem, employee, sp_statuses, problem_appeals, appeals WHERE solving_problem.id_problem_appeals = problem_appeals.id_problem_appeals AND problem_appeals.id_appeals = appeals.id_appeals AND solving_problem.id_statuses = sp_statuses.id_statuses AND appeals.id_employee = employee.id_employee AND appeals.id_employee = '{nomeruser}'";
            else if (nomeruser == "")
                Mycommand.CommandText = $"SELECT solving_problem.id_solving_problem, solving_problem.id_problem_appeals, solving_problem.Description, solving_problem.Data_solving_problem, sp_statuses.statuses, solving_problem.LettersCh FROM solving_problem, employee, sp_statuses, problem_appeals, appeals WHERE solving_problem.id_problem_appeals = problem_appeals.id_problem_appeals AND problem_appeals.id_appeals = appeals.id_appeals AND solving_problem.id_statuses = sp_statuses.id_statuses AND appeals.id_employee = employee.id_employee";

            DtSelectSolvingProblem.Clear();
            Mydata.Fill(DtSelectSolvingProblem);
        }




        static public bool AddLetters(params string [] par)
        {
            Mycommand.CommandText = $"INSERT INTO letter VALUES(null, '{par[0]}','{par[1]}','{par[2]}','{par[3]}','{0}')";
            if (Mycommand.ExecuteNonQuery() > 0)
                return true;
            else
                return false;
        }
        static public bool RedLetters(params string[] par)
        {
            DateTime dt = Convert.ToDateTime(par[2]);
            Mycommand.CommandText = $"UPDATE letter SET id_solving_problem = '{par[0]}', id_employee = '{par[1]}', Date_outgoing = '{dt.ToString("yyyy.MM.dd")}', Description = '{par[3]}' WHERE id_letter = '{par[4]}'";
            if (Mycommand.ExecuteNonQuery() > 0)
                return true;
            else
                return false;
        }
    }
}
