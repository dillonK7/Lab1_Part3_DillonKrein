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
//Code behind scholarship page including, sql queries and session data
namespace Lab1_Part3_DillonKrein
{
    public partial class ScholarshipPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session["ScholarshipArray"] = new Scholarship[100];
                Session["Arraykeeper"] = 0;
                updateFromDB();                
            }
        }
        protected void LstScholarship_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        protected void BtnSave_Click(object sender, EventArgs e)
        {
            String scholarshipName = TxtScholarName.Text.ToString();
            String scholarshipYear = TxtScholarYear.Text.ToString();
            String scholarshipAmount = TxtScholarAmount.Text.ToString();
            String coordName = TxtCoordName.Text.ToString();            
            

            Scholarship[] sArray = (Scholarship[])Session["ScholarshipArray"];
            int keeper = (int)Session["ArrayKeeper"];

            sArray[keeper] = new Scholarship(scholarshipName, scholarshipYear, scholarshipAmount, coordName);
            Session["ScholarshipArray"] = sArray;
        }

        protected void BtnCommit_Click(object sender, EventArgs e)
        {
            Scholarship[] sArray = (Scholarship[])Session["ScholarshipArray"];
            int keeper = (int)Session["ArrayKeeper"];

            string sqlQuery = "INSERT INTO Scholarship(ScholarshipName, ScholarshipYear, ScholarshipAmount, CoordName) VALUES ('"
                + sArray[keeper].ScholarshipName.ToString() + "','" + sArray[keeper].ScholarshipYear.ToString() + "','" + sArray[keeper].ScholarshipAmount.ToString() + "','" + sArray[keeper].CoordName.ToString() + "')";

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

        protected void BtnPopulate_Click(object sender, EventArgs e)
        {
            TxtScholarName.Text = "Presidential Award";
            TxtScholarYear.Text = "2022";
            TxtScholarAmount.Text = "$50,000";
            TxtCoordName.Text = "DukeGroup";
        }

        protected void BtnClear_Click(object sender, EventArgs e)
        {
            clearText();
        }
        protected void updateFromDB()
        {         
            DdlScholarship.Items.Clear();
            Scholarship[] sArray = (Scholarship[])Session["ScholarshipArray"];
            int keeper = (int)Session["ArrayKeeper"];

            string sqlQuery = "SELECT ScholarshipName, ScholarshipYear, ScholarshipAmount, CoordName FROM Scholarship";

            SqlConnection sqlConnect = new SqlConnection(WebConfigurationManager.ConnectionStrings["Lab1"].ConnectionString);

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnect;
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = sqlQuery;

            sqlConnect.Open();
            SqlDataReader queryResults = sqlCommand.ExecuteReader();

            DdlScholarship.Items.Add(new ListItem("Scholarship List"));
            while (queryResults.Read())
            {
                sArray[keeper] = new Scholarship(queryResults["ScholarshipName"].ToString(), queryResults["ScholarshipYear"].ToString(), queryResults["ScholarshipAmount"].ToString(), queryResults["CoordName"].ToString());
                DdlScholarship.Items.Add(new ListItem(
                    sArray[keeper].ScholarshipName + ' ' + sArray[keeper].ScholarshipYear,
                    sArray[keeper].scholarshipID.ToString()));
                keeper++;
            }

            Session["ScholarshipArray"] = sArray;
            Session["ArrayKeeper"] = keeper;
            sqlConnect.Close();
            queryResults.Close();
        }
        protected void clearText()
        {
            TxtScholarName.Text = "";
            TxtScholarYear.Text = "";
            TxtScholarAmount.Text = "";
            TxtCoordName.Text = "";            
        }

        protected void DdlScholarship_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}