using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;
using System.Xml.Linq;

namespace POCXmlReader.XMLManager
{
    public class XMLManagerClass
    {
        private string _filePath;

        public XMLManagerClass(string filePath)
        {
            this._filePath = filePath;
        }

        public IEnumerable<XElement> XElements()
        {
            using (XmlReader reader = XmlReader.Create(_filePath))
            {
                reader.MoveToContent();
                // Parse the file and return each of the child_node
                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element && reader.Name == "record")
                    {
                        XElement el = XNode.ReadFrom(reader) as XElement;
                        if (el != null)
                            yield return el;

                    }
                }


            }
        }
    }
}