namespace Av2Web2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Funcionario_Certificados
    {
        [Key]
        public long NUM_Chave { get; set; }

        [StringLength(14)]
        public string TXT_CPF { get; set; }

        [StringLength(50)]
        public string TXT_Certificado { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DAT_Certificado { get; set; }

        public int? NUM_Meses_Validade { get; set; }
    }
}
