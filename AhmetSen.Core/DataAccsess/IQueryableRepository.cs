using AhmetSen.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AhmetSen.Core.DataAccsess
{
    public interface IQueryableRepository<T> where T:class , IEntity,new ()
    {
        IQueryable<T> Table { get; }
    }
}
