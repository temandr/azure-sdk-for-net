// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> The ConnectionMonitors service client. </summary>
    public partial class ConnectionMonitorsOperations
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal ConnectionMonitorsRestOperations RestClient { get; }
        /// <summary> Initializes a new instance of ConnectionMonitorsOperations for mocking. </summary>
        protected ConnectionMonitorsOperations()
        {
        }
        /// <summary> Initializes a new instance of ConnectionMonitorsOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="endpoint"> server parameter. </param>
        internal ConnectionMonitorsOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            RestClient = new ConnectionMonitorsRestOperations(clientDiagnostics, pipeline, subscriptionId, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Gets a connection monitor by name. </summary>
        /// <param name="resourceGroupName"> The name of the resource group containing Network Watcher. </param>
        /// <param name="networkWatcherName"> The name of the Network Watcher resource. </param>
        /// <param name="connectionMonitorName"> The name of the connection monitor. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ConnectionMonitorResult>> GetAsync(string resourceGroupName, string networkWatcherName, string connectionMonitorName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ConnectionMonitorsOperations.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(resourceGroupName, networkWatcherName, connectionMonitorName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a connection monitor by name. </summary>
        /// <param name="resourceGroupName"> The name of the resource group containing Network Watcher. </param>
        /// <param name="networkWatcherName"> The name of the Network Watcher resource. </param>
        /// <param name="connectionMonitorName"> The name of the connection monitor. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ConnectionMonitorResult> Get(string resourceGroupName, string networkWatcherName, string connectionMonitorName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ConnectionMonitorsOperations.Get");
            scope.Start();
            try
            {
                return RestClient.Get(resourceGroupName, networkWatcherName, connectionMonitorName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Update tags of the specified connection monitor. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkWatcherName"> The name of the network watcher. </param>
        /// <param name="connectionMonitorName"> The name of the connection monitor. </param>
        /// <param name="parameters"> Parameters supplied to update connection monitor tags. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ConnectionMonitorResult>> UpdateTagsAsync(string resourceGroupName, string networkWatcherName, string connectionMonitorName, TagsObject parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ConnectionMonitorsOperations.UpdateTags");
            scope.Start();
            try
            {
                return await RestClient.UpdateTagsAsync(resourceGroupName, networkWatcherName, connectionMonitorName, parameters, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Update tags of the specified connection monitor. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkWatcherName"> The name of the network watcher. </param>
        /// <param name="connectionMonitorName"> The name of the connection monitor. </param>
        /// <param name="parameters"> Parameters supplied to update connection monitor tags. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ConnectionMonitorResult> UpdateTags(string resourceGroupName, string networkWatcherName, string connectionMonitorName, TagsObject parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ConnectionMonitorsOperations.UpdateTags");
            scope.Start();
            try
            {
                return RestClient.UpdateTags(resourceGroupName, networkWatcherName, connectionMonitorName, parameters, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all connection monitors for the specified Network Watcher. </summary>
        /// <param name="resourceGroupName"> The name of the resource group containing Network Watcher. </param>
        /// <param name="networkWatcherName"> The name of the Network Watcher resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<ConnectionMonitorResult> ListAsync(string resourceGroupName, string networkWatcherName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (networkWatcherName == null)
            {
                throw new ArgumentNullException(nameof(networkWatcherName));
            }

            async Task<Page<ConnectionMonitorResult>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ConnectionMonitorsOperations.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListAsync(resourceGroupName, networkWatcherName, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary> Lists all connection monitors for the specified Network Watcher. </summary>
        /// <param name="resourceGroupName"> The name of the resource group containing Network Watcher. </param>
        /// <param name="networkWatcherName"> The name of the Network Watcher resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<ConnectionMonitorResult> List(string resourceGroupName, string networkWatcherName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (networkWatcherName == null)
            {
                throw new ArgumentNullException(nameof(networkWatcherName));
            }

            Page<ConnectionMonitorResult> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ConnectionMonitorsOperations.List");
                scope.Start();
                try
                {
                    var response = RestClient.List(resourceGroupName, networkWatcherName, cancellationToken);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary> Create or update a connection monitor. </summary>
        /// <param name="resourceGroupName"> The name of the resource group containing Network Watcher. </param>
        /// <param name="networkWatcherName"> The name of the Network Watcher resource. </param>
        /// <param name="connectionMonitorName"> The name of the connection monitor. </param>
        /// <param name="parameters"> Parameters that define the operation to create a connection monitor. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ConnectionMonitorsCreateOrUpdateOperation> StartCreateOrUpdateAsync(string resourceGroupName, string networkWatcherName, string connectionMonitorName, ConnectionMonitor parameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (networkWatcherName == null)
            {
                throw new ArgumentNullException(nameof(networkWatcherName));
            }
            if (connectionMonitorName == null)
            {
                throw new ArgumentNullException(nameof(connectionMonitorName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ConnectionMonitorsOperations.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.CreateOrUpdateAsync(resourceGroupName, networkWatcherName, connectionMonitorName, parameters, cancellationToken).ConfigureAwait(false);
                return new ConnectionMonitorsCreateOrUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(resourceGroupName, networkWatcherName, connectionMonitorName, parameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create or update a connection monitor. </summary>
        /// <param name="resourceGroupName"> The name of the resource group containing Network Watcher. </param>
        /// <param name="networkWatcherName"> The name of the Network Watcher resource. </param>
        /// <param name="connectionMonitorName"> The name of the connection monitor. </param>
        /// <param name="parameters"> Parameters that define the operation to create a connection monitor. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ConnectionMonitorsCreateOrUpdateOperation StartCreateOrUpdate(string resourceGroupName, string networkWatcherName, string connectionMonitorName, ConnectionMonitor parameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (networkWatcherName == null)
            {
                throw new ArgumentNullException(nameof(networkWatcherName));
            }
            if (connectionMonitorName == null)
            {
                throw new ArgumentNullException(nameof(connectionMonitorName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ConnectionMonitorsOperations.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var originalResponse = RestClient.CreateOrUpdate(resourceGroupName, networkWatcherName, connectionMonitorName, parameters, cancellationToken);
                return new ConnectionMonitorsCreateOrUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(resourceGroupName, networkWatcherName, connectionMonitorName, parameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes the specified connection monitor. </summary>
        /// <param name="resourceGroupName"> The name of the resource group containing Network Watcher. </param>
        /// <param name="networkWatcherName"> The name of the Network Watcher resource. </param>
        /// <param name="connectionMonitorName"> The name of the connection monitor. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ConnectionMonitorsDeleteOperation> StartDeleteAsync(string resourceGroupName, string networkWatcherName, string connectionMonitorName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (networkWatcherName == null)
            {
                throw new ArgumentNullException(nameof(networkWatcherName));
            }
            if (connectionMonitorName == null)
            {
                throw new ArgumentNullException(nameof(connectionMonitorName));
            }

            using var scope = _clientDiagnostics.CreateScope("ConnectionMonitorsOperations.StartDelete");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.DeleteAsync(resourceGroupName, networkWatcherName, connectionMonitorName, cancellationToken).ConfigureAwait(false);
                return new ConnectionMonitorsDeleteOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteRequest(resourceGroupName, networkWatcherName, connectionMonitorName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes the specified connection monitor. </summary>
        /// <param name="resourceGroupName"> The name of the resource group containing Network Watcher. </param>
        /// <param name="networkWatcherName"> The name of the Network Watcher resource. </param>
        /// <param name="connectionMonitorName"> The name of the connection monitor. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ConnectionMonitorsDeleteOperation StartDelete(string resourceGroupName, string networkWatcherName, string connectionMonitorName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (networkWatcherName == null)
            {
                throw new ArgumentNullException(nameof(networkWatcherName));
            }
            if (connectionMonitorName == null)
            {
                throw new ArgumentNullException(nameof(connectionMonitorName));
            }

            using var scope = _clientDiagnostics.CreateScope("ConnectionMonitorsOperations.StartDelete");
            scope.Start();
            try
            {
                var originalResponse = RestClient.Delete(resourceGroupName, networkWatcherName, connectionMonitorName, cancellationToken);
                return new ConnectionMonitorsDeleteOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteRequest(resourceGroupName, networkWatcherName, connectionMonitorName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Stops the specified connection monitor. </summary>
        /// <param name="resourceGroupName"> The name of the resource group containing Network Watcher. </param>
        /// <param name="networkWatcherName"> The name of the Network Watcher resource. </param>
        /// <param name="connectionMonitorName"> The name of the connection monitor. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ConnectionMonitorsStopOperation> StartStopAsync(string resourceGroupName, string networkWatcherName, string connectionMonitorName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (networkWatcherName == null)
            {
                throw new ArgumentNullException(nameof(networkWatcherName));
            }
            if (connectionMonitorName == null)
            {
                throw new ArgumentNullException(nameof(connectionMonitorName));
            }

            using var scope = _clientDiagnostics.CreateScope("ConnectionMonitorsOperations.StartStop");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.StopAsync(resourceGroupName, networkWatcherName, connectionMonitorName, cancellationToken).ConfigureAwait(false);
                return new ConnectionMonitorsStopOperation(_clientDiagnostics, _pipeline, RestClient.CreateStopRequest(resourceGroupName, networkWatcherName, connectionMonitorName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Stops the specified connection monitor. </summary>
        /// <param name="resourceGroupName"> The name of the resource group containing Network Watcher. </param>
        /// <param name="networkWatcherName"> The name of the Network Watcher resource. </param>
        /// <param name="connectionMonitorName"> The name of the connection monitor. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ConnectionMonitorsStopOperation StartStop(string resourceGroupName, string networkWatcherName, string connectionMonitorName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (networkWatcherName == null)
            {
                throw new ArgumentNullException(nameof(networkWatcherName));
            }
            if (connectionMonitorName == null)
            {
                throw new ArgumentNullException(nameof(connectionMonitorName));
            }

            using var scope = _clientDiagnostics.CreateScope("ConnectionMonitorsOperations.StartStop");
            scope.Start();
            try
            {
                var originalResponse = RestClient.Stop(resourceGroupName, networkWatcherName, connectionMonitorName, cancellationToken);
                return new ConnectionMonitorsStopOperation(_clientDiagnostics, _pipeline, RestClient.CreateStopRequest(resourceGroupName, networkWatcherName, connectionMonitorName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Starts the specified connection monitor. </summary>
        /// <param name="resourceGroupName"> The name of the resource group containing Network Watcher. </param>
        /// <param name="networkWatcherName"> The name of the Network Watcher resource. </param>
        /// <param name="connectionMonitorName"> The name of the connection monitor. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ConnectionMonitorsStartOperation> StartStartAsync(string resourceGroupName, string networkWatcherName, string connectionMonitorName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (networkWatcherName == null)
            {
                throw new ArgumentNullException(nameof(networkWatcherName));
            }
            if (connectionMonitorName == null)
            {
                throw new ArgumentNullException(nameof(connectionMonitorName));
            }

            using var scope = _clientDiagnostics.CreateScope("ConnectionMonitorsOperations.StartStart");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.StartAsync(resourceGroupName, networkWatcherName, connectionMonitorName, cancellationToken).ConfigureAwait(false);
                return new ConnectionMonitorsStartOperation(_clientDiagnostics, _pipeline, RestClient.CreateStartRequest(resourceGroupName, networkWatcherName, connectionMonitorName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Starts the specified connection monitor. </summary>
        /// <param name="resourceGroupName"> The name of the resource group containing Network Watcher. </param>
        /// <param name="networkWatcherName"> The name of the Network Watcher resource. </param>
        /// <param name="connectionMonitorName"> The name of the connection monitor. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ConnectionMonitorsStartOperation StartStart(string resourceGroupName, string networkWatcherName, string connectionMonitorName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (networkWatcherName == null)
            {
                throw new ArgumentNullException(nameof(networkWatcherName));
            }
            if (connectionMonitorName == null)
            {
                throw new ArgumentNullException(nameof(connectionMonitorName));
            }

            using var scope = _clientDiagnostics.CreateScope("ConnectionMonitorsOperations.StartStart");
            scope.Start();
            try
            {
                var originalResponse = RestClient.Start(resourceGroupName, networkWatcherName, connectionMonitorName, cancellationToken);
                return new ConnectionMonitorsStartOperation(_clientDiagnostics, _pipeline, RestClient.CreateStartRequest(resourceGroupName, networkWatcherName, connectionMonitorName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Query a snapshot of the most recent connection states. </summary>
        /// <param name="resourceGroupName"> The name of the resource group containing Network Watcher. </param>
        /// <param name="networkWatcherName"> The name of the Network Watcher resource. </param>
        /// <param name="connectionMonitorName"> The name given to the connection monitor. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ConnectionMonitorsQueryOperation> StartQueryAsync(string resourceGroupName, string networkWatcherName, string connectionMonitorName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (networkWatcherName == null)
            {
                throw new ArgumentNullException(nameof(networkWatcherName));
            }
            if (connectionMonitorName == null)
            {
                throw new ArgumentNullException(nameof(connectionMonitorName));
            }

            using var scope = _clientDiagnostics.CreateScope("ConnectionMonitorsOperations.StartQuery");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.QueryAsync(resourceGroupName, networkWatcherName, connectionMonitorName, cancellationToken).ConfigureAwait(false);
                return new ConnectionMonitorsQueryOperation(_clientDiagnostics, _pipeline, RestClient.CreateQueryRequest(resourceGroupName, networkWatcherName, connectionMonitorName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Query a snapshot of the most recent connection states. </summary>
        /// <param name="resourceGroupName"> The name of the resource group containing Network Watcher. </param>
        /// <param name="networkWatcherName"> The name of the Network Watcher resource. </param>
        /// <param name="connectionMonitorName"> The name given to the connection monitor. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ConnectionMonitorsQueryOperation StartQuery(string resourceGroupName, string networkWatcherName, string connectionMonitorName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (networkWatcherName == null)
            {
                throw new ArgumentNullException(nameof(networkWatcherName));
            }
            if (connectionMonitorName == null)
            {
                throw new ArgumentNullException(nameof(connectionMonitorName));
            }

            using var scope = _clientDiagnostics.CreateScope("ConnectionMonitorsOperations.StartQuery");
            scope.Start();
            try
            {
                var originalResponse = RestClient.Query(resourceGroupName, networkWatcherName, connectionMonitorName, cancellationToken);
                return new ConnectionMonitorsQueryOperation(_clientDiagnostics, _pipeline, RestClient.CreateQueryRequest(resourceGroupName, networkWatcherName, connectionMonitorName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
