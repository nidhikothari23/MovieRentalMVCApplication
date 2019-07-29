using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieRentalMVCApplication.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string MovieName { get; set; }
        public Genre Genre { get; set; }
        public DateTime ReleaseDate { get; set; }
        public DateTime DateAdded { get; set; }
        public int Stock { get; set; }
    }
}