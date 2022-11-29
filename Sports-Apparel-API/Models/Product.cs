namespace Sports_Apparel_API.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Sku { get; set; }
        public string Demographic { get; set; }
        public string Category { get; set; }
        public string Type { get; set; }
        public DateTime ReleaseDate { get; set; }
        public bool Active { get; set; }
        public double Price { get; set; }
        public string Img { get; set; }
        public string  PrimaryColorCode  { get; set; }
        public int Quantity { get; set; }
        public List<int>? Reviews { get; set; }


    }
}
