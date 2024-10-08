// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using System.Runtime.Serialization;

namespace Azure.Provisioning.AppContainers;

/// <summary>
/// Scheme to use for connecting to the host. Defaults to HTTP.
/// </summary>
public enum ContainerAppHttpScheme
{
    /// <summary>
    /// HTTP.
    /// </summary>
    [DataMember(Name = "HTTP")]
    Http,

    /// <summary>
    /// HTTPS.
    /// </summary>
    [DataMember(Name = "HTTPS")]
    Https,
}
