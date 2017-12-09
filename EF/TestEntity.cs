using System;
using System.Collections.Generic;
using System.Text;

namespace EF
{
    public class TestEntity
    {
        public Guid Id { get; private set; }

        public string Name { get; private set; }

        public int Value { get; private set; }

        protected TestEntity()
        {
            //The opened constructor is designed to be used by Entity Framework
        }

        public TestEntity(string name, int value)
        {
            Name = name;
            Value = value;
        }
    }
}
