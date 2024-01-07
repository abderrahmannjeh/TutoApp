
namespace TutoApp.Dto
{
    public class LigneCommandeDTO : GenericDTO
    {
        public int ID { get; set; }
        public float Qte { get; set; }
        public float Price { get; set; }
        public ProductDTO? Product { get; set; }
        public CommandeDTO? Commande { get; set; }
    }
}
