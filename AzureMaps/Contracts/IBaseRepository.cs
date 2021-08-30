using System.Collections.Generic;
using System.Threading.Tasks;

namespace AzureMaps.Contracts
{
    public interface IBaseRepository<T> where  T : class
    {
        Task<IList<T>> Get(string url);
    }
}