using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Configuration;
using System.Net.Mail;

public partial class changepassword : System.Web.UI.Page
{
    string userName = "";
    string Pwd = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            try
            {
                if (!string.IsNullOrEmpty(Session["changePassword"].ToString()))
                {
                    string popMessage = "<script language=javascript>alert('Please change your password.')</script>";
                    Page.RegisterClientScriptBlock("message", popMessage);
                    Session["changePassword"] = "";
                }
            }
            catch { }
        }

        string css_txt = "border:1px solid #ccc;";
        string css_btn = "border:1px solid #ccc;background-color:#999;color:#fff;font-weight:bold;padding:3px 8px;cursor:pointer;";
        //string css_lnk = "color:#0099FF; text-decoration:none;font-size:16px; ";


        txtUserName.Style.Value = css_txt;
        txtOldPwd.Style.Value = css_txt;
        txtNewPwd.Style.Value = css_txt;
        txtConfirmPwd.Style.Value = css_txt;
        btnSubmit.Style.Value = css_btn;
        btnClear.Style.Value = css_btn;
        //lnkBack.Style.Value = css_lnk;


    }
        
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        try
        {
            string css_Error = "color:red;";
            string xmlfile = Server.MapPath("App_code/login.xml").Trim().ToLower();
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load(xmlfile);

            XmlNodeList LoginNodeList = xmldoc.SelectNodes("//login");

            foreach (XmlNode loginNode in LoginNodeList)
            {
                if (loginNode.HasChildNodes)
                {
                    userName = loginNode.ChildNodes[0].InnerText.Trim().ToLower();
                    Pwd = loginNode.ChildNodes[1].InnerText.Trim();

                    if (userName.Trim().ToLower().Equals(txtUserName.Text.Trim().ToLower()) && Pwd.Trim().Equals(txtOldPwd.Text.Trim()))
                    {
                        // if sucess
                        loginNode.ChildNodes[0].InnerText = txtUserName.Text.Trim();
                        loginNode.ChildNodes[1].InnerText = txtNewPwd.Text.Trim();

                        int count = 2;
                        loginNode.ChildNodes[2].InnerText = count.ToString();

                        string css_lbl = "color:red;";
                        lblStatus.Visible = true;
                        lblStatus.Style.Value = css_lbl;
                        lblStatus.Text = "Password Changed Successfully..";

                        xmldoc.Save(xmlfile);

                        SmtpClient smtpclient = new SmtpClient();
                        smtpclient.EnableSsl = true;
                        MailMessage message = new MailMessage();
                        message.To.Add(ConfigurationManager.AppSettings["MailTo"].ToString());

                        message.From = new MailAddress(ConfigurationManager.AppSettings["MailFrom"].ToString());
                        message.Body = "Your New Password is <br/> password : " + txtNewPwd.Text + "";
                        message.Subject = ConfigurationManager.AppSettings["Subject1"].ToString();
                        message.IsBodyHtml = true;
                      
                        smtpclient.Send(message);
                    }
                    else
                    {
                        lblStatus.Visible = true;
                        lblStatus.Style.Value = css_Error;
                        lblStatus.Text = "Plz Check User Credentials...";
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
            txtOldPwd.Text = "";
            txtNewPwd.Text = "";
            txtConfirmPwd.Text = "";
            lblStatus.Visible = false;
        }
        catch { }

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            Response.Redirect("login.aspx", false);
        }
        catch { }
    }
}
