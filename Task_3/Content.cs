using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Content
    {
        private string cont;

        public Content(string cont)
        {
            this.cont = cont;
        }

        public string Cont => cont;

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(cont);
        }
    }
}
