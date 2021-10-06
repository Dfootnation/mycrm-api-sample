// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using MyCrmSampleClient.MyCrmApi.Models;

namespace MyCrmSampleClient.MyCrmApi
{
    /// <summary> The ContactGroupRelationship service client. </summary>
    public partial class ContactGroupRelationshipClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal ContactGroupRelationshipRestClient RestClient { get; }

        /// <summary> Initializes a new instance of ContactGroupRelationshipClient for mocking. </summary>
        protected ContactGroupRelationshipClient()
        {
        }

        /// <summary> Initializes a new instance of ContactGroupRelationshipClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        internal ContactGroupRelationshipClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null)
        {
            RestClient = new ContactGroupRelationshipRestClient(clientDiagnostics, pipeline, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Where `id` is the identifier of the contact group. </summary>
        /// <param name="id"> The Integer to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<RelationshipsMultipleDocument>> GetContactsAsync(int id, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ContactGroupRelationshipClient.GetContacts");
            scope.Start();
            try
            {
                return await RestClient.GetContactsAsync(id, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Where `id` is the identifier of the contact group. </summary>
        /// <param name="id"> The Integer to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<RelationshipsMultipleDocument> GetContacts(int id, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ContactGroupRelationshipClient.GetContacts");
            scope.Start();
            try
            {
                return RestClient.GetContacts(id, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Where `id` is the identifier of the primary contact group resource. </summary>
        /// <param name="id"> The Integer to use. </param>
        /// <param name="body"> The RelationshipsMultipleDocument to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> PostContactsAsync(int id, RelationshipsMultipleDocument body = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ContactGroupRelationshipClient.PostContacts");
            scope.Start();
            try
            {
                return await RestClient.PostContactsAsync(id, body, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Where `id` is the identifier of the primary contact group resource. </summary>
        /// <param name="id"> The Integer to use. </param>
        /// <param name="body"> The RelationshipsMultipleDocument to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response PostContacts(int id, RelationshipsMultipleDocument body = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ContactGroupRelationshipClient.PostContacts");
            scope.Start();
            try
            {
                return RestClient.PostContacts(id, body, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Where `id` is the identifier of the contact group. </summary>
        /// <param name="id"> The Integer to use. </param>
        /// <param name="body"> The RelationshipsMultipleDocument to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> PatchContactsAsync(int id, RelationshipsMultipleDocument body = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ContactGroupRelationshipClient.PatchContacts");
            scope.Start();
            try
            {
                return await RestClient.PatchContactsAsync(id, body, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Where `id` is the identifier of the contact group. </summary>
        /// <param name="id"> The Integer to use. </param>
        /// <param name="body"> The RelationshipsMultipleDocument to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response PatchContacts(int id, RelationshipsMultipleDocument body = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ContactGroupRelationshipClient.PatchContacts");
            scope.Start();
            try
            {
                return RestClient.PatchContacts(id, body, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Where `id` is the identifier of the contact group. </summary>
        /// <param name="id"> The Integer to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> DeleteContactsAsync(int id, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ContactGroupRelationshipClient.DeleteContacts");
            scope.Start();
            try
            {
                return await RestClient.DeleteContactsAsync(id, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Where `id` is the identifier of the contact group. </summary>
        /// <param name="id"> The Integer to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response DeleteContacts(int id, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ContactGroupRelationshipClient.DeleteContacts");
            scope.Start();
            try
            {
                return RestClient.DeleteContacts(id, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Where `id` is the identifier of the contact group. </summary>
        /// <param name="id"> The Integer to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<RelationshipsSingleDocument>> GetAdvisersAsync(int id, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ContactGroupRelationshipClient.GetAdvisers");
            scope.Start();
            try
            {
                return await RestClient.GetAdvisersAsync(id, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Where `id` is the identifier of the contact group. </summary>
        /// <param name="id"> The Integer to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<RelationshipsSingleDocument> GetAdvisers(int id, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ContactGroupRelationshipClient.GetAdvisers");
            scope.Start();
            try
            {
                return RestClient.GetAdvisers(id, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Where `id` is the identifier of the primary contact group resource. </summary>
        /// <param name="id"> The Integer to use. </param>
        /// <param name="body"> The RelationshipsSingleDocument to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> PostAdvisersAsync(int id, RelationshipsSingleDocument body = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ContactGroupRelationshipClient.PostAdvisers");
            scope.Start();
            try
            {
                return await RestClient.PostAdvisersAsync(id, body, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Where `id` is the identifier of the primary contact group resource. </summary>
        /// <param name="id"> The Integer to use. </param>
        /// <param name="body"> The RelationshipsSingleDocument to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response PostAdvisers(int id, RelationshipsSingleDocument body = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ContactGroupRelationshipClient.PostAdvisers");
            scope.Start();
            try
            {
                return RestClient.PostAdvisers(id, body, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Where `id` is the identifier of the contact group. </summary>
        /// <param name="id"> The Integer to use. </param>
        /// <param name="body"> The RelationshipsSingleDocument to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> PatchAdvisersAsync(int id, RelationshipsSingleDocument body = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ContactGroupRelationshipClient.PatchAdvisers");
            scope.Start();
            try
            {
                return await RestClient.PatchAdvisersAsync(id, body, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Where `id` is the identifier of the contact group. </summary>
        /// <param name="id"> The Integer to use. </param>
        /// <param name="body"> The RelationshipsSingleDocument to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response PatchAdvisers(int id, RelationshipsSingleDocument body = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ContactGroupRelationshipClient.PatchAdvisers");
            scope.Start();
            try
            {
                return RestClient.PatchAdvisers(id, body, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Where `id` is the identifier of the contact group. </summary>
        /// <param name="id"> The Integer to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> DeleteAdvisersAsync(int id, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ContactGroupRelationshipClient.DeleteAdvisers");
            scope.Start();
            try
            {
                return await RestClient.DeleteAdvisersAsync(id, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Where `id` is the identifier of the contact group. </summary>
        /// <param name="id"> The Integer to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response DeleteAdvisers(int id, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ContactGroupRelationshipClient.DeleteAdvisers");
            scope.Start();
            try
            {
                return RestClient.DeleteAdvisers(id, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Where `id` is the identifier of the contact group. </summary>
        /// <param name="id"> The Integer to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<RelationshipsSingleDocument>> GetReferrerOrganisationsAsync(int id, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ContactGroupRelationshipClient.GetReferrerOrganisations");
            scope.Start();
            try
            {
                return await RestClient.GetReferrerOrganisationsAsync(id, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Where `id` is the identifier of the contact group. </summary>
        /// <param name="id"> The Integer to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<RelationshipsSingleDocument> GetReferrerOrganisations(int id, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ContactGroupRelationshipClient.GetReferrerOrganisations");
            scope.Start();
            try
            {
                return RestClient.GetReferrerOrganisations(id, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Where `id` is the identifier of the primary contact group resource. </summary>
        /// <param name="id"> The Integer to use. </param>
        /// <param name="body"> The RelationshipsSingleDocument to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> PostReferrerOrganisationsAsync(int id, RelationshipsSingleDocument body = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ContactGroupRelationshipClient.PostReferrerOrganisations");
            scope.Start();
            try
            {
                return await RestClient.PostReferrerOrganisationsAsync(id, body, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Where `id` is the identifier of the primary contact group resource. </summary>
        /// <param name="id"> The Integer to use. </param>
        /// <param name="body"> The RelationshipsSingleDocument to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response PostReferrerOrganisations(int id, RelationshipsSingleDocument body = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ContactGroupRelationshipClient.PostReferrerOrganisations");
            scope.Start();
            try
            {
                return RestClient.PostReferrerOrganisations(id, body, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Where `id` is the identifier of the contact group. </summary>
        /// <param name="id"> The Integer to use. </param>
        /// <param name="body"> The RelationshipsSingleDocument to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> PatchReferrerOrganisationsAsync(int id, RelationshipsSingleDocument body = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ContactGroupRelationshipClient.PatchReferrerOrganisations");
            scope.Start();
            try
            {
                return await RestClient.PatchReferrerOrganisationsAsync(id, body, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Where `id` is the identifier of the contact group. </summary>
        /// <param name="id"> The Integer to use. </param>
        /// <param name="body"> The RelationshipsSingleDocument to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response PatchReferrerOrganisations(int id, RelationshipsSingleDocument body = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ContactGroupRelationshipClient.PatchReferrerOrganisations");
            scope.Start();
            try
            {
                return RestClient.PatchReferrerOrganisations(id, body, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Where `id` is the identifier of the contact group. </summary>
        /// <param name="id"> The Integer to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> DeleteReferrerOrganisationsAsync(int id, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ContactGroupRelationshipClient.DeleteReferrerOrganisations");
            scope.Start();
            try
            {
                return await RestClient.DeleteReferrerOrganisationsAsync(id, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Where `id` is the identifier of the contact group. </summary>
        /// <param name="id"> The Integer to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response DeleteReferrerOrganisations(int id, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ContactGroupRelationshipClient.DeleteReferrerOrganisations");
            scope.Start();
            try
            {
                return RestClient.DeleteReferrerOrganisations(id, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Where `id` is the identifier of the contact group. </summary>
        /// <param name="id"> The Integer to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<RelationshipsSingleDocument>> GetReferrersAsync(int id, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ContactGroupRelationshipClient.GetReferrers");
            scope.Start();
            try
            {
                return await RestClient.GetReferrersAsync(id, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Where `id` is the identifier of the contact group. </summary>
        /// <param name="id"> The Integer to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<RelationshipsSingleDocument> GetReferrers(int id, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ContactGroupRelationshipClient.GetReferrers");
            scope.Start();
            try
            {
                return RestClient.GetReferrers(id, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Where `id` is the identifier of the primary contact group resource. </summary>
        /// <param name="id"> The Integer to use. </param>
        /// <param name="body"> The RelationshipsSingleDocument to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> PostReferrersAsync(int id, RelationshipsSingleDocument body = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ContactGroupRelationshipClient.PostReferrers");
            scope.Start();
            try
            {
                return await RestClient.PostReferrersAsync(id, body, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Where `id` is the identifier of the primary contact group resource. </summary>
        /// <param name="id"> The Integer to use. </param>
        /// <param name="body"> The RelationshipsSingleDocument to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response PostReferrers(int id, RelationshipsSingleDocument body = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ContactGroupRelationshipClient.PostReferrers");
            scope.Start();
            try
            {
                return RestClient.PostReferrers(id, body, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Where `id` is the identifier of the contact group. </summary>
        /// <param name="id"> The Integer to use. </param>
        /// <param name="body"> The RelationshipsSingleDocument to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> PatchReferrersAsync(int id, RelationshipsSingleDocument body = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ContactGroupRelationshipClient.PatchReferrers");
            scope.Start();
            try
            {
                return await RestClient.PatchReferrersAsync(id, body, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Where `id` is the identifier of the contact group. </summary>
        /// <param name="id"> The Integer to use. </param>
        /// <param name="body"> The RelationshipsSingleDocument to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response PatchReferrers(int id, RelationshipsSingleDocument body = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ContactGroupRelationshipClient.PatchReferrers");
            scope.Start();
            try
            {
                return RestClient.PatchReferrers(id, body, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Where `id` is the identifier of the contact group. </summary>
        /// <param name="id"> The Integer to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> DeleteReferrersAsync(int id, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ContactGroupRelationshipClient.DeleteReferrers");
            scope.Start();
            try
            {
                return await RestClient.DeleteReferrersAsync(id, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Where `id` is the identifier of the contact group. </summary>
        /// <param name="id"> The Integer to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response DeleteReferrers(int id, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ContactGroupRelationshipClient.DeleteReferrers");
            scope.Start();
            try
            {
                return RestClient.DeleteReferrers(id, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}