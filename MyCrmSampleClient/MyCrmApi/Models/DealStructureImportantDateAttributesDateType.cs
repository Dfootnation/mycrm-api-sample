// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace MyCrmSampleClient.MyCrmApi.Models
{
    /// <summary> The DealStructureImportantDateAttributesDateType. </summary>
    public readonly partial struct DealStructureImportantDateAttributesDateType : IEquatable<DealStructureImportantDateAttributesDateType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DealStructureImportantDateAttributesDateType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DealStructureImportantDateAttributesDateType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InterestOnlyValue = "InterestOnly";
        private const string RepaymentHolidayValue = "RepaymentHoliday";

        /// <summary> InterestOnly. </summary>
        public static DealStructureImportantDateAttributesDateType InterestOnly { get; } = new DealStructureImportantDateAttributesDateType(InterestOnlyValue);
        /// <summary> RepaymentHoliday. </summary>
        public static DealStructureImportantDateAttributesDateType RepaymentHoliday { get; } = new DealStructureImportantDateAttributesDateType(RepaymentHolidayValue);
        /// <summary> Determines if two <see cref="DealStructureImportantDateAttributesDateType"/> values are the same. </summary>
        public static bool operator ==(DealStructureImportantDateAttributesDateType left, DealStructureImportantDateAttributesDateType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DealStructureImportantDateAttributesDateType"/> values are not the same. </summary>
        public static bool operator !=(DealStructureImportantDateAttributesDateType left, DealStructureImportantDateAttributesDateType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DealStructureImportantDateAttributesDateType"/>. </summary>
        public static implicit operator DealStructureImportantDateAttributesDateType(string value) => new DealStructureImportantDateAttributesDateType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DealStructureImportantDateAttributesDateType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DealStructureImportantDateAttributesDateType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
