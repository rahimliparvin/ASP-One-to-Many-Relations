namespace EntityFramework_Slider.Models
{
    public class Advanced : BaseEntity
    {
        public string? Image { get; set; }
        public string? Offer { get; set; }  
        public int AboutId { get; set; }
        public About About { get; set; }
    }

}
