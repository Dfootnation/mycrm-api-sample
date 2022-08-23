// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace MyCrmSampleClient.MyCrmApi.Models
{
    /// <summary> The AdviserAddressRelationships. </summary>
    public partial class AdviserAddressRelationships
    {
        /// <summary> Initializes a new instance of AdviserAddressRelationships. </summary>
        public AdviserAddressRelationships()
        {
        }

        /// <summary> Initializes a new instance of AdviserAddressRelationships. </summary>
        /// <param name="adviser"></param>
        internal AdviserAddressRelationships(RelationshipsSingleDocument adviser)
        {
            Adviser = adviser;
        }

        /// <summary> Gets or sets the adviser. </summary>
        public RelationshipsSingleDocument Adviser { get; set; }
    }
}