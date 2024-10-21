

using Metek.Domain.Entities;
using Metek.Persistence.Repositories;

namespace Metek.Application.Services.Repositories
{

    public interface IMesaiRepository : IAsyncRepository<Mesai, int>, IRepository<Mesai, int>
    {

    }
}
