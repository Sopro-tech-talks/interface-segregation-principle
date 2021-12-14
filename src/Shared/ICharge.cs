using System.Threading.Tasks;

namespace Shared
{
    public interface ICharge
    {
        Task<double> GetAmountAsync();
        Task Charge();
    }
}