// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace MyCrmSampleClient.MyCrmApi.Models
{
    /// <summary> The LeadsEntityType. </summary>
    public readonly partial struct LeadsEntityType : IEquatable<LeadsEntityType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="LeadsEntityType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public LeadsEntityType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string LeadsValue = "leads";

        /// <summary> leads. </summary>
        public static LeadsEntityType Leads { get; } = new LeadsEntityType(LeadsValue);
        /// <summary> Determines if two <see cref="LeadsEntityType"/> values are the same. </summary>
        public static bool operator ==(LeadsEntityType left, LeadsEntityType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="LeadsEntityType"/> values are not the same. </summary>
        public static bool operator !=(LeadsEntityType left, LeadsEntityType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="LeadsEntityType"/>. </summary>
        public static implicit operator LeadsEntityType(string value) => new LeadsEntityType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is LeadsEntityType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(LeadsEntityType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}