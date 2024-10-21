

using Metek.Application.Services.Repositories;
using Metek.Domain.Entities;
using Metek.Persistence.Contexts;

namespace Metek.Persistence.Repositories
{
   
    public class MesaiRepository : EfRepositoryBase<Mesai, int, BaseDbContext>, IMesaiRepository
    {
        public MesaiRepository(BaseDbContext context) : base(context)
        {
        }
    }
}
