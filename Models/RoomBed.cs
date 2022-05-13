using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Hotel.Models
{

    public class RoomBed
    {
        [Key]
        public int OneBedId  { get; set; }
        public int TwoBedId { get; set; }
        public int ThreeBedId { get; set; }
        public int ForBedId { get; set; }
    }
}
