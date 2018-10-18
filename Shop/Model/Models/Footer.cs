
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Model
{

    [Table("Footers")]
    public class Footer
    {

        [Key]
        public string Id { get; set; }
        
        [Required]
        public string Content { get; set; }

    }
}