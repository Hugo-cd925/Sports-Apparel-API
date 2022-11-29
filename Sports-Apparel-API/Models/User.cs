using System.Text.Json.Serialization;

namespace Sports_Apparel_API.Models
{
    public class User
    {
        [JsonRequired]
        public string Email { get; set; }
        public string Role { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string StreetAddress { get; set; }

        public string StreetAddress2 { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string ZipCode { get; set; }

        public string? PhoneNumber { get; set; }

        public List<int>? RecentlyViewed { get; set; }

    }
}
