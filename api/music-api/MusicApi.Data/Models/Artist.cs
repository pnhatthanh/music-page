using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MusicApi.Data.Models
{
    public class Artist
    {
        [Key]
        public Guid ArtistId { get; set; }=Guid.NewGuid();
        public string ArtistName { get; set; }="";
        public string Country{ get; set; }="";
        public int YearOfBirth{ get; set; }
        public string ImagePath{ get; set; }="";
        public int Flowers { get; set; } = 0;
        public string About { get; set; } = ""; 
    }
}