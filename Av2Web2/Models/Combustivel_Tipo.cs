namespace Av2Web2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Combustivel_Tipo
    {
        [Key]
        public long NUM_Combustivel { get; set; }

        [StringLength(50)]
        public string TXT_Nome { get; set; }
    }
}
