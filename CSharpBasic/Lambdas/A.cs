using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic.Lambdas
{
    public class A
    {
        public int Test { get; private set; }
        public A()
        {
            
        }

        public Action GetIncTestFunc()
        {
            return () => Test++;
        }
    }
}
