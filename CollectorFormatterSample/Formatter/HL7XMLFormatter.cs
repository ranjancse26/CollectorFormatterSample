using HL7Models;
using System.IO;
using System.Text;
using System.Xml.Linq;

namespace CollectorFormatterSample.Formatter
{
    public class HL7XMLFormatter : IHL7Formatter
    {
        public string FormatHL7Message(HL7MessageRoot hL7MessageRoot)
        {
            XDocument xDocument = new XDocument();
            var messageElement = new XElement("Message");

            messageElement.Add(GetMessageHeader(hL7MessageRoot));
            messageElement.Add(GetPatientIdentification(hL7MessageRoot));
            messageElement.Add(GetGuarantor(hL7MessageRoot));
            messageElement.Add(GetInsurance(hL7MessageRoot));
            xDocument.Add(messageElement);

            StringBuilder stringBuilder = new StringBuilder();
            using (TextWriter writer = new StringWriter(stringBuilder))
            {
                xDocument.Save(writer);
            }

            return stringBuilder.ToString();
        }

        XElement GetMessageHeader(HL7MessageRoot hL7MessageRoot)
        {
            return new XElement("MessageHeader",
                new XElement("DateTimeOfMessage",
                    hL7MessageRoot.Message.MessageHeader.DateTimeOfMessage),
                new XElement("MessageType",
                   hL7MessageRoot.Message.MessageHeader.MessageType),
                new XElement("OpenDentalVersion",
                   hL7MessageRoot.Message.MessageHeader.OpenDentalVersion));
        }

        XElement GetPatientIdentification(HL7MessageRoot hL7MessageRoot)
        {
            return new XElement("PatientIdentification",
                    new XElement("NameLast",
                        hL7MessageRoot.Message.PatientIdentification.NameLast),
                    new XElement("NameFirst",
                        hL7MessageRoot.Message.PatientIdentification.NameFirst),
                    new XElement("NameMiddle",
                        hL7MessageRoot.Message.PatientIdentification.NameMiddle),
                    new XElement("DateOfBirth",
                        hL7MessageRoot.Message.PatientIdentification.DateOfBirth),
                    new XElement("Sex",
                        hL7MessageRoot.Message.PatientIdentification.Sex),
                    new XElement("AliasFirst",
                        hL7MessageRoot.Message.PatientIdentification.AliasFirst),
                    new XElement("AddressStreet",
                        hL7MessageRoot.Message.PatientIdentification.AddressStreet),
                    new XElement("AddressOtherDesignation",
                        hL7MessageRoot.Message.PatientIdentification.AddressOtherDesignation),
                    new XElement("AddressCity",
                        hL7MessageRoot.Message.PatientIdentification.AddressCity),
                    new XElement("AddressStateOrProvince",
                        hL7MessageRoot.Message.PatientIdentification.AddressStateOrProvince),
                    new XElement("AddressZipOrPostalCode",
                        hL7MessageRoot.Message.PatientIdentification.AddressZipOrPostalCode),
                    new XElement("PhoneHome",
                        hL7MessageRoot.Message.PatientIdentification.PhoneHome),
                    new XElement("EmailAddressHome",
                        hL7MessageRoot.Message.PatientIdentification.EmailAddressHome),
                    new XElement("PhoneBusiness",
                        hL7MessageRoot.Message.PatientIdentification.PhoneBusiness),
                    new XElement("MaritalStatus",
                        hL7MessageRoot.Message.PatientIdentification.MaritalStatus),
                    new XElement("SSN",
                        hL7MessageRoot.Message.PatientIdentification.SSN),
                    new XElement("NotePhoneAddress",
                        hL7MessageRoot.Message.PatientIdentification.NotePhoneAddress),
                    new XElement("NoteMedicalComplete",
                        hL7MessageRoot.Message.PatientIdentification.NoteMedicalComplete));
        }

        XElement GetGuarantor(HL7MessageRoot hL7MessageRoot)
        {
            return new XElement("Guarantor",
                new XElement("NameLast",
                    hL7MessageRoot.Message.Guarantor.NameLast),
                new XElement("NameFirst",
                   hL7MessageRoot.Message.Guarantor.NameFirst),
                new XElement("NameMiddle",
                   hL7MessageRoot.Message.Guarantor.NameMiddle),
                new XElement("AddressStreet",
                    hL7MessageRoot.Message.Guarantor.AddressStreet),
                new XElement("AddressOtherDesignation",
                   hL7MessageRoot.Message.Guarantor.AddressOtherDesignation),
                new XElement("AddressCity",
                   hL7MessageRoot.Message.Guarantor.AddressCity),
                new XElement("AddressStateOrProvince",
                   hL7MessageRoot.Message.Guarantor.AddressStateOrProvince),
                new XElement("AddressZipOrPostalCode",
                    hL7MessageRoot.Message.Guarantor.AddressZipOrPostalCode),
                new XElement("PhoneHome",
                   hL7MessageRoot.Message.Guarantor.PhoneHome),
                new XElement("EmailAddressHome",
                   hL7MessageRoot.Message.Guarantor.EmailAddressHome),
                new XElement("PhoneBusiness",
                   hL7MessageRoot.Message.Guarantor.PhoneBusiness),
                new XElement("DateOfBirth",
                    hL7MessageRoot.Message.Guarantor.DateOfBirth),
                new XElement("Sex",
                   hL7MessageRoot.Message.Guarantor.Sex),
                new XElement("GuarantorRelationship",
                   hL7MessageRoot.Message.Guarantor.GuarantorRelationship),
                new XElement("SSN",
                    hL7MessageRoot.Message.Guarantor.SSN),
                new XElement("EmployerName",
                   hL7MessageRoot.Message.Guarantor.EmployerName),
                new XElement("MaritalStatus",
                   hL7MessageRoot.Message.Guarantor.MaritalStatus));
        }

