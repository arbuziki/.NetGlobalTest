using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class EF
    {
        [Test]
        public void CRUDTest()
        {
            var repository = new TestEntityRepository(new EntityContext());

            var entity = repository.GetById(Guid.Parse("17BDAEE4-7119-4D30-80CF-E7CAAA633AC1"));

            Assert.NotNull(entity);
            Assert.AreEqual(entity.Value, 666);
        }
    }
}
