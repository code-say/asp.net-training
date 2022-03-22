using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assinment
{
    public class BookApp
    {
        public int bookId;
        public string title;
        public double price;
        public string bookType;

        public BookApp(int bookId, string title, double price, string bookType)
        {
            this.bookId = bookId;
            this.title = title;
            this.price = price;
            this.bookType = bookType;
        }

        public void display()
        {
            Console.WriteLine("Book Id is: " + bookId);
            Console.WriteLine("The title of the Book is: " + title);
            Console.WriteLine("Price of the Boook is: " + price);
            Console.WriteLine("The Book Type is: " + bookType);
        }

        public static void Main()
        {
            BookApp b1 = new BookApp(16, "CDSE Agarwal", 589, "Reference Book");
            b1.display();
            Console.WriteLine();

            BookApp b2 = new BookApp(29, "Playing The palace", 799, "Novel");
            b2.display();
            Console.WriteLine();

            BookApp b3 = new BookApp(4, "Rebel", 342, "Magazine");
            b3.display();
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
