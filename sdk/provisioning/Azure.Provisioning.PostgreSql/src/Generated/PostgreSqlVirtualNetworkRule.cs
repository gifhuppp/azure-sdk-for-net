// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;
using System.ComponentModel;

namespace Azure.Provisioning.PostgreSql;

/// <summary>
/// PostgreSqlVirtualNetworkRule.
/// </summary>
public partial class PostgreSqlVirtualNetworkRule : ProvisionableResource
{
    /// <summary>
    /// The name of the virtual network rule.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// Create firewall rule before the virtual network has vnet service
    /// endpoint enabled.
    /// </summary>
    public BicepValue<bool> IgnoreMissingVnetServiceEndpoint { get => _ignoreMissingVnetServiceEndpoint; set => _ignoreMissingVnetServiceEndpoint.Assign(value); }
    private readonly BicepValue<bool> _ignoreMissingVnetServiceEndpoint;

    /// <summary>
    /// The ARM resource id of the virtual network subnet.
    /// </summary>
    public BicepValue<ResourceIdentifier> VirtualNetworkSubnetId { get => _virtualNetworkSubnetId; set => _virtualNetworkSubnetId.Assign(value); }
    private readonly BicepValue<ResourceIdentifier> _virtualNetworkSubnetId;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// Virtual Network Rule State.
    /// </summary>
    public BicepValue<PostgreSqlVirtualNetworkRuleState> State { get => _state; }
    private readonly BicepValue<PostgreSqlVirtualNetworkRuleState> _state;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// Gets or sets a reference to the parent PostgreSqlServer.
    /// </summary>
    public PostgreSqlServer? Parent { get => _parent!.Value; set => _parent!.Value = value; }
    private readonly ResourceReference<PostgreSqlServer> _parent;

    /// <summary>
    /// Creates a new PostgreSqlVirtualNetworkRule.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the PostgreSqlVirtualNetworkRule
    /// resource.  This can be used to refer to the resource in expressions,
    /// but is not the Azure name of the resource.  This value can contain
    /// letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the PostgreSqlVirtualNetworkRule.</param>
    public PostgreSqlVirtualNetworkRule(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.DBforPostgreSQL/servers/virtualNetworkRules", resourceVersion ?? "2017-12-01")
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isRequired: true);
        _ignoreMissingVnetServiceEndpoint = BicepValue<bool>.DefineProperty(this, "IgnoreMissingVnetServiceEndpoint", ["properties", "ignoreMissingVnetServiceEndpoint"]);
        _virtualNetworkSubnetId = BicepValue<ResourceIdentifier>.DefineProperty(this, "VirtualNetworkSubnetId", ["properties", "virtualNetworkSubnetId"]);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _state = BicepValue<PostgreSqlVirtualNetworkRuleState>.DefineProperty(this, "State", ["properties", "state"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _parent = ResourceReference<PostgreSqlServer>.DefineResource(this, "Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported PostgreSqlVirtualNetworkRule resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2017-12-01.
        /// </summary>
        public static readonly string V2017_12_01 = "2017-12-01";
    }

    /// <summary>
    /// Creates a reference to an existing PostgreSqlVirtualNetworkRule.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the PostgreSqlVirtualNetworkRule
    /// resource.  This can be used to refer to the resource in expressions,
    /// but is not the Azure name of the resource.  This value can contain
    /// letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the PostgreSqlVirtualNetworkRule.</param>
    /// <returns>The existing PostgreSqlVirtualNetworkRule resource.</returns>
    public static PostgreSqlVirtualNetworkRule FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };

    /// <summary>
    /// Get the requirements for naming this PostgreSqlVirtualNetworkRule
    /// resource.
    /// </summary>
    /// <returns>Naming requirements.</returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override ResourceNameRequirements GetResourceNameRequirements() =>
        new(minLength: 1, maxLength: 128, validCharacters: ResourceNameCharacters.LowercaseLetters | ResourceNameCharacters.UppercaseLetters | ResourceNameCharacters.Numbers | ResourceNameCharacters.Hyphen);
}
