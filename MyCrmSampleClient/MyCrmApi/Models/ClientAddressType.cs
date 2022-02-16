// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace MyCrmSampleClient.MyCrmApi.Models
{
    /// <summary> The ClientAddressType. </summary>
    public readonly partial struct ClientAddressType : IEquatable<ClientAddressType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ClientAddressType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ClientAddressType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CurrentValue = "Current";
        private const string PostalValue = "Postal";
        private const string PostSettlementValue = "PostSettlement";
        private const string PreviousValue = "Previous";
        private const string OtherValue = "Other";

        /// <summary> Current. </summary>
        public static ClientAddressType Current { get; } = new ClientAddressType(CurrentValue);
        /// <summary> Postal. </summary>
        public static ClientAddressType Postal { get; } = new ClientAddressType(PostalValue);
        /// <summary> PostSettlement. </summary>
        public static ClientAddressType PostSettlement { get; } = new ClientAddressType(PostSettlementValue);
        /// <summary> Previous. </summary>
        public static ClientAddressType Previous { get; } = new ClientAddressType(PreviousValue);
        /// <summary> Other. </summary>
        public static ClientAddressType Other { get; } = new ClientAddressType(OtherValue);
        /// <summary> Determines if two <see cref="ClientAddressType"/> values are the same. </summary>
        public static bool operator ==(ClientAddressType left, ClientAddressType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ClientAddressType"/> values are not the same. </summary>
        public static bool operator !=(ClientAddressType left, ClientAddressType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ClientAddressType"/>. </summary>
        public static implicit operator ClientAddressType(string value) => new ClientAddressType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ClientAddressType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ClientAddressType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
