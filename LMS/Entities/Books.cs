using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Entities
{
    internal class Books
    {
        private string title;
        public BookType bookType;
        private double basicPrice;
        public double maintainCost=0;
        public double finalPrice=0;
       

        public Books(string Title,double Price, BookType bookType)
        {
            title = Title;
            basicPrice = Price;
            this.bookType = bookType;
        }

        
    }
}
