using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace MusicWebApp.Models
{
    public class Genre
    {
        [Key]
        public int genre_id { get; set; }
        public string genre_name { get; set; }
        public string genre_description { get; set; }

        public virtual ICollection<Album> Albums { get; set; }
    }
}