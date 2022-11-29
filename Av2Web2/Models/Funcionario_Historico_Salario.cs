namespace Av2Web2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Funcionario_Historico_Salario
    {
        [Key]
        public long NUM_Chave { get; set; }

        [StringLength(14)]
        public string TXT_CPF { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? NUM_Salario { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DAT_Aumento { get; set; }
    }
}
