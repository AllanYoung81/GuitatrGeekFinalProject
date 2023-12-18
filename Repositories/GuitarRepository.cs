using System.Data;
using Dapper;
using GuitatrGeekFinalProject.Models;

namespace GuitatrGeekFinalProject.Repositories
{
   
    public class GuitarRepository:IGuitarRepository
    {
       
        private readonly IDbConnection _conn;

        public GuitarRepository(IDbConnection conn)
        {
            _conn = conn;
        }
        public IEnumerable<Guitar> GetAllGuitars()
        {
            return _conn.Query<Guitar>("SELECT * FROM guitar");

        }
    }
}
