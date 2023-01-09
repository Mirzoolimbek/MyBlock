using System.ComponentModel.DataAnnotations;

namespace MyBlock.mvc.Models
{
    public class Block
    {
        //Myblog sitega model
        [Key, Required]
        public Guid Id { get; set; }
        public DateTime Time { get; set; }
        public string Description { get; set; } = string.Empty;
        public double Price { get; set; }
        public string Image { get; set; } = string.Empty;
    }
}
