using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class ShoppingCart : System.Web.UI.Page
    {
        BindingList<Product> tmpBinding = new BindingList<Product>();
        

        protected void Page_Load(object sender, EventArgs e)
        {

            foreach (Product p in tmpBinding)
            {
                
                shoppingCartListBox.Items.Add(p.ToString());
            }
        }

        protected void shoppingCartListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        public void LoadList(BindingList<Product> p)
        {
            tmpBinding = p;
        }
    }
}