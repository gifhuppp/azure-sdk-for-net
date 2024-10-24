// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.ServiceBus;

/// <summary>
/// ServiceBusNetworkRuleSet.
/// </summary>
public partial class ServiceBusNetworkRuleSet : ProvisionableResource
{
    /// <summary>
    /// Gets the Name.
    /// </summary>
    public BicepValue<string> Name { get => _name; }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// Default Action for Network Rule Set.
    /// </summary>
    public BicepValue<ServiceBusNetworkRuleSetDefaultAction> DefaultAction { get => _defaultAction; set => _defaultAction.Assign(value); }
    private readonly BicepValue<ServiceBusNetworkRuleSetDefaultAction> _defaultAction;

    /// <summary>
    /// List of IpRules.
    /// </summary>
    public BicepList<ServiceBusNetworkRuleSetIPRules> IPRules { get => _iPRules; set => _iPRules.Assign(value); }
    private readonly BicepList<ServiceBusNetworkRuleSetIPRules> _iPRules;

    /// <summary>
    /// Value that indicates whether Trusted Service Access is Enabled or not.
    /// </summary>
    public BicepValue<bool> IsTrustedServiceAccessEnabled { get => _isTrustedServiceAccessEnabled; set => _isTrustedServiceAccessEnabled.Assign(value); }
    private readonly BicepValue<bool> _isTrustedServiceAccessEnabled;

    /// <summary>
    /// This determines if traffic is allowed over public network. By default
    /// it is enabled.
    /// </summary>
    public BicepValue<ServiceBusPublicNetworkAccessFlag> PublicNetworkAccess { get => _publicNetworkAccess; set => _publicNetworkAccess.Assign(value); }
    private readonly BicepValue<ServiceBusPublicNetworkAccessFlag> _publicNetworkAccess;

    /// <summary>
    /// List VirtualNetwork Rules.
    /// </summary>
    public BicepList<ServiceBusNetworkRuleSetVirtualNetworkRules> VirtualNetworkRules { get => _virtualNetworkRules; set => _virtualNetworkRules.Assign(value); }
    private readonly BicepList<ServiceBusNetworkRuleSetVirtualNetworkRules> _virtualNetworkRules;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// The geo-location where the resource lives.
    /// </summary>
    public BicepValue<AzureLocation> Location { get => _location; }
    private readonly BicepValue<AzureLocation> _location;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// Gets or sets a reference to the parent ServiceBusNamespace.
    /// </summary>
    public ServiceBusNamespace? Parent { get => _parent!.Value; set => _parent!.Value = value; }
    private readonly ResourceReference<ServiceBusNamespace> _parent;

    /// <summary>
    /// Creates a new ServiceBusNetworkRuleSet.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the ServiceBusNetworkRuleSet resource.
    /// This can be used to refer to the resource in expressions, but is not
    /// the Azure name of the resource.  This value can contain letters,
    /// numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the ServiceBusNetworkRuleSet.</param>
    public ServiceBusNetworkRuleSet(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.ServiceBus/namespaces/networkRuleSets", resourceVersion ?? "2024-01-01")
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isOutput: true);
        _defaultAction = BicepValue<ServiceBusNetworkRuleSetDefaultAction>.DefineProperty(this, "DefaultAction", ["properties", "defaultAction"]);
        _iPRules = BicepList<ServiceBusNetworkRuleSetIPRules>.DefineProperty(this, "IPRules", ["properties", "ipRules"]);
        _isTrustedServiceAccessEnabled = BicepValue<bool>.DefineProperty(this, "IsTrustedServiceAccessEnabled", ["properties", "trustedServiceAccessEnabled"]);
        _publicNetworkAccess = BicepValue<ServiceBusPublicNetworkAccessFlag>.DefineProperty(this, "PublicNetworkAccess", ["properties", "publicNetworkAccess"]);
        _virtualNetworkRules = BicepList<ServiceBusNetworkRuleSetVirtualNetworkRules>.DefineProperty(this, "VirtualNetworkRules", ["properties", "virtualNetworkRules"]);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _location = BicepValue<AzureLocation>.DefineProperty(this, "Location", ["location"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _parent = ResourceReference<ServiceBusNamespace>.DefineResource(this, "Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported ServiceBusNetworkRuleSet resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2024-01-01.
        /// </summary>
        public static readonly string V2024_01_01 = "2024-01-01";

        /// <summary>
        /// 2021-11-01.
        /// </summary>
        public static readonly string V2021_11_01 = "2021-11-01";

        /// <summary>
        /// 2017-04-01.
        /// </summary>
        public static readonly string V2017_04_01 = "2017-04-01";
    }

    /// <summary>
    /// Creates a reference to an existing ServiceBusNetworkRuleSet.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the ServiceBusNetworkRuleSet resource.
    /// This can be used to refer to the resource in expressions, but is not
    /// the Azure name of the resource.  This value can contain letters,
    /// numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the ServiceBusNetworkRuleSet.</param>
    /// <returns>The existing ServiceBusNetworkRuleSet resource.</returns>
    public static ServiceBusNetworkRuleSet FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };
}
