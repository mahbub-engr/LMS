using LMS.Data;
using LMS_OOP.Data;
using LMS_OOP.Entities;
using LMS_OOP.Service;





// add category
BooksCategory category = new BooksCategory("Printed");


InsertCategory insertCategory = new InsertCategory();
insertCategory.AddCategory(category);




// add book
string title = "Programming Hero";
double price = 500;

category.SetCategoryId(1);

Books book = new Books(title, price, category);
PrintedBook calculator = new PrintedBook(book);

InsertBook insertBook = new InsertBook();
insertBook.Addbook(book, calculator);