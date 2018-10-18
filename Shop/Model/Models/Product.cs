

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Model
{

    [Table("Products")]
    public class Product 
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name {  get; set; }

        [Required]
        public string Alias { get; set; }

        [Required]
        public int CategoryId { get; set; }

        public string Image { get; set; }

        public string MoreImages { get; set; }

        public decimal Price { get; set; }


    }
}