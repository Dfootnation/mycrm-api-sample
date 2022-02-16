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

namespace MyCrmSampleClient.MyCrmApi
{
    internal partial class AssetTypeRelatedRestClient
    {
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> Initializes a new instance of AssetTypeRelatedRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        public AssetTypeRelatedRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null)
        {
            _endpoint = endpoint ?? new Uri("");
            ClientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateGetRequest(int id, string relationshipName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/jsonapi/asset-types/", false);
            uri.AppendPath(id, true);
            uri.AppendPath("/", false);
            uri.AppendPath(relationshipName, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/vnd.api+json");
            return message;
        }

        /// <summary> Where `id` is the identifier of the asset type. </summary>
        /// <param name="id"> The Integer to use. </param>
        /// <param name="relationshipName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="relationshipName"/> is null. </exception>
        public async Task<Response> GetAsync(int id, string relationshipName, CancellationToken cancellationToken = default)
        {
            if (relationshipName == null)
            {
                throw new ArgumentNullException(nameof(relationshipName));
            }

            using var message = CreateGetRequest(id, relationshipName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 401:
                    return message.Response;
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Where `id` is the identifier of the asset type. </summary>
        /// <param name="id"> The Integer to use. </param>
        /// <param name="relationshipName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="relationshipName"/> is null. </exception>
        public Response Get(int id, string relationshipName, CancellationToken cancellationToken = default)
        {
            if (relationshipName == null)
            {
                throw new ArgumentNullException(nameof(relationshipName));
            }

            using var message = CreateGetRequest(id, relationshipName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 401:
                    return message.Response;
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
