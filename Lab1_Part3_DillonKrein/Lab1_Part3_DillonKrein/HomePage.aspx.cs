using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//Dillon Krein
//2-11-2022
//Code behind for homePage
namespace Lab1_Part3_DillonKrein
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void StudentPage_Click(object sender, EventArgs e)
        {
            Response.Redirect("StudentPage.aspx");
        }

        protected void ScholarshipPage_Click(object sender, EventArgs e)
        {
            Response.Redirect("ScholarshipPage.aspx");
        }
    }
}