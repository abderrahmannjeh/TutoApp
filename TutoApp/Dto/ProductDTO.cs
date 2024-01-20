using TutoApp.Entity;

namespace TutoApp.Dto
{
    public class ProductDTO : GenericDTO
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Picture { get; set; }
        public float Price { get; set; }
        public int? CategoryID { get; set; }

        public int? BrandID { get; set; }
        public string? UserID { get; set; }
        public float? Weight { get; set; }
        public float? Cost { get; set; }

        public string? SKU { get; set; }

        public float? BasePrice { get; set; }
        public float? Tax { get; set; }
        public int Stock { get; set; }
        public int Reserved { get; set; }
        public bool? IsActive { get; set; }
        public BrandDTO? Brand { get; set; }
        public List<TagDTO> Tags { get; set; } = new List<TagDTO>();

        public UserDTO? User { get; set; }
        public CategoryDTO? Category { get; set; }


    }
}
