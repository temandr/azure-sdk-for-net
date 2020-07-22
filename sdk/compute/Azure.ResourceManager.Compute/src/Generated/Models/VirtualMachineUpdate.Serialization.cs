// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class VirtualMachineUpdate : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Plan != null)
            {
                writer.WritePropertyName("plan");
                writer.WriteObjectValue(Plan);
            }
            if (Identity != null)
            {
                writer.WritePropertyName("identity");
                writer.WriteObjectValue(Identity);
            }
            if (Zones != null)
            {
                writer.WritePropertyName("zones");
                writer.WriteStartArray();
                foreach (var item in Zones)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
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
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (HardwareProfile != null)
            {
                writer.WritePropertyName("hardwareProfile");
                writer.WriteObjectValue(HardwareProfile);
            }
            if (StorageProfile != null)
            {
                writer.WritePropertyName("storageProfile");
                writer.WriteObjectValue(StorageProfile);
            }
            if (AdditionalCapabilities != null)
            {
                writer.WritePropertyName("additionalCapabilities");
                writer.WriteObjectValue(AdditionalCapabilities);
            }
            if (OsProfile != null)
            {
                writer.WritePropertyName("osProfile");
                writer.WriteObjectValue(OsProfile);
            }
            if (NetworkProfile != null)
            {
                writer.WritePropertyName("networkProfile");
                writer.WriteObjectValue(NetworkProfile);
            }
            if (DiagnosticsProfile != null)
            {
                writer.WritePropertyName("diagnosticsProfile");
                writer.WriteObjectValue(DiagnosticsProfile);
            }
            if (AvailabilitySet != null)
            {
                writer.WritePropertyName("availabilitySet");
                writer.WriteObjectValue(AvailabilitySet);
            }
            if (VirtualMachineScaleSet != null)
            {
                writer.WritePropertyName("virtualMachineScaleSet");
                writer.WriteObjectValue(VirtualMachineScaleSet);
            }
            if (ProximityPlacementGroup != null)
            {
                writer.WritePropertyName("proximityPlacementGroup");
                writer.WriteObjectValue(ProximityPlacementGroup);
            }
            if (Priority != null)
            {
                writer.WritePropertyName("priority");
                writer.WriteStringValue(Priority.Value.ToString());
            }
            if (EvictionPolicy != null)
            {
                writer.WritePropertyName("evictionPolicy");
                writer.WriteStringValue(EvictionPolicy.Value.ToString());
            }
            if (BillingProfile != null)
            {
                writer.WritePropertyName("billingProfile");
                writer.WriteObjectValue(BillingProfile);
            }
            if (Host != null)
            {
                writer.WritePropertyName("host");
                writer.WriteObjectValue(Host);
            }
            if (ProvisioningState != null)
            {
                writer.WritePropertyName("provisioningState");
                writer.WriteStringValue(ProvisioningState);
            }
            if (InstanceView != null)
            {
                writer.WritePropertyName("instanceView");
                writer.WriteObjectValue(InstanceView);
            }
            if (LicenseType != null)
            {
                writer.WritePropertyName("licenseType");
                writer.WriteStringValue(LicenseType);
            }
            if (VmId != null)
            {
                writer.WritePropertyName("vmId");
                writer.WriteStringValue(VmId);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }
    }
}
