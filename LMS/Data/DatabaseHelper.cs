using LMS.Entities;
using LMS.Service;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Data
{
    internal class DatabaseHelper
    {
        private string ConnectionString = "Server=.;Database=LMS;Integrated Security=True";
        public void AddBook(Books books) {
            using (SqlConnection connection = new SqlConnection(ConnectionString)) {
                string query = @"insert into tbl_Books(Title,Category,BasePrice,Charge,FinalPrice) values(@Title,@Category,@BasePrice,@Charge,@FinalPrice)";
                using SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("Title",books.title);
                cmd.Parameters.AddWithValue("BasePrice", books.basicPrice);
                cmd.Parameters.AddWithValue("Category", books.bookType);
                cmd.Parameters.AddWithValue("Charge", books.maintainCost);
                cmd.Parameters.AddWithValue("FinalPrice", Billing.bill(books.basicPrice,books.maintainCost));
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
