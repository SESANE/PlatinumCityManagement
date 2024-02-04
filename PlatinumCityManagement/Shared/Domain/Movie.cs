using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatinumCityManagement.Shared.Domain

{
    public class Movie : BaseDomainModel
    {
        [Required(ErrorMessage = "The title of the movie is required.")]
        [StringLength(200, ErrorMessage = "The title must be less than 200 characters.")]
        public string? Title { get; set; }

        [Required(ErrorMessage = "The rating of the movie is required.")]
        [RegularExpression(@"^[A-Za-z0-9 ]*$", ErrorMessage = "Only alphanumeric characters are allowed in the rating.")]
        [StringLength(5, ErrorMessage = "The rating must be less than 5 characters.")]
        public string? Rating { get; set; }

        [Required(ErrorMessage = "The duration of the movie is required.")]
        [RegularExpression(@"^([0-9]+h)?\s*([0-9]+m)?\s*([0-9]+s)?$", ErrorMessage = "The duration should be in a 'Nh Nm Ns' format.")]
        public string? Duration { get; set; }

        [StringLength(1000, ErrorMessage = "The description must be less than 1000 characters.")]
        public string? MovieDescription { get; set; }

        [StringLength(1000, ErrorMessage = "The cast details must be less than 1000 characters.")]
        public string? Cast { get; set; }

        [StringLength(2000, ErrorMessage = "The review must be less than 2000 characters.")]
        public string? Review { get; set; }

        // Assuming the poster is a URL to an image, you may want to validate it as such.
        [Url(ErrorMessage = "You must enter a valid URL for the poster.")]
        [StringLength(500, ErrorMessage = "The URL for the poster must be less than 500 characters.")]
        public string? Poster { get; set; }
    }
}
