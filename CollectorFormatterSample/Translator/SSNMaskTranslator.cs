using System.Text.RegularExpressions;

namespace CollectorFormatterSample.Translator
{
    //Reused code - http://stackoverflow.com/questions/5254197/format-ssn-using-regex
    public class SSNMaskTranslator : ITranslate
    {
        public string Translate(string originalSSN)
        {
            string ssn = originalSSN.ToString();
            if (ssn.Length < 5) originalSSN = ssn;
            var trailingNumbers = ssn.Substring(ssn.Length - 4);
            var leadingNumbers = ssn.Substring(0, ssn.Length - 4);
            var maskedLeadingNumbers = Regex.Replace(leadingNumbers, @"[0-9]", "X");
            return maskedLeadingNumbers + trailingNumbers;
        }
    }
}
