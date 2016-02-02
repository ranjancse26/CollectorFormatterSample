namespace HL7Models
{
    public class Guarantor
    {
        public string NameLast { get; set; }
        public string NameFirst { get; set; }
        public string NameMiddle { get; set; }
        public string AddressStreet { get; set; }
        public string AddressOtherDesignation { get; set; }
        public string AddressCity { get; set; }
        public string AddressStateOrProvince { get; set; }
        public string AddressZipOrPostalCode { get; set; }
        public string PhoneHome { get; set; }
        public string EmailAddressHome { get; set; }
        public string PhoneBusiness { get; set; }
        public string DateOfBirth { get; set; }
        public string Sex { get; set; }
        public string GuarantorRelationship { get; set; }
        public string SSN { get; set; }
        public string EmployerName { get; set; }
        public string MaritalStatus { get; set; }
    }
}
