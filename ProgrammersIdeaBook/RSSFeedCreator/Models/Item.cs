using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSSFeedCreator.Models
{
    public class Item
    {
        public string Title { get; set; } // Required
        public string Description { get; set; } // Required RSS 2.0
        public string Link { get; set; } // Required
        public string Author { get; set; } // Required Atom
        public string Guid { get; set; } // Required Atom
        public string Category { get; set; }
        public string Comments { get; set; }
        public int MyProperty { get; set; }
        public DateTimeOffset PubDate { get; set; } // Sat, 07 Sep 2002 00:00:01 GMT
        public string Source { get; set; }
        public string Enclosure { get; set; }
    }
}
