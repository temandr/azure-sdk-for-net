// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class DiskUpdate : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Tags != null)
            {
                writer.WritePropertyName("tags");
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Sku != null)
            {
                writer.WritePropertyName("sku");
                writer.WriteObjectValue(Sku);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (OsType != null)
            {
                writer.WritePropertyName("osType");
                writer.WriteStringValue(OsType.Value.ToSerialString());
            }
            if (DiskSizeGB != null)
            {
                writer.WritePropertyName("diskSizeGB");
                writer.WriteNumberValue(DiskSizeGB.Value);
            }
            if (EncryptionSettingsCollection != null)
            {
                writer.WritePropertyName("encryptionSettingsCollection");
                writer.WriteObjectValue(EncryptionSettingsCollection);
            }
            if (DiskIopsReadWrite != null)
            {
                writer.WritePropertyName("diskIOPSReadWrite");
                writer.WriteNumberValue(DiskIopsReadWrite.Value);
            }
            if (DiskMBpsReadWrite != null)
            {
                writer.WritePropertyName("diskMBpsReadWrite");
                writer.WriteNumberValue(DiskMBpsReadWrite.Value);
            }
            if (DiskIopsReadOnly != null)
            {
                writer.WritePropertyName("diskIOPSReadOnly");
                writer.WriteNumberValue(DiskIopsReadOnly.Value);
            }
            if (DiskMBpsReadOnly != null)
            {
                writer.WritePropertyName("diskMBpsReadOnly");
                writer.WriteNumberValue(DiskMBpsReadOnly.Value);
            }
            if (MaxShares != null)
            {
                writer.WritePropertyName("maxShares");
                writer.WriteNumberValue(MaxShares.Value);
            }
            if (Encryption != null)
            {
                writer.WritePropertyName("encryption");
                writer.WriteObjectValue(Encryption);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }
    }
}
