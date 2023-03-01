using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordProcessorProject
{
    public class WordProcessor
    {
        public void Print(IDocument document)
        {
            document.Print();
        }
    }
}
