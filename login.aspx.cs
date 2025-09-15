using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

public partial class login : System.Web.UI.Page
{
    string userName = "";
    string Pwd = "";
    string count = "";

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        try
        {
            Session["username"] = txtUserName.Text.Trim().ToString();

            string css_Error = "color:red;";

            string xmlfile = Server.MapPath("App_Code/login.xml");
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load(xmlfile.ToLower().Trim());

            XmlNodeList LoginNodeList = xmldoc.SelectNodes("//login");

            foreach (XmlNode loginNode in LoginNodeList)
            {
                if (loginNode.HasChildNodes)
                {
                    userName = loginNode.ChildNodes[0].InnerText.Trim().ToLower();
                    Pwd = loginNode.ChildNodes[1].InnerText.Trim();
                    count = loginNode.ChildNodes[2].InnerText.Trim();
                    if (userName.Trim().ToLower().Equals(txtUserName.Text.Trim().ToLower()) && Pwd.Trim().Equals(txtPwd.Text.Trim()))
                    {
                        //Response.Redirect("edit.aspx",false);

                        if (count == "1")
                        {
                            Session["changePassword"] = "changepassword";


                            Response.Redirect("changepassword.aspx?uid=" + txtUserName.Text);
                        }
                        else
                        {
                            Response.Redirect("editmenu.aspx", false);
                        }
                    }
                    else
                    {
                        lblStatus.Visible = true;
                        lblStatus.Style.Value = css_Error;
                        lblStatus.Text = "Login Failed....<br/> Plz Check User Credentials...";
                    }
                }
            }

        }
        catch { }
    }
    protected void btnClear_Click(object sender, EventArgs e)
    {
        try
        {
            txtUserName.Text = "";
            txtPwd.Text = "";
            lblStatus.Text = "";
            lblStatus.Visible = false;
        }
        catch { }

    }
    protected void lnkChangePwd_Click(object sender, EventArgs e)
    {
        try
        {
            Response.Redirect("changepassword.aspx", false);
        }
        catch { }
    }
}
