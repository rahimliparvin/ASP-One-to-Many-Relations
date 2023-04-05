using EntityFramework_Slider.Models;

namespace EntityFramework_Slider.ViewModels
{
    public class HomeVM
    {
        public List<Slider> Sliders { get; set; }
        public IEnumerable<Blog> Blogs { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Product> Products { get; set; }
        public SliderInfo SliderInfo { get; set; }
        public About About { get; set; }
        public FlowerExpertHeader FlowerExpertHeader { get; set; }
        public IEnumerable<Expert> Experts { get; set; }
        public Subscribe Subscribe { get; set; }
        public Bloginfo Bloginfo { get; set; }
        public IEnumerable<Say> Says { get; set; }
        public IEnumerable<Instagram> Instagrams { get; set; }

    }
}
