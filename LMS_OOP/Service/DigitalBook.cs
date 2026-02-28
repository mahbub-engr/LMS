using LMS_OOP.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_OOP.Service
{
    class DigitalBook : CalculatePrice
    {
        
        internal DigitalBook(Books book):base(book) {

        } 

        internal override double Calculate()
        {
            double maintainCost =100;
            return maintainCost + _book.basicPrice;
        }
    }
}
