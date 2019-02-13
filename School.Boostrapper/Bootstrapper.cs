using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.WebApi;
using School.Data.Contracts;
using School.Data.StudentRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace School.Boostrapper
{
    public static class Bootstrapper
    {
        public static IUnityContainer Initialise()
        {
            IUnityContainer container = BuildUnityContainer();
            //DependencyResolver.SetResolver(new UnityDependencyResolver(container));
            return container;
        }
        private static IUnityContainer BuildUnityContainer()
        {
            IUnityContainer container = new UnityContainer();

          //  container.RegisterType<IStudentRepository, StudentRepository>();
            //container.Resolve<StudentsController>();

            //RegisterTypes(container);
            return container;
        }
        public static void RegisterTypes(IUnityContainer container)
        {

        }
    }
}
