// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Management.Resource.Models;

namespace Azure.Management.Resource
{
    /// <summary> The ResourceGroups service client. </summary>
    public partial class ResourceGroupsClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal ResourceGroupsRestClient RestClient { get; }
        /// <summary> Initializes a new instance of ResourceGroupsClient for mocking. </summary>
        protected ResourceGroupsClient()
        {
        }

        /// <summary> Initializes a new instance of ResourceGroupsClient. </summary>
        public ResourceGroupsClient(string subscriptionId, TokenCredential tokenCredential, ResourceManagementClientOptions options = null)
        {
            options ??= new ResourceManagementClientOptions();
            _clientDiagnostics = new ClientDiagnostics(options);
            _pipeline = ManagementPipelineBuilder.Build(tokenCredential, options);
            RestClient = new ResourceGroupsRestClient(_clientDiagnostics, _pipeline, subscriptionId: subscriptionId);
        }

        /// <summary> Checks whether a resource group exists. </summary>
        /// <param name="resourceGroupName"> The name of the resource group to check. The name is case insensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> CheckExistenceAsync(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            return await RestClient.CheckExistenceAsync(resourceGroupName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Checks whether a resource group exists. </summary>
        /// <param name="resourceGroupName"> The name of the resource group to check. The name is case insensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response CheckExistence(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            return RestClient.CheckExistence(resourceGroupName, cancellationToken);
        }

        /// <summary> Creates or updates a resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group to create or update. Can include alphanumeric, underscore, parentheses, hyphen, period (except at end), and Unicode characters that match the allowed characters. </param>
        /// <param name="parameters"> Parameters supplied to the create or update a resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ResourceGroup>> CreateOrUpdateAsync(string resourceGroupName, ResourceGroup parameters, CancellationToken cancellationToken = default)
        {
            return await RestClient.CreateOrUpdateAsync(resourceGroupName, parameters, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Creates or updates a resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group to create or update. Can include alphanumeric, underscore, parentheses, hyphen, period (except at end), and Unicode characters that match the allowed characters. </param>
        /// <param name="parameters"> Parameters supplied to the create or update a resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ResourceGroup> CreateOrUpdate(string resourceGroupName, ResourceGroup parameters, CancellationToken cancellationToken = default)
        {
            return RestClient.CreateOrUpdate(resourceGroupName, parameters, cancellationToken);
        }

        /// <summary> Gets a resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group to get. The name is case insensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ResourceGroup>> GetAsync(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            return await RestClient.GetAsync(resourceGroupName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Gets a resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group to get. The name is case insensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ResourceGroup> Get(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            return RestClient.Get(resourceGroupName, cancellationToken);
        }

        /// <summary> Resource groups can be updated through a simple PATCH operation to a group address. The format of the request is the same as that for creating a resource group. If a field is unspecified, the current value is retained. </summary>
        /// <param name="resourceGroupName"> The name of the resource group to update. The name is case insensitive. </param>
        /// <param name="parameters"> Parameters supplied to update a resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ResourceGroup>> UpdateAsync(string resourceGroupName, ResourceGroupPatchable parameters, CancellationToken cancellationToken = default)
        {
            return await RestClient.UpdateAsync(resourceGroupName, parameters, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Resource groups can be updated through a simple PATCH operation to a group address. The format of the request is the same as that for creating a resource group. If a field is unspecified, the current value is retained. </summary>
        /// <param name="resourceGroupName"> The name of the resource group to update. The name is case insensitive. </param>
        /// <param name="parameters"> Parameters supplied to update a resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ResourceGroup> Update(string resourceGroupName, ResourceGroupPatchable parameters, CancellationToken cancellationToken = default)
        {
            return RestClient.Update(resourceGroupName, parameters, cancellationToken);
        }

        /// <summary> Gets all the resource groups for a subscription. </summary>
        /// <param name="filter"> The filter to apply on the operation.&lt;br&gt;&lt;br&gt;You can filter by tag names and values. For example, to filter for a tag name and value, use $filter=tagName eq &apos;tag1&apos; and tagValue eq &apos;Value1&apos;. </param>
        /// <param name="top"> The number of results to return. If null is passed, returns all resource groups. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<ResourceGroup> ListAsync(string filter = null, int? top = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<ResourceGroup>> FirstPageFunc(int? pageSizeHint)
            {
                var response = await RestClient.ListAsync(filter, top, cancellationToken).ConfigureAwait(false);
                return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
            }
            async Task<Page<ResourceGroup>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                var response = await RestClient.ListNextPageAsync(nextLink, filter, top, cancellationToken).ConfigureAwait(false);
                return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets all the resource groups for a subscription. </summary>
        /// <param name="filter"> The filter to apply on the operation.&lt;br&gt;&lt;br&gt;You can filter by tag names and values. For example, to filter for a tag name and value, use $filter=tagName eq &apos;tag1&apos; and tagValue eq &apos;Value1&apos;. </param>
        /// <param name="top"> The number of results to return. If null is passed, returns all resource groups. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<ResourceGroup> List(string filter = null, int? top = null, CancellationToken cancellationToken = default)
        {
            Page<ResourceGroup> FirstPageFunc(int? pageSizeHint)
            {
                var response = RestClient.List(filter, top, cancellationToken);
                return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
            }
            Page<ResourceGroup> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                var response = RestClient.ListNextPage(nextLink, filter, top, cancellationToken);
                return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> When you delete a resource group, all of its resources are also deleted. Deleting a resource group deletes all of its template deployments and currently stored operations. </summary>
        /// <param name="originalResponse"> The original response from starting the operation. </param>
        /// <param name="createOriginalHttpMessage"> Creates the HTTP message used for the original request. </param>
        internal Operation<Response> CreateDelete(Response originalResponse, Func<Core.HttpMessage> createOriginalHttpMessage)
        {
            if (originalResponse == null)
            {
                throw new ArgumentNullException(nameof(originalResponse));
            }
            if (createOriginalHttpMessage == null)
            {
                throw new ArgumentNullException(nameof(createOriginalHttpMessage));
            }

            return ArmOperationHelpers.Create(_pipeline, _clientDiagnostics, originalResponse, RequestMethod.Delete, "ResourceGroupsClient.Delete", OperationFinalStateVia.Location, createOriginalHttpMessage);
        }

        /// <summary> When you delete a resource group, all of its resources are also deleted. Deleting a resource group deletes all of its template deployments and currently stored operations. </summary>
        /// <param name="resourceGroupName"> The name of the resource group to delete. The name is case insensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async ValueTask<Operation<Response>> StartDeleteAsync(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            var originalResponse = await RestClient.DeleteAsync(resourceGroupName, cancellationToken).ConfigureAwait(false);
            return CreateDelete(originalResponse, () => RestClient.CreateDeleteRequest(resourceGroupName));
        }

        /// <summary> When you delete a resource group, all of its resources are also deleted. Deleting a resource group deletes all of its template deployments and currently stored operations. </summary>
        /// <param name="resourceGroupName"> The name of the resource group to delete. The name is case insensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Operation<Response> StartDelete(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            var originalResponse = RestClient.Delete(resourceGroupName, cancellationToken);
            return CreateDelete(originalResponse, () => RestClient.CreateDeleteRequest(resourceGroupName));
        }

        /// <summary> Captures the specified resource group as a template. </summary>
        /// <param name="originalResponse"> The original response from starting the operation. </param>
        /// <param name="createOriginalHttpMessage"> Creates the HTTP message used for the original request. </param>
        internal Operation<ResourceGroupExportResult> CreateExportTemplate(Response originalResponse, Func<Core.HttpMessage> createOriginalHttpMessage)
        {
            if (originalResponse == null)
            {
                throw new ArgumentNullException(nameof(originalResponse));
            }
            if (createOriginalHttpMessage == null)
            {
                throw new ArgumentNullException(nameof(createOriginalHttpMessage));
            }

            return ArmOperationHelpers.Create(_pipeline, _clientDiagnostics, originalResponse, RequestMethod.Post, "ResourceGroupsClient.ExportTemplate", OperationFinalStateVia.Location, createOriginalHttpMessage,
            (response, cancellationToken) =>
            {
                using var document = JsonDocument.Parse(response.ContentStream);
                if (document.RootElement.ValueKind == JsonValueKind.Null)
                {
                    return null;
                }
                else
                {
                    return ResourceGroupExportResult.DeserializeResourceGroupExportResult(document.RootElement);
                }
            },
            async (response, cancellationToken) =>
            {
                using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                if (document.RootElement.ValueKind == JsonValueKind.Null)
                {
                    return null;
                }
                else
                {
                    return ResourceGroupExportResult.DeserializeResourceGroupExportResult(document.RootElement);
                }
            });
        }

        /// <summary> Captures the specified resource group as a template. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="resources"> The IDs of the resources to filter the export by. To export all resources, supply an array with single entry &apos;*&apos;. </param>
        /// <param name="options"> The export template options. A CSV-formatted list containing zero or more of the following: &apos;IncludeParameterDefaultValue&apos;, &apos;IncludeComments&apos;, &apos;SkipResourceNameParameterization&apos;, &apos;SkipAllParameterization&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async ValueTask<Operation<ResourceGroupExportResult>> StartExportTemplateAsync(string resourceGroupName, IEnumerable<string> resources = null, string options = null, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            var originalResponse = await RestClient.ExportTemplateAsync(resourceGroupName, resources, options, cancellationToken).ConfigureAwait(false);
            return CreateExportTemplate(originalResponse, () => RestClient.CreateExportTemplateRequest(resourceGroupName, resources, options));
        }

        /// <summary> Captures the specified resource group as a template. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="resources"> The IDs of the resources to filter the export by. To export all resources, supply an array with single entry &apos;*&apos;. </param>
        /// <param name="options"> The export template options. A CSV-formatted list containing zero or more of the following: &apos;IncludeParameterDefaultValue&apos;, &apos;IncludeComments&apos;, &apos;SkipResourceNameParameterization&apos;, &apos;SkipAllParameterization&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Operation<ResourceGroupExportResult> StartExportTemplate(string resourceGroupName, IEnumerable<string> resources = null, string options = null, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            var originalResponse = RestClient.ExportTemplate(resourceGroupName, resources, options, cancellationToken);
            return CreateExportTemplate(originalResponse, () => RestClient.CreateExportTemplateRequest(resourceGroupName, resources, options));
        }
    }
}