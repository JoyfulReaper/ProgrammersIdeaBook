/*
MIT License

Copyright(c) 2021 Kyle Givler
https://github.com/JoyfulReaper

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/

using RSSFeedCreator.Models;
using System;
using System.Xml;

//TODO: Commented out lines will need additional proccessing

namespace RSSFeedCreator
{
    public class FeedGenerator
    {
        public void GenerateXML(Rss rss)
        {
            using (XmlWriter writer = XmlWriter.Create("rss.xml"))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("rss");
                writer.WriteAttributeString("version", "2.0");
                writer.WriteAttributeString("xmlns", "atom", null, "http://www.w3.org/2005/Atom");

                writer.WriteStartElement("channel");
                writer.WriteElementString("title", rss.Channel.Title);
                writer.WriteElementString("link", rss.Channel.Link);
                writer.WriteElementString("description", rss.Channel.Description);
                WriteAttributeStringIfPresent(writer, "copyright", rss.Channel.Copyright);
                WriteAttributeStringIfPresent(writer, "language", rss.Channel.Language);
                WriteAttributeStringIfPresent(writer, "managingEditor", rss.Channel.ManagingEditor);
                WriteAttributeStringIfPresent(writer, "webMaster", rss.Channel.WebMaster);
                WriteAttributeStringIfPresent(writer, "category", rss.Channel.Category);
                WriteAttributeStringIfPresent(writer, "generator", rss.Channel.Generator);
                WriteAttributeStringIfPresent(writer, "docs", rss.Channel.Docs);
                WriteAttributeStringIfPresent(writer, "cloud", rss.Channel.Cloud);
                WriteAttributeStringIfPresent(writer, "ttl", rss.Channel.Ttl);
                //WriteAttributeStringIfPresent(writer, "image", channel.Image);
                WriteAttributeStringIfPresent(writer, "lastBuildDate", DateTime.Now.ToString("r"));
                WriteAttributeStringIfPresent(writer, "skipDays", rss.Channel.SkipDays);
                WriteAttributeStringIfPresent(writer, "skipHours", rss.Channel.SkipHours);
                //WriteAttributeStringIfPresent(writer, "pubDate", c.PubDate.ToString("r"));

                foreach (Item i in rss.Channel.Items)
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