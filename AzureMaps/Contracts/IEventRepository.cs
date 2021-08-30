using System.Collections.Generic;
using System.Threading.Tasks;
using AzureMaps.Data.Entities;

namespace AzureMaps.Contracts
{
    public interface IEventRepository
    {
        Task<Root> Get(string url);
    }
}