using GuitarGeekFinalProject.Models;

namespace GuitarGeekFinalProject.Repositories
{
    public interface IGuitarRepository
    {
        public IEnumerable<Guitar> GetAllGuitars();
        Guitar GetGuitar(int id);
        public void UpdateGuitar(Guitar guitar);

        public void InsertGuitar(Guitar guitarToInsert);

        public IEnumerable<GuitarCategory> GetGuitarCategories();

        public Guitar AssignGuitarCategory();

        public void DeleteGuitar(Guitar guitar);
    }
}
