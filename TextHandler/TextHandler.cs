namespace KasiskiAnalyzer
{
    public partial class TextHandler
    {
        public char[] cryptedText;
        public char[] decodedText;
        public char[] key;

        public TextHandler()
        {
            cryptedText = [];
            decodedText = [];
            key = [];
        }
    }
}
