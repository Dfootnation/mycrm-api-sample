// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace MyCrmSampleClient.MyCrmApi.Models
{
    /// <summary> The LiabilityRelationships. </summary>
    public partial class LiabilityRelationships
    {
        /// <summary> Initializes a new instance of LiabilityRelationships. </summary>
        public LiabilityRelationships()
        {
        }

        /// <summary> Initializes a new instance of LiabilityRelationships. </summary>
        /// <param name="linkedAsset"></param>
        /// <param name="ownership"></param>
        /// <param name="financial"></param>
        internal LiabilityRelationships(RelationshipsSingleDocument linkedAsset, RelationshipsMultipleDocument ownership, RelationshipsSingleDocument financial)
        {
            LinkedAsset = linkedAsset;
            Ownership = ownership;
            Financial = financial;
        }

        /// <summary> Gets or sets the linked asset. </summary>
        public RelationshipsSingleDocument LinkedAsset { get; set; }
        /// <summary> Gets or sets the ownership. </summary>
        public RelationshipsMultipleDocument Ownership { get; set; }
        /// <summary> Gets or sets the financial. </summary>
        public RelationshipsSingleDocument Financial { get; set; }
    }
}
