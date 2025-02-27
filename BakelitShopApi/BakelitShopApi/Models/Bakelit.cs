namespace BakelitShopApi.Models
{
    public class Bakelit
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Artist { get; set; }
        public int Price { get; set; }
        public string Genre { get; set; }
        public DateTime ReleaseDate { get; set; }

        public string? ImageUrl { get; set; }
    }
}
