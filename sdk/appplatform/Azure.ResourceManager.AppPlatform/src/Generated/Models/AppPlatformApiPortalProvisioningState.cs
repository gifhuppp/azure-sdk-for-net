// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> State of the API portal. </summary>
    public readonly partial struct AppPlatformApiPortalProvisioningState : IEquatable<AppPlatformApiPortalProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AppPlatformApiPortalProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AppPlatformApiPortalProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CreatingValue = "Creating";
        private const string UpdatingValue = "Updating";
        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string DeletingValue = "Deleting";

        /// <summary> Creating. </summary>
        public static AppPlatformApiPortalProvisioningState Creating { get; } = new AppPlatformApiPortalProvisioningState(CreatingValue);
        /// <summary> Updating. </summary>
        public static AppPlatformApiPortalProvisioningState Updating { get; } = new AppPlatformApiPortalProvisioningState(UpdatingValue);
        /// <summary> Succeeded. </summary>
        public static AppPlatformApiPortalProvisioningState Succeeded { get; } = new AppPlatformApiPortalProvisioningState(SucceededValue);
        /// <summary> Failed. </summary>
        public static AppPlatformApiPortalProvisioningState Failed { get; } = new AppPlatformApiPortalProvisioningState(FailedValue);
        /// <summary> Deleting. </summary>
        public static AppPlatformApiPortalProvisioningState Deleting { get; } = new AppPlatformApiPortalProvisioningState(DeletingValue);
        /// <summary> Determines if two <see cref="AppPlatformApiPortalProvisioningState"/> values are the same. </summary>
        public static bool operator ==(AppPlatformApiPortalProvisioningState left, AppPlatformApiPortalProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AppPlatformApiPortalProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(AppPlatformApiPortalProvisioningState left, AppPlatformApiPortalProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="AppPlatformApiPortalProvisioningState"/>. </summary>
        public static implicit operator AppPlatformApiPortalProvisioningState(string value) => new AppPlatformApiPortalProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AppPlatformApiPortalProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AppPlatformApiPortalProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
