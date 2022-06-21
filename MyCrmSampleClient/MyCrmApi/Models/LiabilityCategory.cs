// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace MyCrmSampleClient.MyCrmApi.Models
{
    /// <summary> The LiabilityCategory. </summary>
    public partial class LiabilityCategory : IncludedResource
    {
        /// <summary> Initializes a new instance of LiabilityCategory. </summary>
        public LiabilityCategory()
        {
            Meta = new ChangeTrackingDictionary<string, object>();
            Type = "liability-categories";
        }

        /// <summary> Initializes a new instance of LiabilityCategory. </summary>
        /// <param name="type"></param>
        /// <param name="id"></param>
        /// <param name="attributes"></param>
        /// <param name="relationships"></param>
        /// <param name="links"></param>
        /// <param name="meta"> Dictionary of &lt;any&gt;. </param>
        internal LiabilityCategory(string type, string id, LiabilityCategoryAttributes attributes, LiabilityCategoryRelationships relationships, LiabilityCategoryLinks links, IReadOnlyDictionary<string, object> meta) : base(type, id)
        {
            Attributes = attributes;
            Relationships = relationships;
            Links = links;
            Meta = meta;
            Type = type ?? "liability-categories";
        }

        /// <summary> Gets or sets the attributes. </summary>
        public LiabilityCategoryAttributes Attributes { get; set; }
        /// <summary> Gets or sets the relationships. </summary>
        public LiabilityCategoryRelationships Relationships { get; set; }
        /// <summary> Gets the links. </summary>
        public LiabilityCategoryLinks Links { get; }
        /// <summary> Dictionary of &lt;any&gt;. </summary>
        public IReadOnlyDictionary<string, object> Meta { get; }
    }
}
