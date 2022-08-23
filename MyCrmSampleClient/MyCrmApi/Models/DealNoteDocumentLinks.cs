// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace MyCrmSampleClient.MyCrmApi.Models
{
    /// <summary> The DealNoteDocumentLinks. </summary>
    public partial class DealNoteDocumentLinks : TopLevelLinks
    {
        /// <summary> Initializes a new instance of DealNoteDocumentLinks. </summary>
        internal DealNoteDocumentLinks()
        {
        }

        /// <summary> Initializes a new instance of DealNoteDocumentLinks. </summary>
        /// <param name="self"></param>
        /// <param name="related"></param>
        /// <param name="describedby"></param>
        /// <param name="first"></param>
        /// <param name="last"></param>
        /// <param name="prev"></param>
        /// <param name="next"></param>
        internal DealNoteDocumentLinks(string self, string related, string describedby, string first, string last, string prev, string next) : base(self, related, describedby, first, last, prev, next)
        {
        }
    }
}