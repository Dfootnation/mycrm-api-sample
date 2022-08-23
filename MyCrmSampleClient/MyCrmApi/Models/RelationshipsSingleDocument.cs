// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace MyCrmSampleClient.MyCrmApi.Models
{
    /// <summary> The RelationshipsSingleDocument. </summary>
    public partial class RelationshipsSingleDocument
    {
        /// <summary> Initializes a new instance of RelationshipsSingleDocument. </summary>
        /// <param name="data"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public RelationshipsSingleDocument(ResourceIdentifier data)
        {
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            Meta = new ChangeTrackingDictionary<string, object>();
            Data = data;
        }

        /// <summary> Initializes a new instance of RelationshipsSingleDocument. </summary>
        /// <param name="links"></param>
        /// <param name="meta"> Dictionary of &lt;any&gt;. </param>
        /// <param name="data"></param>
        internal RelationshipsSingleDocument(RelationshipsSingleDocumentLinks links, IReadOnlyDictionary<string, object> meta, ResourceIdentifier data)
        {
            Links = links;
            Meta = meta;
            Data = data;
        }

        /// <summary> Gets the links. </summary>
        public RelationshipsSingleDocumentLinks Links { get; }
        /// <summary> Dictionary of &lt;any&gt;. </summary>
        public IReadOnlyDictionary<string, object> Meta { get; }
        /// <summary> Gets or sets the data. </summary>
        public ResourceIdentifier Data { get; set; }
    }
}