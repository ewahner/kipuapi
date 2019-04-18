using Kipu.KipuApi.Helpers;
using Kipu.KipuApi.Interfaces;
using Kipu.KipuApi.Models;
using RestSharp;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Kipu.KipuApi.Implementations
{
    public class KipuApiService : IKipuApiService
    {
        private readonly string BaseUrl;
        private readonly string AccessId;
        private readonly string SecretKey;
        private readonly string AppId;

        public KipuApiService(string baseUrl, string accessId, string secretKey, string appId)
        {
            this.BaseUrl = baseUrl;
            this.AccessId = accessId;
            this.SecretKey = secretKey;
            this.AppId = appId;

            if (string.IsNullOrEmpty(this.BaseUrl))
            {
                throw new ArgumentNullException("BaseUrl", "ctor expects a valid url");
            }
            if (string.IsNullOrEmpty(this.AccessId))
            {
                throw new ArgumentNullException("accessId", "ctor expects a valid accessId");
            }
            if (string.IsNullOrEmpty(this.SecretKey))
            {
                throw new ArgumentNullException("secretKey", "ctor expects a valid secretKey");
            }
            if (string.IsNullOrEmpty(this.AppId))
            {
                throw new ArgumentNullException("appId", "Must have a valid appid otherwise known as your instance id");
            }
        }

        public async Task<IRestResponse> PostPatientData(KipuDocument patientData)
        {
            var client = new RestClient(this.BaseUrl);
            var request = new RestRequest($"{KipuResource.Patients}", Method.POST);
            if (patientData == null)
            {
                throw new ArgumentNullException("patientData", "patientData of type KipuDocument cannot be null");
            }
            request.AddJson(patientData);
            request.GenerateHeaders(HttpMethod.Post, "application/json", this.AccessId, this.SecretKey);
            return await client.ExecuteTaskAsync<IRestResponse>(request);
        }
    }
}
