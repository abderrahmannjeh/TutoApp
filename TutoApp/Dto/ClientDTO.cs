namespace TutoApp.Dto
{
    public class ClientDTO : GenericDTO
    {
        public int Id { get; set; }
        public int Cin { get; set; }
        public string? Name { get; set; }
        public string? Adress { get; set; }
    }
}
