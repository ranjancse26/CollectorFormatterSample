using HL7Models;

namespace CollectorFormatterSample.Mock
{
    /// <summary>
    /// Sample HL7 Message from http://www.opendental.com/manual/xmlsample.txt
    /// </summary>
    public class MockHL7Message
    {
        public HL7MessageRoot GetHL7Message()
        {
            return new HL7MessageRoot
            {
                Message = GetMessage()
            };
        }

        Message GetMessage()
        {
            return new Message
            {
                MessageHeader = GetMessageHeader(),
                PatientIdentification = GetPatientIdentification(),
                Guarantor = GetGuarantor(),
                Insurance = GetInsurance()
            };
        }

        MessageHeader GetMessageHeader()
        {
            return new MessageHeader
            {
                DateTimeOfMessage = "12/8/05 1:34 PM",
                MessageType = "AdmitPatient",
                OpenDentalVersion = "3.9"
            };
        }

        PatientIdentification GetPatientIdentification()
        {
            return new PatientIdentification
            {
                NameFirst = "Cody",
                NameLast = "William",
                NameMiddle = "F",
                DateOfBirth = "01/01/1975",
                Sex = "M",
                AliasFirst = "Bill",
                AddressStreet = "1234 Oak Rd",
                AddressOtherDesignation = "#5",
                AddressCity = "Scott County",
                AddressStateOrProvince = "Iowa",
                AddressZipOrPostalCode = "90211",
                PhoneHome = "(222)222-2223",
                EmailAddressHome = "wbill @msn.com",
                PhoneBusiness = "(333)333-3334",
                MaritalStatus = "M",
                SSN = "111-11-1112",
                NotePhoneAddress = "Don't call before 10am.",
                NoteMedicalComplete = "I take these medications: blah blah blah.  Allergic to pen.  Don't lay back too far, etc."
            };
        }

        Guarantor GetGuarantor()
        {
            return new Guarantor
            {
                NameFirst = "Cody",
                NameLast = "William",
                NameMiddle = "F",
                AddressStreet = "1234 Oak Rd",
                AddressOtherDesignation = "#4",
                AddressCity = "Scott County",
                AddressStateOrProvince = "Iowa",
                AddressZipOrPostalCode = "90210",
                PhoneHome = "(222)222-2222",
                EmailAddressHome = "wbill@msn.com",
                PhoneBusiness = "(333)333-3333",
                DateOfBirth = "01/01/1946",
                Sex = "other",
                GuarantorRelationship = "other",
                SSN = "111-11-1112",
                EmployerName = "",
                MaritalStatus = "M"
            };
        }

        Insurance GetInsurance()
        {
            return new Insurance
            {
                CompanyName = "Aetna",
                AddressStreet = "1234 Main St.",
                AddressOtherDesignation = "Suite 5",
                AddressCity = "Tulsa",
                AddressStateOrProvince = "OK",
                AddressZipOrPostalCode = "44744",
                PhoneNumber = "(800)123-1234",
                GroupNumber = "12-55656",
                GroupName = "Metro Waste",
                InsuredGroupEmpName = "Metro Waste",
                PlanEffectiveDate = "1/1/03",
                PlanExpirationDate = "",
                InsuredsNameLast = "Cody",
                InsuredsNameFirst = "William",
                InsuredsNameMiddle = "F",
                InsuredsRelationToPat = "parent",
                InsuredsDateOfBirth = "1/5/83",
                InsuredsAddressStreet = "",
                InsuredsAddressOtherDesignation = "",
                InsuredsAddressCity = "",
                InsuredsAddressStateOrProvince = "",
                InsuredsAddressZipOrPostalCode ="",
                AssignmentOfBenefits = "Y",
                ReleaseInformationCode = "",
                PolicyNumber = "123-45-6789",
                PolicyDeductible = "51",
                PolicyLimitAmount = "1001",
                InsuredsSex= "M",
                InsuredsSSN ="6",
                InsuredsPhoneHome = "",
                NotePlan = "Percents: 100/80/50. 1 yr wait on major.  No flo cov."
            };
        }
    }
}
