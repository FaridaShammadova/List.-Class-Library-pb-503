using PB503Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List__Class_Library
{
    public class Book
    {
        private readonly string? bookName;
        private readonly int number;
        private string _code;

        public string Name { get; set; }
        public string AuthorName { get; set; }
        public int PageCount { get; set; }
        public string Code { get; set; }

        public Book(string name, string authorName, int pageCount)
        {
            Name = name;
            AuthorName = authorName;
            PageCount = pageCount;
            _code = Helper.CreateBookCode("Python", 01);
        }
    }
}
