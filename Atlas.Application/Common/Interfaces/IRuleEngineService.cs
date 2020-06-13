using System.Threading.Tasks;

namespace Atlas.Application.Common.Interfaces
{
    public interface IRuleEngineService
    {
        Task<string> ValidateAgencyComission(string CNPJ, string Discount);
    }
}
