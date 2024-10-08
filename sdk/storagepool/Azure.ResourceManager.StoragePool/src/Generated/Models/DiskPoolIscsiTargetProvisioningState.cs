// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.StoragePool.Models
{
    /// <summary> Provisioning state of the iSCSI Target. </summary>
    public readonly partial struct DiskPoolIscsiTargetProvisioningState : IEquatable<DiskPoolIscsiTargetProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DiskPoolIscsiTargetProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DiskPoolIscsiTargetProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InvalidValue = "Invalid";
        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string CanceledValue = "Canceled";
        private const string PendingValue = "Pending";
        private const string CreatingValue = "Creating";
        private const string UpdatingValue = "Updating";
        private const string DeletingValue = "Deleting";

        /// <summary> Invalid. </summary>
        public static DiskPoolIscsiTargetProvisioningState Invalid { get; } = new DiskPoolIscsiTargetProvisioningState(InvalidValue);
        /// <summary> Succeeded. </summary>
        public static DiskPoolIscsiTargetProvisioningState Succeeded { get; } = new DiskPoolIscsiTargetProvisioningState(SucceededValue);
        /// <summary> Failed. </summary>
        public static DiskPoolIscsiTargetProvisioningState Failed { get; } = new DiskPoolIscsiTargetProvisioningState(FailedValue);
        /// <summary> Canceled. </summary>
        public static DiskPoolIscsiTargetProvisioningState Canceled { get; } = new DiskPoolIscsiTargetProvisioningState(CanceledValue);
        /// <summary> Pending. </summary>
        public static DiskPoolIscsiTargetProvisioningState Pending { get; } = new DiskPoolIscsiTargetProvisioningState(PendingValue);
        /// <summary> Creating. </summary>
        public static DiskPoolIscsiTargetProvisioningState Creating { get; } = new DiskPoolIscsiTargetProvisioningState(CreatingValue);
        /// <summary> Updating. </summary>
        public static DiskPoolIscsiTargetProvisioningState Updating { get; } = new DiskPoolIscsiTargetProvisioningState(UpdatingValue);
        /// <summary> Deleting. </summary>
        public static DiskPoolIscsiTargetProvisioningState Deleting { get; } = new DiskPoolIscsiTargetProvisioningState(DeletingValue);
        /// <summary> Determines if two <see cref="DiskPoolIscsiTargetProvisioningState"/> values are the same. </summary>
        public static bool operator ==(DiskPoolIscsiTargetProvisioningState left, DiskPoolIscsiTargetProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DiskPoolIscsiTargetProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(DiskPoolIscsiTargetProvisioningState left, DiskPoolIscsiTargetProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="DiskPoolIscsiTargetProvisioningState"/>. </summary>
        public static implicit operator DiskPoolIscsiTargetProvisioningState(string value) => new DiskPoolIscsiTargetProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DiskPoolIscsiTargetProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DiskPoolIscsiTargetProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
