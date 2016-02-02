using HL7Models;
using Newtonsoft.Json;

namespace CollectorFormatterSample.Formatter
{
    public class HL7JsonFormatter : IHL7Formatter
    {
        public string FormatHL7Message(HL7MessageRoot hL7MessageRoot)
        {
            return JsonConvert.SerializeObject(hL7MessageRoot, Formatting.Indented);
        }
    }
}
