using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KasiskiAnalyzer
{
    public class TextHandler
    {
        public Char[] cryptedText;
        public Char[] decodedText;
        public Char[] key;


        public TextHandler()
        {
            cryptedText = new Char[0];
            decodedText = new Char[0];
            key = new Char[0];
        }


        private Char[] ProcessString(String s)
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
        public void SetCryptedText(String text)
        {
            String s = new String(ProcessString(text.ToLower()));
            cryptedText = s.ToCharArray();
        }

        public void SetDecodedText()
        {
            decodedText = DecodeCrypted();
        }

        public void SetKey(String key)
        {
            String s = new String(ProcessString(key.ToLower()));
            this.key = s.ToCharArray();
        }

        public Char[] DecodeCrypted()
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
                    (Char)((((cryptedText[i] - 'a') - ((key[i % key.Length] - 'a') % 26) + 26) % 26) + 'a')
                );
            }


            return sb.ToString().ToCharArray();
        }
    }
}
