using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KasiskiAnalyzer
{
    public partial class TextHandler
    {
        private char[] ProcessString(string s)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] >= 'a' && s[i] <= 'z')
                {
                    sb.Append(s[i]);
                }
            }

            return sb.ToString().ToCharArray();
        }
    }
}
