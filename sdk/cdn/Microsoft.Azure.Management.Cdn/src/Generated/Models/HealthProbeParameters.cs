// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Cdn.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The JSON object that contains the properties to send health probes to
    /// origin.
    /// </summary>
    public partial class HealthProbeParameters
    {
        /// <summary>
        /// Initializes a new instance of the HealthProbeParameters class.
        /// </summary>
        public HealthProbeParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the HealthProbeParameters class.
        /// </summary>
        /// <param name="probePath">The path relative to the origin that is
        /// used to determine the health of the origin.</param>
        /// <param name="probeRequestType">The type of health probe request
        /// that is made. Possible values include: 'NotSet', 'GET',
        /// 'HEAD'</param>
        /// <param name="probeProtocol">Protocol to use for health probe.
        /// Possible values include: 'NotSet', 'Http', 'Https'</param>
        /// <param name="probeIntervalInSeconds">The number of seconds between
        /// health probes.Default is 240sec.</param>
        public HealthProbeParameters(string probePath = default(string), HealthProbeRequestType? probeRequestType = default(HealthProbeRequestType?), ProbeProtocol? probeProtocol = default(ProbeProtocol?), int? probeIntervalInSeconds = default(int?))
        {
            ProbePath = probePath;
            ProbeRequestType = probeRequestType;
            ProbeProtocol = probeProtocol;
            ProbeIntervalInSeconds = probeIntervalInSeconds;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the path relative to the origin that is used to
        /// determine the health of the origin.
        /// </summary>
        [JsonProperty(PropertyName = "probePath")]
        public string ProbePath { get; set; }

        /// <summary>
        /// Gets or sets the type of health probe request that is made.
        /// Possible values include: 'NotSet', 'GET', 'HEAD'
        /// </summary>
        [JsonProperty(PropertyName = "probeRequestType")]
        public HealthProbeRequestType? ProbeRequestType { get; set; }

        /// <summary>
        /// Gets or sets protocol to use for health probe. Possible values
        /// include: 'NotSet', 'Http', 'Https'
        /// </summary>
        [JsonProperty(PropertyName = "probeProtocol")]
        public ProbeProtocol? ProbeProtocol { get; set; }

        /// <summary>
        /// Gets or sets the number of seconds between health probes.Default is
        /// 240sec.
        /// </summary>
        [JsonProperty(PropertyName = "probeIntervalInSeconds")]
        public int? ProbeIntervalInSeconds { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ProbeIntervalInSeconds > 255)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "ProbeIntervalInSeconds", 255);
            }
            if (ProbeIntervalInSeconds < 1)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "ProbeIntervalInSeconds", 1);
            }
        }
    }
}
