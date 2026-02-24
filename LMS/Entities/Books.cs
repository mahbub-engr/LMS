using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Entities
{
    internal class Books
    {
        public string title { get; }
        public BookType bookType;
        public double basicPrice { get; }
        public double maintainCost { get; set; } = 0;
        public double finalPrice { get; set; } = 0;
       

        public Books(string Title,double Price, BookType bookType)
        {
            title = Title;
            basicPrice = Price;
            this.bookType = bookType;
        }

        
    }
}
