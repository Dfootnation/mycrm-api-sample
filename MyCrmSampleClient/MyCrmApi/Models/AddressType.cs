// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace MyCrmSampleClient.MyCrmApi.Models
{
    /// <summary> The AddressType. </summary>
    internal readonly partial struct AddressType : IEquatable<AddressType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AddressType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AddressType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CurrentAddressValue = "CurrentAddress";
        private const string PostalAddressValue = "PostalAddress";
        private const string PostSettlementAddressValue = "PostSettlementAddress";
        private const string PreviousAddressValue = "PreviousAddress";
        private const string OtherValue = "Other";

        /// <summary> CurrentAddress. </summary>
        public static AddressType CurrentAddress { get; } = new AddressType(CurrentAddressValue);
        /// <summary> PostalAddress. </summary>
        public static AddressType PostalAddress { get; } = new AddressType(PostalAddressValue);
        /// <summary> PostSettlementAddress. </summary>
        public static AddressType PostSettlementAddress { get; } = new AddressType(PostSettlementAddressValue);
        /// <summary> PreviousAddress. </summary>
        public static AddressType PreviousAddress { get; } = new AddressType(PreviousAddressValue);
        /// <summary> Other. </summary>
        public static AddressType Other { get; } = new AddressType(OtherValue);
        /// <summary> Determines if two <see cref="AddressType"/> values are the same. </summary>
        public static bool operator ==(AddressType left, AddressType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AddressType"/> values are not the same. </summary>
        public static bool operator !=(AddressType left, AddressType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AddressType"/>. </summary>
        public static implicit operator AddressType(string value) => new AddressType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AddressType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AddressType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}