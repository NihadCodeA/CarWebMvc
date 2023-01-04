namespace CarWebApp.Models
{
    public class Model
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public string Name { get; set; }
        public Brand Brand { get; set; }
    }
}
