using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public static class Globals
    {
        private static string dbServer = "cis425.wpcarey.asu.edu";
        private static string username = "msampedr";
        private static string password = "fineSAND96";
        private static string dbName = "groupa03";

        static string dbConnectionString = string.Format($"server={dbServer};uid={username};pwd={password};database={dbName};");
        public static MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(dbConnectionString);
    }

    public partial class SearchResults : System.Web.UI.Page
    {
        Product product;
        BindingList<Product> productList;
        BindingList<Product> selectedItems;

        ShoppingCart tmpCart;
        

        string sValue;

        protected void Page_Load(object sender, EventArgs e)
        {
            Globals.conn.Open();
            sValue = (string)Session["SearchValue"];
            //searchData(sValue);

            

            string query = $"SELECT * FROM groupa03.product Where Name LIKE '%{sValue}%'";

            var cmd = new MySql.Data.MySqlClient.MySqlCommand(query, Globals.conn);
            var reader = cmd.ExecuteReader();

            Label1.Text = String.Empty;
            product = new Product();
            
            //int[] priceArray = new int[10];
            //int count = 0;
            //int cellCount = 1;
            productList = new BindingList<Product>();
            while (reader.Read())
            {
                //string tmpAdd = "";
                //int tmpNum;
                

                var price = reader["price"]; // get data from the title column
                var name = reader["Name"];
                var recNumber = reader["RecNumber"];
                var description = reader["Description"];
                var id = reader["ID"];
                product.Price = Convert.ToDouble(price);
                product.Name = name.ToString();
                product.RecNumber = Convert.ToInt32(recNumber);
                product.Description = description.ToString();
                product.Id = Convert.ToInt32(id);

                productList.Add(product);






                //tmpAdd += $"{recNumber} {id} {name} {description} {price}<br>";
                
                //tmpNum = Convert.ToInt32(price);
                //priceArray[count++] = tmpNum;
                
                //Label1.Text += $"{tmpNum}<br>";
            }

            foreach(Product p in productList)
            {
                CheckBoxList1.Items.Add(p.ToString());
            }
            
            reader.Close();


        }
        protected void Page_Unload(object sender, EventArgs e)
        {
            Globals.conn.Close();
        }

        protected void addButton_Click(object sender, EventArgs e)
        {
            int tmpNum;
            selectedItems = new BindingList<Product>();
            for (int i = 0; i < CheckBoxList1.Items.Count; i++)
            {
                if (CheckBoxList1.Items[i].Selected == true)
                {
                    tmpNum = CheckBoxList1.SelectedIndex;
                    selectedItems.Add(productList[tmpNum]);
                }
                else
                    return;
                
            }
            tmpCart = new ShoppingCart();
            tmpCart.LoadList(selectedItems);
            
        }

        //public void searchData(string valueToSearch)
        //{
        //    //con = new MySqlConnection("Server= cis425.wpcarey.asu.edu; Database = groupa03; UID=gespino5; password = congoCOULD66; ");
        //    //string query = "SELECT * FROM groupa03.product WHERE CONCAT('RecNumber', 'ID', 'Name', 'Description', 'Price' ) like '%" + valueToSearch + "%'";
        //    //command = new MySqlCommand(query, con);
        //    //adapter = new MySqlDataAdapter(command);
        //    //table = new DataTable();
        //    //adapter.Fill(table);
        //    //GridView1.DataSource = table;

        //    //con = new MySqlConnection("Server= cis425.wpcarey.asu.edu; Database = groupa03; UID=gespino5; password = congoCOULD66; ");
        //    //string query = "SELECT * FROM groupa03.product";
        //    //adapter = new MySqlDataAdapter(query, con);

        //    //commandBuilder = new MySqlCommandBuilder(adapter);
        //    //dataset = new DataSet();
        //    //adapter.Fill(dataset);
        //    //GridView1.DataSource = dataset.Tables[0];


        //}

        //protected void Button1_Click(object sender, EventArgs e)
        //{
        //    //string str = "Select * from groupa03.product where CONCAT('RecNumber', 'ID', 'Name', 'Description', 'Price' ) like '%' + @search + '%')";
        //    //MySqlCommand xp = new MySqlConnection(str, vid);
        //}
    }


}