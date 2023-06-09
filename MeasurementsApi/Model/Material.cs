namespace MeasurementsApi.Model
{
    public class Material
    {
        public int Id { get; set; }
        public string Name { get; set; }   
        public string Description { get; set; }
        public string Code { get; set; }
        public string ImageUrl { get; set; }
        public int Quantity { get; set; }
        public string UnitOfMeasurement { get; set; }
        public int PricePerUnit { get; set; }

  
    }
}
