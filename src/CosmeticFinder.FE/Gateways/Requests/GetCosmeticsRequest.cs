namespace CosmeticFinder.FE.Gateways.Requests;

public class GetCosmeticsRequest
{
    public int PageNumber { get; set; }
    public int PageSize { get; set; }
    public string Search { get; set; }
    public int MainCategoryId { get; set; }
    public string SortField { get; set; }
    public bool Ascending { get; set; }
    public bool ShouldContainCompose { get; set; }
}
