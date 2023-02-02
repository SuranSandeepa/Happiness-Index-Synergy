using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Happiness_Index.Admin
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "admin" || txtUsername.Text == "Admin" && txtPassword.Text == "12345")
            {
                Session["un"] = txtUsername.Text;
                Session["pw"] = txtPassword.Text;

                Response.Redirect("../DashboardPage.aspx");
            }
            else
            {
                Response.Write("<script>alert('Invalid Login');</script>");
            }
        }
    }
}