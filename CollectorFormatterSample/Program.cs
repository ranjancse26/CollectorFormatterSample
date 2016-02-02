using System;
using HL7Models;
using CollectorFormatterSample.Collector;
using CollectorFormatterSample.Formatter;
using CollectorFormatterSample.Translator;

namespace CollectorFormatterSample
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Collect or Gather Data
            var hL7MessageCollector = new HL7MessageCollector();
            var hL7MessageRoot = hL7MessageCollector.Collect();

            // Translate data
            Translate(hL7MessageRoot);

            // Format and display as XML
            Console.WriteLine("Display HL7 message as XML\n");
            var xmlOutput = FormatToXML(hL7MessageRoot);
            Console.WriteLine(xmlOutput);

            // Format and display as JSON
            Console.WriteLine("\nDisplay HL7 message as JSON\n");
            var jsonOutput = FormatToJSON(hL7MessageRoot);
            Console.WriteLine(jsonOutput);

            Console.ReadLine();
        }
        
        static string FormatToXML(HL7MessageRoot hL7MessageRoot)
        {
            var hL7MessageFormatter = new HL7MessageFormatter(hL7MessageRoot);
            return hL7MessageFormatter.Format(new HL7XMLFormatter());
        }

        static string FormatToJSON(HL7MessageRoot hL7MessageRoot)
        {
            var hL7JSONFormatter = new HL7MessageFormatter(hL7MessageRoot);
            return hL7JSONFormatter.Format(new HL7JsonFormatter());
        }

        static void Translate(HL7MessageRoot hL7MessageRoot)
        {
            var phoneNumber = hL7MessageRoot.Message.PatientIdentification.PhoneHome;
            var phoneNumberTranslator = new PhoneNumberTranslator();

            if (!string.IsNullOrEmpty(phoneNumber))
            {
                hL7MessageRoot.Message.PatientIdentification.PhoneHome = phoneNumberTranslator.Translate(phoneNumber);
            }

            var ssn = hL7MessageRoot.Message.PatientIdentification.SSN;
            var ssnMaskTranslator = new SSNMaskTranslator();

            if (!string.IsNullOrEmpty(ssn))
            {
                hL7MessageRoot.Message.PatientIdentification.SSN = ssnMaskTranslator.Translate(ssn);
            }

            ssn = hL7MessageRoot.Message.Guarantor.SSN;
            if (!string.IsNullOrEmpty(ssn))
            {
                hL7MessageRoot.Message.Guarantor.SSN = ssnMaskTranslator.Translate(ssn);
            }
        }
    }
}
