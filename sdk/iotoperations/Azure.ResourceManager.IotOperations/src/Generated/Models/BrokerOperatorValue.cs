// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.IotOperations.Models
{
    /// <summary> Valid operators are In, NotIn, Exists and DoesNotExist. </summary>
    public readonly partial struct BrokerOperatorValue : IEquatable<BrokerOperatorValue>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="BrokerOperatorValue"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public BrokerOperatorValue(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InValue = "In";
        private const string NotInValue = "NotIn";
        private const string ExistsValue = "Exists";
        private const string DoesNotExistValue = "DoesNotExist";

        /// <summary> In operator. </summary>
        public static BrokerOperatorValue In { get; } = new BrokerOperatorValue(InValue);
        /// <summary> NotIn operator. </summary>
        public static BrokerOperatorValue NotIn { get; } = new BrokerOperatorValue(NotInValue);
        /// <summary> Exists operator. </summary>
        public static BrokerOperatorValue Exists { get; } = new BrokerOperatorValue(ExistsValue);
        /// <summary> DoesNotExist operator. </summary>
        public static BrokerOperatorValue DoesNotExist { get; } = new BrokerOperatorValue(DoesNotExistValue);
        /// <summary> Determines if two <see cref="BrokerOperatorValue"/> values are the same. </summary>
        public static bool operator ==(BrokerOperatorValue left, BrokerOperatorValue right) => left.Equals(right);
        /// <summary> Determines if two <see cref="BrokerOperatorValue"/> values are not the same. </summary>
        public static bool operator !=(BrokerOperatorValue left, BrokerOperatorValue right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="BrokerOperatorValue"/>. </summary>
        public static implicit operator BrokerOperatorValue(string value) => new BrokerOperatorValue(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is BrokerOperatorValue other && Equals(other);
        /// <inheritdoc />
        public bool Equals(BrokerOperatorValue other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
