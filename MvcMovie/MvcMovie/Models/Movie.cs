using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int ID { get; set; }
        
        [Required]
        public string Title { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        
        public string Genre { get; set; }

        [DataType(DataType.Currency)]
        [Range(1,100)]
        public decimal Fare { get; set; }

        [StringLength(2)]
        [RegularExpression(@"[A-Z]+")]
        public string Rating { get; set; }
    }
    public class MovieDBContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
    }
}