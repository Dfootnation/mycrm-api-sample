// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;

namespace MyCrmSampleClient.MyCrmApi
{
    /// <summary> The ContactGroupReferrerRelationship service client. </summary>
    public partial class ContactGroupReferrerRelationshipClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal ContactGroupReferrerRelationshipRestClient RestClient { get; }

        /// <summary> Initializes a new instance of ContactGroupReferrerRelationshipClient for mocking. </summary>
        protected ContactGroupReferrerRelationshipClient()
        {
        }

        /// <summary> Initializes a new instance of ContactGroupReferrerRelationshipClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        internal ContactGroupReferrerRelationshipClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null)
        {
            RestClient = new ContactGroupReferrerRelationshipRestClient(clientDiagnostics, pipeline, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Where `id` is the identifier of the referrer. </summary>
        /// <param name="id"> The Integer to use. </param>
        /// <param name="relationshipName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> GetAsync(int id, string relationshipName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ContactGroupReferrerRelationshipClient.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(id, relationshipName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Where `id` is the identifier of the referrer. </summary>
        /// <param name="id"> The Integer to use. </param>
        /// <param name="relationshipName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Get(int id, string relationshipName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ContactGroupReferrerRelationshipClient.Get");
            scope.Start();
            try
            {
                return RestClient.Get(id, relationshipName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Where `id` is the identifier of the primary referrer resource. </summary>
        /// <param name="id"> The Integer to use. </param>
        /// <param name="relationshipName"> The String to use. </param>
        /// <param name="body"> The any to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> PostAsync(int id, string relationshipName, object body = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ContactGroupReferrerRelationshipClient.Post");
            scope.Start();
            try
            {
                return await RestClient.PostAsync(id, relationshipName, body, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Where `id` is the identifier of the primary referrer resource. </summary>
        /// <param name="id"> The Integer to use. </param>
        /// <param name="relationshipName"> The String to use. </param>
        /// <param name="body"> The any to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Post(int id, string relationshipName, object body = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ContactGroupReferrerRelationshipClient.Post");
            scope.Start();
            try
            {
                return RestClient.Post(id, relationshipName, body, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Where `id` is the identifier of the referrer. </summary>
        /// <param name="id"> The Integer to use. </param>
        /// <param name="relationshipName"> The String to use. </param>
        /// <param name="body"> The any to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> PatchAsync(int id, string relationshipName, object body = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ContactGroupReferrerRelationshipClient.Patch");
            scope.Start();
            try
            {
                return await RestClient.PatchAsync(id, relationshipName, body, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Where `id` is the identifier of the referrer. </summary>
        /// <param name="id"> The Integer to use. </param>
        /// <param name="relationshipName"> The String to use. </param>
        /// <param name="body"> The any to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Patch(int id, string relationshipName, object body = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ContactGroupReferrerRelationshipClient.Patch");
            scope.Start();
            try
            {
                return RestClient.Patch(id, relationshipName, body, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Where `id` is the identifier of the referrer. </summary>
        /// <param name="id"> The Integer to use. </param>
        /// <param name="relationshipName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> DeleteAsync(int id, string relationshipName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ContactGroupReferrerRelationshipClient.Delete");
            scope.Start();
            try
            {
                return await RestClient.DeleteAsync(id, relationshipName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Where `id` is the identifier of the referrer. </summary>
        /// <param name="id"> The Integer to use. </param>
        /// <param name="relationshipName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Delete(int id, string relationshipName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ContactGroupReferrerRelationshipClient.Delete");
            scope.Start();
            try
            {
                return RestClient.Delete(id, relationshipName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}