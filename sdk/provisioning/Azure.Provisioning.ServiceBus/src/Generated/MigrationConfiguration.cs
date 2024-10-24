// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.ServiceBus;

/// <summary>
/// MigrationConfiguration.
/// </summary>
public partial class MigrationConfiguration : ProvisionableResource
{
    private readonly BicepValue<string> _name;

    /// <summary>
    /// Name to access Standard Namespace after migration.
    /// </summary>
    public BicepValue<string> PostMigrationName { get => _postMigrationName; set => _postMigrationName.Assign(value); }
    private readonly BicepValue<string> _postMigrationName;

    /// <summary>
    /// Existing premium Namespace ARM Id name which has no entities, will be
    /// used for migration.
    /// </summary>
    public BicepValue<ResourceIdentifier> TargetServiceBusNamespace { get => _targetServiceBusNamespace; set => _targetServiceBusNamespace.Assign(value); }
    private readonly BicepValue<ResourceIdentifier> _targetServiceBusNamespace;

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
    /// State in which Standard to Premium Migration is, possible values :
    /// Unknown, Reverting, Completing, Initiating, Syncing, Active.
    /// </summary>
    public BicepValue<string> MigrationState { get => _migrationState; }
    private readonly BicepValue<string> _migrationState;

    /// <summary>
    /// Number of entities pending to be replicated.
    /// </summary>
    public BicepValue<long> PendingReplicationOperationsCount { get => _pendingReplicationOperationsCount; }
    private readonly BicepValue<long> _pendingReplicationOperationsCount;

    /// <summary>
    /// Provisioning state of Migration Configuration.
    /// </summary>
    public BicepValue<string> ProvisioningState { get => _provisioningState; }
    private readonly BicepValue<string> _provisioningState;

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
    /// Get the default value for the Name property.
    /// </summary>
    private partial BicepValue<string> GetNameDefaultValue();

    /// <summary>
    /// Creates a new MigrationConfiguration.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the MigrationConfiguration resource.
    /// This can be used to refer to the resource in expressions, but is not
    /// the Azure name of the resource.  This value can contain letters,
    /// numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the MigrationConfiguration.</param>
    public MigrationConfiguration(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.ServiceBus/namespaces/migrationConfigurations", resourceVersion ?? "2024-01-01")
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isOutput: true, defaultValue: GetNameDefaultValue());
        _postMigrationName = BicepValue<string>.DefineProperty(this, "PostMigrationName", ["properties", "postMigrationName"]);
        _targetServiceBusNamespace = BicepValue<ResourceIdentifier>.DefineProperty(this, "TargetServiceBusNamespace", ["properties", "targetNamespace"]);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _location = BicepValue<AzureLocation>.DefineProperty(this, "Location", ["location"], isOutput: true);
        _migrationState = BicepValue<string>.DefineProperty(this, "MigrationState", ["properties", "migrationState"], isOutput: true);
        _pendingReplicationOperationsCount = BicepValue<long>.DefineProperty(this, "PendingReplicationOperationsCount", ["properties", "pendingReplicationOperationsCount"], isOutput: true);
        _provisioningState = BicepValue<string>.DefineProperty(this, "ProvisioningState", ["properties", "provisioningState"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _parent = ResourceReference<ServiceBusNamespace>.DefineResource(this, "Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported MigrationConfiguration resource versions.
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
    /// Creates a reference to an existing MigrationConfiguration.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the MigrationConfiguration resource.
    /// This can be used to refer to the resource in expressions, but is not
    /// the Azure name of the resource.  This value can contain letters,
    /// numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the MigrationConfiguration.</param>
    /// <returns>The existing MigrationConfiguration resource.</returns>
    public static MigrationConfiguration FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };
}
