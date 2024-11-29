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
