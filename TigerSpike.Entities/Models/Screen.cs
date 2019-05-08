using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TigerSpike.Entities.Models
{
    [Table("Screen", Schema = "dbo")]
    public class Screen: BaseEntity
    {
        public DateTime ScreeningDateTime { get; set; }        
        public string ScreenName { get; set; }
    }
}
