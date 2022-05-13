using System.ComponentModel.DataAnnotations;

namespace Hotel.Models
{
    public class Room
    {
        [Key]
        public int RoomsId { get; set; }
        public string RoomName { get; set; }
        public string RoomNumber { get; set; }
        public int RoomBeds { get; set; }
        public int HotelId { get; set; }
    }
}
