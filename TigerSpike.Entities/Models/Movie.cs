using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TigerSpike.Entities.Models
{
    [Table("Movie", Schema = "dbo")]
    public class Movie: BaseEntity
    {
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string ThumbnailPath { get; set; }
        public string FullImagePath { get; set; }
        public string Rating { get; set; }
        public DateTime ReleaseDate { get; set; }
        public List<Screen> ScreenTimings { get; set; }
    }
}
