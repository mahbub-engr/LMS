using LMS_OOP.Entities;
using LMS_OOP.Service;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_OOP.Data
{
    internal class InsertBook:DatabaseHelper
    {

        internal void Addbook(Books book,CalculatePrice calculator)
        {
            double maintainCost = calculator.Calculate() - book.basicPrice;
            double finalPrice = calculator.Calculate();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"Insert into Books(BookTitle,CategoryId,BasePrice,MaintainCost,FinalPrice) values (@BookTitle,@CategoryId,@BasePrice,@MaintainCost,@FinalPrice)";
                using SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("BookTitle", book.title);
                cmd.Parameters.AddWithValue("CategoryId",book._category._categoryId);
                cmd.Parameters.AddWithValue("BasePrice", book.basicPrice);
                cmd.Parameters.AddWithValue("MaintainCost", maintainCost);
                cmd.Parameters.AddWithValue("FinalPrice",finalPrice );
                connection.Open();
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    Console.WriteLine("book added successfully.");
                }
                else
                {
                    Console.WriteLine("Insert failed.");
                }
                connection.Close();
            }
        }
    }
}
