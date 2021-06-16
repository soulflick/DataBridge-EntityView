using System;
using DataBridge.Shared.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataBridge.Shared.Entities
{
    public class BaseEntity : IEntity
    {
        [Key]
        [Column("Id")]
        public Guid Id { get; set; }
        [Required]
        [Column("Creator")]
        public Guid Creator { get; set; }
        [Required]
        [Column("Created")]
        public DateTime Created { get; set; }
        [Column("Modifier")]
        public Guid Modifier { get; set; }
        [Column("Modified")]
        public DateTime Modified { get; set; }
    }
}
