using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Hotel.Models
{
    
    public class HotelStar
    {
        [Key]
        public int OneStarId { get; set; }
        public int TwoStarId { get; set; }
        public int ThreestarId { get; set; }
        public int ForBedId { get; set; }
        
    }
}
