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
        public string? Title { get; set; }
        public string? Rating { get; set; }
        public string? Duration { get; set; }
        public string? MovieDescription { get; set; }
        public string? Cast { get; set; }
        public string? Review { get; set; }
        public string? Poster { get; set; }
    }
}
