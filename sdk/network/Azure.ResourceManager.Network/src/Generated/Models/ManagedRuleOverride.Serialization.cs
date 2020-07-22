// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class ManagedRuleOverride : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("ruleId");
            writer.WriteStringValue(RuleId);
            if (State != null)
            {
                writer.WritePropertyName("state");
                writer.WriteStringValue(State);
            }
            writer.WriteEndObject();
        }

        internal static ManagedRuleOverride DeserializeManagedRuleOverride(JsonElement element)
        {
            string ruleId = default;
            string state = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ruleId"))
                {
                    ruleId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("state"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = property.Value.GetString();
                    continue;
                }
            }
            return new ManagedRuleOverride(ruleId, state);
        }
    }
}
