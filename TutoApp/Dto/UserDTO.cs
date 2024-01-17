using System.ComponentModel.DataAnnotations;

namespace TutoApp.Dto
{
    public class UserDTO
    {
      
        public string Email { get; set; }

        public string Password { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public bool IsStore { get; set; }
    }
}
