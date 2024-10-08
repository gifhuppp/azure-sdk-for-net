// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Deployment build status. </summary>
    public readonly partial struct DeploymentBuildStatus : IEquatable<DeploymentBuildStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DeploymentBuildStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DeploymentBuildStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string TimedOutValue = "TimedOut";
        private const string RuntimeFailedValue = "RuntimeFailed";
        private const string BuildAbortedValue = "BuildAborted";
        private const string BuildFailedValue = "BuildFailed";
        private const string BuildRequestReceivedValue = "BuildRequestReceived";
        private const string BuildPendingValue = "BuildPending";
        private const string BuildInProgressValue = "BuildInProgress";
        private const string BuildSuccessfulValue = "BuildSuccessful";
        private const string PostBuildRestartRequiredValue = "PostBuildRestartRequired";
        private const string StartPollingValue = "StartPolling";
        private const string StartPollingWithRestartValue = "StartPollingWithRestart";
        private const string RuntimeStartingValue = "RuntimeStarting";
        private const string RuntimeSuccessfulValue = "RuntimeSuccessful";

        /// <summary> TimedOut. </summary>
        public static DeploymentBuildStatus TimedOut { get; } = new DeploymentBuildStatus(TimedOutValue);
        /// <summary> RuntimeFailed. </summary>
        public static DeploymentBuildStatus RuntimeFailed { get; } = new DeploymentBuildStatus(RuntimeFailedValue);
        /// <summary> BuildAborted. </summary>
        public static DeploymentBuildStatus BuildAborted { get; } = new DeploymentBuildStatus(BuildAbortedValue);
        /// <summary> BuildFailed. </summary>
        public static DeploymentBuildStatus BuildFailed { get; } = new DeploymentBuildStatus(BuildFailedValue);
        /// <summary> BuildRequestReceived. </summary>
        public static DeploymentBuildStatus BuildRequestReceived { get; } = new DeploymentBuildStatus(BuildRequestReceivedValue);
        /// <summary> BuildPending. </summary>
        public static DeploymentBuildStatus BuildPending { get; } = new DeploymentBuildStatus(BuildPendingValue);
        /// <summary> BuildInProgress. </summary>
        public static DeploymentBuildStatus BuildInProgress { get; } = new DeploymentBuildStatus(BuildInProgressValue);
        /// <summary> BuildSuccessful. </summary>
        public static DeploymentBuildStatus BuildSuccessful { get; } = new DeploymentBuildStatus(BuildSuccessfulValue);
        /// <summary> PostBuildRestartRequired. </summary>
        public static DeploymentBuildStatus PostBuildRestartRequired { get; } = new DeploymentBuildStatus(PostBuildRestartRequiredValue);
        /// <summary> StartPolling. </summary>
        public static DeploymentBuildStatus StartPolling { get; } = new DeploymentBuildStatus(StartPollingValue);
        /// <summary> StartPollingWithRestart. </summary>
        public static DeploymentBuildStatus StartPollingWithRestart { get; } = new DeploymentBuildStatus(StartPollingWithRestartValue);
        /// <summary> RuntimeStarting. </summary>
        public static DeploymentBuildStatus RuntimeStarting { get; } = new DeploymentBuildStatus(RuntimeStartingValue);
        /// <summary> RuntimeSuccessful. </summary>
        public static DeploymentBuildStatus RuntimeSuccessful { get; } = new DeploymentBuildStatus(RuntimeSuccessfulValue);
        /// <summary> Determines if two <see cref="DeploymentBuildStatus"/> values are the same. </summary>
        public static bool operator ==(DeploymentBuildStatus left, DeploymentBuildStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DeploymentBuildStatus"/> values are not the same. </summary>
        public static bool operator !=(DeploymentBuildStatus left, DeploymentBuildStatus right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="DeploymentBuildStatus"/>. </summary>
        public static implicit operator DeploymentBuildStatus(string value) => new DeploymentBuildStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DeploymentBuildStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DeploymentBuildStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
