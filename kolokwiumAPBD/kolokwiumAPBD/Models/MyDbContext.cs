using System.Data.Entity;
using Microsoft.EntityFrameworkCore;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;

namespace kolokwiumAPBD.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() {}
        public MyDbContext(DbContextOptions options) : base(options) {}
        public Microsoft.EntityFrameworkCore.DbSet<Artist> Artists { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Event> Events { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Organiser> Organisers { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<ArtistEvent> ArtistEvents { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<EventOrganiser> EventOrganisers { get; set; }
       
}
}