        XElement GetInsurance(HL7MessageRoot hL7MessageRoot)
        {
            return new XElement("Insurance",
               new XElement("CompanyName",
                   hL7MessageRoot.Message.Insurance.CompanyName),
               new XElement("AddressStreet",
                  hL7MessageRoot.Message.Insurance.AddressStreet),
               new XElement("AddressOtherDesignation",
                  hL7MessageRoot.Message.Insurance.AddressOtherDesignation),
               new XElement("AddressCity",
                   hL7MessageRoot.Message.Insurance.AddressCity),
               new XElement("AddressStateOrProvince",
                  hL7MessageRoot.Message.Insurance.AddressStateOrProvince),
               new XElement("AddressZipOrPostalCode",
                  hL7MessageRoot.Message.Insurance.AddressZipOrPostalCode),
               new XElement("PhoneNumber",
                  hL7MessageRoot.Message.Insurance.PhoneNumber),
               new XElement("GroupNumber",
                   hL7MessageRoot.Message.Insurance.GroupNumber),
               new XElement("GroupName",
                  hL7MessageRoot.Message.Insurance.GroupName),
               new XElement("InsuredGroupEmpName",
                  hL7MessageRoot.Message.Insurance.InsuredGroupEmpName),
               new XElement("PlanEffectiveDate",
                  hL7MessageRoot.Message.Insurance.PlanEffectiveDate),
               new XElement("PlanExpirationDate",
                   hL7MessageRoot.Message.Insurance.PlanExpirationDate),
               new XElement("InsuredsNameLast",
                  hL7MessageRoot.Message.Insurance.InsuredsNameLast),
               new XElement("InsuredsNameFirst",
                  hL7MessageRoot.Message.Insurance.InsuredsNameFirst),
               new XElement("InsuredsNameMiddle",
                   hL7MessageRoot.Message.Insurance.InsuredsNameMiddle),
               new XElement("InsuredsRelationToPat",
                  hL7MessageRoot.Message.Insurance.InsuredsRelationToPat),
               new XElement("InsuredsDateOfBirth",
                  hL7MessageRoot.Message.Insurance.InsuredsDateOfBirth),
               new XElement("InsuredsAddressStreet",
                  hL7MessageRoot.Message.Insurance.InsuredsAddressStreet),
               new XElement("InsuredsAddressOtherDesignation",
                  hL7MessageRoot.Message.Insurance.InsuredsAddressOtherDesignation),
               new XElement("InsuredsAddressCity",
                   hL7MessageRoot.Message.Insurance.InsuredsAddressCity),
               new XElement("InsuredsAddressStateOrProvince",
                  hL7MessageRoot.Message.Insurance.InsuredsAddressStateOrProvince),
               new XElement("InsuredsAddressZipOrPostalCode",
                  hL7MessageRoot.Message.Insurance.InsuredsAddressZipOrPostalCode),
               new XElement("AssignmentOfBenefits",
                  hL7MessageRoot.Message.Insurance.AssignmentOfBenefits),
               new XElement("ReleaseInformationCode",
                   hL7MessageRoot.Message.Insurance.ReleaseInformationCode),
               new XElement("PolicyNumber",
                  hL7MessageRoot.Message.Insurance.PolicyNumber),
               new XElement("PolicyDeductible",
                  hL7MessageRoot.Message.Insurance.PolicyDeductible),
               new XElement("PolicyLimitAmount",
                  hL7MessageRoot.Message.Insurance.PolicyLimitAmount),
               new XElement("InsuredsSex",
                  hL7MessageRoot.Message.Insurance.InsuredsSex),
               new XElement("InsuredsSSN",
                   hL7MessageRoot.Message.Insurance.InsuredsSSN),
               new XElement("InsuredsPhoneHome",
                  hL7MessageRoot.Message.Insurance.InsuredsPhoneHome),
               new XElement("NotePlan",
                  hL7MessageRoot.Message.Insurance.NotePlan));
        }
    }
}
