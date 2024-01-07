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

        public CategoryDTO? Category { get; set; }
    }
}
