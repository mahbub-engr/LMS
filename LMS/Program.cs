
using LMS.Data;
using LMS.Entities;
using LMS.Service;
using static System.Reflection.Metadata.BlobBuilder;

double basePrice = 1600;
double maintainCost = 300;
DatabaseHelper dbHelper = new DatabaseHelper();
Books book;


book = new Books("The Hundred Man", basePrice,BookType.PrintedBooks);
book.maintainCost = maintainCost;
book.finalPrice = Billing.bill(basePrice, maintainCost);

dbHelper.AddBook(book);
