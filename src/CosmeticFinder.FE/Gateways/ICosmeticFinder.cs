using CosmeticFinder.FE.Gateways.Requests;
using CosmeticFinder.FE.Gateways.Responses;
using Refit;

namespace CosmeticFinder.FE.Gateways
{
    public interface ICosmeticFinder
    {
        //Cosmetics?PageNumber=12&PageSize=1&search=Aqua&shouldContainCompose=true&mainCategoryId=8686&sort=true&sortByPriceAsc=false
        // [Get("/Cosmetics?search={request.search}&mainCategoryId={request.mainCategoryId}&sort={request.sort}&sortByPriceAsc={request.sortByPriceAsc}&shouldContainCompose={request.shouldContainCompose}")]
        //  Task<IEnumerable<CosmeticResponse>> GetCosmetic(GetCosmeticsRequest request);

        [Get("/Cosmetics?PageNumber={request.PageNumber}&PageSize={request.PageSize}&SortField={request.SortField}&Ascending={request.Ascending}&search={request.search}&mainCategoryId={request.mainCategoryId}&shouldContainCompose={request.shouldContainCompose}")]
        Task<CosmeticsResponse> GetCosmetic(GetCosmeticsRequest request);

        [Get("/Categories")]
        Task<IEnumerable<CategoryResponse>> GetCategories();

        [Get("/Tags")]
        Task<IEnumerable<TagResponse>> GetTags();
    }
}
