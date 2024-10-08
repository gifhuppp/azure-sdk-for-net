// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.HybridCompute.Models
{
    /// <summary> The server types for Esu. </summary>
    public readonly partial struct EsuServerType : IEquatable<EsuServerType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="EsuServerType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public EsuServerType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string StandardValue = "Standard";
        private const string DataCenterValue = "Datacenter";

        /// <summary> Standard. </summary>
        public static EsuServerType Standard { get; } = new EsuServerType(StandardValue);
        /// <summary> Datacenter. </summary>
        public static EsuServerType DataCenter { get; } = new EsuServerType(DataCenterValue);
        /// <summary> Determines if two <see cref="EsuServerType"/> values are the same. </summary>
        public static bool operator ==(EsuServerType left, EsuServerType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="EsuServerType"/> values are not the same. </summary>
        public static bool operator !=(EsuServerType left, EsuServerType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="EsuServerType"/>. </summary>
        public static implicit operator EsuServerType(string value) => new EsuServerType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is EsuServerType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(EsuServerType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
