using System.Collections.Generic;
using System.Configuration;
using System.Web;
using System.Web.Http;
using System.Web.Services;
using System.Web.SessionState;
using System.Xml;
using System.Xml.Linq;

namespace POCXmlReader.XMLManager
{
  public class XMLController : ApiController
  {

    public IEnumerable<Record> GetXElements()
    {
      var recordList = new List<Record>();
      var fibNumbers = new List<int> { 1, 2, 3 };
      //System.Threading.Thread.Sleep(5000);
      foreach (int doc in fibNumbers)
      {
        var filePath = ConfigurationManager.AppSettings["Document"+ doc];

        using (XmlReader reader = XmlReader.Create(filePath))
        {
          reader.MoveToContent();
          // Parse the file and return each of the child_node
          while (reader.Read())
          {
            if (reader.NodeType == XmlNodeType.Element && reader.Name == "record")
            {
              XElement el = XNode.ReadFrom(reader) as XElement;
              if (el != null)
              {
                var record = new Record();

                record.FileNumber = el.Element("filenumber").Value;
                record.CountryOrigin = el.Element("countryorigin").Value;
                record.EntryPort = el.Element("entryport").Value;
                recordList.Add(record);
              }
            }
          }
          //if (HttpContext.Current == null || HttpContext.Current.Session == null || HttpContext.Current.Session["Test"] == null) {
          //  var test = HttpContext.Current.Session["Test"];
          //}
          
        }

      }

      return recordList;
    }

    // GET api/<controller>/5
    public string Get(int id)
    {
      return "value";
    }

    // POST api/<controller>
    public void Post([FromBody]string value)
    {
    }

    // PUT api/<controller>/5
    public void Put(int id, [FromBody]string value)
    {
    }

    // DELETE api/<controller>/5
    public void Delete(int id)
    {
    }
  }
}
