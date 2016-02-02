using HL7Models;
using CollectorFormatterSample.Mock;

namespace CollectorFormatterSample.Collector
{
    public class HL7MessageCollector
    {
        public HL7MessageRoot Collect()
        {
            // Return Mock Data for now
            return new MockHL7Message().GetHL7Message();
        }
    }
}
