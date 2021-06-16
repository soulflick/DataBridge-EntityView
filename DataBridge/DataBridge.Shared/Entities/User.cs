using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataBridge.Shared.Entities
{
    [Table("Users")]
    public partial class User : BaseEntity
    {
        [Required]
        [Column("UserName")]
        public string UserName { get; set; }
        [Required]
        [Column("CompanyId")]
        public Guid CompanyId { get; set; }
        [Column("FactoryId")]
        public Guid FactoryId { get; set; }

    }
}
