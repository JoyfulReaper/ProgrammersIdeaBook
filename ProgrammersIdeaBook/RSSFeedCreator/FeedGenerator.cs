using RSSFeedCreator.Models;
using System;
using System.Collections.Generic;
using System.Xml;

//TODO: Commented out lines will need additional proccessing

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
                    WriteAttributeStringIfPresent(writer, "copyright", c.Copyright);
                    WriteAttributeStringIfPresent(writer, "language", c.Language);
                    WriteAttributeStringIfPresent(writer, "webmaster", c.Webmaster);
                    WriteAttributeStringIfPresent(writer, "mangingEditor", c.ManagingEditor);
                    WriteAttributeStringIfPresent(writer, "webMaster", c.Webmaster);
                    WriteAttributeStringIfPresent(writer, "category", c.Category);
                    WriteAttributeStringIfPresent(writer, "generator", c.Generator);
                    WriteAttributeStringIfPresent(writer, "docs", c.Docs);
                    WriteAttributeStringIfPresent(writer, "cloud", c.Cloud);
                    WriteTtlAttributeStringIfPositive(writer, c.Ttl);
                    //WriteAttributeStringIfPresent(writer, "image", c.Image);
                    WriteAttributeStringIfPresent(writer, "lastBuildDate", DateTime.Now.ToString("r"));
                    //WriteAttributeStringIfPresent(writer, "pubDate", c.PubDate.ToString("r"));

                    foreach (Item i in c.Items)
                    {
                        writer.WriteStartElement("item");
                        writer.WriteElementString("title", i.Title);
                        writer.WriteElementString("link", i.Link);
                        writer.WriteElementString("description", i.Description);
                        WriteAttributeStringIfPresent(writer, "author", i.Author);
                        WriteAttributeStringIfPresent(writer, "category", i.Category);
                        WriteAttributeStringIfPresent(writer, "comments", i.Comments);
                        WriteAttributeStringIfPresent(writer, "source", i.Source);
                        //WriteAttributeStringIfPresent(writer, "enclosure", i.Enclosure);
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

        private void WriteTtlAttributeStringIfPositive(XmlWriter writer, int value)
        {
            if (value > 0)
            {
                writer.WriteElementString("ttl", value.ToString());
            }
        }

        private void WriteAttributeStringIfPresent(XmlWriter writer, string name, string value)
        {
            if (!String.IsNullOrWhiteSpace(value))
            {
                writer.WriteElementString(name, value);
            }
        }
    }
}
