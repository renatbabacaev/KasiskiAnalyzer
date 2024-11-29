using System.Text;

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
