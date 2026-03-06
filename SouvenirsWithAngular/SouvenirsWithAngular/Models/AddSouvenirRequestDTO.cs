namespace SouvenirsWithAngular.Models
{
    public class AddSouvenirRequestDTO
    {
        //public required int Id { get; set; }
        public required string SouvenirName { get; set; } = string.Empty;
        public required string CountryOfOrigin { get; set; } = string.Empty;
        public decimal? Value { get; set; }
        public required int Quantity { get; set; } = 0;
        public required string FriendID { get; set; } = string.Empty;
        public required string Comment { get; set; } = string.Empty;
    }
}
