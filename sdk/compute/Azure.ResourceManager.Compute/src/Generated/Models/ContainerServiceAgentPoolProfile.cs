// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Profile for the container service agent pool. </summary>
    public partial class ContainerServiceAgentPoolProfile
    {
        /// <summary> Initializes a new instance of ContainerServiceAgentPoolProfile. </summary>
        /// <param name="name"> Unique name of the agent pool profile in the context of the subscription and resource group. </param>
        /// <param name="count"> Number of agents (VMs) to host docker containers. Allowed values must be in the range of 1 to 100 (inclusive). The default value is 1. </param>
        /// <param name="vmSize"> Size of agent VMs. </param>
        /// <param name="dnsPrefix"> DNS prefix to be used to create the FQDN for the agent pool. </param>
        public ContainerServiceAgentPoolProfile(string name, int count, ContainerServiceVMSizeTypes vmSize, string dnsPrefix)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (dnsPrefix == null)
            {
                throw new ArgumentNullException(nameof(dnsPrefix));
            }

            Name = name;
            Count = count;
            VmSize = vmSize;
            DnsPrefix = dnsPrefix;
        }

        /// <summary> Initializes a new instance of ContainerServiceAgentPoolProfile. </summary>
        /// <param name="name"> Unique name of the agent pool profile in the context of the subscription and resource group. </param>
        /// <param name="count"> Number of agents (VMs) to host docker containers. Allowed values must be in the range of 1 to 100 (inclusive). The default value is 1. </param>
        /// <param name="vmSize"> Size of agent VMs. </param>
        /// <param name="dnsPrefix"> DNS prefix to be used to create the FQDN for the agent pool. </param>
        /// <param name="fqdn"> FQDN for the agent pool. </param>
        internal ContainerServiceAgentPoolProfile(string name, int count, ContainerServiceVMSizeTypes vmSize, string dnsPrefix, string fqdn)
        {
            Name = name;
            Count = count;
            VmSize = vmSize;
            DnsPrefix = dnsPrefix;
            Fqdn = fqdn;
        }

        /// <summary> Unique name of the agent pool profile in the context of the subscription and resource group. </summary>
        public string Name { get; set; }
        /// <summary> Number of agents (VMs) to host docker containers. Allowed values must be in the range of 1 to 100 (inclusive). The default value is 1. </summary>
        public int Count { get; set; }
        /// <summary> Size of agent VMs. </summary>
        public ContainerServiceVMSizeTypes VmSize { get; set; }
        /// <summary> DNS prefix to be used to create the FQDN for the agent pool. </summary>
        public string DnsPrefix { get; set; }
        /// <summary> FQDN for the agent pool. </summary>
        public string Fqdn { get; }
    }
}
