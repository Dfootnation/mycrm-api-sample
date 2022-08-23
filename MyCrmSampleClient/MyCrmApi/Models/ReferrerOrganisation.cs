// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace MyCrmSampleClient.MyCrmApi.Models
{
    /// <summary> The ReferrerOrganisation. </summary>
    public partial class ReferrerOrganisation : IncludedResource
    {
        /// <summary> Initializes a new instance of ReferrerOrganisation. </summary>
        public ReferrerOrganisation()
        {
            Meta = new ChangeTrackingDictionary<string, object>();
            Type = "referrer-organisation";
        }

        /// <summary> Initializes a new instance of ReferrerOrganisation. </summary>
        /// <param name="type"></param>
        /// <param name="id"></param>
        /// <param name="attributes"></param>
        /// <param name="relationships"></param>
        /// <param name="links"></param>
        /// <param name="meta"> Dictionary of &lt;any&gt;. </param>
        internal ReferrerOrganisation(string type, string id, ReferrerOrganisationAttributes attributes, ReferrerOrganisationRelationships relationships, ReferrerOrganisationLinks links, IReadOnlyDictionary<string, object> meta) : base(type, id)
        {
            Attributes = attributes;
            Relationships = relationships;
            Links = links;
            Meta = meta;
            Type = type ?? "referrer-organisation";
        }

        /// <summary> Gets or sets the attributes. </summary>
        public ReferrerOrganisationAttributes Attributes { get; set; }
        /// <summary> Gets or sets the relationships. </summary>
        public ReferrerOrganisationRelationships Relationships { get; set; }
        /// <summary> Gets the links. </summary>
        public ReferrerOrganisationLinks Links { get; }
        /// <summary> Dictionary of &lt;any&gt;. </summary>
        public IReadOnlyDictionary<string, object> Meta { get; }
    }
}