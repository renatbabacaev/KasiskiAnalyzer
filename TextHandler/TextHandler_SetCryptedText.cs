using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KasiskiAnalyzer
{
    public partial class TextHandler
    {
        public void SetCryptedText(string text)
        {
            string s = new string(ProcessString(text.ToLower()));
            cryptedText = s.ToCharArray();
        }
    }
}
