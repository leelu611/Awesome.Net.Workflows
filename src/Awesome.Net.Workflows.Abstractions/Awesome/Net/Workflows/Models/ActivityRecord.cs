using Awesome.Net.Data;
using Newtonsoft.Json.Linq;

namespace Awesome.Net.Workflows.Models
{
    public class ActivityRecord : IHasJObjectProperties
    {
        public string ActivityId { get; set; }

        /// <summary>
        /// The type of the activity.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The left coordinate of the activity.
        /// </summary>
        public int X { get; set; }

        /// <summary>
        /// The top coordinate of the activity.
        /// </summary>
        public int Y { get; set; }

        /// <summary>
        /// Whether the activity is a start state for a <see cref="WorkflowType"/>.
        /// </summary>
        public bool IsStart { get; set; }

        public JObject Properties { get; set; } = new JObject();
    }
}