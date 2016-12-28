namespace CRUD.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class table_programador : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Programadores",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Skype = c.String(),
                        Telefone = c.String(),
                        Email = c.String(),
                        Linkdin = c.String(),
                        Cidade = c.String(),
                        Estado = c.String(),
                        SalarioHora = c.String(),
                        SalarioMes = c.String(),
                        CSharp = c.Int(nullable: false),
                        Asp = c.Int(nullable: false),
                        Angular = c.Int(nullable: false),
                        Jquery = c.Int(nullable: false),
                        Bootstrap = c.Int(nullable: false),
                        Wordpress = c.Int(nullable: false),
                        Php = c.Int(nullable: false),
                        Android = c.Int(nullable: false),
                        Ios = c.Int(nullable: false),
                        Ionic = c.Int(nullable: false),
                        Portifolio = c.String(),
                        Linguagens = c.String(),
                        Trabalhos = c.String(),
                        GerenciadorWeb = c.String(),
                        EditorImagem = c.String(),
                        Interesse = c.String(),
                        Curso = c.String(),
                        Horas = c.String(),
                        Horario = c.String(),
                        CLT = c.Boolean(nullable: false),
                        Freelancer = c.Boolean(nullable: false),
                        Estagio = c.Boolean(nullable: false),
                        Banco = c.String(),
                        Comentarios = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Programadores");
        }
    }
}
