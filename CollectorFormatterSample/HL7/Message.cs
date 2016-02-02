namespace HL7Models
{
    public class Message
    {
        public MessageHeader MessageHeader { get; set; }
        public PatientIdentification PatientIdentification { get; set; }
        public Guarantor Guarantor { get; set; }
        public Insurance Insurance { get; set; }
    }
}
