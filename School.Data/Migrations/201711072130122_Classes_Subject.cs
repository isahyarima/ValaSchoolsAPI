namespace School.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Classes_Subject : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Classes",
                c => new
                    {
                        ClassId = c.String(nullable: false, maxLength: 128),
                        ClassRef = c.String(maxLength: 20),
                        ClassAccronym = c.String(maxLength: 20),
                        ClassName = c.String(maxLength: 500),
                        DateCreated = c.String(maxLength: 50),
                        SchoolCode = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.ClassId);
            
            CreateTable(
                "dbo.ClassSubjects",
                c => new
                    {
                        ClassSubjectsId = c.String(nullable: false, maxLength: 128),
                        ClassId = c.Int(nullable: false),
                        SubjectsId = c.String(maxLength: 20),
                        DateCreated = c.String(maxLength: 50),
                        SchoolCode = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.ClassSubjectsId);
            
            CreateTable(
                "dbo.Subjects",
                c => new
                    {
                        SubjectsId = c.String(nullable: false, maxLength: 20),
                        SubjectAccronym = c.String(maxLength: 10),
                        SubjectName = c.String(maxLength: 500),
                        SchoolCode = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.SubjectsId);
            
            CreateTable(
                "dbo.SchoolCategories",
                c => new
                    {
                        SchoolCategoryId = c.String(nullable: false, maxLength: 128),
                        SchoolCategoryName = c.String(maxLength: 200),
                        SchoolCode = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.SchoolCategoryId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SchoolCategories");
            DropTable("dbo.Subjects");
            DropTable("dbo.ClassSubjects");
            DropTable("dbo.Classes");
        }
    }
}
