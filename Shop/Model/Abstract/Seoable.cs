using System.ComponentModel.DataAnnotations;

namespace Shop.Model
{


    public abstract class Seoable : ISeoable
    {

        [MaxLength(256)]
        public string MetaKeyword { get; set; }

        [MaxLength(256)]
        public string MetaDescription { get; set; }
    }
}