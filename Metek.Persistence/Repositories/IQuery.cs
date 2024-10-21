using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Metek.Persistence.Repositories
{
    public interface IQuery<T>
    {
        IQueryable<T> Query();
    }
}
