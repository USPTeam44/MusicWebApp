using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MusicWebApp.Models;
using System.Data.Entity;

namespace MusicWebApp.DAL
{
    public class DatabaseSeeder : System.Data.Entity.DropCreateDatabaseIfModelChanges<MusicContext>
    {
        protected override void Seed(MusicContext context)
        {
            var artists = new List<Artist>
            {
            new Artist{artist_id=1, artist_name="Jeremy"},
            new Artist{artist_id=2, artist_name="Bears and hunters"},
            new Artist{artist_id=3, artist_name="Moose blood"},
            new Artist{artist_id=4, artist_name="Royal blood"},
            new Artist{artist_id=5, artist_name="Artic monkeys"},
            new Artist{artist_id=6, artist_name="Have mercy"},
            };

            artists.ForEach(s => context.Artist.Add(s));
            context.SaveChanges();
            var genres = new List<Genre>
            {
            new Genre{genre_id=1050,genre_name="Emo rock",genre_description="Eternal suffering and desire to commit suicide.",},
            new Genre{genre_id=4022,genre_name="Post rock",genre_description="Blurry dark self-healing experience.",},
            new Genre{genre_id=4041,genre_name="Blues rock",genre_description="Whyskey pouring until oblivion.",},
            new Genre{genre_id=1045,genre_name="Experimental new wave shoegaze",genre_description="Monna Lisa of art music",},
            };
            genres.ForEach(s => context.Genre.Add(s));
            context.SaveChanges();
            var albums = new List<Album>
            {
            new Album{artist_id=1,genre_id=4041,album_id=1, album_name="Wasting light", album_price=4.50, album_recording_company = "Topshelf records" },
            new Album{artist_id=2,genre_id=1050,album_id=2, album_name="The night it all began", album_price=10.20, album_recording_company = "Topshelf records" },
            new Album{artist_id=3,genre_id=4041,album_id=3, album_name="Missing her", album_price=5.00, album_recording_company = "Dawning sun records" },
            new Album{artist_id=4,genre_id=4022,album_id=4, album_name="Dark", album_price=8.00, album_recording_company = "Dawning sun records" },
            new Album{artist_id=5,genre_id=1050,album_id=5, album_name="Waiting for sunrise", album_price=11.80, album_recording_company = "Dawning sun records" },
            new Album{artist_id=6,genre_id=1045,album_id=6, album_name="Alone at night", album_price=2.30, album_recording_company = "Rise records" },
            new Album{artist_id=4,genre_id=4041,album_id=7, album_name="Carrying hope", album_price=22.00, album_recording_company = "Rise records" },
            new Album{artist_id=2,genre_id=1045,album_id=8, album_name="Only you", album_price=6.30, album_recording_company = "Rise records" },
            new Album{artist_id=3,genre_id=4022,album_id=9, album_name="Final", album_price=10.50, album_recording_company = "Topshelf records" },
            };
            albums.ForEach(s => context.Album.Add(s));
            context.SaveChanges();
        }
    }
}