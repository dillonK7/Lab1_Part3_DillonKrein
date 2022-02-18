using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
//Dillon Krein
//2-11-2022
//Code behind student page including, sql queries and session data
namespace Lab1_Part3_DillonKrein
{
    public partial class StudentPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session["StudentArray"] = new Student[100];
                Session["ArrayKeeper"] = 0;
                updateFromDB();
            }            
        }
        protected void BtnSave_Click(object sender, EventArgs e)
        {
            String firstName = TxtFirstName.Text.ToString();
            String lastName = TxtLastName.Text.ToString();
            String email = TxtEmail.Text.ToString();
            String phoneNumber = TxtPhoneNumber.Text.ToString();
            String gradYear = TxtGradYear.Text.ToString();
            String major = TxtMajor.Text.ToString();
            String uniYear = TxtUniYear.Text.ToString();
            String internStatus = TxtInternStatus.Text.ToString();
            String empStatus = TxtEmpStatus.Text.ToString();

            Student[] sArray = (Student[])Session["StudentArray"];
            int keeper = (int)Session["ArrayKeeper"];

            sArray[keeper] = new Student(firstName, lastName, email, phoneNumber, gradYear, major, uniYear, internStatus, empStatus);
            Session["StudentArray"] = sArray;
        }
        protected void BtnComit_Click(object sender, EventArgs e)
        {
            Student[] sArray = (Student[])Session["StudentArray"];
            int keeper = (int)Session["ArrayKeeper"];

            string sqlQuery = "INSERT INTO Student(FirstName, Lastname, EmailAddress, PhoneNumber, ExpectedGradYear, Major, UniversityYear, InternshipStatus, EmploymentStatus) VALUES ('"
                + sArray[keeper].FirstName.ToString() + "','" + sArray[keeper].LastName.ToString() + "','" + sArray[keeper].Email.ToString() + "','" + sArray[keeper].PhoneNumber.ToString() 
                + "','" + sArray[keeper].ExpectedGradYear.ToString() + "','" + sArray[keeper].Major.ToString() + "','" + sArray[keeper].UniversityYear.ToString() + "','"
                + sArray[keeper].InternshipStatus.ToString() + "','" + sArray[keeper].EmploymentStatus.ToString() + "')";

            keeper++;
            Session["ArrayKeeper"] = keeper;

            SqlConnection sqlConnection = new SqlConnection(WebConfigurationManager.ConnectionStrings["Lab1"].ConnectionString);

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = sqlQuery;

            sqlConnection.Open();
            sqlCommand.ExecuteScalar();
            sqlConnection.Close();
            updateFromDB();
            clearText();                 
            }
        protected void BtnTestData_Click(object sender, EventArgs e)
        {
            TxtFirstName.Text = "John";
            TxtLastName.Text = "Smith";
            TxtEmail.Text = "johnsmith@dukes.jmu.edu";
            TxtPhoneNumber.Text = "123-456-7890";
            TxtGradYear.Text = "2022";
            TxtMajor.Text = "CIS";
            TxtUniYear.Text = "Senior";
            TxtInternStatus.Text = "False";
            TxtEmpStatus.Text = "False";
        }
        protected void BtnClear_Click(object sender, EventArgs e)
        {
            clearText();
        }
        protected void updateFromDB()
        {
            DdlStudent.Items.Clear();
            Student[] sArray = (Student[])Session["StudentArray"];
            int keeper = (int)Session["ArrayKeeper"];

            string sqlQuery = "SELECT FirstName, LastName, EmailAddress, PhoneNumber, ExpectedGradYear, Major, UniversityYear, InternshipStatus, Employmentstatus FROM Student";

            SqlConnection sqlConnect = new SqlConnection(WebConfigurationManager.ConnectionStrings["Lab1"].ConnectionString);

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnect;
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = sqlQuery;

            sqlConnect.Open();
            SqlDataReader queryResults = sqlCommand.ExecuteReader();

            DdlStudent.Items.Add(new ListItem("Student List"));
            while (queryResults.Read())
            {
                sArray[keeper] = new Student(queryResults["FirstName"].ToString(), queryResults["LastName"].ToString(), queryResults["EmailAddress"].ToString(), queryResults["PhoneNumber"].ToString(),
                    queryResults["ExpectedGradYear"].ToString(), queryResults["Major"].ToString(), queryResults["UniversityYear"].ToString(), queryResults["InternshipStatus"].ToString(),
                    queryResults["EmploymentStatus"].ToString());
                DdlStudent.Items.Add(new ListItem(
                    sArray[keeper].FirstName + ' ' + sArray[keeper].LastName,
                    sArray[keeper].studentID.ToString()));
                keeper++;
            }

            Session["StudentArray"] = sArray;
            Session["ArrayKeeper"] = keeper;
            sqlConnect.Close();
            queryResults.Close();
        }
        protected void clearText()
        {
            TxtFirstName.Text = "";
            TxtLastName.Text = "";
            TxtEmail.Text = "";
            TxtPhoneNumber.Text = "";
            TxtGradYear.Text = "";
            TxtMajor.Text = "";
            TxtUniYear.Text = "";
            TxtInternStatus.Text = "";
            TxtEmpStatus.Text = "";
        }

        protected void DdlStudent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}