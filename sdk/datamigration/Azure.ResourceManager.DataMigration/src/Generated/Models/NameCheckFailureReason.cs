// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> The reason why the name is not available, if nameAvailable is false. </summary>
    public readonly partial struct NameCheckFailureReason : IEquatable<NameCheckFailureReason>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="NameCheckFailureReason"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public NameCheckFailureReason(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AlreadyExistsValue = "AlreadyExists";
        private const string InvalidValue = "Invalid";

        /// <summary> AlreadyExists. </summary>
        public static NameCheckFailureReason AlreadyExists { get; } = new NameCheckFailureReason(AlreadyExistsValue);
        /// <summary> Invalid. </summary>
        public static NameCheckFailureReason Invalid { get; } = new NameCheckFailureReason(InvalidValue);
        /// <summary> Determines if two <see cref="NameCheckFailureReason"/> values are the same. </summary>
        public static bool operator ==(NameCheckFailureReason left, NameCheckFailureReason right) => left.Equals(right);
        /// <summary> Determines if two <see cref="NameCheckFailureReason"/> values are not the same. </summary>
        public static bool operator !=(NameCheckFailureReason left, NameCheckFailureReason right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="NameCheckFailureReason"/>. </summary>
        public static implicit operator NameCheckFailureReason(string value) => new NameCheckFailureReason(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is NameCheckFailureReason other && Equals(other);
        /// <inheritdoc />
        public bool Equals(NameCheckFailureReason other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
