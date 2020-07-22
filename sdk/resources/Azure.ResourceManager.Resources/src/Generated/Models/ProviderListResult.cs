// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> List of resource providers. </summary>
    public partial class ProviderListResult
    {
        /// <summary> Initializes a new instance of ProviderListResult. </summary>
        internal ProviderListResult()
        {
        }

        /// <summary> Initializes a new instance of ProviderListResult. </summary>
        /// <param name="value"> An array of resource providers. </param>
        /// <param name="nextLink"> The URL to use for getting the next set of results. </param>
        internal ProviderListResult(IReadOnlyList<Provider> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> An array of resource providers. </summary>
        public IReadOnlyList<Provider> Value { get; }
        /// <summary> The URL to use for getting the next set of results. </summary>
        public string NextLink { get; }
    }
}
