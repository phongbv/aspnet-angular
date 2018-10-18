using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Model
{

    [Table("Menus")]
    public class Menu
    {
        
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string URL { get; set; }

        public int? DisplayOrder { get; set; }

        [Required]
        [ForeignKey(nameof(MenuGroup))]
        public int GroupId { get; set; }

        public virtual MenuGroup MenuGroup { get; set;}

        public string Target { get; set; }

        [Required]
        public bool Status { get; set; }

    }

}