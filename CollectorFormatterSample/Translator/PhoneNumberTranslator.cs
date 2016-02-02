namespace CollectorFormatterSample.Translator
{
    public class PhoneNumberTranslator : ITranslate
    {
        public string Translate(string phoneNumber)
        {
            return phoneNumber.ToString()
               .Replace("-", "")
               .Replace("(", "")
               .Replace(")", "");
        }
    }
}
