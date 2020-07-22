// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class ExpressRouteCircuitRoutesTableSummary
    {
        internal static ExpressRouteCircuitRoutesTableSummary DeserializeExpressRouteCircuitRoutesTableSummary(JsonElement element)
        {
            string neighbor = default;
            int? v = default;
            int? @as = default;
            string upDown = default;
            string statePfxRcd = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("neighbor"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    neighbor = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("v"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    v = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("as"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    @as = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("upDown"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    upDown = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("statePfxRcd"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    statePfxRcd = property.Value.GetString();
                    continue;
                }
            }
            return new ExpressRouteCircuitRoutesTableSummary(neighbor, v, @as, upDown, statePfxRcd);
        }
    }
}
