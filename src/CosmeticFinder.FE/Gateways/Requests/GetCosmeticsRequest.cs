namespace CosmeticFinder.FE.Gateways.Requests;

public class GetCosmeticsRequest
{
    public string Search { get; set; }
    public int MainCategoryId { get; set; }
    public bool Sort { get; set; }
    public bool SortByPriceAsc { get; set; }
    public bool ShouldContainCompose { get; set; }
}
