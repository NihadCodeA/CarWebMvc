using CarWebApp.Models;

namespace CarWebApp.ViewModels
{
    public class HomeViewModel
    {
        public List<Brand> Brands { get; set; }
        public List<Car> Cars { get; set; }
        public List<Model> Models { get; set; }
    }
}
