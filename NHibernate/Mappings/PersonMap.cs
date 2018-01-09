using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using NHibernate.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Model;

namespace NHibernate.Mappings
{
    public class PersonMap : ClassMapping<Person>
    {
        public PersonMap()
        {
            Table(nameof(Person));

            Id(x => x.Key, m => { m.Column("PersonId"); });
        }
    }
}
