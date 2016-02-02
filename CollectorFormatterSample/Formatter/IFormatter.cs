namespace CollectorFormatterSample.Formatter
{
    public interface IHL7Formatter
    {
        string FormatHL7Message(HL7Models.HL7MessageRoot hL7Root);
    }
}
