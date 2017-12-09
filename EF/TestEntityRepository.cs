using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EF
{
    public class TestEntityRepository : ITestEntityRepository
    {
        private readonly EntityContext _context;

        public TestEntityRepository(EntityContext context)
        {
            _context = context;
        }

        public TestEntity GetById(Guid id)
        {
            return _context.TestEntities.FirstOrDefault(T => T.Id.Equals(id));
        }

        public async Task<TestEntity> GetByIdAsync(Guid id)
        {
            return await _context.TestEntities.FirstOrDefaultAsync(T => T.Id.Equals(id));
        }
    }
}
