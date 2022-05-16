using CosmeticFinder.FE.Gateways.Responses;
using Refit;

namespace CosmeticFinder.FE.Gateways
{
    public interface ICosmeticFinder
    {
        [Get("/Cosmetics?search={search}&mainCategoryId={mainCategoryId}&sort={sort}&sortByPriceAsc={sortByPriceAsc}&shouldContainCompose={shouldContainCompose}")]
        Task<IEnumerable<CosmeticResponse>> GetCosmetic(string search, int mainCategoryId, bool sort, bool sortByPriceAsc, bool shouldContainCompose);

        [Get("/Categories")]
        Task<IEnumerable<CategoryResponse>> GetCategories();
    }
}
