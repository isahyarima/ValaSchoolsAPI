using Microsoft.EntityFrameworkCore;
using School.Business.AcademicSession;
using School.Business.Attendance;
using School.Business.ClassEnrolment;
using School.Business.Classes;
using School.Business.Classes.Entities;
using School.Business.ClassSubjects.Entities;
using School.Business.Employees;
using School.Business.GradeSetting;
using School.Business.Origin;
using School.Business.Parents;
using School.Business.Passport;
using School.Business.School;
using School.Business.Session;
using School.Business.Students;
using School.Business.Subjects;
using School.Data.AcademicSettingPersistance;
using School.Data.AttendancePersistance;
using School.Data.ClassesPersistance;
using School.Data.ClassSubjectsPersistance;
using School.Data.OriginPersistance;
using School.Data.ParentsPersistance;
using School.Data.SchoolPersistance;
using School.Data.SubjectsPersistance;

namespace School.Data
{
    public class SchoolContext : DbContext
    {
        public SchoolContext()
        {
            //  Database.SetInitializer(new MigrateDatabaseToLatestVersion<SchoolContext, School.Data.Migrations.Configuration>("SchoolContext"));
           // ChangeTracker.AutoDetectChangesEnabled = false;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

           //   modelBuilder.Convention.Remove<PluralizingTableNameConvention>();

          

            //Student Configuration
            modelBuilder.ApplyConfiguration(new StudentContactMap());
            modelBuilder.ApplyConfiguration(new StudentGuardianMap());
            modelBuilder.ApplyConfiguration(new StudentHealthMap());
            modelBuilder.ApplyConfiguration(new StudentMap());

            //Employee Configuration
            modelBuilder.ApplyConfiguration(new EmployeeAcademicRecordMap());
            modelBuilder.ApplyConfiguration(new EmployeeContactMap());
            modelBuilder.ApplyConfiguration(new EmployeeExperiencesMap());
            modelBuilder.ApplyConfiguration(new EmployeeMap());
            modelBuilder.ApplyConfiguration(new EmployeeOlevelMap());
            modelBuilder.ApplyConfiguration(new EmployeeProfessionalExamMap());

            //Passport Configuration
            modelBuilder.ApplyConfiguration(new PassportMap());

            //School Configuration
            modelBuilder.ApplyConfiguration(new SchoolInformationMap());

            //Classes Configuration
            modelBuilder.ApplyConfiguration(new ClassesMap());


            //ClassSubjectMap Configuration
            modelBuilder.ApplyConfiguration(new ClassSubjectMap());

            //ClassSubjectMap Configuration
            modelBuilder.ApplyConfiguration(new SubjectsMap());

            //Father Configuration
            modelBuilder.ApplyConfiguration(new FatherMap());

            //Mother Configuration
            modelBuilder.ApplyConfiguration(new MotherMap());

            //Section Configuration
            modelBuilder.ApplyConfiguration(new SectionMap());

            //Session Configuration
            modelBuilder.ApplyConfiguration(new AcademicSessionMap());

            //AssessmentSetting Configuration
            modelBuilder.ApplyConfiguration(new AssessmentSettingMap());

            //Grade Setiing Configuration
            modelBuilder.ApplyConfiguration(new GradeSettingMap());

            //Attendance Configuration
            modelBuilder.ApplyConfiguration(new AttendanceMap());

            //AttendanceDescription Configuration
            modelBuilder.ApplyConfiguration(new AttendanceDescriptionMap());

            //Country Configuration
            modelBuilder.ApplyConfiguration(new CountryMap());

            //State Of Origin Configuration
            modelBuilder.ApplyConfiguration(new StateOfOriginMap());

            //LGA Configuration
            modelBuilder.ApplyConfiguration(new LGAMap());
        }

        //Student Entities
        public DbSet<Student> StudentSet { get; set; }
        public DbSet<StudentContact> StudentContactSet { get; set; }
        public DbSet<StudentGuardian> StudentGuardianSet { get; set; }
        public DbSet<StudentHealth> StudentHealthSet { get; set; }


        //Employee Entities
        public DbSet<Employee> EmployeeSet { get; set; }
        public DbSet<EmployeeAcademicRecord> EmployeeAcademicRecordSet { get; set; }
        public DbSet<EmployeeContact> EmployeeContactSet { get; set; }
        public DbSet<EmployeeExperiences> EmployeeExperiencesSet { get; set; }
        public DbSet<EmployeeOlevel> EmployeeOlevelSet { get; set; }
        public DbSet<EmployeeProfessionalExam> EmployeeProfessionalExamSet { get; set; }

        //Passport Entity
        public DbSet<RegistrationPassport> PassportSet { get; set; }

        //School Code
        public DbSet<SchoolInformation> SchoolSet { get; set; }

        //Classes Code
        public DbSet<Classes> ClassesSet { get; set; }

        //ClassSubjects Code
        public DbSet<ClassSubjects> ClassSubjectsSet { get; set; }

        //Subjects Code
        public DbSet<Subjects> SubjectsSet { get; set; }

        //Grade Setting
        public DbSet<GradeSetting> GradeSettingSet { get; set; }

        //Class Enrolment
        public DbSet<ClassEnrolment> ClassEnrolmentSet { get; set; }

        //Father
        public DbSet<Father> FatherSet { get; set; }

        //Mother
        public DbSet<Mother> MotherSet { get; set; }

        //Section setting
        public DbSet<Section> SectionSet { get; set; }

        //Session Enrolment
        public DbSet<AcademicSession> AcademicSessionSet { get; set; }

        //Assessment seeting
        public DbSet<AssessmentSetting> AssessmentSettingSet { get; set; }

        //Attendance seeting
        public DbSet<Attendance> AttendanceSet { get; set; }

        //AttendanceDescription seeting
        public DbSet<AttendanceDescription> AttendanceDescriptionSet { get; set; }

        //Country seeting
        public DbSet<Country> CountrySet { get; set; }

        //State of origin seeting
        public DbSet<StateOfOrigin> StateOfOriginSet { get; set; }

        //LGA of origin seeting
        public DbSet<LGA> LGASet { get; set; }
    }
}
