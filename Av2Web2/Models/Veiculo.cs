namespace Av2Web2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Veiculo")]
    public partial class Veiculo
    {
        [Key]
        [StringLength(14)]
        public string TXT_Placa { get; set; }

        [Required]
        [StringLength(18)]
        public string TXT_CNPJ { get; set; }

        [StringLength(2)]
        public string TXT_UF { get; set; }

        [StringLength(50)]
        public string TXT_Renavam { get; set; }

        [StringLength(150)]
        public string TXT_Marca { get; set; }

        public int? NUM_Ano_Fabricacao { get; set; }

        public int? NUM_Ano_Modelo { get; set; }

        [StringLength(50)]
        public string TXT_Chassi { get; set; }

        [StringLength(50)]
        public string TXT_Cor { get; set; }

        public long? NUM_Tipo_Combustivel { get; set; }

        public int? BOL_Ativo { get; set; }

        public long? NUM_Tipo_Servico { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? NUM_Metro_Cubico { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? NUM_Tonelada { get; set; }

        public long? NUM_Minimo_Horas { get; set; }

        [StringLength(50)]
        public string TXT_Login { get; set; }

        public DateTime? DAT_Atualizacao { get; set; }
        public virtual Empresa Empresa { get; set; }

    }
}
