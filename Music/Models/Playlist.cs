using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;

namespace Music.Models
{
    public class Playlist
    {
        public int PlaylistID { get; set; }
        [Required]
        public string Name { get; set; }
        public List<Album> Albums { get; set; }            
    }
}
