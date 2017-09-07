using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusicShop.Model.Models
{
    [Table("Menus")]
    public class Menu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string URL { get; set; }

        public int? DisplayOrder { get; set; }

        [Required]
        public long GroupID { get; set; }

        [ForeignKey("GroupID")]
        public virtual MenuGroup MenuGroup { get; set; }

        public string Target { get; set; }

        [Required]
        public bool Status { get; set; }
    }
}