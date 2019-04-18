# kipuapi

The following library was created to make it easier to get started with sending data to Kipu's EMR system.  You can clone this repo and add it to your own solution or use it as a reference.  This library was written using the latest .NET Standard 2.  It utilizes the latest version of JSON.Net and RestSharp all of which will be automatically installed if you clone the repo.

The test script below was written in [LINQPad](https://www.linqpad.net/) which I encourage you to download and support.  If you clone this repo and import the DLL into LinqPad, you will still need to add the 2 NuGet packages to your LINQPad script.

**NuGet Packages**
- Microsoft.Extensions.Configuration (2.2.0)
- Newtonsoft.Json (12.0.1)
- RestSharp (106.6.9)

```
async Task Main()
{
    string endpoint = "";  // This would be the base URL that would be provided to you by the integration specialist
    string accessId = "";  // A string value that would be provided by a member of the Kipu team.
    string secretKey = ""; // A unique value that you shouldn't share with anyone used to hash the data in your requests.
    string appId = "";     // The instance id as it relates to your Kipu instance.

    var api = new KipuApiService(endpoint, accessId, secretKey,	appId);
	
    var response = await api.PostPatientData(new KipuDocument {
        KipuDocumentBody = new KipuDocumentBody {
            KipuPatientData = new KipuPatientData {
                AddressCity = "Delray Beach",
                AddressCountry = "US",
                AddressState = "FL",
                AddressStreet = "1200 Some Address",
                AddressZip = "33445",
                AdmissionDate = "04/18/2019",
                AdmissionStatus = "Prospect",
                DateOfBirth = "09/05/1984",
                Email = "email@fakemail.com",
                FirstName = "Firstname",
                LastName = "Lastname",
                Gender = "male",
                KipuInsuranceAttributes = new List<KipuInsuranceAttribute> { 
                    new KipuInsuranceAttribute {
                        CoPayment = "20",
                        Deductible = "50.00",
                        InsuranceCompany = "AETNA",
                        PolicyNumber = "123456788",
                        GroupId = "12121"
                    } 
                },
                KipuContactAttributes = new List<Kipu.KipuApi.Models.KipuContactAttribute> { 
                    new KipuContactAttribute {
                        Address = "1122 Boogie Boogie Avenue",
                        ContactType = "Family",
                        FullName = "Bart Simpson",
                        Email = "bart@fakeemail.com",
                        Relationship = "Brother",
                        AlternativePhone = "3055551122",
                        Phone = "4045551122",
                        Notes = "These are the notes"
                    }
                }
            },
            RecipientId = appId,
            SendingAppName = ""
        }
    });
	
    response.Dump();
}
```

This is by no means every property that Kipu supports.  Please review the various different models available and go over with your Kipu integration specialist which ones are right for your company.  This is meant as a tool to help you get started.
