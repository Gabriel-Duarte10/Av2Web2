namespace Av2Web2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Empresa")]
    public partial class Empresa
    {
        [Key]
        [StringLength(18)]
        public string TXT_CNPJ { get; set; }

        [Required]
        [StringLength(150)]
        public string TXT_Razao_Social { get; set; }

        [StringLength(150)]
        public string TXT_Fantasia { get; set; }

        [StringLength(20)]
        public string TXT_Inscricao_Estadual { get; set; }

        [StringLength(20)]
        public string TXT_Inscricao_Municipal { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DAT_Desativacao { get; set; }

        [StringLength(50)]
        public string TXT_Login { get; set; }

        public DateTime? DAT_Atualizacao { get; set; }

        [StringLength(250)]
        public string TXT_Endereco { get; set; }

        public int? NUM_Numero { get; set; }

        [StringLength(50)]
        public string TXT_Complemento { get; set; }

        [StringLength(150)]
        public string TXT_Bairro { get; set; }

        [StringLength(2)]
        public string TXT_Estado { get; set; }

        [StringLength(150)]
        public string TXT_Cidade { get; set; }

        [StringLength(9)]
        public string TXT_CEP { get; set; }

    }
}
