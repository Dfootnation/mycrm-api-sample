// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace MyCrmSampleClient.MyCrmApi.Models
{
    /// <summary> The ResourceObject. </summary>
    internal partial class ResourceObject
    {
        /// <summary> Initializes a new instance of ResourceObject. </summary>
        internal ResourceObject()
        {
            Meta = new ChangeTrackingDictionary<string, object>();
        }

        /// <summary> Gets the id. </summary>
        public string Id { get; }
        /// <summary> Gets the attributes. </summary>
        public ResourceObjectAttributes Attributes { get; }
        /// <summary> Any object. </summary>
        public object Relationships { get; }
        /// <summary> Gets the links. </summary>
        public ResourceObjectLinks Links { get; }
        /// <summary> Dictionary of &lt;any&gt;. </summary>
        public IReadOnlyDictionary<string, object> Meta { get; }
    }
}