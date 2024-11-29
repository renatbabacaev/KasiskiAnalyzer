using System.Text;

namespace KasiskiAnalyzer
{
    public partial class TextHandler
    {
        public char[] DecodeCrypted()
        {
            if (key.Length < 1)
            {
                return cryptedText;
            }

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < cryptedText.Length; i++)
            {
                sb.Append(
                    // ChatGPT Assisted expression notation
                    (char)((cryptedText[i] - 'a' - (key[i % key.Length] - 'a') % 26 + 26) % 26 + 'a')
                );
            }


            return sb.ToString().ToCharArray();
        }
    }
}
