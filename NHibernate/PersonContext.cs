using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Cfg;
using NHibernate.Cfg.MappingSchema;
using NHibernate.Dialect;
using NHibernate.Mapping.ByCode;

namespace NHibernate
{
    public class PersonContext
    {
        public PersonContext()
        {
            
        }

        private ISessionFactory _factory;

        public void Initialize()
        {
            var cfg = new Configuration().DataBaseIntegration(options =>
            {
                options.ConnectionString = "Server=DESKTOP-Q074TOO;Database=dotNetGlobalTest;Trusted_Connection=True;";
                options.Dialect<MsSql2012Dialect>();
            });

            var mapper = new ModelMapper();

            mapper.AddMappings(Assembly.GetExecutingAssembly().GetExportedTypes());

            HbmMapping mapping = mapper.CompileMappingForAllExplicitlyAddedEntities();
            cfg.AddMapping(mapping);

            _factory = cfg.BuildSessionFactory();
        }

        public ISession GetSession()
        {
            return _factory.OpenSession();
        }
    }
}
