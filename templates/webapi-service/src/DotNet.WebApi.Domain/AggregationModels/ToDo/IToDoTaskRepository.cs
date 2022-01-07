using System;
using DotNet.WebApi.Domain.Common;

namespace DotNet.WebApi.Domain.AggregationModels.ToDo
{
    public interface IToDoTaskRepository : IRepository<ToDoTask, Guid>
    {
    }
}