using LMS_OOP.Data;
using LMS_OOP.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Data
{
    internal class InsertCategory:DatabaseHelper
    {
        internal void AddCategory(BooksCategory booksCategory)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"Insert into Category(CategoryName)
                 values (@CategoryName);
                 SELECT SCOPE_IDENTITY();";

                using SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@CategoryName", booksCategory._categoryName);

                connection.Open();
                int newId = Convert.ToInt32(cmd.ExecuteScalar());

                booksCategory.SetCategoryId(newId); ;
            }
        }
    }
}
