using CosmeticFinder.FE.Gateways.Responses;
using Refit;

namespace CosmeticFinder.FE.Gateways
{
    public interface ICosmeticFinder
    {
        [Get("/Cosmetics")]
        Task<IEnumerable<CosmeticResponse>> GetCosmetic();
    }
}
