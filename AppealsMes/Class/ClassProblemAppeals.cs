using Appeals_Mes;
using Appeals_Mes.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppealsMes.Class
{
    class ClassProblemAppeals: ClassConnection
    {
        static public DataTable DtAppeals = new DataTable();
        static public DataTable DtProblemAppeals = new DataTable();
        static public DataTable DtTypeAppeals = new DataTable();
        static public DataTable DtAdressDistrict = new DataTable();
        static public DataTable DtStreet = new DataTable();
        static public DataTable DtSovlingProblem = new DataTable();
        static public DataTable DtOtbor = new DataTable();
        static public DataTable DtDocx = new DataTable();
        static public DataTable DtSelectAppealsRed = new DataTable();
        static public DataTable DtSelectAppealsAllRed = new DataTable();
        static public DataTable DtSelectProblemUserAdd = new DataTable();
        static public DataTable DtSelectProblemAllAdd = new DataTable();
        static public object NomerStreet;
        static public object Adres;
        static public object NomerAdres;
        static public object NomerAppeal;
        static public string st = "appeals.id_employee";

        static public string SelectAdes(string nomer)
        {
            object itog;
            Mycommand.CommandText = $"SELECT id_address_premises FROM problem_appeals WHERE id_problem_appeals = '{nomer}'";
            itog = Mycommand.ExecuteScalar();
            if (nomer != null)
                return itog.ToString();
            else
                return "";
        }
        static public bool DeleteProblem(string nomer)
        {
            try
            {
                Mycommand.CommandText = $"DELETE FROM problem_appeals WHERE id_problem_appeals = '{nomer}'";
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

        static public void OtborProblemStatus(string status,string nomeruser)
        {
            if (nomeruser == "")
            {
                Mycommand.CommandText = $@"SELECT problem_appeals.id_problem_appeals, problem_appeals.Date_delayed_response, sp_statuses.statuses, sp_priorities.priorities,
                                        sp_type_appeal.type_appeal, CONCAT(sp_district.district,' Улица ',street.Street,' Дом ',address_premises.Home,' Корпус ',address_premises.Korpys,' Квартира ',address_premises.Kvartira) AS Adres, problem_appeals.Description, problem_appeals.Note, problem_appeals.SolvingCh FROM problem_appeals, sp_priorities, sp_statuses, sp_type_appeal, address_premises, street, sp_district, appeals
                                        WHERE problem_appeals.id_appeals = appeals.id_appeals AND problem_appeals.id_statuses = sp_statuses.id_statuses AND
                                        problem_appeals.id_priorities = sp_priorities.id_priorities AND problem_appeals.id_type_appeal = sp_type_appeal.id_type_appeal AND
                                        problem_appeals.id_address_premises = address_premises.id_address_premises AND
                                        address_premises.id_street = street.id_street AND street.id_district = sp_district.id_district AND sp_statuses.statuses = '{status}'";
                DtOtbor.Clear();
                Mydata.Fill(DtOtbor);
            }
            else if (nomeruser != "")
            {
                Mycommand.CommandText = $@"SELECT problem_appeals.id_problem_appeals, problem_appeals.Date_delayed_response, sp_statuses.statuses, sp_priorities.priorities,
                                        sp_type_appeal.type_appeal, CONCAT(sp_district.district,' Улица ',street.Street,' Дом ',address_premises.Home,' Корпус ',address_premises.Korpys,' Квартира ',address_premises.Kvartira) AS Adres, problem_appeals.Description, problem_appeals.Note, problem_appeals.SolvingCh FROM problem_appeals, sp_priorities, sp_statuses, sp_type_appeal, address_premises, street, sp_district, appeals
                                        WHERE problem_appeals.id_appeals = appeals.id_appeals AND problem_appeals.id_statuses = sp_statuses.id_statuses AND
                                        problem_appeals.id_priorities = sp_priorities.id_priorities AND problem_appeals.id_type_appeal = sp_type_appeal.id_type_appeal AND
                                        problem_appeals.id_address_premises = address_premises.id_address_premises AND
                                        address_premises.id_street = street.id_street AND street.id_district = sp_district.id_district AND sp_statuses.id_statuses = '{status}' AND appeals.id_employee = '{nomeruser}'";
                DtOtbor.Clear();
                Mydata.Fill(DtOtbor);
            }
        }
        static public void OtborProblemPrioritet(string status, string nomeruser)
        {
            if (nomeruser == "")
            {
                Mycommand.CommandText = $@"SELECT problem_appeals.id_problem_appeals, problem_appeals.Date_delayed_response, sp_statuses.statuses, sp_priorities.priorities,
                                        sp_type_appeal.type_appeal, CONCAT(sp_district.district,' Улица ',street.Street,' Дом ',address_premises.Home,' Корпус ',address_premises.Korpys,' Квартира ',address_premises.Kvartira) AS Adres, problem_appeals.Description, problem_appeals.Note, problem_appeals.SolvingCh FROM problem_appeals, sp_priorities, sp_statuses, sp_type_appeal, address_premises, street, sp_district, appeals
                                        WHERE problem_appeals.id_appeals = appeals.id_appeals AND problem_appeals.id_statuses = sp_statuses.id_statuses AND
                                        problem_appeals.id_priorities = sp_priorities.id_priorities AND problem_appeals.id_type_appeal = sp_type_appeal.id_type_appeal AND
                                        problem_appeals.id_address_premises = address_premises.id_address_premises AND
                                        address_premises.id_street = street.id_street AND street.id_district = sp_district.id_district AND sp_statuses.statuses = '{status}'";
                DtOtbor.Clear();
                Mydata.Fill(DtOtbor);
            }
            else if (nomeruser != "")
            {
                Mycommand.CommandText = $@"SELECT problem_appeals.id_problem_appeals, problem_appeals.Date_delayed_response, sp_statuses.statuses, sp_priorities.priorities,
                                        sp_type_appeal.type_appeal, CONCAT(sp_district.district,' Улица ',street.Street,' Дом ',address_premises.Home,' Корпус ',address_premises.Korpys,' Квартира ',address_premises.Kvartira) AS Adres, problem_appeals.Description, problem_appeals.Note, problem_appeals.SolvingCh FROM problem_appeals, sp_priorities, sp_statuses, sp_type_appeal, address_premises, street, sp_district, appeals
                                        WHERE problem_appeals.id_appeals = appeals.id_appeals AND problem_appeals.id_statuses = sp_statuses.id_statuses AND
                                        problem_appeals.id_priorities = sp_priorities.id_priorities AND problem_appeals.id_type_appeal = sp_type_appeal.id_type_appeal AND
                                        problem_appeals.id_address_premises = address_premises.id_address_premises AND
                                        address_premises.id_street = street.id_street AND street.id_district = sp_district.id_district AND problem_appeals.id_priorities = '{status}' AND appeals.id_employee = '{nomeruser}'";
                DtOtbor.Clear();
                Mydata.Fill(DtOtbor);
            }
        }
        static public void OtborProblemTypeAppeals(string status, string nomeruser)
        {
            if (nomeruser == "")
            {
                Mycommand.CommandText = $@"SELECT problem_appeals.id_problem_appeals, problem_appeals.Date_delayed_response, sp_statuses.statuses, sp_priorities.priorities,
                                        sp_type_appeal.type_appeal, CONCAT(sp_district.district,' Улица ',street.Street,' Дом ',address_premises.Home,' Корпус ',address_premises.Korpys,' Квартира ',address_premises.Kvartira) AS Adres, problem_appeals.Description, problem_appeals.Note, problem_appeals.SolvingCh FROM problem_appeals, sp_priorities, sp_statuses, sp_type_appeal, address_premises, street, sp_district, appeals
                                        WHERE problem_appeals.id_appeals = appeals.id_appeals AND problem_appeals.id_statuses = sp_statuses.id_statuses AND
                                        problem_appeals.id_priorities = sp_priorities.id_priorities AND problem_appeals.id_type_appeal = sp_type_appeal.id_type_appeal AND
                                        problem_appeals.id_address_premises = address_premises.id_address_premises AND
                                        address_premises.id_street = street.id_street AND street.id_district = sp_district.id_district AND sp_statuses.statuses = '{status}'";
                DtOtbor.Clear();
                Mydata.Fill(DtOtbor);
            }
            else if (nomeruser != "")
            {
                Mycommand.CommandText = $@"SELECT problem_appeals.id_problem_appeals, problem_appeals.Date_delayed_response, sp_statuses.statuses, sp_priorities.priorities,
                                        sp_type_appeal.type_appeal, CONCAT(sp_district.district,' Улица ',street.Street,' Дом ',address_premises.Home,' Корпус ',address_premises.Korpys,' Квартира ',address_premises.Kvartira) AS Adres, problem_appeals.Description, problem_appeals.Note, problem_appeals.SolvingCh FROM problem_appeals, sp_priorities, sp_statuses, sp_type_appeal, address_premises, street, sp_district, appeals
                                        WHERE problem_appeals.id_appeals = appeals.id_appeals AND problem_appeals.id_statuses = sp_statuses.id_statuses AND
                                        problem_appeals.id_priorities = sp_priorities.id_priorities AND problem_appeals.id_type_appeal = sp_type_appeal.id_type_appeal AND
                                        problem_appeals.id_address_premises = address_premises.id_address_premises AND
                                        address_premises.id_street = street.id_street AND street.id_district = sp_district.id_district AND problem_appeals.id_type_appeal = '{status}' AND appeals.id_employee = '{nomeruser}'";
                DtOtbor.Clear();
                Mydata.Fill(DtOtbor);
            }
        }

        static public void OtborProblemDates(string dates, string datepo,string last,string nomeruser)
        {
            DateTime dt = DateTime.Now;
            if (dates != "" & datepo != "")
            {
                if (nomeruser != "")
                {
                    Mycommand.CommandText = $@"SELECT problem_appeals.id_problem_appeals, problem_appeals.Date_delayed_response, sp_statuses.statuses, sp_priorities.priorities,
                                        sp_type_appeal.type_appeal, CONCAT(sp_district.district,' Улица ',street.Street,' Дом ',address_premises.Home,' Корпус ',address_premises.Korpys,' Квартира ',address_premises.Kvartira) AS Adres, problem_appeals.Description, problem_appeals.Note, problem_appeals.SolvingCh FROM problem_appeals, sp_priorities, sp_statuses, sp_type_appeal, address_premises, street, sp_district, appeals
                                        WHERE problem_appeals.id_appeals = appeals.id_appeals AND problem_appeals.id_statuses = sp_statuses.id_statuses AND
                                        problem_appeals.id_priorities = sp_priorities.id_priorities AND problem_appeals.id_type_appeal = sp_type_appeal.id_type_appeal AND
                                        problem_appeals.id_address_premises = address_premises.id_address_premises AND
                                        address_premises.id_street = street.id_street AND street.id_district = sp_district.id_district AND problem_appeals.Date_delayed_response BETWEEN '{dates}'AND '{datepo}' AND appeals.id_employee = '{nomeruser}'";
                    DtOtbor.Clear();
                    Mydata.Fill(DtOtbor);
                }
                else if (nomeruser == "")
                {
                    Mycommand.CommandText = $@"SELECT problem_appeals.id_problem_appeals, problem_appeals.Date_delayed_response, sp_statuses.statuses, sp_priorities.priorities,
                                        sp_type_appeal.type_appeal, CONCAT(sp_district.district,' Улица ',street.Street,' Дом ',address_premises.Home,' Корпус ',address_premises.Korpys,' Квартира ',address_premises.Kvartira) AS Adres, problem_appeals.Description, problem_appeals.Note, problem_appeals.SolvingCh FROM problem_appeals, sp_priorities, sp_statuses, sp_type_appeal, address_premises, street, sp_district, appeals
                                        WHERE problem_appeals.id_appeals = appeals.id_appeals AND problem_appeals.id_statuses = sp_statuses.id_statuses AND
                                        problem_appeals.id_priorities = sp_priorities.id_priorities AND problem_appeals.id_type_appeal = sp_type_appeal.id_type_appeal AND
                                        problem_appeals.id_address_premises = address_premises.id_address_premises AND
                                        address_premises.id_street = street.id_street AND street.id_district = sp_district.id_district AND problem_appeals.Date_delayed_response BETWEEN '{dates}'AND '{datepo}'";
                    DtOtbor.Clear();
                    Mydata.Fill(DtOtbor);
                }
            }
            else if (last == dt.ToString("yyyy.MM.dd"))
            {
                if (nomeruser != "")
                {
                    Mycommand.CommandText = Mycommand.CommandText = $@"SELECT problem_appeals.id_problem_appeals, problem_appeals.Date_delayed_response, sp_statuses.statuses, sp_priorities.priorities,
                                        sp_type_appeal.type_appeal, CONCAT(sp_district.district,' Улица ',street.Street,' Дом ',address_premises.Home,' Корпус ',address_premises.Korpys,' Квартира ',address_premises.Kvartira) AS Adres, problem_appeals.Description, problem_appeals.Note, problem_appeals.SolvingCh FROM problem_appeals, sp_priorities, sp_statuses, sp_type_appeal, address_premises, street, sp_district, appeals
                                        WHERE problem_appeals.id_appeals = appeals.id_appeals AND problem_appeals.id_statuses = sp_statuses.id_statuses AND
                                        problem_appeals.id_priorities = sp_priorities.id_priorities AND problem_appeals.id_type_appeal = sp_type_appeal.id_type_appeal AND
                                        problem_appeals.id_address_premises = address_premises.id_address_premises AND
                                        address_premises.id_street = street.id_street AND street.id_district = sp_district.id_district AND problem_appeals.Date_delayed_response = '{last}' AND appeals.id_employee = '{nomeruser}'";
                    DtOtbor.Clear();
                    Mydata.Fill(DtOtbor);
                }
                else if (nomeruser == "")
                {
                    Mycommand.CommandText = Mycommand.CommandText = $@"SELECT problem_appeals.id_problem_appeals, problem_appeals.Date_delayed_response, sp_statuses.statuses, sp_priorities.priorities,
                                        sp_type_appeal.type_appeal, CONCAT(sp_district.district,' Улица ',street.Street,' Дом ',address_premises.Home,' Корпус ',address_premises.Korpys,' Квартира ',address_premises.Kvartira) AS Adres, problem_appeals.Description, problem_appeals.Note, problem_appeals.SolvingCh FROM problem_appeals, sp_priorities, sp_statuses, sp_type_appeal, address_premises, street, sp_district, appeals
                                        WHERE problem_appeals.id_appeals = appeals.id_appeals AND problem_appeals.id_statuses = sp_statuses.id_statuses AND
                                        problem_appeals.id_priorities = sp_priorities.id_priorities AND problem_appeals.id_type_appeal = sp_type_appeal.id_type_appeal AND
                                        problem_appeals.id_address_premises = address_premises.id_address_premises AND
                                        address_premises.id_street = street.id_street AND street.id_district = sp_district.id_district AND problem_appeals.Date_delayed_response = '{last}'";
                    DtOtbor.Clear();
                    Mydata.Fill(DtOtbor);
                }
            }
            else if (last == "last7")
            {
                if (nomeruser != "")
                {
                    Mycommand.CommandText = Mycommand.CommandText = $@"SELECT problem_appeals.id_problem_appeals, problem_appeals.Date_delayed_response, sp_statuses.statuses, sp_priorities.priorities,
                                        sp_type_appeal.type_appeal, CONCAT(sp_district.district,' Улица ',street.Street,' Дом ',address_premises.Home,' Корпус ',address_premises.Korpys,' Квартира ',address_premises.Kvartira) AS Adres, problem_appeals.Description, problem_appeals.Note, problem_appeals.SolvingCh FROM problem_appeals, sp_priorities, sp_statuses, sp_type_appeal, address_premises, street, sp_district, appeals
                                        WHERE problem_appeals.id_appeals = appeals.id_appeals AND problem_appeals.id_statuses = sp_statuses.id_statuses AND
                                        problem_appeals.id_priorities = sp_priorities.id_priorities AND problem_appeals.id_type_appeal = sp_type_appeal.id_type_appeal AND
                                        problem_appeals.id_address_premises = address_premises.id_address_premises AND
                                        address_premises.id_street = street.id_street AND street.id_district = sp_district.id_district AND problem_appeals.Date_delayed_response > NOW() - INTERVAL 7 DAY AND appeals.id_employee = '{nomeruser}'";
                    DtOtbor.Clear();
                    Mydata.Fill(DtOtbor);
                }
                else if (nomeruser == "")
                {
                    Mycommand.CommandText = Mycommand.CommandText = $@"SELECT problem_appeals.id_problem_appeals, problem_appeals.Date_delayed_response, sp_statuses.statuses, sp_priorities.priorities,
                                        sp_type_appeal.type_appeal, CONCAT(sp_district.district,' Улица ',street.Street,' Дом ',address_premises.Home,' Корпус ',address_premises.Korpys,' Квартира ',address_premises.Kvartira) AS Adres, problem_appeals.Description, problem_appeals.Note, problem_appeals.SolvingCh FROM problem_appeals, sp_priorities, sp_statuses, sp_type_appeal, address_premises, street, sp_district, appeals
                                        WHERE problem_appeals.id_appeals = appeals.id_appeals AND problem_appeals.id_statuses = sp_statuses.id_statuses AND
                                        problem_appeals.id_priorities = sp_priorities.id_priorities AND problem_appeals.id_type_appeal = sp_type_appeal.id_type_appeal AND
                                        problem_appeals.id_address_premises = address_premises.id_address_premises AND
                                        address_premises.id_street = street.id_street AND street.id_district = sp_district.id_district AND problem_appeals.Date_delayed_response > NOW() - INTERVAL 7 DAY";
                    DtOtbor.Clear();
                    Mydata.Fill(DtOtbor);
                }
            }
            else if (last == "last30")
            {
                if (nomeruser != "")
                {
                    Mycommand.CommandText = Mycommand.CommandText = $@"SELECT problem_appeals.id_problem_appeals, problem_appeals.Date_delayed_response, sp_statuses.statuses, sp_priorities.priorities,
                                        sp_type_appeal.type_appeal, CONCAT(sp_district.district,' Улица ',street.Street,' Дом ',address_premises.Home,' Корпус ',address_premises.Korpys,' Квартира ',address_premises.Kvartira) AS Adres, problem_appeals.Description, problem_appeals.Note, problem_appeals.SolvingCh FROM problem_appeals, sp_priorities, sp_statuses, sp_type_appeal, address_premises, street, sp_district, appeals
                                        WHERE problem_appeals.id_appeals = appeals.id_appeals AND problem_appeals.id_statuses = sp_statuses.id_statuses AND
                                        problem_appeals.id_priorities = sp_priorities.id_priorities AND problem_appeals.id_type_appeal = sp_type_appeal.id_type_appeal AND
                                        problem_appeals.id_address_premises = address_premises.id_address_premises AND
                                        address_premises.id_street = street.id_street AND street.id_district = sp_district.id_district AND problem_appeals.Date_delayed_response > NOW() - INTERVAL 30 DAY AND appeals.id_employee = '{nomeruser}'";
                    DtOtbor.Clear();
                    Mydata.Fill(DtOtbor);
                }
                else if (nomeruser == "")
                {
                    Mycommand.CommandText = Mycommand.CommandText = $@"SELECT problem_appeals.id_problem_appeals, problem_appeals.Date_delayed_response, sp_statuses.statuses, sp_priorities.priorities,
                                        sp_type_appeal.type_appeal, CONCAT(sp_district.district,' Улица ',street.Street,' Дом ',address_premises.Home,' Корпус ',address_premises.Korpys,' Квартира ',address_premises.Kvartira) AS Adres, problem_appeals.Description, problem_appeals.Note, problem_appeals.SolvingCh FROM problem_appeals, sp_priorities, sp_statuses, sp_type_appeal, address_premises, street, sp_district, appeals
                                        WHERE problem_appeals.id_appeals = appeals.id_appeals AND problem_appeals.id_statuses = sp_statuses.id_statuses AND
                                        problem_appeals.id_priorities = sp_priorities.id_priorities AND problem_appeals.id_type_appeal = sp_type_appeal.id_type_appeal AND
                                        problem_appeals.id_address_premises = address_premises.id_address_premises AND
                                        address_premises.id_street = street.id_street AND street.id_district = sp_district.id_district AND problem_appeals.Date_delayed_response > NOW() - INTERVAL 30 DAY";
                    DtOtbor.Clear();
                    Mydata.Fill(DtOtbor);
                }
            }
        }



        static public void SelectSolvingProblem(string nomer)
        {
            Mycommand.CommandText = $@"SELECT solving_problem.id_solving_problem, solving_problem.id_problem_appeals, solving_problem.Description, solving_problem.Data_solving_problem, sp_statuses.statuses, solving_problem.LettersCh
                                        FROM sp_statuses, solving_problem 
                                        WHERE solving_problem.id_statuses = sp_statuses.id_statuses AND solving_problem. id_problem_appeals = '{nomer}'";
            DtSovlingProblem.Clear();
            Mydata.Fill(DtSovlingProblem);
        }

        static public void SelectAppeals(string fioemp)
        {
            Mycommand.CommandText = $@"SELECT appeals.id_appeals, CONCAT(employee.Surname_employee,' ',employee.Name_employee,' ',employee.Patronymic_employee)AS Fioe, CONCAT(customers.Surname_customers,' ',customers.Name_customers,' ',customers.Patronymic_customers) AS Fioc, sp_method_treatment.method_treatmentcol, sp_statuses.statuses, appeals.Date_appeals, appeals.Note, appeals.Problem_appealsCh
                                       FROM appeals, employee, customers, sp_method_treatment, sp_statuses
                                       WHERE appeals.id_employee = employee.id_employee AND appeals.id_employee = '{fioemp}' AND appeals.id_customers = customers.id_customers AND appeals.id_method_treatment = sp_method_treatment.id_method_treatment AND appeals.id_statuses = sp_statuses.id_statuses";
            DtAppeals.Clear();
            Mydata.Fill(DtAppeals);
        }

        static public void SelectAppealsRed(string fioemp)
        {
            Mycommand.CommandText = $@"SELECT appeals.id_appeals, CONCAT(employee.Surname_employee,' ',employee.Name_employee,' ',employee.Patronymic_employee)AS Fioe, CONCAT(customers.Surname_customers,' ',customers.Name_customers,' ',customers.Patronymic_customers) AS Fioc, sp_method_treatment.method_treatmentcol, sp_statuses.statuses, appeals.Date_appeals, appeals.Note, appeals.Problem_appealsCh
                                       FROM appeals, employee, customers, sp_method_treatment, sp_statuses
                                       WHERE appeals.id_employee = employee.id_employee AND appeals.id_employee = '{fioemp}' AND appeals.id_customers = customers.id_customers AND appeals.id_method_treatment = sp_method_treatment.id_method_treatment AND appeals.id_statuses = sp_statuses.id_statuses";
            DtSelectAppealsRed.Clear();
            Mydata.Fill(DtSelectAppealsRed);
        }

        static public void SelectAppealsAll()
        {
            Mycommand.CommandText = $@"SELECT appeals.id_appeals, CONCAT(employee.Surname_employee,' ',employee.Name_employee,' ',employee.Patronymic_employee)AS Fioe, CONCAT(customers.Surname_customers,' ',customers.Name_customers,' ',customers.Patronymic_customers) AS Fioc, sp_method_treatment.method_treatmentcol, sp_statuses.statuses, appeals.Date_appeals, appeals.Note, appeals.Problem_appealsCh
                                       FROM appeals, employee, customers, sp_method_treatment, sp_statuses
                                       WHERE appeals.id_employee = employee.id_employee AND appeals.id_customers = customers.id_customers AND appeals.id_method_treatment = sp_method_treatment.id_method_treatment AND appeals.id_statuses = sp_statuses.id_statuses";
            DtAppeals.Clear();
            Mydata.Fill(DtAppeals);
        }

        static public void SelectAppealsAllRed()
        {
            Mycommand.CommandText = $@"SELECT appeals.id_appeals, CONCAT(employee.Surname_employee,' ',employee.Name_employee,' ',employee.Patronymic_employee)AS Fioe, CONCAT(customers.Surname_customers,' ',customers.Name_customers,' ',customers.Patronymic_customers) AS Fioc, sp_method_treatment.method_treatmentcol, sp_statuses.statuses, appeals.Date_appeals, appeals.Note, appeals.Problem_appealsCh
                                       FROM appeals, employee, customers, sp_method_treatment, sp_statuses
                                       WHERE appeals.id_employee = employee.id_employee AND appeals.id_customers = customers.id_customers AND appeals.id_method_treatment = sp_method_treatment.id_method_treatment AND appeals.id_statuses = sp_statuses.id_statuses";
            DtSelectAppealsAllRed.Clear();
            Mydata.Fill(DtSelectAppealsAllRed);
        }


        static public void SelectProblem(string nomer)
        {
            Mycommand.CommandText = $@"SELECT problem_appeals.id_problem_appeals, problem_appeals.Date_delayed_response, sp_statuses.statuses, sp_priorities.priorities,
                                        sp_type_appeal.type_appeal, CONCAT(sp_district.district,' Улица ',street.Street,' Дом ',address_premises.Home,' Корпус ',address_premises.Korpys,' Квартира ',address_premises.Kvartira) AS Adres, problem_appeals.Description, problem_appeals.Note, problem_appeals.SolvingCh FROM problem_appeals, sp_priorities, sp_statuses, sp_type_appeal, address_premises, street, sp_district, appeals
                                        WHERE problem_appeals.id_appeals = appeals.id_appeals AND problem_appeals.id_statuses = sp_statuses.id_statuses AND
                                        problem_appeals.id_priorities = sp_priorities.id_priorities AND problem_appeals.id_type_appeal = sp_type_appeal.id_type_appeal AND
                                        problem_appeals.id_address_premises = address_premises.id_address_premises AND
                                        address_premises.id_street = street.id_street AND street.id_district = sp_district.id_district AND problem_appeals.id_appeals = '{nomer}'";
            DtProblemAppeals.Clear();
            Mydata.Fill(DtProblemAppeals);
        }
        static public void SelectProblemUser(string nomer)
        {
            Mycommand.CommandText = $@"SELECT problem_appeals.id_problem_appeals, problem_appeals.Date_delayed_response, sp_statuses.statuses, sp_priorities.priorities,
                                        sp_type_appeal.type_appeal, CONCAT(sp_district.district,' Улица ',street.Street,' Дом ',address_premises.Home,' Корпус ',address_premises.Korpys,' Квартира ',address_premises.Kvartira) AS Adres, problem_appeals.Description, problem_appeals.Note, problem_appeals.SolvingCh FROM problem_appeals, sp_priorities, sp_statuses, sp_type_appeal, address_premises, street, sp_district, appeals
                                        WHERE problem_appeals.id_appeals = appeals.id_appeals AND problem_appeals.id_statuses = sp_statuses.id_statuses AND
                                        problem_appeals.id_priorities = sp_priorities.id_priorities AND problem_appeals.id_type_appeal = sp_type_appeal.id_type_appeal AND
                                        problem_appeals.id_address_premises = address_premises.id_address_premises AND
                                        address_premises.id_street = street.id_street AND street.id_district = sp_district.id_district AND appeals.id_employee = '{nomer}'";
            DtProblemAppeals.Clear();
            Mydata.Fill(DtProblemAppeals);
        }
        //
        static public void SelectProblemUserAdd(string nomer)
        {
            Mycommand.CommandText = $@"SELECT problem_appeals.id_problem_appeals, problem_appeals.Date_delayed_response, sp_statuses.statuses, sp_priorities.priorities,
                                        sp_type_appeal.type_appeal, CONCAT(sp_district.district,' Улица ',street.Street,' Дом ',address_premises.Home,' Корпус ',address_premises.Korpys,' Квартира ',address_premises.Kvartira) AS Adres, problem_appeals.Description, problem_appeals.Note, problem_appeals.SolvingCh FROM problem_appeals, sp_priorities, sp_statuses, sp_type_appeal, address_premises, street, sp_district, appeals
                                        WHERE problem_appeals.id_appeals = appeals.id_appeals AND problem_appeals.id_statuses = sp_statuses.id_statuses AND
                                        problem_appeals.id_priorities = sp_priorities.id_priorities AND problem_appeals.id_type_appeal = sp_type_appeal.id_type_appeal AND
                                        problem_appeals.id_address_premises = address_premises.id_address_premises AND
                                        address_premises.id_street = street.id_street AND street.id_district = sp_district.id_district AND appeals.id_employee = '{nomer}'";
            DtSelectProblemUserAdd.Clear();
            Mydata.Fill(DtSelectProblemUserAdd);
        }
        static public void SelectProblemAllAdd()
        {
            Mycommand.CommandText = $@"SELECT problem_appeals.id_problem_appeals, problem_appeals.Date_delayed_response, sp_statuses.statuses, sp_priorities.priorities,
                                        sp_type_appeal.type_appeal, CONCAT(sp_district.district,' Улица ',street.Street,' Дом ',address_premises.Home,' Корпус ',address_premises.Korpys,' Квартира ',address_premises.Kvartira) AS Adres, problem_appeals.Description, problem_appeals.Note, problem_appeals.SolvingCh FROM problem_appeals, sp_priorities, sp_statuses, sp_type_appeal, address_premises, street, sp_district, appeals
                                        WHERE problem_appeals.id_appeals = appeals.id_appeals AND problem_appeals.id_statuses = sp_statuses.id_statuses AND
                                        problem_appeals.id_priorities = sp_priorities.id_priorities AND problem_appeals.id_type_appeal = sp_type_appeal.id_type_appeal AND
                                        problem_appeals.id_address_premises = address_premises.id_address_premises AND
                                        address_premises.id_street = street.id_street AND street.id_district = sp_district.id_district";
            DtSelectProblemAllAdd.Clear();
            Mydata.Fill(DtSelectProblemAllAdd);
        }
        //
        static public void SelectProblemAll()
        {
            Mycommand.CommandText = $@"SELECT problem_appeals.id_problem_appeals, problem_appeals.Date_delayed_response, sp_statuses.statuses, sp_priorities.priorities,
                                        sp_type_appeal.type_appeal, CONCAT(sp_district.district,' Улица ',street.Street,' Дом ',address_premises.Home,' Корпус ',address_premises.Korpys,' Квартира ',address_premises.Kvartira) AS Adres, problem_appeals.Description, problem_appeals.Note, problem_appeals.SolvingCh FROM problem_appeals, sp_priorities, sp_statuses, sp_type_appeal, address_premises, street, sp_district, appeals
                                        WHERE problem_appeals.id_appeals = appeals.id_appeals AND problem_appeals.id_statuses = sp_statuses.id_statuses AND
                                        problem_appeals.id_priorities = sp_priorities.id_priorities AND problem_appeals.id_type_appeal = sp_type_appeal.id_type_appeal AND
                                        problem_appeals.id_address_premises = address_premises.id_address_premises AND
                                        address_premises.id_street = street.id_street AND street.id_district = sp_district.id_district";
            DtProblemAppeals.Clear();
            Mydata.Fill(DtProblemAppeals);
        }
        static public void SelectAdresDisctict()
        {
            Mycommand.CommandText = $"SELECT id_district, district FROM sp_district";
            DtAdressDistrict.Clear();
            Mydata.Fill(DtAdressDistrict);
        }
        static public void SelectStreet(string nomerDistrict)
        {
            Mycommand.CommandText = $"SELECT id_street, Street FROM street WHERE id_district = '{nomerDistrict}'";
            DtStreet.Clear();
            Mydata.Fill(DtStreet);
        }
        static public bool AddStreet(string district, string street)
        {
            try
            {
                Mycommand.CommandText = $"INSERT INTO street VALUES(null,'{district}','{street}')";
                if (Mycommand.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Запись уже существует","Ошибка",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
        }
        static public bool AddAdres(params string[] par)
        {
            Mycommand.CommandText = $"INSERT INTO address_premises VALUES(null, '{par[0]}','{par[1]}', '{par[2]}','{par[3]}',null)";
            if (Mycommand.ExecuteNonQuery() > 0)
            {
                Mycommand.CommandText = $@"SELECT CONCAT(sp_district.district,', улица ',street.Street,', дом ',address_premises.Home,', корпус ',address_premises.Korpys,', кв.',address_premises.Kvartira) AS Adres 
                                            FROM address_premises, street, sp_district 
                                            WHERE address_premises.id_street = street.id_street AND street.id_district = sp_district.id_district AND address_premises.id_street = '{par[0]}' AND address_premises.Home = '{par[1]}' AND address_premises.Korpys = '{par[2]}' AND address_premises.Kvartira = '{par[3]}'";
                Adres = Mycommand.ExecuteScalar();
                if (Adres != null)
                {
                    Mycommand.CommandText = $@"SELECT address_premises.id_address_premises
                                            FROM address_premises, street, sp_district 
                                            WHERE address_premises.id_street = street.id_street AND street.id_district = sp_district.id_district AND address_premises.id_street = '{par[0]}' AND address_premises.Home = '{par[1]}' AND address_premises.Korpys = '{par[2]}' AND address_premises.Kvartira = '{par[3]}'";
                    NomerAdres = Mycommand.ExecuteScalar();
                    if (NomerAdres != null)
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
        static public bool RedAdres(params string[] par)
        {
            Mycommand.CommandText = $"INSERT INTO address_premises VALUES(null, '{par[0]}','{par[1]}', '{par[2]}','{par[3]}',null)";
            if (Mycommand.ExecuteNonQuery() > 0)
            {
                Mycommand.CommandText = $@"SELECT CONCAT(sp_district.district,', улица ',street.Street,', дом ',address_premises.Home,', корпус ',address_premises.Korpys,', кв.',address_premises.Kvartira) AS Adres 
                                            FROM address_premises, street, sp_district 
                                            WHERE address_premises.id_street = street.id_street AND street.id_district = sp_district.id_district AND address_premises.id_street = '{par[0]}' AND address_premises.Home = '{par[1]}' AND address_premises.Korpys = '{par[2]}' AND address_premises.Kvartira = '{par[3]}'";
                Adres = Mycommand.ExecuteScalar();
                if (Adres != null)
                {
                    Mycommand.CommandText = $@"SELECT address_premises.id_address_premises
                                            FROM address_premises, street, sp_district 
                                            WHERE address_premises.id_street = street.id_street AND street.id_district = sp_district.id_district AND address_premises.id_street = '{par[0]}' AND address_premises.Home = '{par[1]}' AND address_premises.Korpys = '{par[2]}' AND address_premises.Kvartira = '{par[3]}'";
                    NomerAdres = Mycommand.ExecuteScalar();
                    if (NomerAdres != null)
                    {
                        Mycommand.CommandText = $"UPDATE problem_appeals SET id_address_premises = '{NomerAdres}' WHERE id_problem_appeals = '{par[4]}'";
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
                return false;
        }
        static public void SelectStreet(string district,string street)
        {
            Mycommand.CommandText = $"SELECT street.id_street FROM street, sp_district WHERE street.id_district = sp_district.id_district AND street.id_district = '{district}' AND street.Street = '{street}'";
            NomerStreet = Mycommand.ExecuteScalar();
        }

        static public bool AddProblemAppeals(string [] fileName, string [] files, params string [] par1)
        {
            object nomer;
            DateTime dt = Convert.ToDateTime(par1[1]);
            Mycommand.CommandText = $"INSERT INTO problem_appeals VALUES (null,'{par1[0]}','{dt.ToString("yyyy.MM.dd")}','{par1[2]}','{par1[3]}','{par1[4]}','{par1[5]}','{par1[6]}','{par1[7]}','{0}')";
            if (Mycommand.ExecuteNonQuery() > 0)
            {
                Mycommand.CommandText = $"SELECT id_problem_appeals FROM problem_appeals ORDER BY id_problem_appeals DESC LIMIT 1";
                nomer = Mycommand.ExecuteScalar();
                if (nomer != null)
                {
                    AddFileProbleamAppeals(nomer.ToString(), fileName, files);
                    return true;
                }
                else
                    return false;
            }
            else
                return false;
        }

        static public void NomerAppeals(string probleamAppeals)
        {
            Mycommand.CommandText = $"SELECT appeals.id_appeals FROM appeals, problem_appeals WHERE appeals.id_appeals = problem_appeals.id_appeals AND problem_appeals.id_problem_appeals = '{probleamAppeals}'";
            NomerAppeal = Mycommand.ExecuteScalar();
        }



        static public bool RedProbleamAppeals(params string [] par)
        {
            DateTime dt = Convert.ToDateTime(par[0]);
            Mycommand.CommandText = $"UPDATE problem_appeals SET Date_delayed_response = '{dt.ToString("yyyy.MM.dd")}', Description = '{par[1]}', id_statuses = '{par[2]}',  id_priorities = '{par[3]}', id_type_appeal = '{par[4]}', id_address_premises = '{par[5]}', Note = '{par[6]}' WHERE id_problem_appeals = '{par[7]}'";
            if (Mycommand.ExecuteNonQuery() > 0)
                return true;
            else
                return false;
        }
        static public string SelectNomerAppeals(string nomer)
        {
            object nomerappeals;
            Mycommand.CommandText = $"SELECT id_appeals FROM problem_appeals WHERE id_problem_appeals = '{nomer}'";
            nomerappeals = Mycommand.ExecuteScalar();
            if (nomer != null)
                return nomerappeals.ToString();
            else
                return "";
        }





        static public bool AddFileProbleamAppeals(string nomer, string [] strfilename, string[] strfiles)
        {
            for (int i = 0; i < strfilename.Length; i++)
            {
                if (strfilename[i] != null)
                {
                    Mycommand.CommandText = $"INSERT INTO application_documents VALUES(null, '{nomer}', '{strfilename[i]}', '{strfiles[i]}')";
                    Mycommand.ExecuteNonQuery();
                }
            }
            return true;
        }
        static public bool DeleteFile(string nomer)
        {
            if (nomer != "")
            {
                Mycommand.CommandText = $"DELETE FROM application_documents WHERE id_application_documents = '{nomer}'";
                if (Mycommand.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }
        static public void SelectFile(string nomer)
        {
            Mycommand.CommandText = $"SELECT id_application_documents, Heading FROM application_documents WHERE id_problem_appeals = '{nomer}'";
            DtDocx.Clear();
            Mydata.Fill(DtDocx);
        }
    }
}
