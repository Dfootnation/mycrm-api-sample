// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace MyCrmSampleClient.MyCrmApi.Models
{
    /// <summary> The ExpenseRelationships. </summary>
    public partial class ExpenseRelationships
    {
        /// <summary> Initializes a new instance of ExpenseRelationships. </summary>
        public ExpenseRelationships()
        {
        }

        /// <summary> Initializes a new instance of ExpenseRelationships. </summary>
        /// <param name="ownership"></param>
        internal ExpenseRelationships(RelationshipsMultipleDocument ownership)
        {
            Ownership = ownership;
        }

        /// <summary> Gets or sets the ownership. </summary>
        public RelationshipsMultipleDocument Ownership { get; set; }
    }
}