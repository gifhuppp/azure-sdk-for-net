// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Monitor.Query.Models
{
    /// <summary> The unit of the metric. </summary>
    public readonly partial struct MetricUnit : IEquatable<MetricUnit>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MetricUnit"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MetricUnit(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CountValue = "Count";
        private const string BytesValue = "Bytes";
        private const string SecondsValue = "Seconds";
        private const string CountPerSecondValue = "CountPerSecond";
        private const string BytesPerSecondValue = "BytesPerSecond";
        private const string PercentValue = "Percent";
        private const string MilliSecondsValue = "MilliSeconds";
        private const string ByteSecondsValue = "ByteSeconds";
        private const string UnspecifiedValue = "Unspecified";
        private const string CoresValue = "Cores";
        private const string MilliCoresValue = "MilliCores";
        private const string NanoCoresValue = "NanoCores";
        private const string BitsPerSecondValue = "BitsPerSecond";

        /// <summary> Unit of raw quantity. </summary>
        public static MetricUnit Count { get; } = new MetricUnit(CountValue);
        /// <summary> Unit of memory in bytes. </summary>
        public static MetricUnit Bytes { get; } = new MetricUnit(BytesValue);
        /// <summary> Unit of time in seconds. </summary>
        public static MetricUnit Seconds { get; } = new MetricUnit(SecondsValue);
        /// <summary> Rate unit of raw quantity per second. </summary>
        public static MetricUnit CountPerSecond { get; } = new MetricUnit(CountPerSecondValue);
        /// <summary> Rate unit of memory in bytes per second. </summary>
        public static MetricUnit BytesPerSecond { get; } = new MetricUnit(BytesPerSecondValue);
        /// <summary> Percentage unit. </summary>
        public static MetricUnit Percent { get; } = new MetricUnit(PercentValue);
        /// <summary> Unit of time in 1/1000th of a second. </summary>
        public static MetricUnit MilliSeconds { get; } = new MetricUnit(MilliSecondsValue);
        /// <summary> Unit of data transfer or storage. It is the size of the data in bytes multiplied by the time it takes to transfer or store the data in seconds. </summary>
        public static MetricUnit ByteSeconds { get; } = new MetricUnit(ByteSecondsValue);
        /// <summary> No specified unit. </summary>
        public static MetricUnit Unspecified { get; } = new MetricUnit(UnspecifiedValue);
        /// <summary> Unit of processing power. </summary>
        public static MetricUnit Cores { get; } = new MetricUnit(CoresValue);
        /// <summary> Unit of processing power in 1/1000th of a CPU core. </summary>
        public static MetricUnit MilliCores { get; } = new MetricUnit(MilliCoresValue);
        /// <summary> Unit of processing power in one billionth of a CPU core. </summary>
        public static MetricUnit NanoCores { get; } = new MetricUnit(NanoCoresValue);
        /// <summary> Rate unit of binary digits per second. </summary>
        public static MetricUnit BitsPerSecond { get; } = new MetricUnit(BitsPerSecondValue);
        /// <summary> Determines if two <see cref="MetricUnit"/> values are the same. </summary>
        public static bool operator ==(MetricUnit left, MetricUnit right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MetricUnit"/> values are not the same. </summary>
        public static bool operator !=(MetricUnit left, MetricUnit right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="MetricUnit"/>. </summary>
        public static implicit operator MetricUnit(string value) => new MetricUnit(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MetricUnit other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MetricUnit other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
