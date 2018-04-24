using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class HomePage : System.Web.UI.Page
    {
        

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void searchButton_Click(object sender, EventArgs e)
        {
            string valuetoSearch = "";

            valuetoSearch = searchTextBox.Text;
            Session["SearchValue"] = $"{valuetoSearch}";

            Response.Redirect("SearchResults.aspx", true);

        }

        
    }
}