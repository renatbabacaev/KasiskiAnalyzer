using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KasiskiAnalyzer
{
    public partial class TextHandler
    {
        public void SetKey(string key)
        {
            string s = new string(ProcessString(key.ToLower()));
            this.key = s.ToCharArray();
        }
    }
}
