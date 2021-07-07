using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Book
    {
        private string title;
        private string author;
        private string content;

        public Book(string title, string author, string content)
        {
            this.title = title;
            this.author = author;
            this.content = content;
        }

        public string Title => title;
        public string Author => author;
        public string Constent => content;

        public override string ToString()
        {
            return $"\nTitle is: {title};\nAuthor is: {author};\nContent is: {content}";
        }
    }
}
