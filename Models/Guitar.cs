namespace GuitatrGeekFinalProject.Models
{
    public class Guitar
    {
        
        public int GuitarID {  get; set; }
        public string Brand { get; set; }   
        public string Model { get; set; }

        public string GuitarType { get; set; }

        public double Price { get; set; }

        public bool OnSale { get; set; }

        public string ForSkillLevel {  get; set; }  

        public IEnumerable<GuitarCategory> GuitarCategories { get; set;}
    }

}
