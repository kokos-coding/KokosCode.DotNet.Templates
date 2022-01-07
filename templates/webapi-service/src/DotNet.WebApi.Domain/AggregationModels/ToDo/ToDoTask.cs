using System;

namespace DotNet.WebApi.Domain.AggregationModels.ToDo
{
    /// <summary>
    /// Entity for task in todo application
    /// </summary>
    public class ToDoTask
    {
        /// <summary>
        /// Identifier of ToDo item
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// Title of ToDo item
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Description of ToDo item
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Create date of current ToDoTask
        /// </summary>
        public DateTime CreateDate { get; set; }
        /// <summary>
        /// Update date of current ToDoTask
        /// </summary>
        public DateTime? UpdateDate { get; set; }
        /// <summary>
        /// Deadline date of current ToDoTask
        /// </summary>
        public DateTime? DeadlineDate { get; set; }
        /// <summary>
        /// Delete date of current ToDoTask
        /// </summary>
        public DateTime? DeleteDate { get; set; }
        /// <summary>
        /// Is Deleted flag
        /// </summary>
        /// <value></value>
        public bool IsDeleted { get; set; }
        /// <summary>
        /// Identifier of current status
        /// </summary>
        public int StatusId { get; set; }

        public Status Status { get; set; }
    }
}