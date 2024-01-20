namespace TutoApp.Entity
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Picture { get; set; }
        public float Price { get; set; }
        public int? CategoryID { get; set; }
        public int? BrandID { get; set; }
        public float? Weight { get; set; }
        public float? Cost { get; set; }    

        public string ? SKU { get; set; }

        public float? BasePrice { get; set; }
        public float? Tax { get; set; }
        public int Stock { get; set; }
        public int Reserved { get; set; }
        public bool? IsActive { get; set; }

        public string? UserID { get; set; }
        public Category? Category { get; set; }
        public Brand? Brand { get; set; }
        public List<Tag> Tags { get; set; } = new List<Tag>();

        public User? User { get; set; }
    }
}
