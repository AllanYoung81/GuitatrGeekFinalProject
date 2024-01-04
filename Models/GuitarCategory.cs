namespace GuitarGeekFinalProject.Models
{
    public class GuitarCategory
    {
        public int GuitarID { get; set; }
        public string Brand { get; set; }

        public string Model { get; set; }

        public string GuitarType { get; set; }

        public double Price { get; set; }

        public bool OnSale { get; set; }

        public string ForSkillLevel { get; set; }
    }
}
