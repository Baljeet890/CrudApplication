using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Category Name")]
        [MaxLength(30)]
        public string Name { get; set; }
        [DisplayName("Display Order")]
        [Range(1, 100,ErrorMessage ="Please input valid value")]
          public int  DisplayOrder { get; set; }
    }

}
