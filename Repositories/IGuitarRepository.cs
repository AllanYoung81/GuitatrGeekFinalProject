using GuitatrGeekFinalProject.Models;

namespace GuitatrGeekFinalProject.Repositories
{
    public interface IGuitarRepository
    {
        public IEnumerable<Guitar> GetAllGuitars();
    }
}
