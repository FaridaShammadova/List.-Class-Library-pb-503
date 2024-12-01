using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PB503Helper
{
    public static class Helper
    {
        public static string CreateBookCode(string bookName, int number)
        {
            return $"{bookName.Substring(0, 2).ToUpper()}+{number.ToString()}";
        }
    }
}
