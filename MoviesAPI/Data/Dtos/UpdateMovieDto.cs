using System.ComponentModel.DataAnnotations;

namespace MoviesAPI.Data.Dtos;

public class UpdateMovieDto
{
    [Required(ErrorMessage = "The movie title is mandatory.")]
    public string Title { get; set; }

    [Required(ErrorMessage = "The movie genre is mandatory.")]
    [StringLength(50, ErrorMessage = "The movie genre cannot have more than 50 characters.")]
    public string Genre { get; set; }

    [Required]
    [Range(70, 600, ErrorMessage = "The movie duration must be between 70 and 600 minutes.")]
    public int Duration { get; set; }
}
