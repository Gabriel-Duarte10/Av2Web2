namespace Av2Web2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tipo_Recebimento
    {
        [Key]
        [StringLength(50)]
        public string TXT_Recebimento { get; set; }

        [StringLength(150)]
        public string TXT_Descricao { get; set; }

        [StringLength(50)]
        public string TXT_Login { get; set; }

        public DateTime? DAT_Atualizacao { get; set; }
    }
}
