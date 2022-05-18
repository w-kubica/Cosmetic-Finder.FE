using CosmeticFinder.FE.Gateways.Requests;
using CosmeticFinder.FE.Gateways.Responses;
using Refit;

namespace CosmeticFinder.FE.Gateways
{
    public interface ICosmeticFinder
    {
        [Get("/Cosmetics?search={request.search}&mainCategoryId={request.mainCategoryId}&sort={request.sort}&sortByPriceAsc={request.sortByPriceAsc}&shouldContainCompose={request.shouldContainCompose}")]
        Task<IEnumerable<CosmeticResponse>> GetCosmetic(GetCosmeticsRequest request);

        [Get("/Categories")]
        Task<IEnumerable<CategoryResponse>> GetCategories();
    }
}
