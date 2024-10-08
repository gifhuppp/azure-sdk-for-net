// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Authorization.Models
{
    /// <summary> The notification level. </summary>
    public readonly partial struct RoleManagementPolicyNotificationLevel : IEquatable<RoleManagementPolicyNotificationLevel>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RoleManagementPolicyNotificationLevel"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RoleManagementPolicyNotificationLevel(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "None";
        private const string CriticalValue = "Critical";
        private const string AllValue = "All";

        /// <summary> None. </summary>
        public static RoleManagementPolicyNotificationLevel None { get; } = new RoleManagementPolicyNotificationLevel(NoneValue);
        /// <summary> Critical. </summary>
        public static RoleManagementPolicyNotificationLevel Critical { get; } = new RoleManagementPolicyNotificationLevel(CriticalValue);
        /// <summary> All. </summary>
        public static RoleManagementPolicyNotificationLevel All { get; } = new RoleManagementPolicyNotificationLevel(AllValue);
        /// <summary> Determines if two <see cref="RoleManagementPolicyNotificationLevel"/> values are the same. </summary>
        public static bool operator ==(RoleManagementPolicyNotificationLevel left, RoleManagementPolicyNotificationLevel right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RoleManagementPolicyNotificationLevel"/> values are not the same. </summary>
        public static bool operator !=(RoleManagementPolicyNotificationLevel left, RoleManagementPolicyNotificationLevel right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="RoleManagementPolicyNotificationLevel"/>. </summary>
        public static implicit operator RoleManagementPolicyNotificationLevel(string value) => new RoleManagementPolicyNotificationLevel(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RoleManagementPolicyNotificationLevel other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RoleManagementPolicyNotificationLevel other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
