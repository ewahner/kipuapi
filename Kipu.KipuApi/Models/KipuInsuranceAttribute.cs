using Newtonsoft.Json;

namespace Kipu.KipuApi.Models
{
    public class KipuInsuranceAttribute
    {
        [JsonProperty("insurance_company")]
        public string InsuranceCompany { get; set; }
        [JsonProperty("insurance_phone")]
        public string InsurancePhone { get; set; }
        [JsonProperty("subscriber_first_name")]
        public string SubscriberFirstName { get; set; }
        [JsonProperty("subscriber_middle_name")]
        public string SubscriberMiddleName { get; set; }
        [JsonProperty("subscriber_last_name")]
        public string SubscriberLastName { get; set; }
        [JsonProperty("subscriber_name")]
        public string SubscriberName { get; set; }
        [JsonProperty("subscriber_SSN")]
        public string SubscriberSsn { get; set; }
        [JsonProperty("subscriber_DOB")]
        public string SubscriberDateOfBirth { get; set; }
        [JsonProperty("subscriber_gender")]
        public string SubscriberGender { get; set; }
        [JsonProperty("subscriber_address_street")]
        public string SubscriberAddressStreet { get; set; }
        [JsonProperty("subscriber_address_street2")]
        public string SubscriberAddressStreet2 { get; set; }
        [JsonProperty("subscriber_address_city")]
        public string SubscriberAddressCity { get; set; }
        [JsonProperty("subscriber_address_zip")]
        public string SubscriberAddressZip { get; set; }
        [JsonProperty("subscriber_address_state")]
        public string SubscriberAddressState { get; set; }
        [JsonProperty("subscriber_address_country")]
        public string SubscriberAddressCountry { get; set; }
        [JsonProperty("policy_no")]
        public string PolicyNumber { get; set; }
        [JsonProperty("group_ID")]
        public string GroupId { get; set; }
        [JsonProperty("co_payment")]
        public string CoPayment { get; set; }
        [JsonProperty("subscriber_relationship")]
        public string SubscriberRelationship { get; set; }
        [JsonProperty("notes")]
        public string Notes { get; set; }
        [JsonProperty("insurance_type")]
        public string InsuranceType { get; set; }
        [JsonProperty("insurance_plan_type")]
        public string InsurancePlanType { get; set; }
        [JsonProperty("subscriber_employer")]
        public string SubscriberEmployer { get; set; }
        [JsonProperty("rx_name")]
        public string RxName { get; set; }
        [JsonProperty("rx_phone")]
        public string RxPhone { get; set; }
        [JsonProperty("rx_group")]
        public string RxGroup { get; set; }
        [JsonProperty("rx_bin")]
        public string RxBin { get; set; }
        [JsonProperty("rx_pcn")]
        public string RxPcn { get; set; }
        [JsonProperty("deductible")]
        public string Deductible { get; set; }
        [JsonProperty("origin_id")]
        public int PatientInsuranceId { get; set; }
        [JsonProperty("kipu_insurance_id")]
        public string KipuInsuranceId { get; set; }
        [JsonProperty("old_deductible")]
        public string OldDeductible { get; set; }
        [JsonProperty("old_co_payment")]
        public string OldCoPayment { get; set; }
        [JsonProperty("migrating")]
        public bool Migrating { get; set; }
        [JsonProperty("payer_synonym")]
        public string PayerSynonym { get; set; }
        [JsonProperty("exclude_from_scheduling")]
        public bool ExcludeFromScheduling { get; set; }
        [JsonProperty("insurance_policy_type")]
        public string InsurancePolicyType { get; set; }
    }
}
