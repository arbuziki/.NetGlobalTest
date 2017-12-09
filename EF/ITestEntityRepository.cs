using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EF
{
    public interface ITestEntityRepository
    {
        TestEntity GetById(Guid id);

        Task<TestEntity> GetByIdAsync(Guid id);
    }
}
