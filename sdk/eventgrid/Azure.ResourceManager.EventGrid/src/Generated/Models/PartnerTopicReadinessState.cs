// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> The readiness state of the corresponding partner topic. </summary>
    public readonly partial struct PartnerTopicReadinessState : IEquatable<PartnerTopicReadinessState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PartnerTopicReadinessState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PartnerTopicReadinessState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NeverActivatedValue = "NeverActivated";
        private const string ActivatedValue = "Activated";

        /// <summary> NeverActivated. </summary>
        public static PartnerTopicReadinessState NeverActivated { get; } = new PartnerTopicReadinessState(NeverActivatedValue);
        /// <summary> Activated. </summary>
        public static PartnerTopicReadinessState Activated { get; } = new PartnerTopicReadinessState(ActivatedValue);
        /// <summary> Determines if two <see cref="PartnerTopicReadinessState"/> values are the same. </summary>
        public static bool operator ==(PartnerTopicReadinessState left, PartnerTopicReadinessState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PartnerTopicReadinessState"/> values are not the same. </summary>
        public static bool operator !=(PartnerTopicReadinessState left, PartnerTopicReadinessState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="PartnerTopicReadinessState"/>. </summary>
        public static implicit operator PartnerTopicReadinessState(string value) => new PartnerTopicReadinessState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PartnerTopicReadinessState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PartnerTopicReadinessState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
