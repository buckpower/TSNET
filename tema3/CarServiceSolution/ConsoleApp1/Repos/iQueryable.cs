using System.Collections.Generic;

namespace ConsoleApp1.Repos
{
    public interface IQueryable<T,Q>
    {
        ICollection<T> Query(Q queryParams);
    }
}