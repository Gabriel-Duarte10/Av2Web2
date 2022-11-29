namespace Av2Web2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Funcionario")]
    public partial class Funcionario
    {
        [Key]
        [StringLength(14)]
        public string TXT_CPF { get; set; }

        [Required]
        [StringLength(18)]
        public string TXT_CNPJ { get; set; }

        [StringLength(150)]
        public string TXT_Nome { get; set; }

        [StringLength(150)]
        public string TXT_Pai { get; set; }

        [StringLength(150)]
        public string TXT_Mae { get; set; }

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

        [StringLength(50)]
        public string TXT_Telefone { get; set; }

        [StringLength(50)]
        public string TXT_Telefone_Celular { get; set; }

        [StringLength(150)]
        public string TXT_Email { get; set; }

        [StringLength(50)]
        public string TXT_Reservista { get; set; }

        [StringLength(50)]
        public string TXT_Eleitor { get; set; }

        [StringLength(10)]
        public string TXT_Eleitor_Zona { get; set; }

        [StringLength(10)]
        public string TXT_Eleitor_Secao { get; set; }

        [StringLength(50)]
        public string TXT_CTPS { get; set; }

        [StringLength(50)]
        public string TXT_CTPS_Serie { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DAT_CTPS_Emissao { get; set; }

        [StringLength(50)]
        public string TXT_RG { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DAT_RG_Emissao { get; set; }

        [StringLength(50)]
        public string TXT_PIS { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? NUM_Salario { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DAT_Admissao { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DAT_Exame_Periodico { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DAT_Demissao { get; set; }

        [StringLength(50)]
        public string TXT_Login { get; set; }

        public DateTime? DAT_Atualizacao { get; set; }

        [StringLength(4)]
        public string TXT_Banco { get; set; }

        [StringLength(30)]
        public string TXT_Agencia { get; set; }

        [StringLength(30)]
        public string TXT_Conta { get; set; }

        public long? NUM_Funcao { get; set; }
    }
}
