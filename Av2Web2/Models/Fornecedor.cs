namespace Av2Web2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Fornecedor")]
    public partial class Fornecedor
    {
        [Key]
        [StringLength(50)]
        public string TXT_Fornecedor { get; set; }

        [Required]
        [StringLength(14)]
        public string TXT_CPF { get; set; }

        [Required]
        [StringLength(18)]
        public string TXT_CNPJ { get; set; }

        [Required]
        [StringLength(150)]
        public string TXT_Razao_Social { get; set; }

        [StringLength(150)]
        public string TXT_Fantasia { get; set; }

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

        [StringLength(20)]
        public string TXT_Inscricao_Estadual { get; set; }

        [StringLength(20)]
        public string TXT_Inscricao_Municipal { get; set; }

        [StringLength(50)]
        public string TXT_Telefone_Fixo { get; set; }

        [StringLength(50)]
        public string TXT_Telefone_Celular { get; set; }

        [StringLength(50)]
        public string TXT_Telefone_Contato { get; set; }

        [StringLength(150)]
        public string TXT_Email_Contato { get; set; }

        [StringLength(150)]
        public string TXT_Email_Central { get; set; }

        [StringLength(50)]
        public string TXT_Login { get; set; }

        public DateTime? DAT_Atualizacao { get; set; }

        [StringLength(150)]
        public string TXT_Gestor { get; set; }

        [StringLength(4)]
        public string TXT_Banco { get; set; }

        [StringLength(30)]
        public string TXT_Agencia { get; set; }

        [StringLength(30)]
        public string TXT_Conta { get; set; }
    }
}
