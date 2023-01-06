using System.ComponentModel.DataAnnotations;

namespace MoviesAPI.Models;

public class Movie
{
    public int Id { get; set; }

    [Required(ErrorMessage = "The movie title is mandatory.")]
    public string Title { get; set; }

    [Required(ErrorMessage = "The movie genre is mandatory.")]
    [MaxLength(50, ErrorMessage = "The movie genre cannot have more than 50 characters.")]
    public string Genre { get; set; }

    [Required]
    [Range(70, 600, ErrorMessage = "The movie duration must be between 70 and 600 minutes.")]
    public int Duration { get; set; }
}
