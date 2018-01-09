using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Model;

namespace NHibernate
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new PersonContext();

            context.Initialize();

            Person[] persons;

            using (var session = context.GetSession())
            {
                persons = session.QueryOver<Person>().List<Person>().ToArray();
            }
        }
    }
}
