// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace MyCrmSampleClient.MyCrmApi.Models
{
    /// <summary> The PropertyValueEstimatedBasis. </summary>
    public readonly partial struct PropertyValueEstimatedBasis : IEquatable<PropertyValueEstimatedBasis>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PropertyValueEstimatedBasis"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PropertyValueEstimatedBasis(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ApplicantEstimateValue = "ApplicantEstimate";
        private const string CertifiedValuationValue = "CertifiedValuation";
        private const string ActualValueValue = "ActualValue";

        /// <summary> ApplicantEstimate. </summary>
        public static PropertyValueEstimatedBasis ApplicantEstimate { get; } = new PropertyValueEstimatedBasis(ApplicantEstimateValue);
        /// <summary> CertifiedValuation. </summary>
        public static PropertyValueEstimatedBasis CertifiedValuation { get; } = new PropertyValueEstimatedBasis(CertifiedValuationValue);
        /// <summary> ActualValue. </summary>
        public static PropertyValueEstimatedBasis ActualValue { get; } = new PropertyValueEstimatedBasis(ActualValueValue);
        /// <summary> Determines if two <see cref="PropertyValueEstimatedBasis"/> values are the same. </summary>
        public static bool operator ==(PropertyValueEstimatedBasis left, PropertyValueEstimatedBasis right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PropertyValueEstimatedBasis"/> values are not the same. </summary>
        public static bool operator !=(PropertyValueEstimatedBasis left, PropertyValueEstimatedBasis right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="PropertyValueEstimatedBasis"/>. </summary>
        public static implicit operator PropertyValueEstimatedBasis(string value) => new PropertyValueEstimatedBasis(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PropertyValueEstimatedBasis other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PropertyValueEstimatedBasis other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
