using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace Kipu.KipuApi.Helpers
{
    public static class SignatureExtension
    {
        private static string GenerateSignature(RestRequest request, string date, HttpMethod method, string contentType, string secretKey)
        {
            var pathAndQuery = method == HttpMethod.Get ? $"{request.Resource}?{request.Parameters.ToQueryString()}" : request.Resource;
            var crypto = new HMACSHA1(Encoding.UTF8.GetBytes(secretKey));
            var cononicalString = $"{contentType},{request.GenerateMd5()},{pathAndQuery},{date}";
            request.AddHeader("CONONICAL", cononicalString);
            var signature = Convert.ToBase64String(crypto.ComputeHash(Encoding.UTF8.GetBytes(cononicalString)));
            return signature;
        }

        public static void GenerateHeaders(this RestRequest request, HttpMethod method, string contentType, string accessId, string secretKey)
        {
            var date = DateTime.UtcNow.ToString("r");
            request.AddHeader("ACCEPT", "application/vnd.kipusystems+json; version=1");
            request.AddHeader("AUTHORIZATION", $"APIAuth {accessId}:{GenerateSignature(request, date, method, contentType, secretKey)}");
            request.AddHeader("CONTENT_MD5", request.GenerateMd5());
            request.AddHeader("DATE", date);
        }

        public static string ToQueryString(this List<Parameter> parameters)
        {
            var qs = HttpUtility.ParseQueryString("");
            foreach(var parameter in parameters)
            {
                if (parameter.Type == ParameterType.QueryString)
                {
                    qs.Add(parameter.Name, parameter.Value.ToString());
                }
            }
            return qs.ToString();
        }

        public static void AddJson(this RestRequest request, object obj)
        {
            request.AddParameter("application/json", JsonConvert.SerializeObject(obj, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }), ParameterType.RequestBody);
        }

        public static string GenerateMd5(this RestRequest request)
        {
            var crypto = MD5.Create();
            var body = request.Parameters.FirstOrDefault(x => x.Type == ParameterType.RequestBody);
            Trace.WriteLine($"body: {body.Value.ToString()}");
            var content = body == null ? string.Empty : body.Value.ToString();

            return Convert.ToBase64String(crypto.ComputeHash(Encoding.ASCII.GetBytes(content)));
        }
    }
}
