using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Title title1 = new Title("Wild Rift");
            Author author1 = new Author("Riot Games");
            Content content1 = new Content("Game");
            Book book1 = new Book(title1.Subject, author1.Authorr, content1.Cont);

            title1.Show();

            author1.Show();

            content1.Show();

            Console.WriteLine(book1.ToString());


            Console.ReadKey();
        }
    }
}
