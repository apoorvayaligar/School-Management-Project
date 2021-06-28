namespace SchoolProject.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FeeDetails",
                c => new
                    {
                        FeeDetailId = c.Int(nullable: false, identity: true),
                        StudentId = c.Int(nullable: false),
                        FeePaid = c.Int(nullable: false),
                        FeeDue = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.FeeDetailId)
                .ForeignKey("dbo.Students", t => t.StudentId, cascadeDelete: true)
                .Index(t => t.StudentId);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentId = c.Int(nullable: false, identity: true),
                        StudentName = c.String(maxLength: 30),
                        Standard_StandardId = c.Int(nullable: false),
                        Standard_Section = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.StudentId)
                .ForeignKey("dbo.Standards", t => new { t.Standard_StandardId, t.Standard_Section })
                .Index(t => new { t.Standard_StandardId, t.Standard_Section });
            
            CreateTable(
                "dbo.Standards",
                c => new
                    {
                        StandardId = c.Int(nullable: false),
                        Section = c.String(nullable: false, maxLength: 128),
                        TeacherId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.StandardId, t.Section });
            
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        TeacherId = c.Int(nullable: false, identity: true),
                        TeacherName = c.String(),
                        StandardId = c.Int(nullable: false),
                        Section = c.String(),
                        SubjectName = c.String(),
                    })
                .PrimaryKey(t => t.TeacherId);
            
            CreateTable(
                "dbo.StudentDetails",
                c => new
                    {
                        StudentId = c.Int(nullable: false),
                        DOB = c.DateTime(nullable: false),
                        DOJ = c.DateTime(nullable: false),
                        FatherName = c.String(),
                        MotherName = c.String(),
                        Address = c.String(),
                        ParentMobileNo = c.String(),
                    })
                .PrimaryKey(t => t.StudentId)
                .ForeignKey("dbo.Students", t => t.StudentId)
                .Index(t => t.StudentId);
            
            CreateTable(
                "dbo.TeacherStandards",
                c => new
                    {
                        Teacher_TeacherId = c.Int(nullable: false),
                        Standard_StandardId = c.Int(nullable: false),
                        Standard_Section = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.Teacher_TeacherId, t.Standard_StandardId, t.Standard_Section })
                .ForeignKey("dbo.Teachers", t => t.Teacher_TeacherId, cascadeDelete: true)
                .ForeignKey("dbo.Standards", t => new { t.Standard_StandardId, t.Standard_Section }, cascadeDelete: true)
                .Index(t => t.Teacher_TeacherId)
                .Index(t => new { t.Standard_StandardId, t.Standard_Section });
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StudentDetails", "StudentId", "dbo.Students");
            DropForeignKey("dbo.Students", new[] { "Standard_StandardId", "Standard_Section" }, "dbo.Standards");
            DropForeignKey("dbo.TeacherStandards", new[] { "Standard_StandardId", "Standard_Section" }, "dbo.Standards");
            DropForeignKey("dbo.TeacherStandards", "Teacher_TeacherId", "dbo.Teachers");
            DropForeignKey("dbo.FeeDetails", "StudentId", "dbo.Students");
            DropIndex("dbo.TeacherStandards", new[] { "Standard_StandardId", "Standard_Section" });
            DropIndex("dbo.TeacherStandards", new[] { "Teacher_TeacherId" });
            DropIndex("dbo.StudentDetails", new[] { "StudentId" });
            DropIndex("dbo.Students", new[] { "Standard_StandardId", "Standard_Section" });
            DropIndex("dbo.FeeDetails", new[] { "StudentId" });
            DropTable("dbo.TeacherStandards");
            DropTable("dbo.StudentDetails");
            DropTable("dbo.Teachers");
            DropTable("dbo.Standards");
            DropTable("dbo.Students");
            DropTable("dbo.FeeDetails");
        }
    }
}
