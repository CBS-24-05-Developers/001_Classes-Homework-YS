using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Title
    {
        private string subject = null;

        public Title(string subject)
        {
            this.subject = subject;
        }

        public string Subject => subject;

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(subject);
        }
    }
}
