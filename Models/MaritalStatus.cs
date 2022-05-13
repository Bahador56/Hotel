using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Hotel.Models
{
    
    public class MaritalStatus
    {
        [Key]
        public int MarriedId { get; set; }
        public int SingleId { get; set; }
    }
}
