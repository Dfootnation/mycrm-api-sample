// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace MyCrmSampleClient.MyCrmApi.Models
{
    /// <summary> The RelationshipsMultipleDocument. </summary>
    public partial class RelationshipsMultipleDocument
    {
        /// <summary> Initializes a new instance of RelationshipsMultipleDocument. </summary>
        /// <param name="data"></param>
        public RelationshipsMultipleDocument(IEnumerable<ResourceIdentifier> data)
        {
            Meta = new ChangeTrackingDictionary<string, object>();
            Data = data?.ToList();
        }

        /// <summary> Initializes a new instance of RelationshipsMultipleDocument. </summary>
        /// <param name="links"></param>
        /// <param name="meta"> Dictionary of &lt;any&gt;. </param>
        /// <param name="data"></param>
        internal RelationshipsMultipleDocument(RelationshipsMultipleDocumentLinks links, IReadOnlyDictionary<string, object> meta, IList<ResourceIdentifier> data)
        {
            Links = links;
            Meta = meta;
            Data = data;
        }

        /// <summary> Gets the links. </summary>
        public RelationshipsMultipleDocumentLinks Links { get; }
        /// <summary> Dictionary of &lt;any&gt;. </summary>
        public IReadOnlyDictionary<string, object> Meta { get; }
        /// <summary> Gets or sets the data. </summary>
        public IList<ResourceIdentifier> Data { get; set; }
    }
}