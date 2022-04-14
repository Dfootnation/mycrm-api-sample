// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace MyCrmSampleClient.MyCrmApi.Models
{
    /// <summary> The LeadIncome. </summary>
    public partial class LeadIncome
    {
        /// <summary> Initializes a new instance of LeadIncome. </summary>
        public LeadIncome()
        {
            Ownership = new ChangeTrackingList<LeadContactReference>();
        }

        /// <summary> Initializes a new instance of LeadIncome. </summary>
        /// <param name="lid"></param>
        /// <param name="incomeTypeId"></param>
        /// <param name="description"></param>
        /// <param name="value"></param>
        /// <param name="frequency"></param>
        /// <param name="incomeVerification"></param>
        /// <param name="ownership"></param>
        /// <param name="asset"></param>
        /// <param name="employment"></param>
        internal LeadIncome(string lid, int? incomeTypeId, string description, double? value, Frequency? frequency, IncomeVerificationEnum? incomeVerification, IList<LeadContactReference> ownership, LeadAssetReference asset, LeadEmploymentReference employment)
        {
            Lid = lid;
            IncomeTypeId = incomeTypeId;
            Description = description;
            Value = value;
            Frequency = frequency;
            IncomeVerification = incomeVerification;
            Ownership = ownership;
            Asset = asset;
            Employment = employment;
        }

        /// <summary> Gets or sets the lid. </summary>
        public string Lid { get; set; }
        /// <summary> Gets or sets the income type id. </summary>
        public int? IncomeTypeId { get; set; }
        /// <summary> Gets or sets the description. </summary>
        public string Description { get; set; }
        /// <summary> Gets or sets the value. </summary>
        public double? Value { get; set; }
        /// <summary> Gets or sets the frequency. </summary>
        public Frequency? Frequency { get; set; }
        /// <summary> Gets or sets the income verification. </summary>
        public IncomeVerificationEnum? IncomeVerification { get; set; }
        /// <summary> Gets or sets the ownership. </summary>
        public IList<LeadContactReference> Ownership { get; set; }
        /// <summary> Gets or sets the asset. </summary>
        public LeadAssetReference Asset { get; set; }
        /// <summary> Gets or sets the employment. </summary>
        public LeadEmploymentReference Employment { get; set; }
    }
}