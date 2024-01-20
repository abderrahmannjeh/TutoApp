namespace TutoApp.Dto
{
    public class LoginResponse
    {
        public string Email { get; set; }


        public string FirstName { get; set; }

        public string LastName { get; set; }

        public bool? IsStore { get; set; }

        public string Token { get; set; }

        public bool HasError { get; set; }
        public string Error { get; set; }
    }
}
