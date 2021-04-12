using RSSFeedCreator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RSSFeedCreator
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Channel channel = new Channel()
            //{
            //    Title = "A Channel",
            //    Description = "A Channel desc",
            //    Link = "https://github.com/JoyfulReaper"
            //};

            //Item item = new Item()
            //{
            //    Title = "An Item",
            //    Link = "https://example.com",
            //    Description = "This is an example item!"
            //};

            //Item item2 = new Item()
            //{
            //    Title = "Another Item",
            //    Link = "https://sample.com",
            //    Description = "This is another example item!"
            //};

            //channel.Items.Add(item);
            //channel.Items.Add(item2);

            //FeedGenerator feed = new FeedGenerator();
            //feed.GenerateXML(new List<Channel> { channel });

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
}
