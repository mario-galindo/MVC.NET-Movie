using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;


namespace MvcMovie.Models
{
    public class Movie
    {
        public int ID { get; set; }

        [Display(Name = "Titulo")]
        public string Title { get; set; }

        [Display(Name = "Fecha de Liberacion")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}",ApplyFormatInEditMode =true)]

        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Genero")]
        public string Genre { get; set; }

        [Display(Name = "Precio")]
        public decimal Price { get; set; }
    }

    public class MovieDBContext : DbContext {
        public DbSet<Movie> Movies { get; set; }
    }
}