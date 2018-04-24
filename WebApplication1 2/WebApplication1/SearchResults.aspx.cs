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
    //public static class Globals
    //{
    //    private static string dbServer = "cis425.wpcarey.asu.edu";
    //    private static string username = "gespino5";
    //    private static string password = "congoCOULD66";
    //    private static string dbName = "groupa03";

    //    static string dbConnectionString = string.Format($"server={dbServer};uid={username};pwd={password};database={dbName};");
    //    public static MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(dbConnectionString);
    //}

    public partial class SearchResults : System.Web.UI.Page
    {

        MySqlConnection con = new MySqlConnection("Server= cis425.wpcarey.asu.edu; Database = groupa03; UID=gespino5; password = congoCOULD66; ");
        MySqlCommand command;
        MySqlDataAdapter adapter;
        DataTable table;

        string sValue;

        protected void Page_Load(object sender, EventArgs e)
        {
            //Globals.conn.Open();
            sValue = (string)Session["SearchValue"];
            searchData(sValue);



            //string query = "SELECT * FROM groupa03.product;";

            //var cmd = new MySql.Data.MySqlClient.MySqlCommand(query, Globals.conn);
            //var reader = cmd.ExecuteReader();

            //Label1.Text = String.Empty;

            //while (reader.Read())
            //{
            //    var price = reader["price"]; // get data from the title column


            //    Label1.Text += "Book title is " + price.ToString() + "<br>";
            //}

            //reader.Close();


        }
        //protected void Page_Unload(object sender, EventArgs e)
        //{
        //    Globals.conn.Close();
        //}

        public void searchData(string valueToSearch)
        {
            string query = "SELECT * FROM groupa03.product WHERE CONCAT('RecNumber', 'ID', 'Name', 'Description', 'Price' ) like '%" + valueToSearch + "'";
            command = new MySqlCommand(query, con);
            adapter = new MySqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            GridView1.DataSource = table;
            

        }
    }


}