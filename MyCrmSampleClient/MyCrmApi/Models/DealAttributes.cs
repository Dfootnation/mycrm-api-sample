// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace MyCrmSampleClient.MyCrmApi.Models
{
    /// <summary> The DealAttributes. </summary>
    public partial class DealAttributes
    {
        /// <summary> Initializes a new instance of DealAttributes. </summary>
        public DealAttributes()
        {
            Splits = new ChangeTrackingList<Split>();
        }

        /// <summary> Initializes a new instance of DealAttributes. </summary>
        /// <param name="updated"></param>
        /// <param name="created"></param>
        /// <param name="dates"></param>
        /// <param name="totalLoanAmount"></param>
        /// <param name="customStatusName"></param>
        /// <param name="dealType"></param>
        /// <param name="name"></param>
        /// <param name="dealStatus"></param>
        /// <param name="opportunity"></param>
        /// <param name="splits"></param>
        /// <param name="lenderName"></param>
        internal DealAttributes(DateTimeOffset? updated, DateTimeOffset? created, ImportantDatesSet dates, double? totalLoanAmount, string customStatusName, DealAttributesDealType? dealType, string name, DealAttributesDealStatus? dealStatus, Opportunity opportunity, IReadOnlyList<Split> splits, string lenderName)
        {
            Updated = updated;
            Created = created;
            Dates = dates;
            TotalLoanAmount = totalLoanAmount;
            CustomStatusName = customStatusName;
            DealType = dealType;
            Name = name;
            DealStatus = dealStatus;
            Opportunity = opportunity;
            Splits = splits;
            LenderName = lenderName;
        }

        /// <summary> Gets the updated. </summary>
        public DateTimeOffset? Updated { get; }
        /// <summary> Gets the created. </summary>
        public DateTimeOffset? Created { get; }
        /// <summary> Gets or sets the dates. </summary>
        public ImportantDatesSet Dates { get; set; }
        /// <summary> Gets the total loan amount. </summary>
        public double? TotalLoanAmount { get; }
        /// <summary> Gets the custom status name. </summary>
        public string CustomStatusName { get; }
        /// <summary> Gets or sets the deal type. </summary>
        public DealAttributesDealType? DealType { get; set; }
        /// <summary> Gets the name. </summary>
        public string Name { get; }
        /// <summary> Gets the deal status. </summary>
        public DealAttributesDealStatus? DealStatus { get; }
        /// <summary> Gets or sets the opportunity. </summary>
        public Opportunity Opportunity { get; set; }
        /// <summary> Gets the splits. </summary>
        public IReadOnlyList<Split> Splits { get; }
        /// <summary> Gets the lender name. </summary>
        public string LenderName { get; }
    }
}
