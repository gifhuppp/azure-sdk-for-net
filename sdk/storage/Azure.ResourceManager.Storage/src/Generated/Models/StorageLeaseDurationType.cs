// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> Specifies whether the lease on a container is of infinite or fixed duration, only when the container is leased. </summary>
    public readonly partial struct StorageLeaseDurationType : IEquatable<StorageLeaseDurationType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="StorageLeaseDurationType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public StorageLeaseDurationType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InfiniteValue = "Infinite";
        private const string FixedValue = "Fixed";

        /// <summary> Infinite. </summary>
        public static StorageLeaseDurationType Infinite { get; } = new StorageLeaseDurationType(InfiniteValue);
        /// <summary> Fixed. </summary>
        public static StorageLeaseDurationType Fixed { get; } = new StorageLeaseDurationType(FixedValue);
        /// <summary> Determines if two <see cref="StorageLeaseDurationType"/> values are the same. </summary>
        public static bool operator ==(StorageLeaseDurationType left, StorageLeaseDurationType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="StorageLeaseDurationType"/> values are not the same. </summary>
        public static bool operator !=(StorageLeaseDurationType left, StorageLeaseDurationType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="StorageLeaseDurationType"/>. </summary>
        public static implicit operator StorageLeaseDurationType(string value) => new StorageLeaseDurationType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is StorageLeaseDurationType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(StorageLeaseDurationType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
