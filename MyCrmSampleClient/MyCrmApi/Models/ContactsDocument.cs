// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace MyCrmSampleClient.MyCrmApi.Models
{
    /// <summary> The ContactsDocument. </summary>
    public partial class ContactsDocument
    {
        /// <summary> Initializes a new instance of ContactsDocument. </summary>
        /// <param name="data"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        internal ContactsDocument(IEnumerable<Contact> data)
        {
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            Meta = new ChangeTrackingDictionary<string, object>();
            JsonApi = new ChangeTrackingDictionary<string, object>();
            Data = data.ToList();
            Included = new ChangeTrackingList<IncludedResource>();
        }

        /// <summary> Initializes a new instance of ContactsDocument. </summary>
        /// <param name="meta"> Dictionary of &lt;any&gt;. </param>
        /// <param name="jsonApi"> Dictionary of &lt;any&gt;. </param>
        /// <param name="links"></param>
        /// <param name="data"></param>
        /// <param name="included"></param>
        internal ContactsDocument(IReadOnlyDictionary<string, object> meta, IReadOnlyDictionary<string, object> jsonApi, ContactsDocumentLinks links, IReadOnlyList<Contact> data, IReadOnlyList<IncludedResource> included)
        {
            Meta = meta;
            JsonApi = jsonApi;
            Links = links;
            Data = data;
            Included = included;
        }

        /// <summary> Dictionary of &lt;any&gt;. </summary>
        public IReadOnlyDictionary<string, object> Meta { get; }
        /// <summary> Dictionary of &lt;any&gt;. </summary>
        public IReadOnlyDictionary<string, object> JsonApi { get; }
        /// <summary> Gets the links. </summary>
        public ContactsDocumentLinks Links { get; }
        /// <summary> Gets the data. </summary>
        public IReadOnlyList<Contact> Data { get; }
        /// <summary> Gets the included. </summary>
        public IReadOnlyList<IncludedResource> Included { get; }
    }
}
