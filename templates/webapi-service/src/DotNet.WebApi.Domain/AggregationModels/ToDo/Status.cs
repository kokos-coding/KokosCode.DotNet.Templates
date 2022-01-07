namespace DotNet.WebApi.Domain.AggregationModels.ToDo
{
    public class Status
    {
        /// <summary>
        /// Identifier of status
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Name of current status
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Description of current status
        /// </summary>
        public string Description { get; set; }
        public int[] AvailableTransitionStatuses { get; set; }
    }
}