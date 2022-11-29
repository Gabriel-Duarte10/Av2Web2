namespace Av2Web2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Combustivel_Tipo",
                c => new
                    {
                        NUM_Combustivel = c.Long(nullable: false, identity: true),
                        TXT_Nome = c.String(maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.NUM_Combustivel);
            
            CreateTable(
                "dbo.Empresa",
                c => new
                    {
                        TXT_CNPJ = c.String(nullable: false, maxLength: 18, unicode: false),
                        TXT_Razao_Social = c.String(nullable: false, maxLength: 150, unicode: false),
                        TXT_Fantasia = c.String(maxLength: 150, unicode: false),
                        TXT_Inscricao_Estadual = c.String(maxLength: 20, unicode: false),
                        TXT_Inscricao_Municipal = c.String(maxLength: 20, unicode: false),
                        DAT_Desativacao = c.DateTime(storeType: "date"),
                        TXT_Login = c.String(maxLength: 50, unicode: false),
                        DAT_Atualizacao = c.DateTime(),
                        TXT_Endereco = c.String(maxLength: 250, unicode: false),
                        NUM_Numero = c.Int(),
                        TXT_Complemento = c.String(maxLength: 50, unicode: false),
                        TXT_Bairro = c.String(maxLength: 150, unicode: false),
                        TXT_Estado = c.String(maxLength: 2, unicode: false),
                        TXT_Cidade = c.String(maxLength: 150, unicode: false),
                        TXT_CEP = c.String(maxLength: 9, unicode: false),
                        Empresa2_TXT_CNPJ = c.String(nullable: false, maxLength: 18, unicode: false),
                    })
                .PrimaryKey(t => t.TXT_CNPJ)
                .ForeignKey("dbo.Empresa", t => t.Empresa2_TXT_CNPJ)
                .Index(t => t.Empresa2_TXT_CNPJ);
            
            CreateTable(
                "dbo.Veiculo",
                c => new
                    {
                        TXT_Placa = c.String(nullable: false, maxLength: 14, unicode: false),
                        TXT_CNPJ = c.String(nullable: false, maxLength: 18, unicode: false),
                        TXT_UF = c.String(maxLength: 2, unicode: false),
                        TXT_Renavam = c.String(maxLength: 50, unicode: false),
                        TXT_Marca = c.String(maxLength: 150, unicode: false),
                        NUM_Ano_Fabricacao = c.Int(),
                        NUM_Ano_Modelo = c.Int(),
                        TXT_Chassi = c.String(maxLength: 50, unicode: false),
                        TXT_Cor = c.String(maxLength: 50, unicode: false),
                        NUM_Tipo_Combustivel = c.Long(),
                        BOL_Ativo = c.Int(),
                        NUM_Tipo_Servico = c.Long(),
                        NUM_Metro_Cubico = c.Decimal(precision: 18, scale: 2, storeType: "numeric"),
                        NUM_Tonelada = c.Decimal(precision: 18, scale: 2, storeType: "numeric"),
                        NUM_Minimo_Horas = c.Long(),
                        TXT_Login = c.String(maxLength: 50, unicode: false),
                        DAT_Atualizacao = c.DateTime(),
                    })
                .PrimaryKey(t => t.TXT_Placa)
                .ForeignKey("dbo.Empresa", t => t.TXT_CNPJ)
                .Index(t => t.TXT_CNPJ);
            
            CreateTable(
                "dbo.ETE",
                c => new
                    {
                        NUM_ETE = c.Long(nullable: false, identity: true),
                        TXT_Cliente = c.String(nullable: false, maxLength: 50, unicode: false),
                        TXT_Descricao = c.String(maxLength: 150, unicode: false),
                        DAT_Inativo = c.DateTime(),
                    })
                .PrimaryKey(t => t.NUM_ETE);
            
            CreateTable(
                "dbo.Fornecedor",
                c => new
                    {
                        TXT_Fornecedor = c.String(nullable: false, maxLength: 50, unicode: false),
                        TXT_CPF = c.String(nullable: false, maxLength: 14, unicode: false),
                        TXT_CNPJ = c.String(nullable: false, maxLength: 18, unicode: false),
                        TXT_Razao_Social = c.String(nullable: false, maxLength: 150, unicode: false),
                        TXT_Fantasia = c.String(maxLength: 150, unicode: false),
                        TXT_Endereco = c.String(maxLength: 250, unicode: false),
                        NUM_Numero = c.Int(),
                        TXT_Complemento = c.String(maxLength: 50, unicode: false),
                        TXT_Bairro = c.String(maxLength: 150, unicode: false),
                        TXT_Estado = c.String(maxLength: 2, unicode: false),
                        TXT_Cidade = c.String(maxLength: 150, unicode: false),
                        TXT_CEP = c.String(maxLength: 9, unicode: false),
                        TXT_Inscricao_Estadual = c.String(maxLength: 20, unicode: false),
                        TXT_Inscricao_Municipal = c.String(maxLength: 20, unicode: false),
                        TXT_Telefone_Fixo = c.String(maxLength: 50, unicode: false),
                        TXT_Telefone_Celular = c.String(maxLength: 50, unicode: false),
                        TXT_Telefone_Contato = c.String(maxLength: 50, unicode: false),
                        TXT_Email_Contato = c.String(maxLength: 150, unicode: false),
                        TXT_Email_Central = c.String(maxLength: 150, unicode: false),
                        TXT_Login = c.String(maxLength: 50, unicode: false),
                        DAT_Atualizacao = c.DateTime(),
                        TXT_Gestor = c.String(maxLength: 150, unicode: false),
                        TXT_Banco = c.String(maxLength: 4, unicode: false),
                        TXT_Agencia = c.String(maxLength: 30, unicode: false),
                        TXT_Conta = c.String(maxLength: 30, unicode: false),
                    })
                .PrimaryKey(t => t.TXT_Fornecedor);
            
            CreateTable(
                "dbo.Funcionario",
                c => new
                    {
                        TXT_CPF = c.String(nullable: false, maxLength: 14, unicode: false),
                        TXT_CNPJ = c.String(nullable: false, maxLength: 18, unicode: false),
                        TXT_Nome = c.String(maxLength: 150, unicode: false),
                        TXT_Pai = c.String(maxLength: 150, unicode: false),
                        TXT_Mae = c.String(maxLength: 150, unicode: false),
                        TXT_Endereco = c.String(maxLength: 250, unicode: false),
                        NUM_Numero = c.Int(),
                        TXT_Complemento = c.String(maxLength: 50, unicode: false),
                        TXT_Bairro = c.String(maxLength: 150, unicode: false),
                        TXT_Estado = c.String(maxLength: 2, unicode: false),
                        TXT_Cidade = c.String(maxLength: 150, unicode: false),
                        TXT_CEP = c.String(maxLength: 9, unicode: false),
                        TXT_Telefone = c.String(maxLength: 50, unicode: false),
                        TXT_Telefone_Celular = c.String(maxLength: 50, unicode: false),
                        TXT_Email = c.String(maxLength: 150, unicode: false),
                        TXT_Reservista = c.String(maxLength: 50, unicode: false),
                        TXT_Eleitor = c.String(maxLength: 50, unicode: false),
                        TXT_Eleitor_Zona = c.String(maxLength: 10, unicode: false),
                        TXT_Eleitor_Secao = c.String(maxLength: 10, unicode: false),
                        TXT_CTPS = c.String(maxLength: 50, unicode: false),
                        TXT_CTPS_Serie = c.String(maxLength: 50, unicode: false),
                        DAT_CTPS_Emissao = c.DateTime(storeType: "date"),
                        TXT_RG = c.String(maxLength: 50, unicode: false),
                        DAT_RG_Emissao = c.DateTime(storeType: "date"),
                        TXT_PIS = c.String(maxLength: 50, unicode: false),
                        NUM_Salario = c.Decimal(precision: 18, scale: 2, storeType: "numeric"),
                        DAT_Admissao = c.DateTime(storeType: "date"),
                        DAT_Exame_Periodico = c.DateTime(storeType: "date"),
                        DAT_Demissao = c.DateTime(storeType: "date"),
                        TXT_Login = c.String(maxLength: 50, unicode: false),
                        DAT_Atualizacao = c.DateTime(),
                        TXT_Banco = c.String(maxLength: 4, unicode: false),
                        TXT_Agencia = c.String(maxLength: 30, unicode: false),
                        TXT_Conta = c.String(maxLength: 30, unicode: false),
                        NUM_Funcao = c.Long(),
                    })
                .PrimaryKey(t => t.TXT_CPF);
            
            CreateTable(
                "dbo.Funcionario_Certificados",
                c => new
                    {
                        NUM_Chave = c.Long(nullable: false, identity: true),
                        TXT_CPF = c.String(maxLength: 14, unicode: false),
                        TXT_Certificado = c.String(maxLength: 50, unicode: false),
                        DAT_Certificado = c.DateTime(storeType: "date"),
                        NUM_Meses_Validade = c.Int(),
                    })
                .PrimaryKey(t => t.NUM_Chave);
            
            CreateTable(
                "dbo.Funcionario_Historico_Salario",
                c => new
                    {
                        NUM_Chave = c.Long(nullable: false, identity: true),
                        TXT_CPF = c.String(maxLength: 14, unicode: false),
                        NUM_Salario = c.Decimal(precision: 18, scale: 2, storeType: "numeric"),
                        DAT_Aumento = c.DateTime(storeType: "date"),
                    })
                .PrimaryKey(t => t.NUM_Chave);
            
            CreateTable(
                "dbo.Plano_De_Conta",
                c => new
                    {
                        TXT_Plano_Conta = c.String(nullable: false, maxLength: 31, unicode: false),
                        TXT_Descricao = c.String(maxLength: 150, unicode: false),
                        TXT_Tipo = c.String(maxLength: 7, unicode: false),
                        TXT_Login = c.String(maxLength: 50, unicode: false),
                        DAT_Atualizacao = c.DateTime(),
                    })
                .PrimaryKey(t => t.TXT_Plano_Conta);
            
            CreateTable(
                "dbo.Tipo_Recebimento",
                c => new
                    {
                        TXT_Recebimento = c.String(nullable: false, maxLength: 50, unicode: false),
                        TXT_Descricao = c.String(maxLength: 150, unicode: false),
                        TXT_Login = c.String(maxLength: 50, unicode: false),
                        DAT_Atualizacao = c.DateTime(),
                    })
                .PrimaryKey(t => t.TXT_Recebimento);
            
            CreateTable(
                "dbo.Tipo_Servico",
                c => new
                    {
                        NUM_Servico = c.Long(nullable: false, identity: true),
                        TXT_Descricao = c.String(maxLength: 50, unicode: false),
                        TXT_CNPJ = c.String(maxLength: 18, unicode: false),
                    })
                .PrimaryKey(t => t.NUM_Servico);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Veiculo", "TXT_CNPJ", "dbo.Empresa");
            DropForeignKey("dbo.Empresa", "Empresa2_TXT_CNPJ", "dbo.Empresa");
            DropIndex("dbo.Veiculo", new[] { "TXT_CNPJ" });
            DropIndex("dbo.Empresa", new[] { "Empresa2_TXT_CNPJ" });
            DropTable("dbo.Tipo_Servico");
            DropTable("dbo.Tipo_Recebimento");
            DropTable("dbo.Plano_De_Conta");
            DropTable("dbo.Funcionario_Historico_Salario");
            DropTable("dbo.Funcionario_Certificados");
            DropTable("dbo.Funcionario");
            DropTable("dbo.Fornecedor");
            DropTable("dbo.ETE");
            DropTable("dbo.Veiculo");
            DropTable("dbo.Empresa");
            DropTable("dbo.Combustivel_Tipo");
        }
    }
}
