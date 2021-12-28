using MinimalJwt.Models;

namespace MinimalJwt.Repositories
{
    public class UserRepository
    {
        public static List<User> Users = new()
        {
            new()
            {
                UserName = "jorge",
                EmailAddress = "jorge@gmail.com",
                Password = "123456",
                GivenName = "Luke",
                SurName = "Rogers",
                Role = "Administrator",
            },
            new()
            {
                UserName = "marcelo",
                EmailAddress = "marcelo@mail.com",
                Password = "123456",
                GivenName = "Marcelo",
                SurName = "Rogers",
                Role = "Standard",
            },
        };
    }
}
