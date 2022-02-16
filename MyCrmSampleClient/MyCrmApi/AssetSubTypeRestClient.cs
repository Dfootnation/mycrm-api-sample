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
using MyCrmSampleClient.MyCrmApi.Models;

namespace MyCrmSampleClient.MyCrmApi
{
    internal partial class AssetSubTypeRestClient
    {
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> Initializes a new instance of AssetSubTypeRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        public AssetSubTypeRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null)
        {
            _endpoint = endpoint ?? new Uri("");
            ClientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateGetRequest(int id)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/jsonapi/asset-sub-types/", false);
            uri.AppendPath(id, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/vnd.api+json");
            return message;
        }

        /// <summary> Where `id` is the identifier of the asset sub-type. </summary>
        /// <param name="id"> The Integer to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<AssetSubTypeDocument>> GetAsync(int id, CancellationToken cancellationToken = default)
        {
            using var message = CreateGetRequest(id);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AssetSubTypeDocument value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = AssetSubTypeDocument.DeserializeAssetSubTypeDocument(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 401:
                    return Response.FromValue((AssetSubTypeDocument)null, message.Response);
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Where `id` is the identifier of the asset sub-type. </summary>
        /// <param name="id"> The Integer to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<AssetSubTypeDocument> Get(int id, CancellationToken cancellationToken = default)
        {
            using var message = CreateGetRequest(id);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AssetSubTypeDocument value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = AssetSubTypeDocument.DeserializeAssetSubTypeDocument(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 401:
                    return Response.FromValue((AssetSubTypeDocument)null, message.Response);
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
