using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataBridge.Shared.Entities
{
    [Table("Factories")]
    public partial class Factory : BaseEntity
    {
        [Required]
        [Column("FactoryName")]
        public string FactoryName { get; set; }
        [Required]
        [Column("Location")]
        public string Location { get; set; }
        [Required]
        [Column("CompanyId")]
        public Guid CompanyId { get; set; }
    }
}
