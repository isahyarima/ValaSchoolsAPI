namespace School.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initail_Migration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EmployeeAcademicRecord",
                c => new
                    {
                        EmployeeAcademicRecordId = c.Int(nullable: false, identity: true),
                        SchoolName = c.String(maxLength: 500),
                        EnrolmentDate = c.DateTime(nullable: false),
                        GraduationDate = c.DateTime(nullable: false),
                        CertificateObtained = c.String(maxLength: 100),
                        EmployeeId = c.String(maxLength: 20),
                        SchoolCode = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.EmployeeAcademicRecordId)
                .ForeignKey("dbo.Employee", t => t.EmployeeId)
                .Index(t => t.EmployeeId);
            
            CreateTable(
                "dbo.Employee",
                c => new
                    {
                        EmployeeId = c.String(nullable: false, maxLength: 20),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        MiddleName = c.String(maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        Gender = c.String(nullable: false, maxLength: 10),
                        StateOfOrigin = c.String(nullable: false, maxLength: 100),
                        LocalGovt = c.String(nullable: false, maxLength: 100),
                        DateOfBirth = c.String(nullable: false, maxLength: 50),
                        Religion = c.String(maxLength: 50),
                        NativeLaguage = c.String(nullable: false, maxLength: 100),
                        SchoolCode = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.EmployeeId);
            
            CreateTable(
                "dbo.EmployeeContact",
                c => new
                    {
                        EmployeeContactId = c.Int(nullable: false, identity: true),
                        Email = c.String(maxLength: 100),
                        HomeAddress = c.String(maxLength: 500),
                        PhoneNumber = c.String(maxLength: 20),
                        EmployeeId = c.String(maxLength: 20),
                        SchoolCode = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.EmployeeContactId)
                .ForeignKey("dbo.Employee", t => t.EmployeeId)
                .Index(t => t.EmployeeId);
            
            CreateTable(
                "dbo.EmployeeExperiences",
                c => new
                    {
                        EmployeeExperienceId = c.Int(nullable: false, identity: true),
                        PositionHeld = c.String(maxLength: 100),
                        EmployerName = c.String(maxLength: 200),
                        EmploymentDate = c.DateTime(nullable: false),
                        TerminationDate = c.DateTime(nullable: false),
                        Contribution = c.String(maxLength: 500),
                        EmployeeId = c.String(maxLength: 20),
                        SchoolCode = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.EmployeeExperienceId)
                .ForeignKey("dbo.Employee", t => t.EmployeeId)
                .Index(t => t.EmployeeId);
            
            CreateTable(
                "dbo.EmployeeOlevel",
                c => new
                    {
                        EmployeeOlevelId = c.Int(nullable: false, identity: true),
                        SchoolName = c.String(maxLength: 500),
                        SchoolAddress = c.String(maxLength: 500),
                        ExamNumber = c.String(maxLength: 20),
                        ExamYear = c.String(maxLength: 20),
                        ExamBatch = c.String(maxLength: 80),
                        Subject = c.String(maxLength: 100),
                        Grade = c.String(maxLength: 10),
                        EmployeeId = c.String(maxLength: 20),
                        SchoolCode = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.EmployeeOlevelId)
                .ForeignKey("dbo.Employee", t => t.EmployeeId)
                .Index(t => t.EmployeeId);
            
            CreateTable(
                "dbo.EmployeeProfessionalExam",
                c => new
                    {
                        EmployeeProfessionalExamId = c.Int(nullable: false, identity: true),
                        ExamBody = c.String(maxLength: 50),
                        ExamDate = c.String(maxLength: 20),
                        CertificationName = c.String(maxLength: 50),
                        EmployeeId = c.String(maxLength: 20),
                        SchoolCode = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.EmployeeProfessionalExamId)
                .ForeignKey("dbo.Employee", t => t.EmployeeId)
                .Index(t => t.EmployeeId);
            
            CreateTable(
                "dbo.RegistrationPassport",
                c => new
                    {
                        RegistrationPassportsId = c.Int(nullable: false, identity: true),
                        PersonId = c.String(maxLength: 20),
                        ImageBinary = c.Byte(),
                        ImagePath = c.String(maxLength: 500),
                        ImageName = c.String(maxLength: 200),
                        ImageExtention = c.String(maxLength: 10),
                        ImageSize = c.String(maxLength: 10),
                        DateCreated = c.DateTime(),
                        CreatedBy = c.String(maxLength: 200),
                        CreatedFrom = c.String(maxLength: 200),
                        DateEdited = c.DateTime(),
                        EditedBy = c.String(maxLength: 200),
                        EditedFrom = c.String(maxLength: 200),
                        ImageStatus = c.String(maxLength: 20),
                        SchoolCode = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.RegistrationPassportsId);
            
            CreateTable(
                "dbo.SchoolInformation",
                c => new
                    {
                        SchoolId = c.Int(nullable: false, identity: true),
                        SchoolCode = c.String(nullable: false, maxLength: 20),
                        SchoolName = c.String(nullable: false, maxLength: 200),
                    })
                .PrimaryKey(t => t.SchoolId);
            
            CreateTable(
                "dbo.StudentContact",
                c => new
                    {
                        StudentContactId = c.Int(nullable: false, identity: true),
                        Email = c.String(maxLength: 100),
                        HomeAddress = c.String(maxLength: 500),
                        PhoneNumber = c.String(maxLength: 20),
                        StudentId = c.String(maxLength: 20),
                        SchoolCode = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.StudentContactId)
                .ForeignKey("dbo.Student", t => t.StudentId)
                .Index(t => t.StudentId);
            
            CreateTable(
                "dbo.Student",
                c => new
                    {
                        StudentId = c.String(nullable: false, maxLength: 20),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        MiddleName = c.String(maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        Gender = c.String(nullable: false, maxLength: 10),
                        StateOfOrigin = c.String(nullable: false, maxLength: 100),
                        LocalGovt = c.String(nullable: false, maxLength: 100),
                        DateOfBirth = c.String(nullable: false, maxLength: 20),
                        Religion = c.String(nullable: false, maxLength: 20),
                        NativeLaguage = c.String(nullable: false, maxLength: 50),
                        SchoolCode = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.StudentId);
            
            CreateTable(
                "dbo.StudentGuardian",
                c => new
                    {
                        StudentGuardianId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(maxLength: 20),
                        MiddleName = c.String(maxLength: 20),
                        LastName = c.String(maxLength: 20),
                        Gender = c.String(maxLength: 10),
                        DateOfBirth = c.String(maxLength: 20),
                        StateOfOrigin = c.String(maxLength: 100),
                        LocalGovt = c.String(maxLength: 100),
                        Email = c.String(maxLength: 100),
                        HomeAddress = c.String(maxLength: 500),
                        PhoneNumber = c.String(maxLength: 20),
                        OfficeAddress = c.String(maxLength: 500),
                        OfficeNumber = c.String(maxLength: 20),
                        Relationship = c.String(maxLength: 100),
                        StudentId = c.String(maxLength: 20),
                        SchoolCode = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.StudentGuardianId)
                .ForeignKey("dbo.Student", t => t.StudentId)
                .Index(t => t.StudentId);
            
            CreateTable(
                "dbo.StudentHealth",
                c => new
                    {
                        StudentHealthId = c.Int(nullable: false, identity: true),
                        BloodGroup = c.String(maxLength: 10),
                        EyeStatus = c.String(maxLength: 10),
                        EarStatus = c.String(maxLength: 10),
                        Temperament = c.String(maxLength: 100),
                        PrequestCases = c.String(maxLength: 500),
                        StudentId = c.String(maxLength: 20),
                        SchoolCode = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.StudentHealthId)
                .ForeignKey("dbo.Student", t => t.StudentId)
                .Index(t => t.StudentId);
            
            CreateTable(
                "dbo.StudentTableExtention",
                c => new
                    {
                        StudentTableExtentionId = c.Int(nullable: false, identity: true),
                        DateCreated = c.DateTime(nullable: false),
                        CreatedBy = c.String(maxLength: 200),
                        CreatedFrom = c.String(maxLength: 200),
                        IsModefied = c.Boolean(nullable: false),
                        DateModified = c.DateTime(nullable: false),
                        ModifiedBy = c.String(maxLength: 200),
                        ModifiedFrom = c.String(maxLength: 200),
                        IsDeleted = c.Boolean(nullable: false),
                        DateDeleted = c.DateTime(nullable: false),
                        DeletedBy = c.String(maxLength: 200),
                        DeletedFrom = c.String(),
                        IsApproved = c.Boolean(nullable: false),
                        DateApproved = c.DateTime(nullable: false),
                        ApprovedBy = c.String(maxLength: 200),
                        ApprovedFrom = c.String(maxLength: 200),
                        Status = c.String(maxLength: 20),
                        SystemIP = c.String(maxLength: 20),
                        StudentId = c.String(maxLength: 20),
                        SchoolCode = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.StudentTableExtentionId)
                .ForeignKey("dbo.Student", t => t.StudentId)
                .Index(t => t.StudentId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StudentTableExtention", "StudentId", "dbo.Student");
            DropForeignKey("dbo.StudentHealth", "StudentId", "dbo.Student");
            DropForeignKey("dbo.StudentGuardian", "StudentId", "dbo.Student");
            DropForeignKey("dbo.StudentContact", "StudentId", "dbo.Student");
            DropForeignKey("dbo.EmployeeProfessionalExam", "EmployeeId", "dbo.Employee");
            DropForeignKey("dbo.EmployeeOlevel", "EmployeeId", "dbo.Employee");
            DropForeignKey("dbo.EmployeeExperiences", "EmployeeId", "dbo.Employee");
            DropForeignKey("dbo.EmployeeContact", "EmployeeId", "dbo.Employee");
            DropForeignKey("dbo.EmployeeAcademicRecord", "EmployeeId", "dbo.Employee");
            DropIndex("dbo.StudentTableExtention", new[] { "StudentId" });
            DropIndex("dbo.StudentHealth", new[] { "StudentId" });
            DropIndex("dbo.StudentGuardian", new[] { "StudentId" });
            DropIndex("dbo.StudentContact", new[] { "StudentId" });
            DropIndex("dbo.EmployeeProfessionalExam", new[] { "EmployeeId" });
            DropIndex("dbo.EmployeeOlevel", new[] { "EmployeeId" });
            DropIndex("dbo.EmployeeExperiences", new[] { "EmployeeId" });
            DropIndex("dbo.EmployeeContact", new[] { "EmployeeId" });
            DropIndex("dbo.EmployeeAcademicRecord", new[] { "EmployeeId" });
            DropTable("dbo.StudentTableExtention");
            DropTable("dbo.StudentHealth");
            DropTable("dbo.StudentGuardian");
            DropTable("dbo.Student");
            DropTable("dbo.StudentContact");
            DropTable("dbo.SchoolInformation");
            DropTable("dbo.RegistrationPassport");
            DropTable("dbo.EmployeeProfessionalExam");
            DropTable("dbo.EmployeeOlevel");
            DropTable("dbo.EmployeeExperiences");
            DropTable("dbo.EmployeeContact");
            DropTable("dbo.Employee");
            DropTable("dbo.EmployeeAcademicRecord");
        }
    }
}
