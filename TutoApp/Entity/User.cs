using Microsoft.AspNetCore.Identity;

namespace TutoApp.Entity
{
    public class User: IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ConnectionString { get;set; }
        public string Type { get;set; }
    }
}
