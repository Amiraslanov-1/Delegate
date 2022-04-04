using System;
using System.Collections.Generic;
using System.Text;

namespace Delegate
{
     class Book
    {
        static int _no;
        public int No { get; }
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public double BookPrice { get; set; }
        public Genre Genre { get; set; }
        public Book()
        {
            _no++;
            No = _no;
        }

    }

    public  enum Genre
    {
        Action=1,
        Classics,
        Detective,
        Fantasy,
        Adventure
    }
}
