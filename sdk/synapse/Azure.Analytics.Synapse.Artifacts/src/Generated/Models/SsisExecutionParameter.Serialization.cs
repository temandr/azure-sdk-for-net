// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    public partial class SsisExecutionParameter : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("value");
            writer.WriteObjectValue(Value);
            writer.WriteEndObject();
        }

        internal static SsisExecutionParameter DeserializeSsisExecutionParameter(JsonElement element)
        {
            object value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    value = property.Value.GetObject();
                    continue;
                }
            }
            return new SsisExecutionParameter(value);
        }
    }
}
