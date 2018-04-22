using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MusicWebApp.ViewModels
{
    public class ArtistAlbums
    {
       // [DataType(DataType.int)]
        public String album_recording_company { get; set; }

        public int AlbumCount { get; set; }
    }
}