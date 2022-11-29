namespace Av2Web2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Plano_De_Conta
    {
        [Key]
        [StringLength(31)]
        public string TXT_Plano_Conta { get; set; }

        [StringLength(150)]
        public string TXT_Descricao { get; set; }

        [StringLength(7)]
        public string TXT_Tipo { get; set; }

        [StringLength(50)]
        public string TXT_Login { get; set; }

        public DateTime? DAT_Atualizacao { get; set; }
    }
}
