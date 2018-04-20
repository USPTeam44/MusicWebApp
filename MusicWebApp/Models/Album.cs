using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace MusicWebApp.Models
{
    public class Album
    {
        internal int artist_id;
        internal int genre_id;
        [Key]
        public int album_id { get; set; }
        public String album_name { get; set; }
        public double album_price { get; set; }
        public String album_recording_company { get; set; }

        public virtual Artist Artist { get; set; }
        public virtual Genre Genre { get; set; }
    }
}