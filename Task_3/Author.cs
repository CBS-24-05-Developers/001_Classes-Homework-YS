using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Author
    {
        private string authorr;

        public Author(string authorr)
        {
            this.authorr = authorr;
        }

        public string Authorr => authorr;

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(authorr);
        }
    }
}
