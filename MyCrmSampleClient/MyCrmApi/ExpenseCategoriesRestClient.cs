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
using MyCrmSampleClient.MyCrmApi.Models;

namespace MyCrmSampleClient.MyCrmApi
{
    internal partial class ExpenseCategoriesRestClient
    {
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> Initializes a new instance of ExpenseCategoriesRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/> or <paramref name="pipeline"/> is null. </exception>
        public ExpenseCategoriesRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null)
        {
            ClientDiagnostics = clientDiagnostics ?? throw new ArgumentNullException(nameof(clientDiagnostics));
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("");
        }

        internal HttpMessage CreateGetRequest(IEnumerable<string> filter, IEnumerable<string> sort, Pagination page, IEnumerable<string> include)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/jsonapi/expense-categories", false);
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

        /// <summary> Gets a collection of expense categories. </summary>
        /// <param name="filter"> The ArrayOfString to use. </param>
        /// <param name="sort"> The ArrayOfString to use. </param>
        /// <param name="page"> The Pagination to use. </param>
        /// <param name="include"> The ArrayOfString to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<ExpenseCategoriesDocument>> GetAsync(IEnumerable<string> filter = null, IEnumerable<string> sort = null, Pagination page = null, IEnumerable<string> include = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateGetRequest(filter, sort, page, include);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ExpenseCategoriesDocument value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ExpenseCategoriesDocument.DeserializeExpenseCategoriesDocument(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 401:
                    return Response.FromValue((ExpenseCategoriesDocument)null, message.Response);
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets a collection of expense categories. </summary>
        /// <param name="filter"> The ArrayOfString to use. </param>
        /// <param name="sort"> The ArrayOfString to use. </param>
        /// <param name="page"> The Pagination to use. </param>
        /// <param name="include"> The ArrayOfString to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<ExpenseCategoriesDocument> Get(IEnumerable<string> filter = null, IEnumerable<string> sort = null, Pagination page = null, IEnumerable<string> include = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateGetRequest(filter, sort, page, include);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ExpenseCategoriesDocument value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ExpenseCategoriesDocument.DeserializeExpenseCategoriesDocument(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 401:
                    return Response.FromValue((ExpenseCategoriesDocument)null, message.Response);
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
