namespace KasiskiAnalyzer
{
    public partial class Main : Form
    {
        public static void processed_Update(object? sender, EventArgs e)
        {
            textHandler.SetCryptedText(textCryptedText.Text);

            if (analyzer != null)
            {
                textHandler.SetKey(KasiskiAnalyzer.MainAnalyzer.keyInput.Text);
            }

            String key = new String(textHandler.key);
            String processed = new String(textHandler.DecodeCrypted());

            textKey.Text = key;
            textProcessedText.Text = processed;
        }

        public Main()
        {
            InitializeComponent();

            buttonFindSequences.Click += (object? sender, EventArgs e) =>
            {
                String crypt = new String(textHandler.cryptedText);

                processed_Update(buttonFindSequences, EventArgs.Empty);

                textCryptedText.Text = crypt;

                if (analyzer == null || analyzer.IsDisposed)
                {
                    analyzer = new MainAnalyzer();
                    analyzer.FormClosed += (object? sender, FormClosedEventArgs e) =>
                    {
                        analyzer = null;
                    };
                    analyzer.Show();
                }
                else
                {
                    analyzer.BringToFront();
                }
            };

            textCryptedText.TextChanged += processed_Update;

            textKey.TextChanged += processed_Update;

            buttonReset.Click += (object? sender, EventArgs e) =>
            {
                textHandler.SetCryptedText("");
                textCryptedText.Text = "";
                textProcessedText.Text = "";
                textKey.Text = "";
            };
        }
    }
}
