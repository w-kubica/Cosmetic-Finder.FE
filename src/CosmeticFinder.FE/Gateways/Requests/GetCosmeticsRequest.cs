namespace CosmeticFinder.FE.Gateways.Requests;

public class GetCosmeticsRequest
{
    public string search { get; set; }
    public int mainCategoryId { get; set; }
    public bool sort { get; set; }
    public bool sortByPriceAsc { get; set; }
    public bool shouldContainCompose { get; set; }
}
