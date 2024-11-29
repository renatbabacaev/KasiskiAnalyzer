namespace KasiskiAnalyzer
{
    public partial class TextHandler
    {
        public void SetCryptedText(string text)
        {
            string s = new string(ProcessString(text.ToLower()));
            cryptedText = s.ToCharArray();
        }
    }
}
