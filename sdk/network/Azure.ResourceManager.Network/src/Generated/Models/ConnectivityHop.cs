// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Information about a hop between the source and the destination. </summary>
    public partial class ConnectivityHop
    {
        /// <summary> Initializes a new instance of ConnectivityHop. </summary>
        internal ConnectivityHop()
        {
        }

        /// <summary> Initializes a new instance of ConnectivityHop. </summary>
        /// <param name="type"> The type of the hop. </param>
        /// <param name="id"> The ID of the hop. </param>
        /// <param name="address"> The IP address of the hop. </param>
        /// <param name="resourceId"> The ID of the resource corresponding to this hop. </param>
        /// <param name="nextHopIds"> List of next hop identifiers. </param>
        /// <param name="issues"> List of issues. </param>
        internal ConnectivityHop(string type, string id, string address, string resourceId, IReadOnlyList<string> nextHopIds, IReadOnlyList<ConnectivityIssue> issues)
        {
            Type = type;
            Id = id;
            Address = address;
            ResourceId = resourceId;
            NextHopIds = nextHopIds;
            Issues = issues;
        }

        /// <summary> The type of the hop. </summary>
        public string Type { get; }
        /// <summary> The ID of the hop. </summary>
        public string Id { get; }
        /// <summary> The IP address of the hop. </summary>
        public string Address { get; }
        /// <summary> The ID of the resource corresponding to this hop. </summary>
        public string ResourceId { get; }
        /// <summary> List of next hop identifiers. </summary>
        public IReadOnlyList<string> NextHopIds { get; }
        /// <summary> List of issues. </summary>
        public IReadOnlyList<ConnectivityIssue> Issues { get; }
    }
}
