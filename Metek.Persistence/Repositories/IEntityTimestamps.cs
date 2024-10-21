using System;
using System.Collections.Generic;
using System.Text;

namespace Metek.Persistence.Repositories
{
    public interface IEntityTimestamps
    {
        DateTime CreatedDate { get; set; }
        DateTime? UpdatedDate { get; set; }
        DateTime? DeletedDate { get; set; }
    }
}
