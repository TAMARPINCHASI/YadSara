namespace YadSara.Entities
{
    public class City
    {
        public int cityId { get; set; }
        public string cityName { get; set; }

        public City(int cityId, string cityName)
        {
            this.cityId = cityId;
            this.cityName = cityName;
        }
    }
}
