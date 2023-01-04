namespace CarWebApp.Models
{
    public class CarImage
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public string ImgUrl { get; set; }
        public Car Car { get; set; }
    }
}
