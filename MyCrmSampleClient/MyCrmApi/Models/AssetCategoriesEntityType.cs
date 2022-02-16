// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace MyCrmSampleClient.MyCrmApi.Models
{
    /// <summary> The AssetCategoriesEntityType. </summary>
    public readonly partial struct AssetCategoriesEntityType : IEquatable<AssetCategoriesEntityType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AssetCategoriesEntityType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AssetCategoriesEntityType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AssetCategoriesValue = "asset-categories";

        /// <summary> asset-categories. </summary>
        public static AssetCategoriesEntityType AssetCategories { get; } = new AssetCategoriesEntityType(AssetCategoriesValue);
        /// <summary> Determines if two <see cref="AssetCategoriesEntityType"/> values are the same. </summary>
        public static bool operator ==(AssetCategoriesEntityType left, AssetCategoriesEntityType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AssetCategoriesEntityType"/> values are not the same. </summary>
        public static bool operator !=(AssetCategoriesEntityType left, AssetCategoriesEntityType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AssetCategoriesEntityType"/>. </summary>
        public static implicit operator AssetCategoriesEntityType(string value) => new AssetCategoriesEntityType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AssetCategoriesEntityType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AssetCategoriesEntityType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
