using MinimalJwt.Models;

namespace MinimalJwt.Repositories
{
    public class MovieRepository
    {
        public static List<Movie> Movies = new()
        {
            new()
            {
                Id = 1,
                Title = "Eternals",
                Description = "La saga de Eternals",
                Rating = 1
            },
            new()
            {
                Id = 2,
                Title = "Titanic",
                Description = "La caída del titánic",
                Rating = 5
            },
            new()
            {
                Id = 3,
                Title = "Romeo y Julieta",
                Description = "Nueva versión de Romeo y Julieta (1997)",
                Rating = 5
            },
            new()
            {
                Id = 4,
                Title = "Once upon a time in México",
                Description = "Antonio Banderas y Salma Hayek",
                Rating = 3
            },
            new()
            {
                Id = 5,
                Title = "Ghost",
                Description = "Demi More con Patrick Swaize - Ghost",
                Rating = 4.5
            },
        };
    }
}
