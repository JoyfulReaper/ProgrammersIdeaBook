using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSSFeedCreator.Models
{
    public class Channel
    {
        public string Title { get; set; } // Required
        public string Description { get; set; } // Required RSS 2.0
        public string Link { get; set; } // Required
        public string Copyright { get; set; }
        public string Language { get; set; } // en-us
        public string Webmaster { get; set; }
        public string ManagingEditor { get; set; }
        public DateTimeOffset PubDate { get; set; } // Sat, 07 Sep 2002 00:00:01 GMT
        public DateTimeOffset lastBuildDate { get; set; } // Required Atom
        public string Category { get; set; }
        public string Generator { get; } = "RSSFeedCreator https://github.com/JoyfulReaper/ProgrammersIdeaBook";
        public string Docs { get; } = "http://blogs.law.harvard.edu/tech/rss";
        public string Cloud { get; set; }
        public int Ttl { get; set; }
        public string Image { get; set; }
        public List<Item> MyProperty { get; set; } = new List<Item>();
    }
}
