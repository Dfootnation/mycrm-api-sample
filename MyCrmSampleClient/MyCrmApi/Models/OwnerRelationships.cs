// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace MyCrmSampleClient.MyCrmApi.Models
{
    /// <summary> The OwnerRelationships. </summary>
    public partial class OwnerRelationships
    {
        /// <summary> Initializes a new instance of OwnerRelationships. </summary>
        public OwnerRelationships()
        {
        }

        /// <summary> Initializes a new instance of OwnerRelationships. </summary>
        /// <param name="contact"></param>
        /// <param name="business"></param>
        /// <param name="financial"></param>
        /// <param name="asset"></param>
        /// <param name="expense"></param>
        /// <param name="liability"></param>
        /// <param name="income"></param>
        internal OwnerRelationships(RelationshipsSingleDocument contact, RelationshipsSingleDocument business, RelationshipsSingleDocument financial, RelationshipsSingleDocument asset, RelationshipsSingleDocument expense, RelationshipsSingleDocument liability, RelationshipsSingleDocument income)
        {
            Contact = contact;
            Business = business;
            Financial = financial;
            Asset = asset;
            Expense = expense;
            Liability = liability;
            Income = income;
        }

        /// <summary> Gets or sets the contact. </summary>
        public RelationshipsSingleDocument Contact { get; set; }
        /// <summary> Gets or sets the business. </summary>
        public RelationshipsSingleDocument Business { get; set; }
        /// <summary> Gets or sets the financial. </summary>
        public RelationshipsSingleDocument Financial { get; set; }
        /// <summary> Gets or sets the asset. </summary>
        public RelationshipsSingleDocument Asset { get; set; }
        /// <summary> Gets or sets the expense. </summary>
        public RelationshipsSingleDocument Expense { get; set; }
        /// <summary> Gets or sets the liability. </summary>
        public RelationshipsSingleDocument Liability { get; set; }
        /// <summary> Gets or sets the income. </summary>
        public RelationshipsSingleDocument Income { get; set; }
    }
}
