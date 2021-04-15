using System.Xml.Serialization;
using System.IO;

namespace RSSFeedCreator.Helpers
{
    public static class XmlDeserializer
    {
        public static T DeserializeXml<T>(string xmlFile)
        {
            XmlSerializer xs = new XmlSerializer(typeof(T));
            FileStream fs = new FileStream(xmlFile, FileMode.Open);


            var output = (T)xs.Deserialize(fs);
            fs.Close();

            return output;
        }
    }
}
