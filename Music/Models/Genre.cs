using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Music.Models
{
    public class Genre
    {
        public int GenreID { get; set; }
        [Required(ErrorMessage ="Name is required for this field")]
        [StringLength(20,ErrorMessage ="The genre's name cannot exceed 20 characters")]
        public string Name { get; set; }
        public List<Album> Albums { get; set; }
    }
}