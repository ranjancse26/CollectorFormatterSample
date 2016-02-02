using HL7Models;

namespace CollectorFormatterSample.Formatter
{
    public class HL7MessageFormatter
    {
        HL7MessageRoot hL7MessageRootObject;

        public HL7MessageFormatter(HL7MessageRoot hL7MessageRoot)
        {
            hL7MessageRootObject = hL7MessageRoot;
        }

        public string Format(IHL7Formatter formatter)
        {
            return formatter.FormatHL7Message(hL7MessageRootObject);
        }
    }
}
