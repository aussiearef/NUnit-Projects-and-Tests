using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordProcessorProject
{
    public class WordDocument : IDocument
    {
        public void Print()
        {
            Console.WriteLine("Word printed.");
        }
    }

    public class Word365Document: WordDocument{

        public new void Print() { Console.WriteLine("Word 365 document was printed."); }
    }
}
