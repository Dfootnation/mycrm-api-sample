// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace MyCrmSampleClient.MyCrmApi
{
    /// <summary> The AdviserDetails service client. </summary>
    public partial class AdviserDetailsClient
    {
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of AdviserDetailsClient for mocking. </summary>
        protected AdviserDetailsClient()
        {
        }

        /// <summary> Initializes a new instance of AdviserDetailsClient. </summary>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="options"> The options for configuring the client. </param>
        public AdviserDetailsClient(Uri endpoint = null, MyCRMAPIClientOptions options = null)
        {
            endpoint ??= new Uri("");
            options ??= new MyCRMAPIClientOptions();

            ClientDiagnostics = new ClientDiagnostics(options);
            _pipeline = HttpPipelineBuilder.Build(options, Array.Empty<HttpPipelinePolicy>(), Array.Empty<HttpPipelinePolicy>(), new ResponseClassifier());
            _endpoint = endpoint;
        }

        /// <summary> Gets a collection of adviser details. </summary>
        /// <param name="filter"> The ArrayOfString to use. </param>
        /// <param name="sort"> The ArrayOfString to use. </param>
        /// <param name="page"> The Pagination to use. </param>
        /// <param name="include"> The ArrayOfString to use. </param>
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
        ///   data: [
        ///     {
        ///       type: string,
        ///       id: string,
        ///       type: &quot;adviser-details&quot;,
        ///       id: string,
        ///       attributes: {
        ///         gender: &quot;Male&quot; | &quot;Female&quot; | &quot;Undisclosed&quot;,
        ///         placeOfBirth: string,
        ///         title: string,
        ///         firstName: string,
        ///         middleName: string,
        ///         lastName: string,
        ///         preferredName: string,
        ///         homePhone: string,
        ///         businessPhone: string,
        ///         mobilePhone: string,
        ///         email: string,
        ///         birthCountry: string,
        ///         fax: string,
        ///         workEmail: string,
        ///         dateOfBirth: AdviserDetailAttributesDateOfBirth,
        ///         updated: string (ISO 8601 Format),
        ///         created: string (ISO 8601 Format),
        ///         description: string
        ///       },
        ///       relationships: {
        ///         adviser: {
        ///           links: {
        ///             self: string,
        ///             related: string
        ///           },
        ///           meta: Dictionary&lt;string, object&gt;,
        ///           data: {
        ///             type: string,
        ///             id: string
        ///           }
        ///         }
        ///       },
        ///       links: {
        ///         self: string
        ///       },
        ///       meta: Dictionary&lt;string, object&gt;
        ///     }
        ///   ],
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
        public virtual async Task<Response> GetAdviserDetailAsync(IEnumerable<string> filter = null, IEnumerable<string> sort = null, object page = null, IEnumerable<string> include = null, RequestContext context = null)
        {
            using var scope = ClientDiagnostics.CreateScope("AdviserDetailsClient.GetAdviserDetail");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetAdviserDetailRequest(filter, sort, page, include, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a collection of adviser details. </summary>
        /// <param name="filter"> The ArrayOfString to use. </param>
        /// <param name="sort"> The ArrayOfString to use. </param>
        /// <param name="page"> The Pagination to use. </param>
        /// <param name="include"> The ArrayOfString to use. </param>
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
        ///   data: [
        ///     {
        ///       type: string,
        ///       id: string,
        ///       type: &quot;adviser-details&quot;,
        ///       id: string,
        ///       attributes: {
        ///         gender: &quot;Male&quot; | &quot;Female&quot; | &quot;Undisclosed&quot;,
        ///         placeOfBirth: string,
        ///         title: string,
        ///         firstName: string,
        ///         middleName: string,
        ///         lastName: string,
        ///         preferredName: string,
        ///         homePhone: string,
        ///         businessPhone: string,
        ///         mobilePhone: string,
        ///         email: string,
        ///         birthCountry: string,
        ///         fax: string,
        ///         workEmail: string,
        ///         dateOfBirth: AdviserDetailAttributesDateOfBirth,
        ///         updated: string (ISO 8601 Format),
        ///         created: string (ISO 8601 Format),
        ///         description: string
        ///       },
        ///       relationships: {
        ///         adviser: {
        ///           links: {
        ///             self: string,
        ///             related: string
        ///           },
        ///           meta: Dictionary&lt;string, object&gt;,
        ///           data: {
        ///             type: string,
        ///             id: string
        ///           }
        ///         }
        ///       },
        ///       links: {
        ///         self: string
        ///       },
        ///       meta: Dictionary&lt;string, object&gt;
        ///     }
        ///   ],
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
        public virtual Response GetAdviserDetail(IEnumerable<string> filter = null, IEnumerable<string> sort = null, object page = null, IEnumerable<string> include = null, RequestContext context = null)
        {
            using var scope = ClientDiagnostics.CreateScope("AdviserDetailsClient.GetAdviserDetail");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetAdviserDetailRequest(filter, sort, page, include, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        internal HttpMessage CreateGetAdviserDetailRequest(IEnumerable<string> filter, IEnumerable<string> sort, object page, IEnumerable<string> include, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200401);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/jsonapi/adviser-details", false);
            if (filter != null)
            {
                uri.AppendQueryDelimited("filter", filter, ",", false);
            }
            if (sort != null)
            {
                uri.AppendQueryDelimited("sort", sort, ",", false);
            }
            if (page != null)
            {
                uri.AppendQuery("page", page, true);
            }
            if (include != null)
            {
                uri.AppendQueryDelimited("include", include, ",", true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/vnd.api+json");
            return message;
        }

        private static ResponseClassifier _responseClassifier200401;
        private static ResponseClassifier ResponseClassifier200401 => _responseClassifier200401 ??= new StatusCodeClassifier(stackalloc ushort[] { 200, 401 });
    }
}
