using RSSFeedCreator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace RSSFeedCreator
{
    public class FeedGenerator
    {
        public void GenerateXML(List<Channel> channels)
        {
            using (XmlWriter writer = XmlWriter.Create("rss.xml"))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("rss");
                writer.WriteAttributeString("version", "2.0");
                writer.WriteAttributeString("xmlns", "atom", null, "http://www.w3.org/2005/Atom");

                writer.WriteStartElement("channel");
                foreach(Channel c in channels)
                {
                    writer.WriteElementString("title", c.Title);
                    writer.WriteElementString("link", c.Link);
                    writer.WriteElementString("description", c.Description);

                    foreach(Item i in c.Items)
                    {
                        writer.WriteStartElement("item");
                        writer.WriteElementString("title", i.Title);
                        writer.WriteElementString("link", i.Link);
                        writer.WriteElementString("description", i.Description);
                        writer.WriteElementString("guid", i.Link);
                        writer.WriteEndElement();
                    }
                }

                writer.WriteEndElement();
                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Flush();
                writer.Close();
            }
        }
    }
}
