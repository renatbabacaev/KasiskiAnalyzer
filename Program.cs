namespace KasiskiAnalyzer
{
    public class CryptedTextHandler
    {
        public String cryptedText;
        public String decodedText;
        public List<Char> key;

        public CryptedTextHandler(String text)
        {
            cryptedText = text;
        }


    }

    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new KasiskiAnalyzer());
        }
    }
}