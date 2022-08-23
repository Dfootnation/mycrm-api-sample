// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace MyCrmSampleClient.MyCrmApi.Models
{
    /// <summary> The ContactAddressRelationships. </summary>
    public partial class ContactAddressRelationships
    {
        /// <summary> Initializes a new instance of ContactAddressRelationships. </summary>
        public ContactAddressRelationships()
        {
        }

        /// <summary> Initializes a new instance of ContactAddressRelationships. </summary>
        /// <param name="contacts"></param>
        internal ContactAddressRelationships(RelationshipsMultipleDocument contacts)
        {
            Contacts = contacts;
        }

        /// <summary> Gets or sets the contacts. </summary>
        public RelationshipsMultipleDocument Contacts { get; set; }
    }
}