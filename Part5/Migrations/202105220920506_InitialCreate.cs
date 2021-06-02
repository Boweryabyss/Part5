namespace Part5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StringHolders",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Lowercase = c.String(),
                        Uppercase = c.String(),
                        Inverted = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.StringHolders");
        }
    }
}
