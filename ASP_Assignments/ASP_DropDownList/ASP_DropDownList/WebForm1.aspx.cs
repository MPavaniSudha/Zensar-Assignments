using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP_DropDownList
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

                string[] str = new string[] { "Select", "Mi LED", "LG SmartTV", "Realme LED","Infinix LED" };
                for (int i = 0; i < str.Length; i++)
                {
                    DropDownList1.Items.Add(str[i]);
                }
            }

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = DropDownList1.Text;
            Image1.ImageUrl = "~/images/" + str +".jpg";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedValue == "Mi LED")
            {
                TextBox1.Text = "30000";
            }
            else if (DropDownList1.SelectedValue == "LG SmartTV")
            {
                TextBox1.Text = "40000";
            }
            else if (DropDownList1.SelectedValue == "Realme LED")
            {
                TextBox1.Text = "25000";
            }
            else if (DropDownList1.SelectedValue == "Infinix LED")
            {
                TextBox1.Text = "50000";
            }
        }
    }
    
}