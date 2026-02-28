using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_OOP.Entities
{
    internal class BooksCategory
    {
        internal string _categoryName { get; private set; }
        internal BooksCategory (string categoryName)
        {
            _categoryName = categoryName;
        }
    }
}
