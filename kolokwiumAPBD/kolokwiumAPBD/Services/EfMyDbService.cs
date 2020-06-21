using kolokwiumAPBD.Models;
using Microsoft.EntityFrameworkCore;

namespace kolokwiumAPBD.Services
{
    public class EfMyDbService : MyDbContext
    {
        private readonly MyDbContext _context;

        public EfMyDbService(MyDbContext context)
        {
            _context = context;
        }

        public Artist GetArtist(int id)
        {
            return _context.Artists.Find(id);
        }
        
    }
}