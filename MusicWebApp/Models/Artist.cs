using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace MusicWebApp.Models
{
    public class Artist
    {
        [Key]
        public int artist_id { get; set; }
        public string artist_name { get; set; }

        public virtual ICollection<Album> Albums { get; set; }
    }
}