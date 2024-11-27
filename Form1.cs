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
            textCryptedText.TextChanged += textProcessedText_Update;
            textKey.TextChanged += textDecodedText_Update;
            buttonReset.Click += buttonReset_Click;
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


            public TextHandler()
            {
                cryptedText = new Char[0];
                decodedText = new Char[0];
                key = new Char[0];
            }


            private Char[] ProcessString(String s)
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

                for (int i = 0; i < cryptedText.Length; i++)
                {
                    sb.Append(
                        // ChatGPT Assisted expression notation
                        (Char)( (((cryptedText[i] - 'a') - ((key[i % key.Length] - 'a') % 26) + 26) % 26) + 'a')
                    );
                }


                return sb.ToString().ToCharArray();
            }
        }

        private void textProcessedText_Update(object sender, EventArgs e)
        {
            textHandler.SetCryptedText(textCryptedText.Text);
            String s = new String(textHandler.cryptedText);
            textCryptedText.Text = s;
            textProcessedText.Text = s;
        }
        private void textDecodedText_Update(object sender, EventArgs e)
        {
            textHandler.SetKey(textKey.Text);
            String s = new string(textHandler.DecodeCrypted());
            textProcessedText.Text = s;
        }
        private void buttonReset_Click(object sender, EventArgs e)
        {
            textHandler.SetCryptedText("");
            textCryptedText.Text = "";
            textProcessedText.Text = "";
            textKey.Text = "";
        }
    }
}
