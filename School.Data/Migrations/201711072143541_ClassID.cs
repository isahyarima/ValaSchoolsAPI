namespace School.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ClassID : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Classes");
            DropPrimaryKey("dbo.ClassSubjects");
            DropPrimaryKey("dbo.SchoolCategories");
            AlterColumn("dbo.Classes", "ClassId", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.ClassSubjects", "ClassSubjectsId", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.SchoolCategories", "SchoolCategoryId", c => c.String(nullable: false, maxLength: 20));
            AddPrimaryKey("dbo.Classes", "ClassId");
            AddPrimaryKey("dbo.ClassSubjects", "ClassSubjectsId");
            AddPrimaryKey("dbo.SchoolCategories", "SchoolCategoryId");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.SchoolCategories");
            DropPrimaryKey("dbo.ClassSubjects");
            DropPrimaryKey("dbo.Classes");
            AlterColumn("dbo.SchoolCategories", "SchoolCategoryId", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.ClassSubjects", "ClassSubjectsId", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Classes", "ClassId", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.SchoolCategories", "SchoolCategoryId");
            AddPrimaryKey("dbo.ClassSubjects", "ClassSubjectsId");
            AddPrimaryKey("dbo.Classes", "ClassId");
        }
    }
}
