namespace SouvenirsWithAngular.Models.Domain
{
    public class Friend
    {
        public required int Id { get; set; }
        public required string FriendName { get; set; } = string.Empty;
        public required string FriendCode { get; set; } = string.Empty;
    }
}
