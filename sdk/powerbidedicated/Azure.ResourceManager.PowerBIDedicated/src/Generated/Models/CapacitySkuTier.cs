// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.PowerBIDedicated.Models
{
    /// <summary> The name of the Azure pricing tier to which the SKU applies. </summary>
    public readonly partial struct CapacitySkuTier : IEquatable<CapacitySkuTier>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="CapacitySkuTier"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CapacitySkuTier(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PbieAzureValue = "PBIE_Azure";
        private const string PremiumValue = "Premium";
        private const string AutoPremiumHostValue = "AutoPremiumHost";

        /// <summary> PBIE_Azure. </summary>
        public static CapacitySkuTier PbieAzure { get; } = new CapacitySkuTier(PbieAzureValue);
        /// <summary> Premium. </summary>
        public static CapacitySkuTier Premium { get; } = new CapacitySkuTier(PremiumValue);
        /// <summary> AutoPremiumHost. </summary>
        public static CapacitySkuTier AutoPremiumHost { get; } = new CapacitySkuTier(AutoPremiumHostValue);
        /// <summary> Determines if two <see cref="CapacitySkuTier"/> values are the same. </summary>
        public static bool operator ==(CapacitySkuTier left, CapacitySkuTier right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CapacitySkuTier"/> values are not the same. </summary>
        public static bool operator !=(CapacitySkuTier left, CapacitySkuTier right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="CapacitySkuTier"/>. </summary>
        public static implicit operator CapacitySkuTier(string value) => new CapacitySkuTier(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CapacitySkuTier other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CapacitySkuTier other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
