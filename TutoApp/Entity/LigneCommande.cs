namespace TutoApp.Entity
{
    public class LigneCommande
    {
        public int ID { get; set; }
        public float Qte { get; set; }
        public float Price { get; set; }
        public Product? Product { get; set; }
        public Commande? Commande { get; set; }

    }
}
