// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> The more detailed status of the key set. </summary>
    public readonly partial struct BmcKeySetDetailedStatus : IEquatable<BmcKeySetDetailedStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="BmcKeySetDetailedStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public BmcKeySetDetailedStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AllActiveValue = "AllActive";
        private const string SomeInvalidValue = "SomeInvalid";
        private const string AllInvalidValue = "AllInvalid";
        private const string ValidatingValue = "Validating";

        /// <summary> AllActive. </summary>
        public static BmcKeySetDetailedStatus AllActive { get; } = new BmcKeySetDetailedStatus(AllActiveValue);
        /// <summary> SomeInvalid. </summary>
        public static BmcKeySetDetailedStatus SomeInvalid { get; } = new BmcKeySetDetailedStatus(SomeInvalidValue);
        /// <summary> AllInvalid. </summary>
        public static BmcKeySetDetailedStatus AllInvalid { get; } = new BmcKeySetDetailedStatus(AllInvalidValue);
        /// <summary> Validating. </summary>
        public static BmcKeySetDetailedStatus Validating { get; } = new BmcKeySetDetailedStatus(ValidatingValue);
        /// <summary> Determines if two <see cref="BmcKeySetDetailedStatus"/> values are the same. </summary>
        public static bool operator ==(BmcKeySetDetailedStatus left, BmcKeySetDetailedStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="BmcKeySetDetailedStatus"/> values are not the same. </summary>
        public static bool operator !=(BmcKeySetDetailedStatus left, BmcKeySetDetailedStatus right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="BmcKeySetDetailedStatus"/>. </summary>
        public static implicit operator BmcKeySetDetailedStatus(string value) => new BmcKeySetDetailedStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is BmcKeySetDetailedStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(BmcKeySetDetailedStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
