using Kipu.KipuApi.Models;
using RestSharp;
using System.Threading.Tasks;

namespace Kipu.KipuApi.Interfaces
{
    public interface IKipuApiService
    {
        Task<IRestResponse> PostPatientData(KipuDocument patientData);
    }
}
