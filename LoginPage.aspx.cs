using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Shopping
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            if (txt1.Text == "admin" && txt2.Text == "password")
            {
                //go to the home page
                Response.Redirect("Shop.aspx");
            }
            else
            {
                //show a message
                Lbl3.Text = "Invalid username or password";
            }
        }
    }
}