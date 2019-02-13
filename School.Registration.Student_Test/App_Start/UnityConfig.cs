using Microsoft.Practices.Unity;
using School.Data;
using School.Data.ClassesRepository;
using School.Data.Contracts;
using School.Data.Contracts.ClassesContracts;
using School.Data.Contracts.SubjectsContracts;
using School.Data.EmployeesRepository;
using School.Data.StudentRepository;
using School.Data.SubjectsRepository;
using System.Web.Http;
using Unity.WebApi;

namespace School.Registration.Student_Test
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            ////Student Information Injection
            container.RegisterType<IStudentRepository, StudentRepository>();
           // container.RegisterType<ISchoolReference, SchoolReference>();
            container.RegisterType<IStudentContactRepository, StudentContactRepository>();
            container.RegisterType<IStudentGuardianRepository, StudentGuardianRepository>();
            container.RegisterType<IStudentHealthRepository, StudentHealthRepository>();
            container.RegisterType<IStudentTableExtentionRepository, StudentTableExtentionRepository>();

            //Employees Information Injections
            container.RegisterType<IEmployeeRepository, EmployeeRepository>();
            container.RegisterType<IEmployeeAcademicRecordRepository, EmployeeAcademicRecordRepository>();
            container.RegisterType<IEmployeeContactRepository, EmployeeContactRepository>();
            container.RegisterType<IEmployeeExperiencesRepository, EmployeeExperiencesRepository>();
            container.RegisterType<IEmployeeOlevelRepository, EmployeeOlevelRepository>();
            container.RegisterType<IEmployeeProfessionalExamRepository, EmployeeProfessionalExamRepository>();

            //SchoolCategories
          //  container.RegisterType<ISchoolCategoriesRepository, SchoolCategoriesRepository>();

            //Subjects
            container.RegisterType<ISubjectsRepository, SubjectsRepository>();

            //Classes
            container.RegisterType<IClassesRepository, ClassesRepository>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}