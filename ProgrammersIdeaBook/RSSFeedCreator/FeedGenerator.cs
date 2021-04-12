using RSSFeedCreator.Models;
using System;
using System.Xml;

//TODO: Commented out lines will need additional proccessing

namespace RSSFeedCreator
{
    public class FeedGenerator
    {
        public void GenerateXML(Channel channel)
        {
            using (XmlWriter writer = XmlWriter.Create("rss.xml"))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("rss");
                writer.WriteAttributeString("version", "2.0");
                writer.WriteAttributeString("xmlns", "atom", null, "http://www.w3.org/2005/Atom");

                writer.WriteStartElement("channel");

                writer.WriteElementString("title", channel.Title);
                writer.WriteElementString("link", channel.Link);
                writer.WriteElementString("description", channel.Description);
                WriteAttributeStringIfPresent(writer, "copyright", channel.Copyright);
                WriteAttributeStringIfPresent(writer, "language", channel.Language);
                WriteAttributeStringIfPresent(writer, "managingEditor", channel.ManagingEditor);
                WriteAttributeStringIfPresent(writer, "webMaster", channel.Webmaster);
                WriteAttributeStringIfPresent(writer, "category", channel.Category);
                WriteAttributeStringIfPresent(writer, "generator", channel.Generator);
                WriteAttributeStringIfPresent(writer, "docs", channel.Docs);
                WriteAttributeStringIfPresent(writer, "cloud", channel.Cloud);
                WriteTtlAttributeStringIfPositive(writer, channel.Ttl);
                //WriteAttributeStringIfPresent(writer, "image", channel.Image);
                WriteAttributeStringIfPresent(writer, "lastBuildDate", DateTime.Now.ToString("r"));
                //WriteAttributeStringIfPresent(writer, "pubDate", c.PubDate.ToString("r"));

                foreach (Item i in channel.Items)
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