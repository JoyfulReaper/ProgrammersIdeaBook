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

using System;
using System.Collections.Generic;

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
        public List<Item> Items { get; set; } = new List<Item>();
    }
}
