using System.Threading.Tasks;

namespace Shared
{
    public interface INeedGlass
    {
        Task<Glass> GetGlassAsync();
    }
}