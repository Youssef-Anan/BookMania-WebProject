namespace BookMania.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author_Name { get; set; }
        public string Type { get; set; }
        public string Genre { get; set; }
        public float Price { get; set; }
        public float Rating { get; set; }
    }
}
