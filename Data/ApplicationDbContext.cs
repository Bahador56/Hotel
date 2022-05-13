using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace Hotel.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {

        #region [ApplicationDbContext]
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
                 : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Hotel.Models.Hotel>(x =>
            {
                x.HasKey(p => p.HotelId);
                x.Property(p => p.HotelName).HasMaxLength(50);
                x.Property(p => p.HotelAddress).HasMaxLength(500);
                x.Property(p => p.HotelStar);
                x.Property(p => p.HotelBads);
            });
            builder.Entity<Hotel.Models.Room>(x =>
            {
                x.HasKey(p => p.RoomsId);
            });
            builder.Entity<Hotel.Models.User>(x =>
            {
                x.HasKey(p => p.UserId);
            });
        }

        #endregion

        #region [DbSet]
        public DbSet<Hotel.Models.User> Users { get; set; }
        public DbSet<Hotel.Models.Hotel> Hotels { get; set; }
        public DbSet<Hotel.Models.Room> Rooms { get; set; }
        public DbSet<Hotel.Models.MaritalStatus> MaritalStatus { get; set; }
        public DbSet<Hotel.Models.RoomBed> RoomBeds { get; set; }
        public DbSet<Hotel.Models.HotelStar> HotelStars { get; set; }

        #endregion


    }
}




