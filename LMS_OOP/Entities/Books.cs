using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_OOP.Entities
{
    internal class Books
    {
        internal string title { get; private set; }
        internal double basicPrice { get; private set; }
        internal BooksCategory _category { get; private set; }

        internal Books (string title, double basicPrice ,BooksCategory category)
        {
            this.title = title;
            this.basicPrice = basicPrice;
            _category=category;
        }
    }
}
