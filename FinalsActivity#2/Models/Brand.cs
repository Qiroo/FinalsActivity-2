using System.ComponentModel.DataAnnotations.Schema;

namespace FinalsActivity_2.Models
{
    [Table("Brands")]
    public class Brand
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BrandID { get; set; }
        public string BrandName { get; set; }
    }
}
