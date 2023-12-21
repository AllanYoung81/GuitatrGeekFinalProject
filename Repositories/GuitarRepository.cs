using System.Data;
using System.Net.Http.Headers;
using Dapper;
using GuitatrGeekFinalProject.Models;

namespace GuitatrGeekFinalProject.Repositories
{

    public class GuitarRepository : IGuitarRepository
    {

        private readonly IDbConnection _conn;

        public GuitarRepository(IDbConnection conn)
        {
            _conn = conn;
        }

        //public Guitar AssignGuitarCategory()
        //{
        //    throw new NotImplementedException();
        //}

      

        public IEnumerable<Guitar> GetAllGuitars()
        {
            return _conn.Query<Guitar>("SELECT * FROM guitar");

        }

        public Guitar GetGuitar(int id)
        {
            return _conn.QuerySingle<Guitar>("SELECT * FROM guitar WHERE GuitarID = @id", new { id = id });
        }

        //public IEnumerable<GuitarCategory> GetGuitarCategories()
        //{
        //    throw new NotImplementedException();
        //}

        //public void InsertGuitar(Guitar guitarToInsert)
        //{
        //    throw new NotImplementedException();
        //}

        public void UpdateGuitar(Guitar guitar)
        {
            _conn.Execute("UPDATE guitar SET Brand = @brand, Price = @price, Model = @model, GuitarType = @type, OnSale = @sale, ForSkillLevel = @level WHERE GuitarID = @id",
                new { brand = guitar.Brand,
                    model = guitar.Model,
                    type = guitar.GuitarType,
                    price = guitar.Price,
                    sale = guitar.OnSale,
                    level = guitar.ForSkillLevel,
                    id = guitar.GuitarID });


        }

        public void InsertGuitar(Guitar guitarToInsert)
        {
            _conn.Execute("INSERT INTO guitar (BRAND, PRICE, MODEL, GUITARTYPE, ONSALE, FORSKILLLEVEL) VALUES (@brand, @price, @model, @type, @sale, @level);",
                new
                {
                    brand = guitarToInsert.Brand,
                    model = guitarToInsert.Model,
                    type = guitarToInsert.GuitarType,
                    price = guitarToInsert.Price,
                    sale = guitarToInsert.OnSale,
                    level = guitarToInsert.ForSkillLevel,
                    id = guitarToInsert.GuitarID
                });


        }

        public IEnumerable<GuitarCategory> GetGuitarCategories()
        {
            return _conn.Query<GuitarCategory>("SELECT * FROM guitar");

        }

        public Guitar AssignGuitarCategory()
        {
            var categoryList = GetGuitarCategories();
            var guitar = new Guitar();
            guitar.GuitarCategories = categoryList;

            return guitar;

        }

        public void DeleteGuitar(Guitar guitar)
        {
            //_conn.Execute("DELETE FROM Brand WHERE GuitarID = @id;", new { id = guitar.GuitarID });
            //         _conn.Execute("DELETE FROM Model WHERE GuitarID = @id;", new { id = guitar.GuitarID });
            //         _conn.Execute("DELETE FROM GuitarType WHERE GuitarID = @id;", new { id = guitar.GuitarID });
            //_conn.Execute("DELETE FROM Price WHERE GuitarID = @id;", new { id = guitar.GuitarID });
            //_conn.Execute("DELETE FROM OnSale WHERE GuitarID = @id;", new { id = guitar.GuitarID });
            //_conn.Execute("DELETE FROM ForSkillLevel WHERE GuitarID = @id;", new { id = guitar.GuitarID });
            _conn.Execute("DELETE FROM guitar WHERE GuitarID = @id;", new { id = guitar.GuitarID });
        }


    }
}
