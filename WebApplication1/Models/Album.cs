using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Album
    {
        public int AlbumId { get; set; }
        public string Title { set; get; }
        public int ArtistId { get; set; }
        public int GenreId { get; set; }
        public int Year { get; set; }
    }
}