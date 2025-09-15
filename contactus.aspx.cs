using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Configuration;
using System.Xml;
using System.Web.UI.HtmlControls;
using System.Text.RegularExpressions;

public partial class contactus : System.Web.UI.Page
{
    int valid = 0;
    bool _isvalidMessage;
    bool _isEnglishvalidate;
    public const string err_CaptchaMsg = "Please enter valid Message and exact code shown!";
    public const string errmessage = "Please Enter Valid Message";
    public const string captchaMessage = "Please enter the exact code shown!";
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (Session["editlogin"].ToString() == "1")
            {
                editlogin.Visible = false;
            }
        }
        catch { }
        try
        {
            XmlDocument xdoc1 = new XmlDocument();
            xdoc1.Load(Server.MapPath("xml/tfile_main.xml"));
            XmlNamespaceManager nsm1 = new XmlNamespaceManager(new NameTable());
            XmlNodeList nodelist1 = xdoc1.SelectNodes("root/*", nsm1);
            foreach (XmlNode node1 in nodelist1)
            {

                if (node1.Attributes[0].InnerText.ToLower().Equals("p0"))
                {
                    string nodetype = "";
                    string tempId = "";

                    int bimg_cnt = 1;

                    for (int i = 0; i < node1.ChildNodes.Count; i++)
                    {
                        XmlNode childNode = node1.ChildNodes[i];
                        nodetype = childNode.Name.Trim();


                        if (nodetype.Equals("bigImages"))
                        {
                            // check for Images
                            try
                            {
                                tempId = ("bimg" + bimg_cnt).Trim();
                                HtmlImage ht_img = (HtmlImage)form1.FindControl(tempId);
                                ht_img.Src = childNode.InnerText.Trim();

                            }
                            catch { }
                            finally { bimg_cnt++; }

                        }

                    }
                }
            }
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(Server.MapPath("xml/tfile_main.xml"));
            XmlNamespaceManager nsm = new XmlNamespaceManager(new NameTable());
            XmlNodeList nodelist = xdoc.SelectNodes("root/*", nsm);
            foreach (XmlNode node in nodelist)
            {
                if (node.Attributes[0].InnerText.ToLower().Equals("p5"))
                {
                    string nodetype = "";
                    string tempId = "";
                    int txt_cnt = 1;
                    int img_cnt = 1;

                    for (int i = 0; i < node.ChildNodes.Count; i++)
                    {
                        XmlNode childNode = node.ChildNodes[i];
                        nodetype = childNode.Name.Trim().ToLower();

                        if (nodetype.Equals("txt"))
                        {
                            // check for text
                            try
                            {
                                tempId = ("p" + txt_cnt).Trim();
                                HtmlGenericControl ht_txt = (HtmlGenericControl)form1.FindControl(tempId);
                                ht_txt.InnerHtml = childNode.InnerText.Trim();

                            }
                            catch { }
                            finally { txt_cnt++; }

                        }
                        if (nodetype.Equals("t"))
                        {
                            // check for text
                            try
                            {
                                tempId = ("p" + txt_cnt).Trim();
                                HtmlGenericControl ht_txt = (HtmlGenericControl)form1.FindControl(tempId);
                                ht_txt.InnerHtml = childNode.InnerText.Trim();

                            }
                            catch { }
                            finally { txt_cnt++; }

                        }
                        else if (nodetype.Equals("img"))
                        {
                            // check for Images
                            try
                            {
                                tempId = ("img" + img_cnt).Trim();
                                HtmlImage ht_img = (HtmlImage)form1.FindControl(tempId);
                                ht_img.Src = childNode.InnerText.Trim();

                            }
                            catch { }
                            finally { img_cnt++; }

                        }

                    }
                }
            }
        }
        catch { }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            string body = "";
            string tbl_custInfo = "";
            string rs = HttpContext.Current.Request.UrlReferrer.AbsolutePath;
            if (!rs.ToLower().Contains("contactus.aspx")) return;
            if (txtmessage.Value.Trim().ToLower().Contains("in your city")) return;
            if (txtmessage.Value.Trim().ToLower().Contains("in your town")) return;
            if (txtmessage.Value.Trim().ToLower().Contains("Sex")) return;
            if (txtmessage.Value.Trim().ToLower().Contains("hot")) return;
            if (txtmessage.Value.Trim().ToLower().Contains("girls")) return;
            if (txtmessage.Value.Trim().ToLower().Contains("guy")) return;
            if (txtmessage.Value.Trim().ToLower().Contains("http")) return;
            if (txtmessage.Value.Trim().ToLower().Contains("https")) return;
            if (txtmessage.Value.Trim().ToLower().Contains("bitcoin")) return;
            if (txtmessage.Value.Trim().ToLower().Contains("women")) return;
            if (txtmessage.Value.Trim().ToLower().Contains("seo")) return;
            if (txtmessage.Value.Trim().ToLower().Contains("Search engine optimization")) return;
            if (txtmessage.Value.Trim().ToLower().Contains("girl")) return;
            _isEnglishvalidate = IsEnglish(txtmessage.Value);
            tbl_custInfo = "<table style='border:solid 1px #aec6d8;padding:15px;' align='center' width='100%'>";
            tbl_custInfo += "<tr><td colspan='2' style='border-bottom:solid 1px #aec6d8;text-align:center;font-weight:bold;color:#8d8f8a;'>Customer Contact Details</td></tr>";
            tbl_custInfo += "<tr><td style='border-bottom:solid 1px #eee;'>Name : </td><td style='border-bottom:solid 1px #eee;'>" + txtname.Value.Trim() + "</td></tr>";
            tbl_custInfo += "<tr><td style='border-bottom:solid 1px #eee;'>Phone : </td><td style='border-bottom:solid 1px #eee;'>" + txtphone.Value.Trim() + "</td></tr>";
            tbl_custInfo += "<tr><td style='border-bottom:solid 1px #eee;'>Mobile : </td><td style='border-bottom:solid 1px #eee;'>" + txtmobile.Value.Trim() + "</td></tr>";
            tbl_custInfo += "<tr><td style='border-bottom:solid 1px #eee;'>E_mail : </td><td style='border-bottom:solid 1px #eee;'>" + txtemail.Value.Trim() + "</td></tr>";
            tbl_custInfo += "<tr><td>Comments : </td><td>" + txtmessage.Value.Trim() + "</td></tr>";
            tbl_custInfo += "</table>";

            body = "<br/>" + tbl_custInfo;

            SmtpClient smtpClient = new SmtpClient();
            smtpClient.EnableSsl = true;
            MailMessage message = new MailMessage();

            message.From = new MailAddress(ConfigurationManager.AppSettings["MailFrom"], txtemail.Value);

            if (ConfigurationManager.AppSettings["MailTo"].Trim() != "")
                message.To.Add(ConfigurationManager.AppSettings["MailTo"]);

            if (ConfigurationManager.AppSettings["MailBCc"].Trim() != "")
                message.Bcc.Add(ConfigurationManager.AppSettings["MailBCc"]);

            if (ConfigurationManager.AppSettings["Subject"].Trim() != "")
                message.Subject = ConfigurationManager.AppSettings["Subject"];

            message.ReplyTo = new MailAddress(txtemail.Value.Trim());

            message.Body = body;
            message.IsBodyHtml = true;
            if (_isEnglishvalidate)
            {
                smtpClient.Send(message);

                ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), Guid.NewGuid().ToString(), "alert('Thanks for contacting ALLSTAR SIGNS');", true);

                txtname.Value = "- your name -";
                txtemail.Value = "- email -";
                txtphone.Value = "- phone -";
                txtmobile.Value = "- mobile -";
                txtmessage.Value = "- comments -";
            }
            else
            {
                this.ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert(\"" + errmessage + "\");", true);
                return;
            }

        }
        catch { }
    }
    private bool IsEnglish(string message)
    {
        Regex regex = new Regex(@"[A-Za-z0-9 .,-=+(){}\[\]\\]");
        MatchCollection matches = regex.Matches(message);

        if (matches.Count.Equals(message.Length))
            return true;
        else
            return false;
    }
}
