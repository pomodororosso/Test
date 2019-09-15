namespace JustEat.Domain
{
    public class RestaurantResponse
    {
        public Restaurant[] Restaurants { get; set; }
        public string ShortResultText { get; set; }
        public string Area { get; set; }
        public object Errors { get; set; }
        public bool HasErrors { get; set; }
    }
}
