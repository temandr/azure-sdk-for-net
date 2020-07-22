// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Describes a virtual machine scale set virtual machine profile. </summary>
    public partial class VirtualMachineScaleSetUpdateVMProfile
    {
        /// <summary> Initializes a new instance of VirtualMachineScaleSetUpdateVMProfile. </summary>
        public VirtualMachineScaleSetUpdateVMProfile()
        {
        }

        /// <summary> Initializes a new instance of VirtualMachineScaleSetUpdateVMProfile. </summary>
        /// <param name="osProfile"> The virtual machine scale set OS profile. </param>
        /// <param name="storageProfile"> The virtual machine scale set storage profile. </param>
        /// <param name="networkProfile"> The virtual machine scale set network profile. </param>
        /// <param name="diagnosticsProfile"> The virtual machine scale set diagnostics profile. </param>
        /// <param name="extensionProfile"> The virtual machine scale set extension profile. </param>
        /// <param name="licenseType"> The license type, which is for bring your own license scenario. </param>
        /// <param name="billingProfile"> Specifies the billing related details of a Azure Spot VMSS. &lt;br&gt;&lt;br&gt;Minimum api-version: 2019-03-01. </param>
        /// <param name="scheduledEventsProfile"> Specifies Scheduled Event related configurations. </param>
        internal VirtualMachineScaleSetUpdateVMProfile(VirtualMachineScaleSetUpdateOSProfile osProfile, VirtualMachineScaleSetUpdateStorageProfile storageProfile, VirtualMachineScaleSetUpdateNetworkProfile networkProfile, DiagnosticsProfile diagnosticsProfile, VirtualMachineScaleSetExtensionProfile extensionProfile, string licenseType, BillingProfile billingProfile, ScheduledEventsProfile scheduledEventsProfile)
        {
            OsProfile = osProfile;
            StorageProfile = storageProfile;
            NetworkProfile = networkProfile;
            DiagnosticsProfile = diagnosticsProfile;
            ExtensionProfile = extensionProfile;
            LicenseType = licenseType;
            BillingProfile = billingProfile;
            ScheduledEventsProfile = scheduledEventsProfile;
        }

        /// <summary> The virtual machine scale set OS profile. </summary>
        public VirtualMachineScaleSetUpdateOSProfile OsProfile { get; set; }
        /// <summary> The virtual machine scale set storage profile. </summary>
        public VirtualMachineScaleSetUpdateStorageProfile StorageProfile { get; set; }
        /// <summary> The virtual machine scale set network profile. </summary>
        public VirtualMachineScaleSetUpdateNetworkProfile NetworkProfile { get; set; }
        /// <summary> The virtual machine scale set diagnostics profile. </summary>
        public DiagnosticsProfile DiagnosticsProfile { get; set; }
        /// <summary> The virtual machine scale set extension profile. </summary>
        public VirtualMachineScaleSetExtensionProfile ExtensionProfile { get; set; }
        /// <summary> The license type, which is for bring your own license scenario. </summary>
        public string LicenseType { get; set; }
        /// <summary> Specifies the billing related details of a Azure Spot VMSS. &lt;br&gt;&lt;br&gt;Minimum api-version: 2019-03-01. </summary>
        public BillingProfile BillingProfile { get; set; }
        /// <summary> Specifies Scheduled Event related configurations. </summary>
        public ScheduledEventsProfile ScheduledEventsProfile { get; set; }
    }
}
