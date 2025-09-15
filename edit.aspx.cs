using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FreeTextBoxControls;
using System.Xml;
using System.Collections;
using System.IO;
using System.Drawing.Imaging;

public partial class edit : System.Web.UI.Page
{
    static string pageurl = "";
    static string pageid = "";

    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (Session["username"].ToString() == "")
            {
                Response.Redirect("login.aspx");
            }
            pageid = Request.QueryString["pid"];
            pageurl = Request.QueryString["url"];
            string s1 = "<iframe  src='" + pageurl + "' name='frame' width='1015px'  frameborder='4' height='800px'" +
            "style='text-align:left;'></iframe>";
            div_iframe.InnerHtml = s1;
            Session["editlogin"] = "1";
        }
        catch { }

        try
        {
            Table table1 = new Table();
            table1.ID = "table1";
            table1.Attributes.Add("align", "center");
            table1.Style.Value = "width:100%";
            TableRow row_btn1 = new TableRow();
            TableCell cell_btn1 = new TableCell();
            row_btn1.ID = "trbtn1";
            cell_btn1.ID = "tdbtn1";

            Button btnsubmit1 = new Button();
            btnsubmit1.ID = "btn_submit1";
            btnsubmit1.Text = "Submit";
            btnsubmit1.Style.Value = "cursor:pointer;";
            btnsubmit1.Style.Value = "width:100px";
            btnsubmit1.Click += new EventHandler(btnSubmit_Click);

            Button btncancel1 = new Button();
            btncancel1.ID = "btn_cancel1";
            btncancel1.Text = "Cancel";
            btncancel1.Style.Value = "cursor:pointer;";
            btncancel1.Style.Value = "width:100px";
            btncancel1.Click += new EventHandler(btnCancel_Click);

            cell_btn1.Controls.Add(btnsubmit1);
            cell_btn1.Controls.Add(btncancel1);
            row_btn1.Cells.Add(cell_btn1);
            table1.Rows.Add(row_btn1);
            panel1.Controls.Add(table1);

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(Server.MapPath("xml/tfile_main.xml"));
            XmlNamespaceManager nsm = new XmlNamespaceManager(new NameTable());
            XmlNodeList nodelist1 = xmlDoc.SelectNodes("root/*", nsm);

            foreach (XmlNode node1 in nodelist1)
            {
                if (node1.Attributes[0].Value.Equals(pageid))
                {
                    XmlNodeList nodelist2 = node1.ChildNodes;
                    int s = 0;
                    int k = 0;
                    Table table = new Table();
                    table.ID = "tbl";
                    table.Attributes.Add("align", "center");
                    table.Style.Value = "width:100%";

                    foreach (XmlNode node2 in nodelist2)
                    {
                        if (node2.Name.ToLower().Equals("txt"))
                        {
                            TableRow rowtext = new TableRow();
                            rowtext.ID = "trtext" + s;
                            TableCell celltext = new TableCell();
                            celltext.ID = "tdtext" + s;
                            celltext.Attributes.Add("colspan", "3");
                            celltext.Attributes.Add("align", "center");

                            FreeTextBox ftbtextbox = new FreeTextBox();
                            ftbtextbox.ToolbarLayout = "createlink,bold,underline,italic;unlink,insertdate,bulletedlist;paragraphmenu,fontforecolorsmenu";
                            ftbtextbox.ID = "txttext" + s;
                            ftbtextbox.Text = node2.InnerText;
                            ftbtextbox.Height = 170;
                            ftbtextbox.Width = 440;

                            celltext.Controls.Add(ftbtextbox);
                            rowtext.Cells.Add(celltext);
                            table.Rows.Add(rowtext);
                            panel1.Controls.Add(table);
                        }
                        else if (node2.Name.ToLower().Equals("t"))
                        {

                            TableRow rowstext = new TableRow();
                            rowstext.ID = "trstext" + s;
                            TableCell cellstext = new TableCell();
                            cellstext.ID = "tdstext" + s;
                            cellstext.Attributes.Add("colspan", "3");
                            cellstext.Attributes.Add("align", "center");

                            TextBox textbox = new TextBox();
                            textbox.ID = "txtstext" + s;
                            textbox.TextMode = TextBoxMode.MultiLine;
                            textbox.Text = node2.InnerText;
                            textbox.Height = 170;
                            textbox.Width = 400;

                            cellstext.Controls.Add(textbox);
                            rowstext.Cells.Add(cellstext);
                            table.Rows.Add(rowstext);
                            panel1.Controls.Add(table);

                        }
                        else if (node2.Name.ToLower().Contains("pdf"))
                        {

                            TableRow rowpdf = new TableRow();
                            rowpdf.ID = "trpdf" + s;
                            TableCell cellpdf = new TableCell();
                            cellpdf.ID = "tdpdf" + s;
                            cellpdf.Attributes.Add("align", "right");
                            TableCell cellpdffile = new TableCell();
                            cellpdffile.ID = "tdpdffile" + s;
                            cellpdffile.Attributes.Add("align", "left");

                            Label pdffile = new Label();
                            pdffile.ID = "pdffile" + k;
                            pdffile.Height = 100;
                            pdffile.Width = 100;
                            pdffile.Style.Add("Color", "white");
                            pdffile.Text = node2.InnerText;
                            cellpdf.Controls.Add(pdffile);
                            rowpdf.Cells.Add(cellpdf);

                            FileUpload pdffileupload = new FileUpload();
                            pdffileupload.ID = "pdffileupload" + k;
                            pdffileupload.Width = 220;
                            cellpdffile.Controls.Add(pdffileupload);
                            rowpdf.Cells.Add(cellpdffile);

                            table.Rows.Add(rowpdf);
                            panel1.Controls.Add(table);
                        }
                        else
                        {
                            if (pageid == "p0")
                            {
                                XmlNodeList nodelist3 = node2.ChildNodes;
                                foreach (XmlNode node3 in nodelist3)
                                {
                                        TableRow rowImage = new TableRow();
                                        rowImage.ID = "trImage" + s;
                                        TableCell cellImage = new TableCell();
                                        cellImage.ID = "tdImage" + s;
                                        cellImage.Attributes.Add("align", "right");
                                        TableCell cellImagefile = new TableCell();
                                        cellImagefile.ID = "tdImagefile" + s;
                                        cellImagefile.Attributes.Add("align", "left");

                                        Image imagefile = new Image();
                                        imagefile.ID = "imagefile" + k;
                                        imagefile.Height = 100;
                                        imagefile.Width = 100;
                                        imagefile.ImageUrl = node3.InnerText.Trim();
                                        cellImage.Controls.Add(imagefile);
                                        rowImage.Cells.Add(cellImage);

                                        FileUpload imagefileupload = new FileUpload();
                                        imagefileupload.ID = "imagefileupload" + k;
                                        imagefileupload.Width = 220;
                                        cellImagefile.Controls.Add(imagefileupload);
                                        rowImage.Cells.Add(cellImagefile);

                                        table.Rows.Add(rowImage);
                                        panel1.Controls.Add(table);
                                    }
                            }
                            if (pageid == "p4")
                            {
                                if (node2.Name.ToLower().Contains("imgb"))
                                {
                                    TableRow rowImage = new TableRow();
                                    rowImage.ID = "trImage" + s;
                                    TableCell cellImageText = new TableCell();
                                    cellImageText.ID = "tdImageText" + s;
                                    cellImageText.Attributes.Add("align", "left");
                                    TableCell cellImage = new TableCell();
                                    cellImage.ID = "tdImage" + s;
                                    cellImage.Attributes.Add("align", "right");
                                    TableCell cellImagefile = new TableCell();
                                    cellImagefile.ID = "tdImagefile" + s;
                                    cellImagefile.Attributes.Add("align", "left");

                                    Label lblText = new Label();
                                    lblText.ID = "lblText" + s;
                                    lblText.Style.Add("color", "aqua");
                                    lblText.Text = "Big";
                                    cellImageText.Controls.Add(lblText);
                                    rowImage.Cells.Add(cellImageText);

                                    Image imagefile = new Image();
                                    imagefile.ID = "imagefile" + k;
                                    imagefile.Height = 100;
                                    imagefile.Width = 100;
                                    imagefile.ImageUrl = node2.InnerText.Trim();
                                    cellImage.Controls.Add(imagefile);
                                    rowImage.Cells.Add(cellImage);

                                    FileUpload imagefileupload = new FileUpload();
                                    imagefileupload.ID = "imagefileupload" + k;
                                    imagefileupload.Width = 220;
                                    cellImagefile.Controls.Add(imagefileupload);
                                    rowImage.Cells.Add(cellImagefile);

                                    table.Rows.Add(rowImage);
                                    panel1.Controls.Add(table);
                                }
                                if (node2.Name.ToLower().Contains("imgs"))
                                {
                                    TableRow rowImage = new TableRow();
                                    rowImage.ID = "trImage" + s;
                                    TableCell cellImageText = new TableCell();
                                    cellImageText.ID = "tdImageText" + s;
                                    cellImageText.Attributes.Add("align", "left");
                                    TableCell cellImage = new TableCell();
                                    cellImage.ID = "tdImage" + s;
                                    cellImage.Attributes.Add("align", "right");
                                    TableCell cellImagefile = new TableCell();
                                    cellImagefile.ID = "tdImagefile" + s;
                                    cellImagefile.Attributes.Add("align", "left");

                                    Label lblText = new Label();
                                    lblText.ID = "lblText" + s;
                                    lblText.Text = "Small";
                                    cellImageText.Controls.Add(lblText);
                                    rowImage.Cells.Add(cellImageText);

                                    Image imagefile = new Image();
                                    imagefile.ID = "imagefile" + k;
                                    imagefile.Height = 100;
                                    imagefile.Width = 100;
                                    imagefile.ImageUrl = node2.InnerText.Trim();
                                    cellImage.Controls.Add(imagefile);
                                    rowImage.Cells.Add(cellImage);

                                    FileUpload imagefileupload = new FileUpload();
                                    imagefileupload.ID = "imagefileupload" + k;
                                    imagefileupload.Width = 220;
                                    cellImagefile.Controls.Add(imagefileupload);
                                    rowImage.Cells.Add(cellImagefile);

                                    table.Rows.Add(rowImage);
                                    panel1.Controls.Add(table);
                                }
                            }
                            if (pageid == "p1" || pageid == "p2" || pageid == "p3" || pageid == "p5")
                            {
                                TableRow rowImage = new TableRow();
                                rowImage.ID = "trImage" + s;
                                TableCell cellImage = new TableCell();
                                cellImage.ID = "tdImage" + s;
                                cellImage.Attributes.Add("align", "right");
                                TableCell cellImagefile = new TableCell();
                                cellImagefile.ID = "tdImagefile" + s;
                                cellImagefile.Attributes.Add("align", "left");

                                Image imagefile = new Image();
                                imagefile.ID = "imagefile" + k;
                                imagefile.Height = 100;
                                imagefile.Width = 100;
                                imagefile.ImageUrl = node2.InnerText.Trim();
                                cellImage.Controls.Add(imagefile);
                                rowImage.Cells.Add(cellImage);

                                FileUpload imagefileupload = new FileUpload();
                                imagefileupload.ID = "imagefileupload" + k;
                                imagefileupload.Width = 220;
                                cellImagefile.Controls.Add(imagefileupload);
                                rowImage.Cells.Add(cellImagefile);

                                table.Rows.Add(rowImage);
                                panel1.Controls.Add(table);

                            }
                        }
                        s++;
                        k++;
                    }
                }
            }
            Table table2 = new Table();
            table2.ID = "table2";
            table2.Attributes.Add("align", "center");
            table2.Style.Value = "width:100%";
            TableRow row_btn2 = new TableRow(); ;
            TableCell cell_btn2 = new TableCell(); ;
            row_btn2.ID = "trbtn2";
            cell_btn2.ID = "tdbtn2";

            Button btnsubmit2 = new Button();
            btnsubmit2.ID = "btn_submit2";
            btnsubmit2.Text = "Submit";
            btnsubmit2.Style.Value = "cursor:pointer;";
            btnsubmit2.Style.Value = "width:100px";
            btnsubmit2.Click += new EventHandler(btnSubmit_Click);

            Button btncancel2 = new Button();
            btncancel2.ID = "btn_cancel2";
            btncancel2.Text = "Cancel";
            btncancel2.Style.Value = "cursor:pointer;";
            btncancel2.Style.Value = "width:100px";
            btncancel2.Click += new EventHandler(btnCancel_Click);

            cell_btn2.Controls.Add(btnsubmit2);
            cell_btn2.Controls.Add(btncancel2);
            row_btn2.Cells.Add(cell_btn2);
            table2.Rows.Add(row_btn2);
            panel1.Controls.Add(table2);

        }
        catch { }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        try
        {
            WriteToXml();
           
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(Server.MapPath("xml/tfile_main.xml"));
            XmlNamespaceManager nsm = new XmlNamespaceManager(new NameTable());
            XmlNodeList nodelist1 = xmlDoc.SelectNodes("root/*", nsm);

            foreach (XmlNode node1 in nodelist1)
            {
                if (node1.Attributes[0].Value.Equals(pageid))
                {
                    XmlNodeList nodelist2 = node1.ChildNodes;
                    int s = 0;
                    int k = 0;

                    foreach (XmlNode node2 in nodelist2)
                    {
                        if (node2.Name.ToLower().Equals("txt"))
                        {
                            FreeTextBox ftbtextbox = (FreeTextBox)FindControl("txttext" + s);
                            if (Request.Browser.Browser.ToLower().Equals("ie"))
                            {
                                if (Request.Browser.MajorVersion < 9)
                                {
                                    TextValidation TV = new TextValidation();
                                    node2.InnerText = TV.TextValid(ftbtextbox.Text);
                                }
                                else
                                {
                                    node2.InnerText = ftbtextbox.Text;
                                }
                            }
                            else
                            {
                                node2.InnerText = ftbtextbox.Text;
                            }
                        }
                        else if (node2.Name.ToLower().Equals("t"))
                        {
                            TextBox textbox = (TextBox)FindControl("txtstext" + s);
                            node2.InnerText = textbox.Text;
                        }
                        else if (node2.Name.ToLower().Contains("pdf"))
                        {
                            Label pdffile = (Label)FindControl("pdffile" + k);
                            FileUpload pdffileupload = (FileUpload)FindControl("pdffileupload" + k);
                            if (!pdffileupload.FileName.Equals(""))
                            {
                                if (File.Exists(Server.MapPath("pdf/" + pdffileupload.FileName)))
                                {
                                    string scriptStr = "<script type=text/javascript>alert('pdf(s) " + pdffileupload.FileName + " already Exist.Please rename the Pdf file.');</script>";
                                    ClientScript.RegisterStartupScript(this.GetType(), "Pop", scriptStr);
                                    return;
                                }
                                pdffileupload.PostedFile.SaveAs(MapPath("pdf/") + pdffileupload.FileName);
                                pdffile.Text = pdffileupload.FileName;
                            }
                            node2.InnerText = pdffile.Text;
                        }
                        else
                        {
                            if (pageid == "p0")
                            {
                                XmlNodeList nodelist3 = node2.ChildNodes;
                                foreach (XmlNode node3 in nodelist3)
                                {
                                    Image imagefile = (Image)FindControl("imagefile" + k);
                                    FileUpload imagefileupload = (FileUpload)FindControl("imagefileupload" + k);
                                    string path;
                                    path = "images/";
                                    if (!imagefileupload.FileName.Equals(""))
                                    {
                                        //Code For Checking extension
                                        string fileName = imagefileupload.FileName;
                                        string fileExtension = Path.GetExtension(fileName);
                                        string[] validFileExtensions = new string[] { ".gif", ".png", ".tif", ".bmp", ".jpg", ".jpeg" };
                                        bool flag = false;
                                        foreach (string extension in validFileExtensions)
                                        {
                                            if (fileExtension == extension)
                                                flag = true;
                                        }
                                        if (flag == false)
                                        {
                                            string scriptStr = "<script type=text/javascript>alert('File with Extension \"" + fileExtension + "\" are not allowed. Please upload the images with following extensions only:\\n\\n.gif, .jpg, .jpeg, .png, .tif, .bmp');</script>";
                                            ClientScript.RegisterStartupScript(this.GetType(), "Pop", scriptStr);
                                            return;
                                        }
                                        else
                                        {
                                            if (File.Exists(Server.MapPath("OriginalImage/" + imagefileupload.FileName)))
                                            {
                                                string scriptStr = "<script type=text/javascript>alert('Image(s) " + imagefileupload.FileName + " already Exist.Please rename the selected image.');</script>";
                                                ClientScript.RegisterStartupScript(this.GetType(), "Pop", scriptStr);
                                                return;
                                            }
                                            if (File.Exists(Server.MapPath(path + imagefileupload.FileName)))
                                            {
                                                string scriptStr = "<script type=text/javascript>alert('Image(s) " + imagefileupload.FileName + " already Exist.Please rename the selected image.');</script>";
                                                ClientScript.RegisterStartupScript(this.GetType(), "Pop", scriptStr);
                                                return;
                                            }
                                            String fname1 = imagefileupload.FileName;
                                            imagefileupload.PostedFile.SaveAs(MapPath("OriginalImage/") + fname1);
                                            string imagepath, thumbnailpath;
                                            int new_height = 0, new_width = 0;
                                            imagepath = "OriginalImage/" + fname1;
                                            System.Drawing.Image simple_image;
                                            simple_image = System.Drawing.Image.FromFile(Server.MapPath(imagepath));
                                            new_height = 469;
                                            new_width = 974;
                                            System.Drawing.Image thumb_image;
                                            thumb_image = simple_image.GetThumbnailImage(new_width, new_height, null, IntPtr.Zero);
                                            thumbnailpath = "images/" + fname1;
                                            thumb_image.Save(Server.MapPath(thumbnailpath), ImageFormat.Jpeg);
                                            imagefile.ImageUrl = "images/" + fname1;

                                        }
                                    }
                                    node3.InnerText = imagefile.ImageUrl;
                                }
                                
                            }
                            if (pageid == "p4")
                            {
                                if (node2.Name.ToLower().Contains("imgb"))
                                {
                                    Image imagefile = (Image)FindControl("imagefile" + k);
                                    FileUpload imagefileupload = (FileUpload)FindControl("imagefileupload" + k);
                                    string path;
                                    path = "images/gallery_page/";
                                    if (!imagefileupload.FileName.Equals(""))
                                    {
                                        //Code For Checking extension
                                        string fileName = imagefileupload.FileName;
                                        string fileExtension = Path.GetExtension(fileName);
                                        string[] validFileExtensions = new string[] { ".gif", ".png", ".tif", ".bmp", ".jpg", ".jpeg" };
                                        bool flag = false;
                                        foreach (string extension in validFileExtensions)
                                        {
                                            if (fileExtension == extension)
                                                flag = true;
                                        }
                                        if (flag == false)
                                        {
                                            string scriptStr = "<script type=text/javascript>alert('File with Extension \"" + fileExtension + "\" are not allowed. Please upload the images with following extensions only:\\n\\n.gif, .jpg, .jpeg, .png, .tif, .bmp');</script>";
                                            ClientScript.RegisterStartupScript(this.GetType(), "Pop", scriptStr);
                                            return;
                                        }
                                        else
                                        {
                                            if (File.Exists(Server.MapPath(path + imagefileupload.FileName)))
                                            {
                                                string scriptStr = "<script type=text/javascript>alert('Image(s) " + imagefileupload.FileName + " already Exist.Please rename the selected image.');</script>";
                                                ClientScript.RegisterStartupScript(this.GetType(), "Pop", scriptStr);
                                                return;
                                            }
                                            imagefileupload.PostedFile.SaveAs(MapPath(path + imagefileupload.FileName));
                                            imagefile.ImageUrl = path + imagefileupload.FileName;
                                        }
                                    }
                                    node2.InnerText = imagefile.ImageUrl;
                                }
                                if (node2.Name.ToLower().Contains("imgs"))
                                {
                                    Image imagefile = (Image)FindControl("imagefile" + k);
                                    FileUpload imagefileupload = (FileUpload)FindControl("imagefileupload" + k);
                                    string path;
                                    path = "images/gallery_page/";
                                    if (!imagefileupload.FileName.Equals(""))
                                    {
                                        //Code For Checking extension
                                        string fileName = imagefileupload.FileName;
                                        string fileExtension = Path.GetExtension(fileName);
                                        string[] validFileExtensions = new string[] { ".gif", ".png", ".tif", ".bmp", ".jpg", ".jpeg" };
                                        bool flag = false;
                                        foreach (string extension in validFileExtensions)
                                        {
                                            if (fileExtension == extension)
                                                flag = true;
                                        }
                                        if (flag == false)
                                        {
                                            string scriptStr = "<script type=text/javascript>alert('File with Extension \"" + fileExtension + "\" are not allowed. Please upload the images with following extensions only:\\n\\n.gif, .jpg, .jpeg, .png, .tif, .bmp');</script>";
                                            ClientScript.RegisterStartupScript(this.GetType(), "Pop", scriptStr);
                                            return;
                                        }
                                        else
                                        {
                                            if (File.Exists(Server.MapPath(path + imagefileupload.FileName)))
                                            {
                                                string scriptStr = "<script type=text/javascript>alert('Image(s) " + imagefileupload.FileName + " already Exist.Please rename the selected image.');</script>";
                                                ClientScript.RegisterStartupScript(this.GetType(), "Pop", scriptStr);
                                                return;
                                            }
                                            imagefileupload.PostedFile.SaveAs(MapPath(path + imagefileupload.FileName));
                                            imagefile.ImageUrl = path + imagefileupload.FileName;
                                        }
                                    }
                                    node2.InnerText = imagefile.ImageUrl;
                                }
                            }
                            if (pageid == "p1" || pageid == "p2" || pageid == "p3" || pageid == "p5")
                            {
                                Image imagefile = (Image)FindControl("imagefile" + k);
                                FileUpload imagefileupload = (FileUpload)FindControl("imagefileupload" + k);
                                string path;
                                path = "images/";
                                if (!imagefileupload.FileName.Equals(""))
                                {
                                    //Code For Checking extension
                                    string fileName = imagefileupload.FileName;
                                    string fileExtension = Path.GetExtension(fileName);
                                    string[] validFileExtensions = new string[] { ".gif", ".png", ".tif", ".bmp", ".jpg", ".jpeg" };
                                    bool flag = false;
                                    foreach (string extension in validFileExtensions)
                                    {
                                        if (fileExtension == extension)
                                            flag = true;
                                    }
                                    if (flag == false)
                                    {
                                        string scriptStr = "<script type=text/javascript>alert('File with Extension \"" + fileExtension + "\" are not allowed. Please upload the images with following extensions only:\\n\\n.gif, .jpg, .jpeg, .png, .tif, .bmp');</script>";
                                        ClientScript.RegisterStartupScript(this.GetType(), "Pop", scriptStr);
                                        return;
                                    }
                                    else
                                    {
                                        if (File.Exists(Server.MapPath(path + imagefileupload.FileName)))
                                        {
                                            string scriptStr = "<script type=text/javascript>alert('Image(s) " + imagefileupload.FileName + " already Exist.Please rename the selected image.');</script>";
                                            ClientScript.RegisterStartupScript(this.GetType(), "Pop", scriptStr);
                                            return;
                                        }
                                        imagefileupload.PostedFile.SaveAs(MapPath(path + imagefileupload.FileName));
                                        imagefile.ImageUrl = path + imagefileupload.FileName;
                                    }
                                }
                                node2.InnerText = imagefile.ImageUrl;
                            }
                        }
                        k++;
                        s++;
                    }
                }
            }
            xmlDoc.Save(Server.MapPath("xml/tfile_main.xml"));
            xmlDoc.Load(Server.MapPath("xml/tfile_main.xml"));
            XmlNodeList nodeList = xmlDoc.SelectNodes("root/*", nsm);
            Response.Redirect(Request.UrlReferrer.AbsoluteUri.ToString());
        }
        catch
        {
        }
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        try
        {
            Response.Redirect("EditMenu.aspx");
        }
        catch
        {
        }
    }
    protected void lnklogout_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Response.Redirect("Default.aspx");
    }
    void WriteToXml()
    {
        sample();
    }
    void sample()
    {
        string xmlfile = "";
        string xmlfilePath = "";
        string prexmlfile = Server.MapPath("xml/tfile_mainprev.xml");
        XmlDocument xdoc1 = new XmlDocument();
        XmlDocument xdoc2 = new XmlDocument();

        if (xmlfile.Trim().Length <= 0)
        {
            xmlfile = Server.MapPath("xml/tfile_main.xml");
        }

        string xmlContent = "";
        if (!File.Exists(prexmlfile.Trim()))
        {
            StreamWriter sw = new StreamWriter(prexmlfile.Trim(), false, System.Text.Encoding.Default);

            xdoc1.Load(xmlfilePath.Trim());
            xmlContent = xdoc1.InnerXml;

            sw.Write(xmlContent.Trim());
            sw.Close();
        }
        else
        {
            xdoc1.Load(xmlfile.Trim());
            xmlContent = xdoc1.InnerXml;
            xdoc2.Load(prexmlfile.Trim());
            xdoc2.InnerXml = xmlContent;
            xdoc1.Save(xmlfile.Trim());
            xdoc2.Save(prexmlfile.Trim());
        }
    }
    protected void btnUndo_Click(object sender, EventArgs e)
    {
        try
        {
            undosample();
            string url = "";
            url = "edit.aspx?pid=" + pageid + "&url=" + pageurl;
            Response.Redirect(url);
        }
        catch { }     
    } 
    void undosample()
    {
        string prexmlfile = "";
        string xmlfilePath = "";
        prexmlfile = Server.MapPath("xml/tfile_mainprev.xml");
        xmlfilePath = Server.MapPath("xml/tfile_main.xml");

        XmlDocument xdoc = new XmlDocument();
        XmlDocument xdoc1 = new XmlDocument();

        if (!File.Exists(prexmlfile.Trim()))
        {
            string xmlContent = "";
            StreamWriter sw = new StreamWriter(prexmlfile.Trim(), false, System.Text.Encoding.Default);
            xdoc.Load(xmlfilePath.Trim());
            xmlContent = xdoc.InnerXml;
            sw.Write(xmlContent.Trim());
            sw.Close();
        }
        else
        {
            xdoc1.Load(prexmlfile.Trim());
            string oldContent = xdoc1.InnerXml;
            xdoc.Load(xmlfilePath.Trim());
            xdoc.InnerXml = oldContent;

            xdoc.Save(xmlfilePath.Trim());
            xdoc1.Save(prexmlfile.Trim());
        } 
    }
}


