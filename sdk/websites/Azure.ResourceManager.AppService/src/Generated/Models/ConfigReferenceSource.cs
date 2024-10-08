// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> The ConfigReferenceSource. </summary>
    public readonly partial struct ConfigReferenceSource : IEquatable<ConfigReferenceSource>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ConfigReferenceSource"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ConfigReferenceSource(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string KeyVaultValue = "KeyVault";

        /// <summary> KeyVault. </summary>
        public static ConfigReferenceSource KeyVault { get; } = new ConfigReferenceSource(KeyVaultValue);
        /// <summary> Determines if two <see cref="ConfigReferenceSource"/> values are the same. </summary>
        public static bool operator ==(ConfigReferenceSource left, ConfigReferenceSource right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ConfigReferenceSource"/> values are not the same. </summary>
        public static bool operator !=(ConfigReferenceSource left, ConfigReferenceSource right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ConfigReferenceSource"/>. </summary>
        public static implicit operator ConfigReferenceSource(string value) => new ConfigReferenceSource(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ConfigReferenceSource other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ConfigReferenceSource other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
