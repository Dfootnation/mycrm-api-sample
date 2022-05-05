// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace MyCrmSampleClient.MyCrmApi
{
    /// <summary> The LiabilityCategory service client. </summary>
    public partial class LiabilityCategoryClient
    {
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of LiabilityCategoryClient for mocking. </summary>
        protected LiabilityCategoryClient()
        {
        }

        /// <summary> Initializes a new instance of LiabilityCategoryClient. </summary>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="options"> The options for configuring the client. </param>
        public LiabilityCategoryClient(Uri endpoint = null, MyCRMAPIClientOptions options = null)
        {
            endpoint ??= new Uri("");
            options ??= new MyCRMAPIClientOptions();

            ClientDiagnostics = new ClientDiagnostics(options);
            _pipeline = HttpPipelineBuilder.Build(options, Array.Empty<HttpPipelinePolicy>(), Array.Empty<HttpPipelinePolicy>(), new ResponseClassifier());
            _endpoint = endpoint;
        }

        /// <summary> Where `id` is the identifier of the liability category. </summary>
        /// <param name="id"> The Integer to use. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   meta: Dictionary&lt;string, object&gt;,
        ///   jsonApi: Dictionary&lt;string, object&gt;,
        ///   links: {
        ///     self: string,
        ///     related: string,
        ///     describedby: string,
        ///     first: string,
        ///     last: string,
        ///     prev: string,
        ///     next: string
        ///   },
        ///   data: {
        ///     type: string,
        ///     id: string,
        ///     type: &quot;liability-categories&quot;,
        ///     id: string,
        ///     attributes: {
        ///       description: string
        ///     },
        ///     relationships: {
        ///       liabilityTypes: {
        ///         links: {
        ///           self: string,
        ///           related: string
        ///         },
        ///         meta: Dictionary&lt;string, object&gt;,
        ///         data: [
        ///           {
        ///             type: string,
        ///             id: string
        ///           }
        ///         ]
        ///       }
        ///     },
        ///     links: {
        ///       self: string
        ///     },
        ///     meta: Dictionary&lt;string, object&gt;
        ///   },
        ///   included: [
        ///     {
        ///       type: string,
        ///       id: string
        ///     }
        ///   ]
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   links: {
        ///     self: string,
        ///     related: string,
        ///     describedby: string,
        ///     first: string,
        ///     last: string,
        ///     prev: string,
        ///     next: string
        ///   },
        ///   errors: [
        ///     {
        ///       id: string,
        ///       links: {
        ///         about: string,
        ///         type: string
        ///       },
        ///       status: string,
        ///       code: string,
        ///       title: string,
        ///       detail: string,
        ///       source: {
        ///         pointer: string,
        ///         parameter: string,
        ///         header: string
        ///       },
        ///       meta: Dictionary&lt;string, object&gt;
        ///     }
        ///   ]
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual async Task<Response> GetLiabilityCategoryAsync(int id, RequestContext context = null)
        {
            using var scope = ClientDiagnostics.CreateScope("LiabilityCategoryClient.GetLiabilityCategory");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetLiabilityCategoryRequest(id, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Where `id` is the identifier of the liability category. </summary>
        /// <param name="id"> The Integer to use. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   meta: Dictionary&lt;string, object&gt;,
        ///   jsonApi: Dictionary&lt;string, object&gt;,
        ///   links: {
        ///     self: string,
        ///     related: string,
        ///     describedby: string,
        ///     first: string,
        ///     last: string,
        ///     prev: string,
        ///     next: string
        ///   },
        ///   data: {
        ///     type: string,
        ///     id: string,
        ///     type: &quot;liability-categories&quot;,
        ///     id: string,
        ///     attributes: {
        ///       description: string
        ///     },
        ///     relationships: {
        ///       liabilityTypes: {
        ///         links: {
        ///           self: string,
        ///           related: string
        ///         },
        ///         meta: Dictionary&lt;string, object&gt;,
        ///         data: [
        ///           {
        ///             type: string,
        ///             id: string
        ///           }
        ///         ]
        ///       }
        ///     },
        ///     links: {
        ///       self: string
        ///     },
        ///     meta: Dictionary&lt;string, object&gt;
        ///   },
        ///   included: [
        ///     {
        ///       type: string,
        ///       id: string
        ///     }
        ///   ]
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   links: {
        ///     self: string,
        ///     related: string,
        ///     describedby: string,
        ///     first: string,
        ///     last: string,
        ///     prev: string,
        ///     next: string
        ///   },
        ///   errors: [
        ///     {
        ///       id: string,
        ///       links: {
        ///         about: string,
        ///         type: string
        ///       },
        ///       status: string,
        ///       code: string,
        ///       title: string,
        ///       detail: string,
        ///       source: {
        ///         pointer: string,
        ///         parameter: string,
        ///         header: string
        ///       },
        ///       meta: Dictionary&lt;string, object&gt;
        ///     }
        ///   ]
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual Response GetLiabilityCategory(int id, RequestContext context = null)
        {
            using var scope = ClientDiagnostics.CreateScope("LiabilityCategoryClient.GetLiabilityCategory");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetLiabilityCategoryRequest(id, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        internal HttpMessage CreateGetLiabilityCategoryRequest(int id, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200401);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/jsonapi/liability-categories/", false);
            uri.AppendPath(id, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/vnd.api+json");
            return message;
        }

        private static ResponseClassifier _responseClassifier200401;
        private static ResponseClassifier ResponseClassifier200401 => _responseClassifier200401 ??= new StatusCodeClassifier(stackalloc ushort[] { 200, 401 });
    }
}
