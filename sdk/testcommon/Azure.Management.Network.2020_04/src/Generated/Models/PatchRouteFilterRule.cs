// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Management.Network.Models
{
    /// <summary> Route Filter Rule Resource. </summary>
    public partial class PatchRouteFilterRule : SubResource
    {
        /// <summary> Initializes a new instance of PatchRouteFilterRule. </summary>
        public PatchRouteFilterRule()
        {
            RouteFilterRuleType = "Community";
        }

        /// <summary> Initializes a new instance of PatchRouteFilterRule. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> The name of the resource that is unique within a resource group. This name can be used to access the resource. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="access"> The access type of the rule. </param>
        /// <param name="routeFilterRuleType"> The rule type of the rule. </param>
        /// <param name="communities"> The collection for bgp community values to filter on. e.g. [&apos;12076:5010&apos;,&apos;12076:5020&apos;]. </param>
        /// <param name="provisioningState"> The provisioning state of the route filter rule resource. </param>
        internal PatchRouteFilterRule(string id, string name, string etag, Access? access, string routeFilterRuleType, IList<string> communities, ProvisioningState? provisioningState) : base(id)
        {
            Name = name;
            Etag = etag;
            Access = access;
            RouteFilterRuleType = routeFilterRuleType;
            Communities = communities;
            ProvisioningState = provisioningState;
        }

        /// <summary> The name of the resource that is unique within a resource group. This name can be used to access the resource. </summary>
        public string Name { get; }
        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; }
        /// <summary> The access type of the rule. </summary>
        public Access? Access { get; set; }
        /// <summary> The rule type of the rule. </summary>
        public string RouteFilterRuleType { get; set; }
        /// <summary> The collection for bgp community values to filter on. e.g. [&apos;12076:5010&apos;,&apos;12076:5020&apos;]. </summary>
        public IList<string> Communities { get; set; }
        /// <summary> The provisioning state of the route filter rule resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
    }
}
