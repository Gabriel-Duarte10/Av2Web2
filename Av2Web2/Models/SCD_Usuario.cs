namespace Av2Web2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SCD_Usuario
    {
        [Key]
        [StringLength(150)]
        public string TXT_Login { get; set; }

        [Required]
        [StringLength(255)]
        public string TXT_Senha { get; set; }

        [Required]
        [StringLength(100)]
        public string TXT_Nome { get; set; }

        public DateTime? DAT_Cancelamento { get; set; }

        public int? NUM_Empresa { get; set; }

        public int? NUM_Grupo { get; set; }
    }
}
