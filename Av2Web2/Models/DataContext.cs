using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Av2Web2.Models
{
    public partial class DataContext : DbContext
    {
        public DataContext()
            : base("name=DataContext")
        {
        }

        public virtual DbSet<Combustivel_Tipo> Combustivel_Tipo { get; set; }
        public virtual DbSet<Empresa> Empresa { get; set; }
        public virtual DbSet<ETE> ETE { get; set; }
        public virtual DbSet<Fornecedor> Fornecedor { get; set; }
        public virtual DbSet<Funcionario> Funcionario { get; set; }
        public virtual DbSet<Funcionario_Certificados> Funcionario_Certificados { get; set; }
        public virtual DbSet<Funcionario_Historico_Salario> Funcionario_Historico_Salario { get; set; }
        public virtual DbSet<Plano_De_Conta> Plano_De_Conta { get; set; }
        public virtual DbSet<Tipo_Recebimento> Tipo_Recebimento { get; set; }
        public virtual DbSet<Tipo_Servico> Tipo_Servico { get; set; }
        public virtual DbSet<Veiculo> Veiculo { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Combustivel_Tipo>()
                .Property(e => e.TXT_Nome)
                .IsUnicode(false);

            modelBuilder.Entity<Empresa>()
                .Property(e => e.TXT_CNPJ)
                .IsUnicode(false);

            modelBuilder.Entity<Empresa>()
                .Property(e => e.TXT_Razao_Social)
                .IsUnicode(false);

            modelBuilder.Entity<Empresa>()
                .Property(e => e.TXT_Fantasia)
                .IsUnicode(false);

            modelBuilder.Entity<Empresa>()
                .Property(e => e.TXT_Inscricao_Estadual)
                .IsUnicode(false);

            modelBuilder.Entity<Empresa>()
                .Property(e => e.TXT_Inscricao_Municipal)
                .IsUnicode(false);

            modelBuilder.Entity<Empresa>()
                .Property(e => e.TXT_Login)
                .IsUnicode(false);

            modelBuilder.Entity<Empresa>()
                .Property(e => e.TXT_Endereco)
                .IsUnicode(false);

            modelBuilder.Entity<Empresa>()
                .Property(e => e.TXT_Complemento)
                .IsUnicode(false);

            modelBuilder.Entity<Empresa>()
                .Property(e => e.TXT_Bairro)
                .IsUnicode(false);

            modelBuilder.Entity<Empresa>()
                .Property(e => e.TXT_Estado)
                .IsUnicode(false);

            modelBuilder.Entity<Empresa>()
                .Property(e => e.TXT_Cidade)
                .IsUnicode(false);

            modelBuilder.Entity<Empresa>()
                .Property(e => e.TXT_CEP)
                .IsUnicode(false);

            modelBuilder.Entity<ETE>()
                .Property(e => e.TXT_Cliente)
                .IsUnicode(false);

            modelBuilder.Entity<ETE>()
                .Property(e => e.TXT_Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<Fornecedor>()
                .Property(e => e.TXT_Fornecedor)
                .IsUnicode(false);

            modelBuilder.Entity<Fornecedor>()
                .Property(e => e.TXT_CPF)
                .IsUnicode(false);

            modelBuilder.Entity<Fornecedor>()
                .Property(e => e.TXT_CNPJ)
                .IsUnicode(false);

            modelBuilder.Entity<Fornecedor>()
                .Property(e => e.TXT_Razao_Social)
                .IsUnicode(false);

            modelBuilder.Entity<Fornecedor>()
                .Property(e => e.TXT_Fantasia)
                .IsUnicode(false);

            modelBuilder.Entity<Fornecedor>()
                .Property(e => e.TXT_Endereco)
                .IsUnicode(false);

            modelBuilder.Entity<Fornecedor>()
                .Property(e => e.TXT_Complemento)
                .IsUnicode(false);

            modelBuilder.Entity<Fornecedor>()
                .Property(e => e.TXT_Bairro)
                .IsUnicode(false);

            modelBuilder.Entity<Fornecedor>()
                .Property(e => e.TXT_Estado)
                .IsUnicode(false);

            modelBuilder.Entity<Fornecedor>()
                .Property(e => e.TXT_Cidade)
                .IsUnicode(false);

            modelBuilder.Entity<Fornecedor>()
                .Property(e => e.TXT_CEP)
                .IsUnicode(false);

            modelBuilder.Entity<Fornecedor>()
                .Property(e => e.TXT_Inscricao_Estadual)
                .IsUnicode(false);

            modelBuilder.Entity<Fornecedor>()
                .Property(e => e.TXT_Inscricao_Municipal)
                .IsUnicode(false);

            modelBuilder.Entity<Fornecedor>()
                .Property(e => e.TXT_Telefone_Fixo)
                .IsUnicode(false);

            modelBuilder.Entity<Fornecedor>()
                .Property(e => e.TXT_Telefone_Celular)
                .IsUnicode(false);

            modelBuilder.Entity<Fornecedor>()
                .Property(e => e.TXT_Telefone_Contato)
                .IsUnicode(false);

            modelBuilder.Entity<Fornecedor>()
                .Property(e => e.TXT_Email_Contato)
                .IsUnicode(false);

            modelBuilder.Entity<Fornecedor>()
                .Property(e => e.TXT_Email_Central)
                .IsUnicode(false);

            modelBuilder.Entity<Fornecedor>()
                .Property(e => e.TXT_Login)
                .IsUnicode(false);

            modelBuilder.Entity<Fornecedor>()
                .Property(e => e.TXT_Gestor)
                .IsUnicode(false);

            modelBuilder.Entity<Fornecedor>()
                .Property(e => e.TXT_Banco)
                .IsUnicode(false);

            modelBuilder.Entity<Fornecedor>()
                .Property(e => e.TXT_Agencia)
                .IsUnicode(false);

            modelBuilder.Entity<Fornecedor>()
                .Property(e => e.TXT_Conta)
                .IsUnicode(false);

            modelBuilder.Entity<Funcionario>()
                .Property(e => e.TXT_CPF)
                .IsUnicode(false);

            modelBuilder.Entity<Funcionario>()
                .Property(e => e.TXT_CNPJ)
                .IsUnicode(false);

            modelBuilder.Entity<Funcionario>()
                .Property(e => e.TXT_Nome)
                .IsUnicode(false);

            modelBuilder.Entity<Funcionario>()
                .Property(e => e.TXT_Pai)
                .IsUnicode(false);

            modelBuilder.Entity<Funcionario>()
                .Property(e => e.TXT_Mae)
                .IsUnicode(false);

            modelBuilder.Entity<Funcionario>()
                .Property(e => e.TXT_Endereco)
                .IsUnicode(false);

            modelBuilder.Entity<Funcionario>()
                .Property(e => e.TXT_Complemento)
                .IsUnicode(false);

            modelBuilder.Entity<Funcionario>()
                .Property(e => e.TXT_Bairro)
                .IsUnicode(false);

            modelBuilder.Entity<Funcionario>()
                .Property(e => e.TXT_Estado)
                .IsUnicode(false);

            modelBuilder.Entity<Funcionario>()
                .Property(e => e.TXT_Cidade)
                .IsUnicode(false);

            modelBuilder.Entity<Funcionario>()
                .Property(e => e.TXT_CEP)
                .IsUnicode(false);

            modelBuilder.Entity<Funcionario>()
                .Property(e => e.TXT_Telefone)
                .IsUnicode(false);

            modelBuilder.Entity<Funcionario>()
                .Property(e => e.TXT_Telefone_Celular)
                .IsUnicode(false);

            modelBuilder.Entity<Funcionario>()
                .Property(e => e.TXT_Email)
                .IsUnicode(false);

            modelBuilder.Entity<Funcionario>()
                .Property(e => e.TXT_Reservista)
                .IsUnicode(false);

            modelBuilder.Entity<Funcionario>()
                .Property(e => e.TXT_Eleitor)
                .IsUnicode(false);

            modelBuilder.Entity<Funcionario>()
                .Property(e => e.TXT_Eleitor_Zona)
                .IsUnicode(false);

            modelBuilder.Entity<Funcionario>()
                .Property(e => e.TXT_Eleitor_Secao)
                .IsUnicode(false);

            modelBuilder.Entity<Funcionario>()
                .Property(e => e.TXT_CTPS)
                .IsUnicode(false);

            modelBuilder.Entity<Funcionario>()
                .Property(e => e.TXT_CTPS_Serie)
                .IsUnicode(false);

            modelBuilder.Entity<Funcionario>()
                .Property(e => e.TXT_RG)
                .IsUnicode(false);

            modelBuilder.Entity<Funcionario>()
                .Property(e => e.TXT_PIS)
                .IsUnicode(false);

            modelBuilder.Entity<Funcionario>()
                .Property(e => e.TXT_Login)
                .IsUnicode(false);

            modelBuilder.Entity<Funcionario>()
                .Property(e => e.TXT_Banco)
                .IsUnicode(false);

            modelBuilder.Entity<Funcionario>()
                .Property(e => e.TXT_Agencia)
                .IsUnicode(false);

            modelBuilder.Entity<Funcionario>()
                .Property(e => e.TXT_Conta)
                .IsUnicode(false);

            modelBuilder.Entity<Funcionario_Certificados>()
                .Property(e => e.TXT_CPF)
                .IsUnicode(false);

            modelBuilder.Entity<Funcionario_Certificados>()
                .Property(e => e.TXT_Certificado)
                .IsUnicode(false);

            modelBuilder.Entity<Funcionario_Historico_Salario>()
                .Property(e => e.TXT_CPF)
                .IsUnicode(false);

            modelBuilder.Entity<Plano_De_Conta>()
                .Property(e => e.TXT_Plano_Conta)
                .IsUnicode(false);

            modelBuilder.Entity<Plano_De_Conta>()
                .Property(e => e.TXT_Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<Plano_De_Conta>()
                .Property(e => e.TXT_Tipo)
                .IsUnicode(false);

            modelBuilder.Entity<Plano_De_Conta>()
                .Property(e => e.TXT_Login)
                .IsUnicode(false);

            modelBuilder.Entity<Tipo_Recebimento>()
                .Property(e => e.TXT_Recebimento)
                .IsUnicode(false);

            modelBuilder.Entity<Tipo_Recebimento>()
                .Property(e => e.TXT_Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<Tipo_Recebimento>()
                .Property(e => e.TXT_Login)
                .IsUnicode(false);

            modelBuilder.Entity<Tipo_Servico>()
                .Property(e => e.TXT_Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<Tipo_Servico>()
                .Property(e => e.TXT_CNPJ)
                .IsUnicode(false);

            modelBuilder.Entity<Veiculo>()
                .Property(e => e.TXT_Placa)
                .IsUnicode(false);

            modelBuilder.Entity<Veiculo>()
                .Property(e => e.TXT_CNPJ)
                .IsUnicode(false);

            modelBuilder.Entity<Veiculo>()
                .Property(e => e.TXT_UF)
                .IsUnicode(false);

            modelBuilder.Entity<Veiculo>()
                .Property(e => e.TXT_Renavam)
                .IsUnicode(false);

            modelBuilder.Entity<Veiculo>()
                .Property(e => e.TXT_Marca)
                .IsUnicode(false);

            modelBuilder.Entity<Veiculo>()
                .Property(e => e.TXT_Chassi)
                .IsUnicode(false);

            modelBuilder.Entity<Veiculo>()
                .Property(e => e.TXT_Cor)
                .IsUnicode(false);

            modelBuilder.Entity<Veiculo>()
                .Property(e => e.TXT_Login)
                .IsUnicode(false);
        }
    }
}
