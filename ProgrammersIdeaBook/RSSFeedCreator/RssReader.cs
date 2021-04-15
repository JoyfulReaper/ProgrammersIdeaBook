using System;
using System.Xml;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using RSSFeedCreator.Models;
using System.IO;

namespace RSSFeedCreator
{
    // Ignore this for testing...
    public class RssReader
    {
        public Rss ReadXml()
        {
            FileStream fs;
            XmlSerializer xs;
            try
            {
                xs = new XmlSerializer(typeof(Rss));
                fs = new FileStream(@"rss2.xml", FileMode.Open);
            }
            catch (Exception e)
            {
                // TODO: just for testing
                return null;
            }

            var test = (Rss)xs.Deserialize(fs);
            fs.Close();

            return test;
        }
    }
}
