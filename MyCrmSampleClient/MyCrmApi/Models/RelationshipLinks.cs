// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace MyCrmSampleClient.MyCrmApi.Models
{
    /// <summary> The RelationshipLinks. </summary>
    public partial class RelationshipLinks
    {
        /// <summary> Initializes a new instance of RelationshipLinks. </summary>
        internal RelationshipLinks()
        {
        }

        /// <summary> Initializes a new instance of RelationshipLinks. </summary>
        /// <param name="self"></param>
        /// <param name="related"></param>
        internal RelationshipLinks(string self, string related)
        {
            Self = self;
            Related = related;
        }

        /// <summary> Gets the self. </summary>
        public string Self { get; }
        /// <summary> Gets the related. </summary>
        public string Related { get; }
    }
}