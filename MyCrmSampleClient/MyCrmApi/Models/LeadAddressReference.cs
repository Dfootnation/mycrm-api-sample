// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace MyCrmSampleClient.MyCrmApi.Models
{
    /// <summary> The LeadAddressReference. </summary>
    public partial class LeadAddressReference
    {
        /// <summary> Initializes a new instance of LeadAddressReference. </summary>
        /// <param name="lid"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="lid"/> is null. </exception>
        public LeadAddressReference(string lid)
        {
            if (lid == null)
            {
                throw new ArgumentNullException(nameof(lid));
            }

            Lid = lid;
        }

        /// <summary> Gets or sets the lid. </summary>
        public string Lid { get; set; }
    }
}