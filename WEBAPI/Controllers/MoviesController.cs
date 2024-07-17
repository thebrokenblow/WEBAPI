using Microsoft.AspNetCore.Mvc;
using WEBAPI.Model;

namespace WEBAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class MoviesController : ControllerBase
{

    private static readonly List<Movie> Movies =
    [
            new()
            {
                Id = 1,
                Title = "The Shawshank Redemption",
                ReleaseDate = new DateTime(1994, 9, 23),
                Genre = "Drama",
                Description = "Two imprisoned men bond over a period of two decades, finding solace and eventual redemption through acts of common decency."
            },
            new()
            {
                Id = 2,
                Title = "The Godfather",
                ReleaseDate = new DateTime(1972, 3, 24),
                Genre = "Crime",
                Description = "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son."
            },
            new()
            {
                Id = 3,
                Title = "The Dark Knight",
                ReleaseDate = new DateTime(2008, 7, 18),
                Genre = "Action",
                Description = "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice."
            },
            new()
            {
                Id = 4,
                Title = "Pulp Fiction",
                ReleaseDate = new DateTime(1994, 10, 14),
                Genre = "Crime",
                Description = "The lives of two mob hitmen, a boxer, a gangster's wife, and a drug addict intertwine in four tales of violence and redemption."
            },
            new()
            {
                Id = 5,
                Title = "The Lord of the Rings: The Return of the King",
                ReleaseDate = new DateTime(2003, 12, 17), Genre = "Fantasy",
                Description = "Gandalf and Aragorn lead the World of Men against Sauron's army to destroy the One Ring."
            },
            new()
            {
                Id = 6,
                Title = "Fight Club",
                ReleaseDate = new DateTime(1999, 10, 15),
                Genre = "Drama",
                Description = "An insomniac office worker looking for a way to change his life crosses paths with a devil-may-care soap maker and they form an underground fight club that evolves into something much, much more."
            },
            new()
            {
                Id = 7,
                Title = "Inception",
                ReleaseDate = new DateTime(2010, 7, 16),
                Genre = "Sci-Fi",
                Description = "A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a CEO."
            },
            new()
            {
                Id = 8,
                Title = "Forrest Gump",
                ReleaseDate = new DateTime(1994, 7, 6),
                Genre = "Drama",
                Description = "The presidencies of Nixon, Ford, Carter, Reagan, and Bush, Watergate, Vietnam, and the rise of rock and roll are all seen through the eyes of Forrest Gump, a man with an IQ of 75, whose life is a series of improbable events."
            },
            new()
            {
                Id = 9,
                Title = "The Matrix",
                ReleaseDate = new DateTime(1999, 3, 31),
                Genre = "Sci-Fi",
                Description = "A computer hacker learns from mysterious rebels about the true nature of his reality and his role in the war against its controllers."
            },
            new()
            {
                Id = 10,
                Title = "Goodfellas",
                ReleaseDate = new DateTime(1990, 9, 19),
                Genre = "Crime",
                Description = "The story of Henry Hill and his life in the mob, covering his rise to power, his eventual downfall and the consequences of his actions."
            }
    ];

    [HttpGet]
    public IEnumerable<Movie> GetAll() =>
        Movies;


    [HttpPost]
    public void AddMovie(Movie movie)
    {
        Movies.Add(movie);
    }

    [HttpPut]
    public void UpdateMovie(int id, Movie movie)
    {
        var updatedMovie = Movies.Find(movie => movie.Id == id) ?? throw new Exception("‘ильм не был найден");
        updatedMovie.Title = movie.Title;
        updatedMovie.ReleaseDate = movie.ReleaseDate;
        updatedMovie.Genre = movie.Genre;
        updatedMovie.Description = movie.Description;
    }

    [HttpDelete]
    public void UpdateMovie(int id)
    {
        var deletedMovie = Movies.Find(movie => movie.Id == id) ?? throw new Exception("‘ильм не был найден");
        Movies.Remove(deletedMovie);
    }
}
