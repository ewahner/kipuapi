using Newtonsoft.Json;
using System.Collections.Generic;

namespace Kipu.KipuApi.Models
{
    public class KipuPatientData
    {
        [JsonProperty("casefile_id")]
        public string CasefileId { get; set; }
        [JsonProperty("marital_status")]
        public string MaritalStatus { get; set; }
        [JsonProperty("patient_color_id")]
        public string PatientColorId { get; set; }
        [JsonProperty("location_id")]
        public string LocationId { get; set; }
        [JsonProperty("sending_app_patient_master_id")]
        public string PatientId { get; set; }
        [JsonProperty("sending_app_patient_id")]
        public string PatientPreAdmissionId { get; set; }
        [JsonProperty("first_name")]
        public string FirstName { get; set; }
        [JsonProperty("middle_name")]
        public string MiddleName { get; set; }
        [JsonProperty("last_name")]
        public string LastName { get; set; }
        [JsonProperty("preferred_name")]
        public string PreferredName { get; set; }
        [JsonProperty("dob")]
        public string DateOfBirth { get; set; }
        [JsonProperty("address_street")]
        public string AddressStreet { get; set; }
        [JsonProperty("address_street2")]
        public string AddressStreet2 { get; set; }
        [JsonProperty("address_city")]
        public string AddressCity { get; set; }
        [JsonProperty("address_zip")]
        public string AddressZip { get; set; }
        [JsonProperty("address_state")]
        public string AddressState { get; set; }
        [JsonProperty("address_country")]
        public string AddressCountry { get; set; }
        [JsonProperty("occupation")]
        public string Occupation { get; set; }
        [JsonProperty("employer_name")]
        public string EmployerName { get; set; }
        [JsonProperty("employer_phone")]
        public string EmployerPhone { get; set; }
        [JsonProperty("mr")]
        public string MedicalRecord { get; set; }
        [JsonProperty("phone")]
        public string Phone { get; set; }
        [JsonProperty("alternate_phone")]
        public string AlternatePhone { get; set; }
        [JsonProperty("race")]
        public string Race { get; set; }
        [JsonProperty("ethnicity")]
        public string Ethnicity { get; set; }
        [JsonProperty("pre_admission_status")]
        public string PreAdmissionStatus { get; set; }
        [JsonProperty("admission_date")]
        public string AdmissionDate { get; set; }
        [JsonProperty("discharge_date")]
        public string DischargeDate { get; set; }
        [JsonProperty("anticipated_discharge_date")]
        public string AnticipatedDischargeDate { get; set; }
        [JsonProperty("ssn")]
        public string SocialSecurityNumber { get; set; }
        [JsonProperty("gender")]
        public string Gender { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("first_contact_date")]
        public string FirstContactDate { get; set; }
        [JsonProperty("first_contact_rep_on_call")]
        public string FirstContactRepOnCall { get; set; }
        [JsonProperty("first_contact_name")]
        public string FirstContactName { get; set; }
        [JsonProperty("first_contact_information")]
        public string FirstContactInformation { get; set; }
        [JsonProperty("first_contact_relationship")]
        public string FirstContactRelationship { get; set; }
        [JsonProperty("referrer_id")]
        public string ReferrerId { get; set; }
        [JsonProperty("referrer_name")]
        public string ReferrerName { get; set; }
        [JsonProperty("discharge_to_id")]
        public string DischargeToId { get; set; }
        [JsonProperty("discharge_to_name")]
        public string DischargeToName { get; set; }
        [JsonProperty("payment_method")]
        public string PaymentMethod { get; set; }
        [JsonProperty("sobriety_date")]
        public string SobrietyDate { get; set; }
        [JsonProperty("bed_name")]
        public string BedName { get; set; }
        [JsonProperty("pre_admission_status_short_code")]
        public string PreAdmissionStatusShortCode { get; set; }
        [JsonProperty("admission_status")]
        public string AdmissionStatus { get; set; }
        [JsonProperty("insurances_attributes")]
        public List<KipuInsuranceAttribute> KipuInsuranceAttributes { get; set; }
        [JsonProperty("patient_contacts_attributes")]
        public List<KipuContactAttribute> KipuContactAttributes { get; set; }
        [JsonProperty("health_care_card_attributes")]
        public KipuCanadaInsurance KipuCanadaInsurance { get; set; }
    }
}