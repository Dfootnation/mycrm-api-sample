// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace MyCrmSampleClient.MyCrmApi.Models
{
    /// <summary> The ApiAddressClientEntity. </summary>
    internal partial class ApiAddressClientEntity
    {
        /// <summary> Initializes a new instance of ApiAddressClientEntity. </summary>
        /// <param name="id"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        internal ApiAddressClientEntity(string id)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            Id = id;
        }

        /// <summary> Gets the id. </summary>
        public string Id { get; }
        /// <summary> Gets the contact. </summary>
        public Contact Contact { get; }
        /// <summary> Gets the address details. </summary>
        public ContactAddress AddressDetails { get; }
    }
}