using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Shopping
{
    public partial class Shop : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Ddl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Lbl1.Text = Ddl1.SelectedValue;
            Img2.ImageUrl = "Images/" + Ddl1.SelectedItem.ToString() + ".jpg";
        }
      
        protected void btn2_Click(object sender, EventArgs e)
        {
            double total =0;
            double price =0;
            int qty =0;
            
            price = Convert.ToDouble(Lbl1.Text);
            qty = Convert.ToInt32(Txt1.Text);
            total = price * qty;
            if (Rb1.Checked)
            {
                if (total < 100)
                {
                    total = total + (total * 0.10);
                }
            }
            if (Rb4.Checked)
            {
                total = total + (total * 0.13);
            }

            Lbl2.Text = total.ToString();
        }

       
    }
}