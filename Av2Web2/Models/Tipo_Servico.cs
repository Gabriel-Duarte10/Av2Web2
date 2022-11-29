namespace Av2Web2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tipo_Servico
    {
        [Key]
        public long NUM_Servico { get; set; }

        [StringLength(50)]
        public string TXT_Descricao { get; set; }

        [StringLength(18)]
        public string TXT_CNPJ { get; set; }
    }
}
