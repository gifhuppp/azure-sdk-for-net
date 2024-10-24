// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.CosmosDB;

/// <summary>
/// The CassandraCertificate.
/// </summary>
public partial class CassandraCertificate : ProvisionableConstruct
{
    /// <summary>
    /// PEM formatted public key.
    /// </summary>
    public BicepValue<string> Pem { get => _pem; set => _pem.Assign(value); }
    private readonly BicepValue<string> _pem;

    /// <summary>
    /// Creates a new CassandraCertificate.
    /// </summary>
    public CassandraCertificate()
    {
        _pem = BicepValue<string>.DefineProperty(this, "Pem", ["pem"]);
    }
}
