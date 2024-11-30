namespace KasiskiAnalyzer
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            buttonFindSequences.Click += (object sender, EventArgs e) =>
            {
                textHandler.SetCryptedText(textCryptedText.Text);
                textHandler.SetKey(textKey.Text);

                String crypt = new String(textHandler.cryptedText);
                String key = new String(textHandler.key);
                String processed = new String(textHandler.DecodeCrypted());

                textCryptedText.Text = crypt;
                textKey.Text = key;

                textProcessedText.Text = processed;
            };

            textCryptedText.TextChanged += (object sender, EventArgs e) =>
            {
                textHandler.SetCryptedText(textCryptedText.Text);
                textHandler.SetKey(textKey.Text);

                String key = new String(textHandler.key);
                String processed = new String(textHandler.DecodeCrypted());

                textKey.Text = key;
                textProcessedText.Text = processed;
            };

            textKey.TextChanged += (object sender, EventArgs e) =>
            {
                textHandler.SetCryptedText(textCryptedText.Text);
                textHandler.SetKey(textKey.Text);

                String key = new String(textHandler.key);
                String processed = new String(textHandler.DecodeCrypted());

                textKey.Text = key;
                textProcessedText.Text = processed;
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
