using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace BookMania.Models
{
    public class Book
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author_Name { get; set; }
        public string Type { get; set; }
        public string Genre { get; set; }
        public float Price { get; set; }
        public float Rating { get; set; }
        public string ImageURL { get; set; }
    }
}
