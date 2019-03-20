using System.Collections.Generic;

namespace CarService.Repos
{
    public interface IQueryable<T,Q>
    {
        ICollection<T> Query(Q queryParams);
    }
}