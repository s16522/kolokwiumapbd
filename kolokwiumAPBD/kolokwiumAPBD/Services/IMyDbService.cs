using kolokwiumAPBD.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace kolokwiumAPBD.Services
{
    public interface IMyDbService
    {
        public Artist GetArtist(int id);
    }
}