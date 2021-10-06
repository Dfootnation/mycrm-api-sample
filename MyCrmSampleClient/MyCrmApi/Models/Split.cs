// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace MyCrmSampleClient.MyCrmApi.Models
{
    /// <summary> The Split. </summary>
    public partial class Split
    {
        /// <summary> Initializes a new instance of Split. </summary>
        internal Split()
        {
        }

        /// <summary> Initializes a new instance of Split. </summary>
        /// <param name="loanTermYears"></param>
        /// <param name="rateType"></param>
        /// <param name="loanStructureType"></param>
        /// <param name="amount"></param>
        /// <param name="interestRate"></param>
        /// <param name="rateTypePeriodMonths"></param>
        /// <param name="paymentAmount"></param>
        /// <param name="fixedRateStartDate"></param>
        /// <param name="fixedRateEndDate"></param>
        /// <param name="interestOnlyStartDate"></param>
        /// <param name="interestOnlyEndDate"></param>
        /// <param name="repaymentHolidayStartDate"></param>
        /// <param name="repaymentHolidayEndDate"></param>
        internal Split(double? loanTermYears, string rateType, LoanStructureType? loanStructureType, double? amount, double? interestRate, int? rateTypePeriodMonths, double? paymentAmount, DateTimeOffset? fixedRateStartDate, DateTimeOffset? fixedRateEndDate, DateTimeOffset? interestOnlyStartDate, DateTimeOffset? interestOnlyEndDate, DateTimeOffset? repaymentHolidayStartDate, DateTimeOffset? repaymentHolidayEndDate)
        {
            LoanTermYears = loanTermYears;
            RateType = rateType;
            LoanStructureType = loanStructureType;
            Amount = amount;
            InterestRate = interestRate;
            RateTypePeriodMonths = rateTypePeriodMonths;
            PaymentAmount = paymentAmount;
            FixedRateStartDate = fixedRateStartDate;
            FixedRateEndDate = fixedRateEndDate;
            InterestOnlyStartDate = interestOnlyStartDate;
            InterestOnlyEndDate = interestOnlyEndDate;
            RepaymentHolidayStartDate = repaymentHolidayStartDate;
            RepaymentHolidayEndDate = repaymentHolidayEndDate;
        }

        /// <summary> Gets the loan term years. </summary>
        public double? LoanTermYears { get; }
        /// <summary> Gets the rate type. </summary>
        public string RateType { get; }
        /// <summary> Gets the loan structure type. </summary>
        public LoanStructureType? LoanStructureType { get; }
        /// <summary> Gets the amount. </summary>
        public double? Amount { get; }
        /// <summary> Gets the interest rate. </summary>
        public double? InterestRate { get; }
        /// <summary> Gets the rate type period months. </summary>
        public int? RateTypePeriodMonths { get; }
        /// <summary> Gets the payment amount. </summary>
        public double? PaymentAmount { get; }
        /// <summary> Gets the fixed rate start date. </summary>
        public DateTimeOffset? FixedRateStartDate { get; }
        /// <summary> Gets the fixed rate end date. </summary>
        public DateTimeOffset? FixedRateEndDate { get; }
        /// <summary> Gets the interest only start date. </summary>
        public DateTimeOffset? InterestOnlyStartDate { get; }
        /// <summary> Gets the interest only end date. </summary>
        public DateTimeOffset? InterestOnlyEndDate { get; }
        /// <summary> Gets the repayment holiday start date. </summary>
        public DateTimeOffset? RepaymentHolidayStartDate { get; }
        /// <summary> Gets the repayment holiday end date. </summary>
        public DateTimeOffset? RepaymentHolidayEndDate { get; }
    }
}