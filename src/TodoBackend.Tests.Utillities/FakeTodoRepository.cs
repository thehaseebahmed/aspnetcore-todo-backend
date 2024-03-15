using Starter.Domain.Entities;
using Starter.Domain.Repositories;

namespace Starter.Tests.Utillities
{
    public class FakeTodoRepository : FakeRepository<Todo>, ITodoRepository
    {
        public Task DeleteAllAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<Todo> ReadByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
