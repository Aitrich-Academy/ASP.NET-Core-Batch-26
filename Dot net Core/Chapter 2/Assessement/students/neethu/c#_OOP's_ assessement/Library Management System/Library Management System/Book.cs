using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    public class Book:LibraryItem
    {
        public string Author { get; set; }
        private string Type1 = "Book";

        public Book(string itemid, string title,bool isavailable, string author) : base(itemid, title,isavailable)
        {
            Author = author;
        }
        public override string GetItemType(LibraryItem item)
        {
            return Type1;
        }
    }
}
