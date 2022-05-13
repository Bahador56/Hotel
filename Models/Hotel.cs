using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Hotel.Models
{

    public class Hotel
    {
        [Key]
        public int HotelId { get; set; }

        public string HotelName { get; set; }

        [Required(ErrorMessage = "فقط تعداد ستاره ها را وارد کنید")]
       
        public int HotelStar { get; set; }
        public int HotelBads { get; set; }
        public string? HotelAddress { get; set; }
       
    }
}
