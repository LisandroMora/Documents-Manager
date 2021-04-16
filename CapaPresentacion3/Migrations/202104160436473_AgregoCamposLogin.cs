namespace CapaPresentacion3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AgregoCamposLogin : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Nombre", c => c.String());
            AddColumn("dbo.AspNetUsers", "IdDepartamento", c => c.Int(nullable: false));
            AddColumn("dbo.AspNetUsers", "Cargo", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Cargo");
            DropColumn("dbo.AspNetUsers", "IdDepartamento");
            DropColumn("dbo.AspNetUsers", "Nombre");
        }
    }
}
