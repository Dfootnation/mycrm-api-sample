// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace MyCrmSampleClient.MyCrmApi.Models
{
    /// <summary> The ContactAddressDocumentLinks. </summary>
    public partial class ContactAddressDocumentLinks : TopLevelLinks
    {
        /// <summary> Initializes a new instance of ContactAddressDocumentLinks. </summary>
        internal ContactAddressDocumentLinks()
        {
        }

        /// <summary> Initializes a new instance of ContactAddressDocumentLinks. </summary>
        /// <param name="self"></param>
        /// <param name="related"></param>
        /// <param name="describedBy"></param>
        /// <param name="first"></param>
        /// <param name="last"></param>
        /// <param name="prev"></param>
        /// <param name="next"></param>
        internal ContactAddressDocumentLinks(string self, string related, string describedBy, string first, string last, string prev, string next) : base(self, related, describedBy, first, last, prev, next)
        {
        }
    }
}