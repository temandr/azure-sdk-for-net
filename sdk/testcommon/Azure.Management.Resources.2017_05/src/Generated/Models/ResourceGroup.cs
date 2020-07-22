// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Management.Resources.Models
{
    /// <summary> Resource group information. </summary>
    public partial class ResourceGroup
    {
        /// <summary> Initializes a new instance of ResourceGroup. </summary>
        /// <param name="location"> The location of the resource group. It cannot be changed after the resource group has been created. It must be one of the supported Azure locations. </param>
        public ResourceGroup(string location)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }

            Location = location;
        }

        /// <summary> Initializes a new instance of ResourceGroup. </summary>
        /// <param name="id"> The ID of the resource group. </param>
        /// <param name="name"> The name of the resource group. </param>
        /// <param name="properties"> The resource group properties. </param>
        /// <param name="location"> The location of the resource group. It cannot be changed after the resource group has been created. It must be one of the supported Azure locations. </param>
        /// <param name="managedBy"> The ID of the resource that manages this resource group. </param>
        /// <param name="tags"> The tags attached to the resource group. </param>
        internal ResourceGroup(string id, string name, ResourceGroupProperties properties, string location, string managedBy, IDictionary<string, string> tags)
        {
            Id = id;
            Name = name;
            Properties = properties;
            Location = location;
            ManagedBy = managedBy;
            Tags = tags;
        }

        /// <summary> The ID of the resource group. </summary>
        public string Id { get; }
        /// <summary> The name of the resource group. </summary>
        public string Name { get; set; }
        /// <summary> The resource group properties. </summary>
        public ResourceGroupProperties Properties { get; set; }
        /// <summary> The location of the resource group. It cannot be changed after the resource group has been created. It must be one of the supported Azure locations. </summary>
        public string Location { get; set; }
        /// <summary> The ID of the resource that manages this resource group. </summary>
        public string ManagedBy { get; set; }
        /// <summary> The tags attached to the resource group. </summary>
        public IDictionary<string, string> Tags { get; set; }
    }
}
