
using LMS.Entities;
using LMS.Service;

double basePrice = 1600;
double maintainCost = 300;


Books books=new Books("The Hundred Man", basePrice, BookType.PrintedBooks);

books.finalPrice = Billing.bill(basePrice, maintainCost);

