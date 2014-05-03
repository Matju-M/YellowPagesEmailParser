using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using HtmlAgilityPack;
using System.Web.Script.Serialization;
using ExtensionMethods;

namespace YellowPagesEmailParser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private List<EmailModel> GetAllItems(HtmlAgilityPack.HtmlDocument doc, String URL)
        {
            List<EmailModel> lstEmails = new List<EmailModel>();
            //HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            //doc.LoadHtml(data);

            HtmlNode headerNode = doc.DocumentNode.SelectSingleNode("//div[@class='yellowTitleWrapper']");
            String headerName = headerNode.Descendants("h2").FirstOrDefault().InnerHtml;
            String headerID = headerNode.Descendants("Input").Where(inp => inp.Id.Equals("hdnHeadingID")).First().GetAttributeValue("value", 0).ToString();
            String headerSearchTypeID = headerNode.Descendants("Input").Where(inp => inp.Id.Equals("hdnSearchTypeID")).First().GetAttributeValue("value", 0).ToString();
            String headerSearchModeID = headerNode.Descendants("Input").Where(inp => inp.Id.Equals("hdnSearchModeID")).First().GetAttributeValue("value", 0).ToString();

            headerName = headerName.Replace(' ', '+');


            var impDiv = doc.DocumentNode
                         .SelectNodes("//div[@class='listingWrapper ']");


            for (int f = 0; f < impDiv.Count; f++)
            {
                var currHeader = impDiv[f].Descendants("div")
                                .Where(div => div.GetAttributeValue("class", "").Contains("listingHeadClientName")).First().InnerHtml;

                currHeader = currHeader.Replace(' ', '+');

                //here we need to detemine only the items that have the email
                IEnumerable<HtmlNode> currfooter = impDiv[f].Descendants("div")
                                 .Where(div => div.GetAttributeValue("class", "").Contains("listingFooter"));


                bool hasEmail = false;

                foreach (HtmlNode node in currfooter.First().ChildNodes)
                {
                    if (node.InnerHtml.Contains("email")) hasEmail = true;
                }

                if (hasEmail)
                {
                    String[] attributes = impDiv[f].Id.Split('_');


                    using (var client = new WebClient())
                    {

                        StringBuilder sb = new StringBuilder();
                        sb.Append("accountInstanceID=").Append(attributes[1]);
                        sb.Append("&");
                        sb.Append("headingID=").Append(headerID);
                        sb.Append("&");
                        sb.Append("headingName=").Append(headerName);
                        sb.Append("&");
                        sb.Append("clientName=").Append(currHeader);
                        sb.Append("&");
                        sb.Append("websiteButtonID=").Append("2");
                        sb.Append("&");
                        sb.Append("searchModeID=").Append(headerSearchModeID);
                        sb.Append("&");
                        sb.Append("searchTypeID=").Append(headerSearchTypeID);

                        JavaScriptSerializer ser = new JavaScriptSerializer();

                        HttpWebRequest req = (HttpWebRequest)WebRequest.Create("http://www.yellowpages.com.mt/Listing/GetButtonDetails");
                        req.Method = "POST";
                        req.ContentType = "application/x-www-form-urlencoded; charset=UTF-8";
                        req.Referer = URL;
                        req.Accept = "*/*";
                        req.ContentLength = sb.Length;
                        req.UserAgent = "Mozilla/5.0 (Windows NT 6.1; Trident/7.0; rv:11.0) like Gecko";

                        using (var streamWriter = new StreamWriter(req.GetRequestStream()))
                        {
                            streamWriter.Write(sb.ToString());
                            streamWriter.Flush();
                            streamWriter.Close();

                            var httpResponse = (HttpWebResponse)req.GetResponse();
                            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                            {
                                var result = streamReader.ReadToEnd();
                                //MessageBox.Show(result);

                                List<EmailModel> lst = new JavaScriptSerializer().Deserialize<List<EmailModel>>(result);
                                lst.First().Caption = currHeader.Replace('+', ' ');
                                lstEmails.Add(lst.First());

                            }
                        }


                    }
                }

            }
            return lstEmails;
        }



        private void btnStartParse_Click(object sender, EventArgs e)
        {
            // String URL = @"http://www.yellowpages.com.mt/Malta-Search/Chaffeur-Driven/he/Chauffeur-Service/0/100-in-Malta-Gozo.aspx";
            String URL = txtInput.Text.Trim();

            gridviewMain.DataSource = null;

            HtmlWeb ws = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument rd = ws.Load(URL);

            List<EmailModel> lst = GetAllItems(rd, URL);

            gridviewMain.DataSource = lst;

        }

        private void modelBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInput.Text = String.Empty;
        }
    }
}
