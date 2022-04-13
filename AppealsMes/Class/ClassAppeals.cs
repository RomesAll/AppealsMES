using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appeals_Mes.Class
{
    class ClassAppeals : ClassConnection
    {
        static public DataTable DtAppeals = new DataTable();
        static public DataTable DtProblemAppeals = new DataTable();
        static public DataTable Dtklient = new DataTable();
        static public DataTable Dtemployee = new DataTable();
        static public DataTable DtMethodAppeals = new DataTable();
        static public DataTable DtStatus = new DataTable();
        static public DataTable DtOtbor = new DataTable();
        static public DataTable DtSelectAppealsTest = new DataTable();
        static public DataTable DtSelectAppealsTest2 = new DataTable();
        static public void OtborStatus(string status, string nomeruser)
        {
            if (nomeruser == "")
            {
                Mycommand.CommandText = $@"SELECT appeals.id_appeals, CONCAT(employee.Surname_employee,' ',employee.Name_employee,' ',employee.Patronymic_employee)AS Fioe, CONCAT(customers.Surname_customers,' ',customers.Name_customers,' ',customers.Patronymic_customers) AS Fioc, sp_method_treatment.method_treatmentcol, sp_statuses.statuses, appeals.Date_appeals, appeals.Note, appeals.Problem_appealsCh FROM appeals, employee, customers, sp_method_treatment, sp_statuses
                                       WHERE appeals.id_employee = employee.id_employee AND appeals.id_customers = customers.id_customers AND appeals.id_method_treatment = sp_method_treatment.id_method_treatment AND appeals.id_statuses = sp_statuses.id_statuses AND appeals.id_statuses ='{status}'";
                DtOtbor.Clear();
                Mydata.Fill(DtOtbor);
            }
            else if (nomeruser != "")
            {
                Mycommand.CommandText = $@"SELECT appeals.id_appeals, CONCAT(employee.Surname_employee,' ',employee.Name_employee,' ',employee.Patronymic_employee)AS Fioe, CONCAT(customers.Surname_customers,' ',customers.Name_customers,' ',customers.Patronymic_customers) AS Fioc, sp_method_treatment.method_treatmentcol, sp_statuses.statuses, appeals.Date_appeals, appeals.Note, appeals.Problem_appealsCh FROM appeals, employee, customers, sp_method_treatment, sp_statuses
                                       WHERE appeals.id_employee = employee.id_employee AND appeals.id_customers = customers.id_customers AND appeals.id_method_treatment = sp_method_treatment.id_method_treatment AND appeals.id_statuses = sp_statuses.id_statuses AND appeals.id_statuses ='{status}' AND appeals.id_employee = '{nomeruser}'";
                DtOtbor.Clear();
                Mydata.Fill(DtOtbor);
            }
        }
        static public void OtborMethot(string method, string nomeruser)
        {
            if (nomeruser == "")
            {
                Mycommand.CommandText = $@"SELECT appeals.id_appeals, CONCAT(employee.Surname_employee,' ',employee.Name_employee,' ',employee.Patronymic_employee)AS Fioe, CONCAT(customers.Surname_customers,' ',customers.Name_customers,' ',customers.Patronymic_customers) AS Fioc, sp_method_treatment.method_treatmentcol, sp_statuses.statuses, appeals.Date_appeals, appeals.Note, appeals.Problem_appealsCh FROM appeals, employee, customers, sp_method_treatment, sp_statuses WHERE appeals.id_employee = employee.id_employee AND appeals.id_customers = customers.id_customers AND appeals.id_method_treatment = sp_method_treatment.id_method_treatment AND appeals.id_statuses = sp_statuses.id_statuses AND appeals.id_method_treatment ='{method}'";
                DtOtbor.Clear();
                Mydata.Fill(DtOtbor);
            }
            else if (nomeruser != "")
            {
                Mycommand.CommandText = $@"SELECT appeals.id_appeals, CONCAT(employee.Surname_employee,' ',employee.Name_employee,' ',employee.Patronymic_employee)AS Fioe, CONCAT(customers.Surname_customers,' ',customers.Name_customers,' ',customers.Patronymic_customers) AS Fioc, sp_method_treatment.method_treatmentcol, sp_statuses.statuses, appeals.Date_appeals, appeals.Note, appeals.Problem_appealsCh FROM appeals, employee, customers, sp_method_treatment, sp_statuses
                                       WHERE appeals.id_employee = employee.id_employee AND appeals.id_customers = customers.id_customers AND appeals.id_method_treatment = sp_method_treatment.id_method_treatment AND appeals.id_statuses = sp_statuses.id_statuses AND appeals.id_method_treatment ='{method}' AND appeals.id_employee = '{nomeruser}'";
                DtOtbor.Clear();
                Mydata.Fill(DtOtbor);
            }
        }
        static public void OtborDate(string dateS, string datePo, string last, string nomeruser)
        {
            DateTime dt = DateTime.Now;
            if (dateS != "" & datePo != "")
            {
                if (nomeruser != "")
                {
                    Mycommand.CommandText = $@"SELECT appeals.id_appeals, CONCAT(employee.Surname_employee,' ',employee.Name_employee,' ',employee.Patronymic_employee)AS Fioe, CONCAT(customers.Surname_customers,' ',customers.Name_customers,' ',customers.Patronymic_customers) AS Fioc, sp_method_treatment.method_treatmentcol, sp_statuses.statuses, appeals.Date_appeals, appeals.Note, appeals.Problem_appealsCh FROM appeals, employee, customers, sp_method_treatment, sp_statuses
                                       WHERE appeals.id_employee = employee.id_employee AND appeals.id_customers = customers.id_customers AND appeals.id_method_treatment = sp_method_treatment.id_method_treatment AND appeals.id_statuses = sp_statuses.id_statuses AND Date_appeals BETWEEN '{dateS}'AND '{datePo}' AND appeals.id_employee = '{nomeruser}'";
                    DtOtbor.Clear();
                    Mydata.Fill(DtOtbor);
                }
                else if (nomeruser == "")
                {
                    Mycommand.CommandText = $@"SELECT appeals.id_appeals, CONCAT(employee.Surname_employee,' ',employee.Name_employee,' ',employee.Patronymic_employee)AS Fioe, CONCAT(customers.Surname_customers,' ',customers.Name_customers,' ',customers.Patronymic_customers) AS Fioc, sp_method_treatment.method_treatmentcol, sp_statuses.statuses, appeals.Date_appeals, appeals.Note, appeals.Problem_appealsCh FROM appeals, employee, customers, sp_method_treatment, sp_statuses
                                       WHERE appeals.id_employee = employee.id_employee AND appeals.id_customers = customers.id_customers AND appeals.id_method_treatment = sp_method_treatment.id_method_treatment AND appeals.id_statuses = sp_statuses.id_statuses AND Date_appeals BETWEEN '{dateS}'AND '{datePo}'";
                    DtOtbor.Clear();
                    Mydata.Fill(DtOtbor);
                }
            }
            else if (last == dt.ToString("yyyy.MM.dd"))
            {
                if (nomeruser != "")
                {
                    Mycommand.CommandText = $@"SELECT appeals.id_appeals, CONCAT(employee.Surname_employee,' ',employee.Name_employee,' ',employee.Patronymic_employee)AS Fioe, CONCAT(customers.Surname_customers,' ',customers.Name_customers,' ',customers.Patronymic_customers) AS Fioc, sp_method_treatment.method_treatmentcol, sp_statuses.statuses, appeals.Date_appeals, appeals.Note, appeals.Problem_appealsCh FROM appeals, employee, customers, sp_method_treatment, sp_statuses
                                       WHERE appeals.id_employee = employee.id_employee AND appeals.id_customers = customers.id_customers AND appeals.id_method_treatment = sp_method_treatment.id_method_treatment AND appeals.id_statuses = sp_statuses.id_statuses AND Date_appeals = '{last}' AND appeals.id_employee = '{nomeruser}'";
                    DtOtbor.Clear();
                    Mydata.Fill(DtOtbor);
                }
                else if (nomeruser == "")
                {
                    Mycommand.CommandText = $@"SELECT appeals.id_appeals, CONCAT(employee.Surname_employee,' ',employee.Name_employee,' ',employee.Patronymic_employee)AS Fioe, CONCAT(customers.Surname_customers,' ',customers.Name_customers,' ',customers.Patronymic_customers) AS Fioc, sp_method_treatment.method_treatmentcol, sp_statuses.statuses, appeals.Date_appeals, appeals.Note, appeals.Problem_appealsCh FROM appeals, employee, customers, sp_method_treatment, sp_statuses
                                       WHERE appeals.id_employee = employee.id_employee AND appeals.id_customers = customers.id_customers AND appeals.id_method_treatment = sp_method_treatment.id_method_treatment AND appeals.id_statuses = sp_statuses.id_statuses AND Date_appeals = '{last}'";
                    DtOtbor.Clear();
                    Mydata.Fill(DtOtbor);
                }
            }
            else if (last == "last7")
            {
                if (nomeruser != "")
                {
                    Mycommand.CommandText = $@"SELECT appeals.id_appeals, CONCAT(employee.Surname_employee,' ',employee.Name_employee,' ',employee.Patronymic_employee)AS Fioe, CONCAT(customers.Surname_customers,' ',customers.Name_customers,' ',customers.Patronymic_customers) AS Fioc, sp_method_treatment.method_treatmentcol, sp_statuses.statuses, appeals.Date_appeals, appeals.Note, appeals.Problem_appealsCh FROM appeals, employee, customers, sp_method_treatment, sp_statuses
                                       WHERE appeals.id_employee = employee.id_employee AND appeals.id_customers = customers.id_customers AND appeals.id_method_treatment = sp_method_treatment.id_method_treatment AND appeals.id_statuses = sp_statuses.id_statuses AND Date_appeals > NOW() - INTERVAL 7 DAY AND appeals.id_employee = '{nomeruser}'";
                    DtOtbor.Clear();
                    Mydata.Fill(DtOtbor);
                }
                else if (nomeruser == "")
                {
                    Mycommand.CommandText = $@"SELECT appeals.id_appeals, CONCAT(employee.Surname_employee,' ',employee.Name_employee,' ',employee.Patronymic_employee)AS Fioe, CONCAT(customers.Surname_customers,' ',customers.Name_customers,' ',customers.Patronymic_customers) AS Fioc, sp_method_treatment.method_treatmentcol, sp_statuses.statuses, appeals.Date_appeals, appeals.Note, appeals.Problem_appealsCh FROM appeals, employee, customers, sp_method_treatment, sp_statuses
                                       WHERE appeals.id_employee = employee.id_employee AND appeals.id_customers = customers.id_customers AND appeals.id_method_treatment = sp_method_treatment.id_method_treatment AND appeals.id_statuses = sp_statuses.id_statuses AND Date_appeals > NOW() - INTERVAL 7 DAY";
                    DtOtbor.Clear();
                    Mydata.Fill(DtOtbor);
                }
            }
            else if (last == "last30")
            {
                if (nomeruser != "")
                {
                    Mycommand.CommandText = $@"SELECT appeals.id_appeals, CONCAT(employee.Surname_employee,' ',employee.Name_employee,' ',employee.Patronymic_employee)AS Fioe, CONCAT(customers.Surname_customers,' ',customers.Name_customers,' ',customers.Patronymic_customers) AS Fioc, sp_method_treatment.method_treatmentcol, sp_statuses.statuses, appeals.Date_appeals, appeals.Note, appeals.Problem_appealsCh FROM appeals, employee, customers, sp_method_treatment, sp_statuses
                                       WHERE appeals.id_employee = employee.id_employee AND appeals.id_customers = customers.id_customers AND appeals.id_method_treatment = sp_method_treatment.id_method_treatment AND appeals.id_statuses = sp_statuses.id_statuses AND Date_appeals > NOW() - INTERVAL 30 DAY AND appeals.id_employee = '{nomeruser}'";
                    DtOtbor.Clear();
                    Mydata.Fill(DtOtbor);
                }
                else if (nomeruser == "")
                {
                    Mycommand.CommandText = $@"SELECT appeals.id_appeals, CONCAT(employee.Surname_employee,' ',employee.Name_employee,' ',employee.Patronymic_employee)AS Fioe, CONCAT(customers.Surname_customers,' ',customers.Name_customers,' ',customers.Patronymic_customers) AS Fioc, sp_method_treatment.method_treatmentcol, sp_statuses.statuses, appeals.Date_appeals, appeals.Note, appeals.Problem_appealsCh FROM appeals, employee, customers, sp_method_treatment, sp_statuses
                                       WHERE appeals.id_employee = employee.id_employee AND appeals.id_customers = customers.id_customers AND appeals.id_method_treatment = sp_method_treatment.id_method_treatment AND appeals.id_statuses = sp_statuses.id_statuses AND Date_appeals > NOW() - INTERVAL 30 DAY";
                    DtOtbor.Clear();
                    Mydata.Fill(DtOtbor);
                }
            }
        }
        static public void SelectAppeals()
        {
            Mycommand.CommandText = $@"SELECT appeals.id_appeals, CONCAT(employee.Surname_employee,' ',employee.Name_employee,' ',employee.Patronymic_employee)AS Fioe, CONCAT(customers.Surname_customers,' ',customers.Name_customers,' ',customers.Patronymic_customers) AS Fioc, sp_method_treatment.method_treatmentcol, sp_statuses.statuses, appeals.Date_appeals, appeals.Note, appeals.Problem_appealsCh
                                       FROM appeals, employee, customers, sp_method_treatment, sp_statuses
                                       WHERE appeals.id_employee = employee.id_employee AND appeals.id_customers = customers.id_customers AND appeals.id_method_treatment = sp_method_treatment.id_method_treatment AND appeals.id_statuses = sp_statuses.id_statuses";
            DtAppeals.Clear();
            Mydata.Fill(DtAppeals);
        }
        static public void SelectAppealsTest(string dates, string datepo)
        {
            DateTime dt1 = Convert.ToDateTime(dates);
            DateTime dt2 = Convert.ToDateTime(datepo);
            Mycommand.CommandText = $@"SELECT appeals.id_appeals, CONCAT(employee.Surname_employee,' ',employee.Name_employee)AS Fioe, CONCAT(customers.Surname_customers,' ',customers.Name_customers) AS Fioc, sp_method_treatment.method_treatmentcol, sp_statuses.statuses, appeals.Date_appeals, appeals.Problem_appealsCh
                                       FROM appeals, employee, customers, sp_method_treatment, sp_statuses
                                       WHERE appeals.Date_appeals BETWEEN '{dt1.ToString("yyyy.MM.dd")}'AND '{dt2.ToString("yyyy.MM.dd")}' AND appeals.id_employee = employee.id_employee AND appeals.id_customers = customers.id_customers AND appeals.id_method_treatment = sp_method_treatment.id_method_treatment AND appeals.id_statuses = sp_statuses.id_statuses";
            DtSelectAppealsTest.Clear();
            Mydata.Fill(DtSelectAppealsTest);
        }
        //static public void SelectAppealsTest2()
        //{
        //    Mycommand.CommandText = $@"SELECT problem_appeals.id_problem_appeals, problem_appeals.Date_delayed_response, sp_type_appeal.type_appeal,
        //                                CONCAT(sp_district.district,' Улица ',street.Street,' Дом ',address_premises.Home,' Корпус ',address_premises.Korpys,' Квартира ', address_premises.Kvartira) AS Adres,
        //                                problem_appeals.SolvingCh, solving_problem.LettersCh
        //                                FROM appeals, employee, customers, sp_method_treatment, sp_statuses, problem_appeals, sp_type_appeal, sp_district, address_premises, street, solving_problem
        //                                WHERE appeals.id_employee = employee.id_employee
        //                                AND appeals.id_customers = customers.id_customers
        //                                AND appeals.id_method_treatment = sp_method_treatment.id_method_treatment
        //                                AND appeals.id_statuses = sp_statuses.id_statuses
        //                                AND appeals.id_appeals = problem_appeals.id_appeals
        //                                AND problem_appeals.id_type_appeal = sp_type_appeal.id_type_appeal
        //                                AND problem_appeals.id_address_premises = address_premises.id_address_premises
        //                                AND address_premises.id_street = street.id_street
        //                                AND street.id_district = sp_district.id_district
        //                                AND problem_appeals.id_problem_appeals = solving_problem.id_problem_appeals";
        //    DtSelectAppealsTest2.Clear();
        //    Mydata.Fill(DtSelectAppealsTest2);
        //}
        static public void SelectKlient()
        {
            Mycommand.CommandText = $"SELECT id_customers, CONCAT(Surname_customers,' ',Name_customers,' ', Patronymic_customers) AS Fioc FROM customers";
            Dtklient.Clear();
            Mydata.Fill(Dtklient);
        }
        static public void SelectEmployee()
        {
            Mycommand.CommandText = $"SELECT id_employee, CONCAT(Surname_employee,' ',Name_employee,' ', Patronymic_employee) AS Fioe FROM employee";
            Dtemployee.Clear();
            Mydata.Fill(Dtemployee);
        }
        static public void SelectMethodAppeals()
        {
            Mycommand.CommandText = $"SELECT id_method_treatment, method_treatmentcol FROM sp_method_treatment";
            DtMethodAppeals.Clear();
            Mydata.Fill(DtMethodAppeals);
        }
        static public void SelectStatus()
        {
            Mycommand.CommandText = $"SELECT id_statuses, statuses FROM sp_statuses";
            DtStatus.Clear();
            Mydata.Fill(DtStatus);
        }

        static public bool AppealsAdd(params string[] par)
        {
            Mycommand.CommandText = $"INSERT INTO appeals VALUES(null,'{par[0]}','{par[1]}','{par[2]}','{par[3]}','{par[4]}','{par[5]}','{0}')";
            if (Mycommand.ExecuteNonQuery() > 0)
                return true;
            else
                return false;
        }
        static public bool AppealsRed(params string[] par)
        {
            Mycommand.CommandText = $"UPDATE appeals SET id_employee = '{par[0]}', id_customers = '{par[1]}', id_method_treatment = '{par[2]}',id_statuses = {par[3]}, Date_appeals = '{par[4]}', Note = '{par[5]}' WHERE id_appeals = '{par[6]}'";
            if (Mycommand.ExecuteNonQuery() > 0)
                return true;
            else
                return false;
        }
        static public bool AppealsDel(string nomer)
        {
            try
            {
                Mycommand.CommandText = $"DELETE FROM appeals WHERE id_appeals = '{nomer}'";
                if (Mycommand.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Запись используеться в других таблицах","Ошибка",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
