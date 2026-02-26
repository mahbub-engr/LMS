using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Entities
{
    internal class Books
    {
        internal string title { get; }
        internal BookType bookType;
        internal double basicPrice { get; }
        internal double maintainCost { get; set; } = 0;
        internal double finalPrice { get; set; } = 0;
       

        internal Books(string Title,double Price, BookType bookType)
        {
            title = Title;
            basicPrice = Price;
            this.bookType = bookType;
        }

        
    }
}
