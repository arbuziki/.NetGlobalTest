using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic.OOP.Constructors
{
    public class Child : Parent
    {
        protected Child(int value) : base(value)
        {
        }
    }
}
