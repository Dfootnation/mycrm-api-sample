// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace MyCrmSampleClient.MyCrmApi.Models
{
    /// <summary> The ExpenseType. </summary>
    public partial class ExpenseType : IncludedResource
    {
        /// <summary> Initializes a new instance of ExpenseType. </summary>
        public ExpenseType()
        {
            Meta = new ChangeTrackingDictionary<string, object>();
            Type = "expense-types";
        }

        /// <summary> Initializes a new instance of ExpenseType. </summary>
        /// <param name="type"></param>
        /// <param name="id"></param>
        /// <param name="attributes"></param>
        /// <param name="relationships"></param>
        /// <param name="links"></param>
        /// <param name="meta"> Dictionary of &lt;any&gt;. </param>
        internal ExpenseType(string type, string id, ExpenseTypeAttributes attributes, ExpenseTypeRelationships relationships, ExpenseTypeLinks links, IReadOnlyDictionary<string, object> meta) : base(type, id)
        {
            Attributes = attributes;
            Relationships = relationships;
            Links = links;
            Meta = meta;
            Type = type ?? "expense-types";
        }

        /// <summary> Gets or sets the attributes. </summary>
        public ExpenseTypeAttributes Attributes { get; set; }
        /// <summary> Gets or sets the relationships. </summary>
        public ExpenseTypeRelationships Relationships { get; set; }
        /// <summary> Gets the links. </summary>
        public ExpenseTypeLinks Links { get; }
        /// <summary> Dictionary of &lt;any&gt;. </summary>
        public IReadOnlyDictionary<string, object> Meta { get; }
    }
}