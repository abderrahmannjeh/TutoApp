namespace TutoApp.Entity
{
    public class Client
    {
        public int Id { get; set; }
        public int Cin { get; set; }
        public string? Name { get; set; }
        public string? Adress { get; set; }

        public List<Commande>? CommandeList { get; set;}
    }
}
