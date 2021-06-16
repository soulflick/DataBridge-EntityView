using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataBridge.Shared.Entities
{
    [Table("Companies")]
    public partial class Company : BaseEntity
    {
        [Required]
        [Column("CompanyName")]
        public string CompanyName { get; set; }
        [Required]
        [Column("InternalName")]
        public string InternalName { get; set; }
        [Required]
        [Column("Address")]
        public string Address { get; set; }
    }
}
