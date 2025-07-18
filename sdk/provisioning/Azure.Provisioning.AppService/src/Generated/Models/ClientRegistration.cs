// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.AppService;

/// <summary>
/// The configuration settings of the app registration for providers that have
/// client ids and client secrets.
/// </summary>
public partial class ClientRegistration : ProvisionableConstruct
{
    /// <summary>
    /// The Client ID of the app used for login.
    /// </summary>
    public BicepValue<string> ClientId 
    {
        get { Initialize(); return _clientId!; }
        set { Initialize(); _clientId!.Assign(value); }
    }
    private BicepValue<string>? _clientId;

    /// <summary>
    /// The app setting name that contains the client secret.
    /// </summary>
    public BicepValue<string> ClientSecretSettingName 
    {
        get { Initialize(); return _clientSecretSettingName!; }
        set { Initialize(); _clientSecretSettingName!.Assign(value); }
    }
    private BicepValue<string>? _clientSecretSettingName;

    /// <summary>
    /// Creates a new ClientRegistration.
    /// </summary>
    public ClientRegistration()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of ClientRegistration.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _clientId = DefineProperty<string>("ClientId", ["clientId"]);
        _clientSecretSettingName = DefineProperty<string>("ClientSecretSettingName", ["clientSecretSettingName"]);
    }
}
