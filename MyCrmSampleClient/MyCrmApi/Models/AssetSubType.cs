// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace MyCrmSampleClient.MyCrmApi.Models
{
    /// <summary> The AssetSubType. </summary>
    public partial class AssetSubType : IncludedResource
    {
        /// <summary> Initializes a new instance of AssetSubType. </summary>
        public AssetSubType()
        {
            Meta = new ChangeTrackingDictionary<string, object>();
            Type = "asset-sub-types";
        }

        /// <summary> Initializes a new instance of AssetSubType. </summary>
        /// <param name="type"></param>
        /// <param name="id"></param>
        /// <param name="attributes"></param>
        /// <param name="relationships"> Any object. </param>
        /// <param name="links"></param>
        /// <param name="meta"> Dictionary of &lt;any&gt;. </param>
        internal AssetSubType(string type, string id, AssetSubTypeAttributes attributes, object relationships, AssetSubTypeLinks links, IReadOnlyDictionary<string, object> meta) : base(type, id)
        {
            Attributes = attributes;
            Relationships = relationships;
            Links = links;
            Meta = meta;
            Type = type ?? "asset-sub-types";
        }

        /// <summary> Gets or sets the attributes. </summary>
        public AssetSubTypeAttributes Attributes { get; set; }
        /// <summary> Any object. </summary>
        public object Relationships { get; set; }
        /// <summary> Gets the links. </summary>
        public AssetSubTypeLinks Links { get; }
        /// <summary> Dictionary of &lt;any&gt;. </summary>
        public IReadOnlyDictionary<string, object> Meta { get; }
    }
}
