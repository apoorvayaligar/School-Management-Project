namespace SchoolProject.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AgeAddedToStudentEntity : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Students", name: "Standard_StandardId", newName: "StandardId");
            RenameColumn(table: "dbo.Students", name: "Standard_Section", newName: "Section");
            RenameIndex(table: "dbo.Students", name: "IX_Standard_StandardId_Standard_Section", newName: "IX_StandardId_Section");
            AddColumn("dbo.Students", "Age", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "Age");
            RenameIndex(table: "dbo.Students", name: "IX_StandardId_Section", newName: "IX_Standard_StandardId_Standard_Section");
            RenameColumn(table: "dbo.Students", name: "Section", newName: "Standard_Section");
            RenameColumn(table: "dbo.Students", name: "StandardId", newName: "Standard_StandardId");
        }
    }
}
