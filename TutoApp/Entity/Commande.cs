namespace TutoApp.Entity
{
    public class Commande
    {
        public int Id { get; set; }
        public float Total { get; set; }

        public int Discount { get; set; }
        public DateTime Date { get; set; }
        public int ClientID { get; set; }
        public Client? Client { get; set; }

    }
}
