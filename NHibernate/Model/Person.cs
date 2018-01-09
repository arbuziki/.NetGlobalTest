using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernate.Model
{
    public class Person
    {
        public virtual PersonKey Key { get; set; }

        public virtual string LastName { get; set; }

        public virtual string FirstName { get; set; }

        public virtual string MiddleName { get; set; }
    }
}
