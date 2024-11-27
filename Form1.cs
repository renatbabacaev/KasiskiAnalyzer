using System.Runtime.CompilerServices;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace KasiskiAnalyzer
{
    public partial class KasiskiAnalyzer : Form
    {
        public KasiskiAnalyzer()
        {
            InitializeComponent();
            buttonFindSequences.Click += buttonFindSequences_Click;
            textKey.TextChanged += updateDecodedTextWithKey;
        }

        private void ButtonFindSequences_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public class TextHandler
        {
            public Char[] cryptedText;
            public Char[] decodedText;
            public Char[] key;

            public Char[] ProcessString(String s)
            {
                StringBuilder sb = new StringBuilder();

                for(int i = 0; i < s.Length; i++)
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
                Char tempChar;

                for (int i = 0; i < cryptedText.Length; i++)
                {
                    tempChar = (Char)(cryptedText[i] + key[i % key.Length]);
                    if (tempChar >= 'a' && tempChar <= 'z')
                    {
                        sb.Append(
                            (Char)(key[i % key.Length] + ((tempChar - key[i % key.Length] + 1) % 26))
                            );
                    }
                    else
                    {
                        sb.Append(tempChar);
                    }
                }


                return sb.ToString().ToCharArray();
            }
        }

        private void buttonFindSequences_Click(object sender, EventArgs e)
        {
            textHandler.SetCryptedText(textCryptedText.Text);
            String s = new String(textHandler.cryptedText);
            textCryptedText.Text = s;
            textProcessedText.Text = s;
        }
        private void updateDecodedTextWithKey(object sender, EventArgs e)
        {
            textHandler.SetKey(textKey.Text);
            String s = new string(textHandler.DecodeCrypted());
            textProcessedText.Text = s;
        }
    }
}
