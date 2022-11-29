namespace Av2Web2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ETE")]
    public partial class ETE
    {
        [Key]
        public long NUM_ETE { get; set; }

        [Required]
        [StringLength(50)]
        public string TXT_Cliente { get; set; }

        [StringLength(150)]
        public string TXT_Descricao { get; set; }

        public DateTime? DAT_Inativo { get; set; }
    }
}
