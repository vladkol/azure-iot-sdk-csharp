// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.IoT.DigitalTwin.Service.Generated.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    internal partial class DesiredState
    {
        /// <summary>
        /// Initializes a new instance of the DesiredState class.
        /// </summary>
        public DesiredState()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DesiredState class.
        /// </summary>
        /// <param name="code">Status code for the operation.</param>
        /// <param name="version">Version of the desired value
        /// received.</param>
        /// <param name="description">Description of the status.</param>
        public DesiredState(int? code = default(int?), long? version = default(long?), string description = default(string))
        {
            Code = code;
            Version = version;
            Description = description;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets status code for the operation.
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public int? Code { get; set; }

        /// <summary>
        /// Gets or sets version of the desired value received.
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public long? Version { get; set; }

        /// <summary>
        /// Gets or sets description of the status.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

    }
}