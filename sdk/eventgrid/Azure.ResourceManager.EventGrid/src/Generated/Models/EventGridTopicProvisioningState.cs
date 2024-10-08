// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> Provisioning state of the topic. </summary>
    public readonly partial struct EventGridTopicProvisioningState : IEquatable<EventGridTopicProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="EventGridTopicProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public EventGridTopicProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CreatingValue = "Creating";
        private const string UpdatingValue = "Updating";
        private const string DeletingValue = "Deleting";
        private const string SucceededValue = "Succeeded";
        private const string CanceledValue = "Canceled";
        private const string FailedValue = "Failed";

        /// <summary> Creating. </summary>
        public static EventGridTopicProvisioningState Creating { get; } = new EventGridTopicProvisioningState(CreatingValue);
        /// <summary> Updating. </summary>
        public static EventGridTopicProvisioningState Updating { get; } = new EventGridTopicProvisioningState(UpdatingValue);
        /// <summary> Deleting. </summary>
        public static EventGridTopicProvisioningState Deleting { get; } = new EventGridTopicProvisioningState(DeletingValue);
        /// <summary> Succeeded. </summary>
        public static EventGridTopicProvisioningState Succeeded { get; } = new EventGridTopicProvisioningState(SucceededValue);
        /// <summary> Canceled. </summary>
        public static EventGridTopicProvisioningState Canceled { get; } = new EventGridTopicProvisioningState(CanceledValue);
        /// <summary> Failed. </summary>
        public static EventGridTopicProvisioningState Failed { get; } = new EventGridTopicProvisioningState(FailedValue);
        /// <summary> Determines if two <see cref="EventGridTopicProvisioningState"/> values are the same. </summary>
        public static bool operator ==(EventGridTopicProvisioningState left, EventGridTopicProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="EventGridTopicProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(EventGridTopicProvisioningState left, EventGridTopicProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="EventGridTopicProvisioningState"/>. </summary>
        public static implicit operator EventGridTopicProvisioningState(string value) => new EventGridTopicProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is EventGridTopicProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(EventGridTopicProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
