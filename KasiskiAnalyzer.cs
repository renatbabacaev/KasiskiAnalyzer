namespace KasiskiAnalyzer
{
    public partial class KasiskiAnalyzer : Form
    {
        public KasiskiAnalyzer()
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
