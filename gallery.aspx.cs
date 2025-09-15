using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Web.UI.HtmlControls;

public partial class gallery : System.Web.UI.Page
{
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
                if (node.Attributes[0].InnerText.ToLower().Equals("p4"))
                {
                    string nodetype = "";
                    string tempId = "";
                    int txt_cnt = 1;
                    int img_cnt = 1;
                    int anchr_cnt = 1;

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
                        else if (nodetype.Equals("imgs"))
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
                        //else if (nodetype.Equals("imgb"))
                        //{
                        //    // check for Images
                        //    try
                        //    {
                        //        tempId = ("a" + anchr_cnt).Trim();
                        //        HtmlAnchor ht_anchr = (HtmlAnchor)form1.FindControl(tempId);
                        //        ht_anchr.HRef = childNode.InnerText.Trim();

                        //    }
                        //    catch { }
                        //    finally { anchr_cnt++; }

                        //}

                    }
                }
            }
        }
        catch { }
    }
}
