using System.ComponentModel.DataAnnotations;

namespace Hotel.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? PhoneNumber { get; set; }
        public string? NationalCode { get; set; }
        public DateTime ReservationDate { get; set; }
        public int MaritalStatus { get; set; }
        public int RoomsId { get; set; }
    }
}
