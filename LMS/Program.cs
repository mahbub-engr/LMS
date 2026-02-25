
using LMS.Data;
using LMS.Entities;
using LMS.Service;
using static System.Reflection.Metadata.BlobBuilder;
DatabaseHelper dbHelper = new DatabaseHelper();
Books book;
string title;
int catchoice;
BookType bookType;
double basePrice ;
double maintainCost;
int choice;







do
{
    Console.WriteLine("1.Add Book:");
    Console.WriteLine("2.Show Book:");
    choice =Convert.ToInt32(Console.ReadLine());
    switch (choice)
    {
        case 1:

            Console.Write("Enter Book Title:");
            title = Console.ReadLine();

            Console.Write("Enter Base Price:");
            basePrice= Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Book category 1.Printed 2.Digital :");
            catchoice = Convert.ToInt32(Console.ReadLine());
            if (catchoice ==1)
            {
                bookType = BookType.PrintedBooks;
            }else if (catchoice == 2)
            {
                bookType = BookType.DigitalBooks ;
            }else
            {
                Console.WriteLine("Invalid book type");
                continue;
            }



            book = new Books(title, basePrice,bookType);
            Console.Write("Enter Maintain Cost:");
            maintainCost = Convert.ToDouble(Console.ReadLine());
            book.maintainCost = maintainCost;
            book.finalPrice = Billing.bill(basePrice, maintainCost);
            dbHelper.AddBook(book);
        break;
        case 2:

        break;
    }
}while (true);