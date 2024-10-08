// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DigitalTwins.Models
{
    /// <summary> The type of managed identity used. </summary>
    public readonly partial struct DigitalTwinsManagedIdentityType : IEquatable<DigitalTwinsManagedIdentityType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DigitalTwinsManagedIdentityType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DigitalTwinsManagedIdentityType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SystemAssignedValue = "SystemAssigned";
        private const string UserAssignedValue = "UserAssigned";

        /// <summary> SystemAssigned. </summary>
        public static DigitalTwinsManagedIdentityType SystemAssigned { get; } = new DigitalTwinsManagedIdentityType(SystemAssignedValue);
        /// <summary> UserAssigned. </summary>
        public static DigitalTwinsManagedIdentityType UserAssigned { get; } = new DigitalTwinsManagedIdentityType(UserAssignedValue);
        /// <summary> Determines if two <see cref="DigitalTwinsManagedIdentityType"/> values are the same. </summary>
        public static bool operator ==(DigitalTwinsManagedIdentityType left, DigitalTwinsManagedIdentityType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DigitalTwinsManagedIdentityType"/> values are not the same. </summary>
        public static bool operator !=(DigitalTwinsManagedIdentityType left, DigitalTwinsManagedIdentityType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="DigitalTwinsManagedIdentityType"/>. </summary>
        public static implicit operator DigitalTwinsManagedIdentityType(string value) => new DigitalTwinsManagedIdentityType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DigitalTwinsManagedIdentityType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DigitalTwinsManagedIdentityType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
