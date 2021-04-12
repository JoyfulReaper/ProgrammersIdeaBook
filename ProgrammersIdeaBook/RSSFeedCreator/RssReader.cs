using System;
using System.Xml;
using System.Linq;
using System.Text;

namespace RSSFeedCreator
{
    // Ignore this for testing...
    public class RssReader
    {
        public void ReadXml()
        {
            using (XmlReader reader = XmlReader.Create("rss.xml"))
            {
                reader.MoveToContent();

                while(reader.Read())
                {
                    switch (reader.NodeType)
                    {
                        case XmlNodeType.Element when reader.Name == "channel":
                            Console.WriteLine(reader.Name);
                            break;
                        case XmlNodeType.Text:
                            Console.WriteLine(reader.Value);
                            break;
                        default:
                            break;
                    }
                }
            }    
        }
    }
}
