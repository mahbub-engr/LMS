using LMS_OOP.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_OOP.Service
{
    abstract class CalculatePrice
    {
        protected Books _book;
        internal CalculatePrice (Books book)
        {
            _book = book;
        }
        internal abstract double Calculate();
    }
}
