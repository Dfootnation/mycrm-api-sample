// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace MyCrmSampleClient.MyCrmApi.Models
{
    /// <summary> The ApiAdviserProfile. </summary>
    internal partial class ApiAdviserProfile
    {
        /// <summary> Initializes a new instance of ApiAdviserProfile. </summary>
        /// <param name="id"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        internal ApiAdviserProfile(string id)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            Id = id;
        }

        /// <summary> Gets the id. </summary>
        public string Id { get; }
        /// <summary> Gets the job title. </summary>
        public string JobTitle { get; }
        /// <summary> Gets the bio. </summary>
        public string Bio { get; }
        /// <summary> Gets the adviser. </summary>
        public Adviser Adviser { get; }
    }
}