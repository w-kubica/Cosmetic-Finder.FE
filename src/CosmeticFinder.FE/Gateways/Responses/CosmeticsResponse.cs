namespace CosmeticFinder.FE.Gateways.Responses
{
    public class CosmeticsResponse
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public int TotalPages { get; set; }
        public int TotalRecords { get; set; }
        public bool NextPage { get; set; }
        public bool PreviousPage { get; set; }
        public  List<CosmeticResponse> Data { get; set; }
    }
}
