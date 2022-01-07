using DotNet.WebApi.Domain.AggregationModels.ToDo;

namespace DotNet.WebApi.DataAccess.DbContexts
{
    public class ToDoDbContext : DbContext
    {
        public ToDoDbContext()
        {
            
        }

        public DbSet<ToDoTask> ToDoTasks { get; set; }
        public DbSet<Status> Statuses { get; set; }
        
        
    }
}