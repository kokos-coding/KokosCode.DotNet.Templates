using DotNet.WebApi.Domain.Common;

namespace DotNet.WebApi.Domain.AggregationModels.ToDo
{
    public interface IStatusRepository : IRepository<Status, int>
    {
        
    }
}