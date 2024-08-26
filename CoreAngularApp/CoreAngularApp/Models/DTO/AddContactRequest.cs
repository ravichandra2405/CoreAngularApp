namespace CoreAngularApp.Models.DTO
{
    public class AddContactRequest
    {
        public required string Name { get; set; }
        public string? Email { get; set; }
        public required string Phone { get; set; }
        public bool Favorite { get; set; }
    }
}
