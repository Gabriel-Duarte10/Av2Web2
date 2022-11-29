namespace Av2Web2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SCD_Grupo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NUM_Grupo { get; set; }

        [Required]
        [StringLength(40)]
        public string TXT_Nome { get; set; }
    }
}
