using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KasiskiAnalyzer
{
    public partial class TextHandler
    {
        public char[] cryptedText;
        public char[] decodedText;
        public char[] key;

        public TextHandler()
        {
            cryptedText = new char[0];
            decodedText = new char[0];
            key = new char[0];
        }
    }
}
