// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace MyCrmSampleClient.MyCrmApi.Models
{
    /// <summary> The AssetSubTypesEntityType. </summary>
    public readonly partial struct AssetSubTypesEntityType : IEquatable<AssetSubTypesEntityType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AssetSubTypesEntityType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AssetSubTypesEntityType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AssetSubTypesValue = "asset-sub-types";

        /// <summary> asset-sub-types. </summary>
        public static AssetSubTypesEntityType AssetSubTypes { get; } = new AssetSubTypesEntityType(AssetSubTypesValue);
        /// <summary> Determines if two <see cref="AssetSubTypesEntityType"/> values are the same. </summary>
        public static bool operator ==(AssetSubTypesEntityType left, AssetSubTypesEntityType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AssetSubTypesEntityType"/> values are not the same. </summary>
        public static bool operator !=(AssetSubTypesEntityType left, AssetSubTypesEntityType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AssetSubTypesEntityType"/>. </summary>
        public static implicit operator AssetSubTypesEntityType(string value) => new AssetSubTypesEntityType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AssetSubTypesEntityType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AssetSubTypesEntityType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
