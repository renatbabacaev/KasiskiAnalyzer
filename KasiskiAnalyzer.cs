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
            /*
            textCryptedText.TextChanged += textCryptedText_Update;
            textKey.TextChanged += textDecodedText_Update;
            buttonReset.Click += buttonReset_Click;
            */

            textCryptedText.TextChanged += (object sender, EventArgs e) =>
            {
                textHandler.SetCryptedText(textCryptedText.Text);
                String s = new String(textHandler.cryptedText);
                textCryptedText.Text = s;
                textProcessedText.Text = s;
            };
            
            textKey.TextChanged += (object sender, EventArgs e) =>
            {
                textHandler.SetKey(textKey.Text);
                String s = new string(textHandler.DecodeCrypted());
                textProcessedText.Text = s;
            };

            buttonReset.Click += (object sender, EventArgs e) =>
            {
                textHandler.SetCryptedText("");
                textCryptedText.Text = "";
                textProcessedText.Text = "";
                textKey.Text = "";
            };
        }
    }
}
