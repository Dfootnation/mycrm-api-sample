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
    internal partial class DealNoteRestClient
    {
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> Initializes a new instance of DealNoteRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/> or <paramref name="pipeline"/> is null. </exception>
        public DealNoteRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null)
        {
            ClientDiagnostics = clientDiagnostics ?? throw new ArgumentNullException(nameof(clientDiagnostics));
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("");
        }

        internal HttpMessage CreatePostRequest(DealNoteDocument body)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/jsonapi/deal-notes", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/vnd.api+json");
            if (body != null)
            {
                request.Headers.Add("Content-Type", "application/vnd.api+json");
                var content = new Utf8JsonRequestContent();
                content.JsonWriter.WriteObjectValue(body);
                request.Content = content;
            }
            return message;
        }

        /// <summary> Creates a new deal note with attributes, relationships or both. </summary>
        /// <param name="body"> The DealNoteDocument to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<ResponseWithHeaders<DealNoteDocument, DealNotePostHeaders>> PostAsync(DealNoteDocument body = null, CancellationToken cancellationToken = default)
        {
            using var message = CreatePostRequest(body);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            var headers = new DealNotePostHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 201:
                    {
                        DealNoteDocument value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = DealNoteDocument.DeserializeDealNoteDocument(document.RootElement);
                        return ResponseWithHeaders.FromValue(value, headers, message.Response);
                    }
                case 401:
                    return ResponseWithHeaders.FromValue((DealNoteDocument)null, headers, message.Response);
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Creates a new deal note with attributes, relationships or both. </summary>
        /// <param name="body"> The DealNoteDocument to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public ResponseWithHeaders<DealNoteDocument, DealNotePostHeaders> Post(DealNoteDocument body = null, CancellationToken cancellationToken = default)
        {
            using var message = CreatePostRequest(body);
            _pipeline.Send(message, cancellationToken);
            var headers = new DealNotePostHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 201:
                    {
                        DealNoteDocument value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = DealNoteDocument.DeserializeDealNoteDocument(document.RootElement);
                        return ResponseWithHeaders.FromValue(value, headers, message.Response);
                    }
                case 401:
                    return ResponseWithHeaders.FromValue((DealNoteDocument)null, headers, message.Response);
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(int id)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/jsonapi/deal-notes/", false);
            uri.AppendPath(id, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/vnd.api+json");
            return message;
        }

        /// <summary> Where `id` is the identifier of the deal note. </summary>
        /// <param name="id"> The Integer to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<DealNoteDocument>> GetAsync(int id, CancellationToken cancellationToken = default)
        {
            using var message = CreateGetRequest(id);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DealNoteDocument value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = DealNoteDocument.DeserializeDealNoteDocument(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 401:
                    return Response.FromValue((DealNoteDocument)null, message.Response);
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Where `id` is the identifier of the deal note. </summary>
        /// <param name="id"> The Integer to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<DealNoteDocument> Get(int id, CancellationToken cancellationToken = default)
        {
            using var message = CreateGetRequest(id);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DealNoteDocument value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = DealNoteDocument.DeserializeDealNoteDocument(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 401:
                    return Response.FromValue((DealNoteDocument)null, message.Response);
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreatePatchRequest(int id, DealNoteDocument body)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Patch;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/jsonapi/deal-notes/", false);
            uri.AppendPath(id, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/vnd.api+json");
            if (body != null)
            {
                request.Headers.Add("Content-Type", "application/vnd.api+json");
                var content = new Utf8JsonRequestContent();
                content.JsonWriter.WriteObjectValue(body);
                request.Content = content;
            }
            return message;
        }

        /// <summary> Where `id` is the identifier of the deal note. </summary>
        /// <param name="id"> The Integer to use. </param>
        /// <param name="body"> The DealNoteDocument to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<DealNoteDocument>> PatchAsync(int id, DealNoteDocument body = null, CancellationToken cancellationToken = default)
        {
            using var message = CreatePatchRequest(id, body);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DealNoteDocument value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = DealNoteDocument.DeserializeDealNoteDocument(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 204:
                case 401:
                    return Response.FromValue((DealNoteDocument)null, message.Response);
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Where `id` is the identifier of the deal note. </summary>
        /// <param name="id"> The Integer to use. </param>
        /// <param name="body"> The DealNoteDocument to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<DealNoteDocument> Patch(int id, DealNoteDocument body = null, CancellationToken cancellationToken = default)
        {
            using var message = CreatePatchRequest(id, body);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DealNoteDocument value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = DealNoteDocument.DeserializeDealNoteDocument(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 204:
                case 401:
                    return Response.FromValue((DealNoteDocument)null, message.Response);
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteRequest(int id)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/jsonapi/deal-notes/", false);
            uri.AppendPath(id, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/vnd.api+json");
            return message;
        }

        /// <summary> Where `id` is the identifier of the deal note. </summary>
        /// <param name="id"> The Integer to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response> DeleteAsync(int id, CancellationToken cancellationToken = default)
        {
            using var message = CreateDeleteRequest(id);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 204:
                case 401:
                    return message.Response;
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Where `id` is the identifier of the deal note. </summary>
        /// <param name="id"> The Integer to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response Delete(int id, CancellationToken cancellationToken = default)
        {
            using var message = CreateDeleteRequest(id);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 204:
                case 401:
                    return message.Response;
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}