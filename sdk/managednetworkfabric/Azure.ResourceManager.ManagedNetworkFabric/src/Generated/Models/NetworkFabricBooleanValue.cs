// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> Boolean Enum. Example- True/False. </summary>
    public readonly partial struct NetworkFabricBooleanValue : IEquatable<NetworkFabricBooleanValue>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="NetworkFabricBooleanValue"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public NetworkFabricBooleanValue(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string TrueValue = "True";
        private const string FalseValue = "False";

        /// <summary> True. </summary>
        public static NetworkFabricBooleanValue True { get; } = new NetworkFabricBooleanValue(TrueValue);
        /// <summary> False. </summary>
        public static NetworkFabricBooleanValue False { get; } = new NetworkFabricBooleanValue(FalseValue);
        /// <summary> Determines if two <see cref="NetworkFabricBooleanValue"/> values are the same. </summary>
        public static bool operator ==(NetworkFabricBooleanValue left, NetworkFabricBooleanValue right) => left.Equals(right);
        /// <summary> Determines if two <see cref="NetworkFabricBooleanValue"/> values are not the same. </summary>
        public static bool operator !=(NetworkFabricBooleanValue left, NetworkFabricBooleanValue right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="NetworkFabricBooleanValue"/>. </summary>
        public static implicit operator NetworkFabricBooleanValue(string value) => new NetworkFabricBooleanValue(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is NetworkFabricBooleanValue other && Equals(other);
        /// <inheritdoc />
        public bool Equals(NetworkFabricBooleanValue other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
