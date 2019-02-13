using School.Data;
using School.Data.StudentRepository;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Boostrapper
{
    public static class MEFLoader
    {
        public static CompositionContainer Init()
        {
            AggregateCatalog catalog = new AggregateCatalog();

            catalog.Catalogs.Add(new AssemblyCatalog(typeof(StudentRepository).Assembly));
            catalog.Catalogs.Add(new AssemblyCatalog(typeof(StudentContactRepository).Assembly));

            CompositionContainer container = new CompositionContainer(catalog);

            return container;
        }
    }
}
