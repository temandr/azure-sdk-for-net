// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.DigitalTwins.Models;

namespace Azure.ResourceManager.DigitalTwins
{
    internal partial class DigitalTwinsEndpointRestOperations
    {
        private string subscriptionId;
        private Uri endpoint;
        private string apiVersion;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of DigitalTwinsEndpointRestOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> The subscription identifier. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> This occurs when one of the required arguments is null. </exception>
        public DigitalTwinsEndpointRestOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null, string apiVersion = "2020-03-01-preview")
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            endpoint ??= new Uri("https://management.azure.com");
            if (apiVersion == null)
            {
                throw new ArgumentNullException(nameof(apiVersion));
            }

            this.subscriptionId = subscriptionId;
            this.endpoint = endpoint;
            this.apiVersion = apiVersion;
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateListRequest(string resourceGroupName, string resourceName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.DigitalTwins/digitalTwinsInstances/", false);
            uri.AppendPath(resourceName, true);
            uri.AppendPath("/endpoints", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            return message;
        }

        /// <summary> Get DigitalTwinsInstance Endpoints. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the DigitalTwinsInstance. </param>
        /// <param name="resourceName"> The name of the DigitalTwinsInstance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<DigitalTwinsEndpointResourceListResult>> ListAsync(string resourceGroupName, string resourceName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (resourceName == null)
            {
                throw new ArgumentNullException(nameof(resourceName));
            }

            using var message = CreateListRequest(resourceGroupName, resourceName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DigitalTwinsEndpointResourceListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = DigitalTwinsEndpointResourceListResult.DeserializeDigitalTwinsEndpointResourceListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Get DigitalTwinsInstance Endpoints. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the DigitalTwinsInstance. </param>
        /// <param name="resourceName"> The name of the DigitalTwinsInstance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<DigitalTwinsEndpointResourceListResult> List(string resourceGroupName, string resourceName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (resourceName == null)
            {
                throw new ArgumentNullException(nameof(resourceName));
            }

            using var message = CreateListRequest(resourceGroupName, resourceName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DigitalTwinsEndpointResourceListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = DigitalTwinsEndpointResourceListResult.DeserializeDigitalTwinsEndpointResourceListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string resourceGroupName, string resourceName, string endpointName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.DigitalTwins/digitalTwinsInstances/", false);
            uri.AppendPath(resourceName, true);
            uri.AppendPath("/endpoints/", false);
            uri.AppendPath(endpointName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            return message;
        }

        /// <summary> Get DigitalTwinsInstances Endpoint. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the DigitalTwinsInstance. </param>
        /// <param name="resourceName"> The name of the DigitalTwinsInstance. </param>
        /// <param name="endpointName"> Name of Endpoint Resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<DigitalTwinsEndpointResource>> GetAsync(string resourceGroupName, string resourceName, string endpointName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (resourceName == null)
            {
                throw new ArgumentNullException(nameof(resourceName));
            }
            if (endpointName == null)
            {
                throw new ArgumentNullException(nameof(endpointName));
            }

            using var message = CreateGetRequest(resourceGroupName, resourceName, endpointName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DigitalTwinsEndpointResource value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = DigitalTwinsEndpointResource.DeserializeDigitalTwinsEndpointResource(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Get DigitalTwinsInstances Endpoint. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the DigitalTwinsInstance. </param>
        /// <param name="resourceName"> The name of the DigitalTwinsInstance. </param>
        /// <param name="endpointName"> Name of Endpoint Resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<DigitalTwinsEndpointResource> Get(string resourceGroupName, string resourceName, string endpointName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (resourceName == null)
            {
                throw new ArgumentNullException(nameof(resourceName));
            }
            if (endpointName == null)
            {
                throw new ArgumentNullException(nameof(endpointName));
            }

            using var message = CreateGetRequest(resourceGroupName, resourceName, endpointName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DigitalTwinsEndpointResource value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = DigitalTwinsEndpointResource.DeserializeDigitalTwinsEndpointResource(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string resourceGroupName, string resourceName, string endpointName, DigitalTwinsEndpointResourceProperties properties)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.DigitalTwins/digitalTwinsInstances/", false);
            uri.AppendPath(resourceName, true);
            uri.AppendPath("/endpoints/", false);
            uri.AppendPath(endpointName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            var model = new DigitalTwinsEndpointResource()
            {
                Properties = properties
            };
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(model);
            request.Content = content;
            return message;
        }

        /// <summary> Create or update DigitalTwinsInstance endpoint. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the DigitalTwinsInstance. </param>
        /// <param name="resourceName"> The name of the DigitalTwinsInstance. </param>
        /// <param name="endpointName"> Name of Endpoint Resource. </param>
        /// <param name="properties"> DigitalTwinsInstance endpoint resource properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response> CreateOrUpdateAsync(string resourceGroupName, string resourceName, string endpointName, DigitalTwinsEndpointResourceProperties properties = null, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (resourceName == null)
            {
                throw new ArgumentNullException(nameof(resourceName));
            }
            if (endpointName == null)
            {
                throw new ArgumentNullException(nameof(endpointName));
            }

            using var message = CreateCreateOrUpdateRequest(resourceGroupName, resourceName, endpointName, properties);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Create or update DigitalTwinsInstance endpoint. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the DigitalTwinsInstance. </param>
        /// <param name="resourceName"> The name of the DigitalTwinsInstance. </param>
        /// <param name="endpointName"> Name of Endpoint Resource. </param>
        /// <param name="properties"> DigitalTwinsInstance endpoint resource properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response CreateOrUpdate(string resourceGroupName, string resourceName, string endpointName, DigitalTwinsEndpointResourceProperties properties = null, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (resourceName == null)
            {
                throw new ArgumentNullException(nameof(resourceName));
            }
            if (endpointName == null)
            {
                throw new ArgumentNullException(nameof(endpointName));
            }

            using var message = CreateCreateOrUpdateRequest(resourceGroupName, resourceName, endpointName, properties);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteRequest(string resourceGroupName, string resourceName, string endpointName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.DigitalTwins/digitalTwinsInstances/", false);
            uri.AppendPath(resourceName, true);
            uri.AppendPath("/endpoints/", false);
            uri.AppendPath(endpointName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            return message;
        }

        /// <summary> Delete a DigitalTwinsInstance endpoint. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the DigitalTwinsInstance. </param>
        /// <param name="resourceName"> The name of the DigitalTwinsInstance. </param>
        /// <param name="endpointName"> Name of Endpoint Resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response> DeleteAsync(string resourceGroupName, string resourceName, string endpointName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (resourceName == null)
            {
                throw new ArgumentNullException(nameof(resourceName));
            }
            if (endpointName == null)
            {
                throw new ArgumentNullException(nameof(endpointName));
            }

            using var message = CreateDeleteRequest(resourceGroupName, resourceName, endpointName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Delete a DigitalTwinsInstance endpoint. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the DigitalTwinsInstance. </param>
        /// <param name="resourceName"> The name of the DigitalTwinsInstance. </param>
        /// <param name="endpointName"> Name of Endpoint Resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response Delete(string resourceGroupName, string resourceName, string endpointName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (resourceName == null)
            {
                throw new ArgumentNullException(nameof(resourceName));
            }
            if (endpointName == null)
            {
                throw new ArgumentNullException(nameof(endpointName));
            }

            using var message = CreateDeleteRequest(resourceGroupName, resourceName, endpointName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListNextPageRequest(string nextLink, string resourceGroupName, string resourceName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            return message;
        }

        /// <summary> Get DigitalTwinsInstance Endpoints. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="resourceGroupName"> The name of the resource group that contains the DigitalTwinsInstance. </param>
        /// <param name="resourceName"> The name of the DigitalTwinsInstance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<DigitalTwinsEndpointResourceListResult>> ListNextPageAsync(string nextLink, string resourceGroupName, string resourceName, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (resourceName == null)
            {
                throw new ArgumentNullException(nameof(resourceName));
            }

            using var message = CreateListNextPageRequest(nextLink, resourceGroupName, resourceName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DigitalTwinsEndpointResourceListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = DigitalTwinsEndpointResourceListResult.DeserializeDigitalTwinsEndpointResourceListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Get DigitalTwinsInstance Endpoints. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="resourceGroupName"> The name of the resource group that contains the DigitalTwinsInstance. </param>
        /// <param name="resourceName"> The name of the DigitalTwinsInstance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<DigitalTwinsEndpointResourceListResult> ListNextPage(string nextLink, string resourceGroupName, string resourceName, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (resourceName == null)
            {
                throw new ArgumentNullException(nameof(resourceName));
            }

            using var message = CreateListNextPageRequest(nextLink, resourceGroupName, resourceName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DigitalTwinsEndpointResourceListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = DigitalTwinsEndpointResourceListResult.DeserializeDigitalTwinsEndpointResourceListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
