using POCXmlReader.XMLManager;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace POCXmlReader
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void OnClickAction(object sender, EventArgs e)
        {
            //Stopwatch sw = new Stopwatch();
            //sw.Start();

            //var reader = new XMLManagerClass("http://xmlreader.com/Files/xmltest.xml");

            //int i = 0;
            //foreach (XElement element in reader.XElements())
            //{
            //    i++;
            //}

            //sw.Stop();
            //lblSeconds.Text = sw.Elapsed.TotalSeconds.ToString();
            //lblTotalElements.Text = i.ToString();
        }

    [WebMethod(EnableSession = true)]
    [ScriptMethod(UseHttpGet = true)]
    public string TestXMLReader()
        {
            //Stopwatch sw = new Stopwatch();
            //sw.Start();

            //var reader = new XMLManagerClass("http://xmlreader.com/Files/xmltest.xml");

            //int i = 0;
            //foreach (XElement element in reader.XElements())
            //{
            //    i++;
            //}

            //sw.Stop();
            ////lblSeconds.Text = sw.Elapsed.TotalSeconds.ToString();
            ////lblTotalElements.Text = i.ToString();

            //Dictionary<string, string> name = new Dictionary<string, string>();

            //name.Add("1", "Sourav Kayal");
            //name.Add("2", "Ram mishra");

            return "test";
        }
    }
}
