﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nite.API.Data.Models
{
    public class TVShowCreationDTO
    {
        [Required]
        public string? Name { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        public string? Audience { get; set; }
        [Required]
        public int Seasons { get; set; }
        [Required]
        public string? Genre { get; set; }
        [Required]
        public string? Status { get; set; }
        [Required]
        public string? Description { get; set; }
        [Required]
        public string? Streaming { get; set; }
        [Required]
        public int Likes { get; set; }
        public string? NewSeason { get; set; }
        public string? Poster { get; set; }

        [NotMapped]
        public IFormFile? PosterFile { get; set; }

        public string? Banner { get; set; }

        [NotMapped]
        public IFormFile? BannerFile { get; set; }

        public string? Logo { get; set; }

        [NotMapped]
        public IFormFile? LogoFile { get; set; }
    }
}