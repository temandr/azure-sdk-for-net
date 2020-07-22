// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class AzureReachabilityReport
    {
        internal static AzureReachabilityReport DeserializeAzureReachabilityReport(JsonElement element)
        {
            string aggregationLevel = default;
            AzureReachabilityReportLocation providerLocation = default;
            IReadOnlyList<AzureReachabilityReportItem> reachabilityReport = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("aggregationLevel"))
                {
                    aggregationLevel = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("providerLocation"))
                {
                    providerLocation = AzureReachabilityReportLocation.DeserializeAzureReachabilityReportLocation(property.Value);
                    continue;
                }
                if (property.NameEquals("reachabilityReport"))
                {
                    List<AzureReachabilityReportItem> array = new List<AzureReachabilityReportItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(AzureReachabilityReportItem.DeserializeAzureReachabilityReportItem(item));
                        }
                    }
                    reachabilityReport = array;
                    continue;
                }
            }
            return new AzureReachabilityReport(aggregationLevel, providerLocation, reachabilityReport);
        }
    }
}
