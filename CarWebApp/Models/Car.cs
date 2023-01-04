namespace CarWebApp.Models
{
    public class Car
    {
        public int Id { get; set; }
        public int ModelId { get; set; }
        public string City { get; set; }    
        public string Color { get; set; }    
        public int Engine { get; set; }    
        public double Mileage { get; set; }    
        public double Price { get; set; }  
        public byte SeatsCount { get; set; }    
        public int Year { get; set; }    
        public DateTime Date { get; set; }
        public List<CarImage> CarImages { get; set; }
        public Model Model { get; set; }
    }
}
