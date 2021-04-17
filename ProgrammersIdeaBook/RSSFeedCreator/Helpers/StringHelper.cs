using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSSFeedCreator.Helpers
{
    public static class StringHelper
    {
        public static string AssignNullIfEmpty(string value)
        {
            if (String.IsNullOrWhiteSpace(value))
            {
                return null;
            }

            return value;
        }
    }
}
