// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.Authorization;

/// <summary>
/// RoleEligibilityScheduleRequest.
/// </summary>
public partial class RoleEligibilityScheduleRequest : ProvisionableResource
{
    /// <summary>
    /// The name of the role eligibility to create. It can be any valid GUID.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// The conditions on the role assignment. This limits the resources it can
    /// be assigned to. e.g.:
    /// @Resource[Microsoft.Storage/storageAccounts/blobServices/containers:ContainerName]
    /// StringEqualsIgnoreCase &apos;foo_storage_container&apos;.
    /// </summary>
    public BicepValue<string> Condition { get => _condition; set => _condition.Assign(value); }
    private readonly BicepValue<string> _condition;

    /// <summary>
    /// Version of the condition. Currently accepted value is &apos;2.0&apos;.
    /// </summary>
    public BicepValue<string> ConditionVersion { get => _conditionVersion; set => _conditionVersion.Assign(value); }
    private readonly BicepValue<string> _conditionVersion;

    /// <summary>
    /// Duration of the role eligibility schedule in TimeSpan.
    /// </summary>
    public BicepValue<TimeSpan> Duration { get => _duration; set => _duration.Assign(value); }
    private readonly BicepValue<TimeSpan> _duration;

    /// <summary>
    /// End DateTime of the role eligibility schedule.
    /// </summary>
    public BicepValue<DateTimeOffset> EndOn { get => _endOn; set => _endOn.Assign(value); }
    private readonly BicepValue<DateTimeOffset> _endOn;

    /// <summary>
    /// Type of the role eligibility schedule expiration.
    /// </summary>
    public BicepValue<RoleManagementScheduleExpirationType> ExpirationType { get => _expirationType; set => _expirationType.Assign(value); }
    private readonly BicepValue<RoleManagementScheduleExpirationType> _expirationType;

    /// <summary>
    /// Justification for the role eligibility.
    /// </summary>
    public BicepValue<string> Justification { get => _justification; set => _justification.Assign(value); }
    private readonly BicepValue<string> _justification;

    /// <summary>
    /// The principal ID.
    /// </summary>
    public BicepValue<Guid> PrincipalId { get => _principalId; set => _principalId.Assign(value); }
    private readonly BicepValue<Guid> _principalId;

    /// <summary>
    /// The type of the role assignment schedule request. Eg: SelfActivate,
    /// AdminAssign etc.
    /// </summary>
    public BicepValue<RoleManagementScheduleRequestType> RequestType { get => _requestType; set => _requestType.Assign(value); }
    private readonly BicepValue<RoleManagementScheduleRequestType> _requestType;

    /// <summary>
    /// The role definition ID.
    /// </summary>
    public BicepValue<ResourceIdentifier> RoleDefinitionId { get => _roleDefinitionId; set => _roleDefinitionId.Assign(value); }
    private readonly BicepValue<ResourceIdentifier> _roleDefinitionId;

    /// <summary>
    /// Start DateTime of the role eligibility schedule.
    /// </summary>
    public BicepValue<DateTimeOffset> StartOn { get => _startOn; set => _startOn.Assign(value); }
    private readonly BicepValue<DateTimeOffset> _startOn;

    /// <summary>
    /// The resultant role eligibility schedule id or the role eligibility
    /// schedule id being updated.
    /// </summary>
    public BicepValue<ResourceIdentifier> TargetRoleEligibilityScheduleId { get => _targetRoleEligibilityScheduleId; set => _targetRoleEligibilityScheduleId.Assign(value); }
    private readonly BicepValue<ResourceIdentifier> _targetRoleEligibilityScheduleId;

    /// <summary>
    /// The role eligibility schedule instance id being updated.
    /// </summary>
    public BicepValue<ResourceIdentifier> TargetRoleEligibilityScheduleInstanceId { get => _targetRoleEligibilityScheduleInstanceId; set => _targetRoleEligibilityScheduleInstanceId.Assign(value); }
    private readonly BicepValue<ResourceIdentifier> _targetRoleEligibilityScheduleInstanceId;

    /// <summary>
    /// Ticket Info of the role eligibility.
    /// </summary>
    public BicepValue<RoleEligibilityScheduleRequestPropertiesTicketInfo> TicketInfo { get => _ticketInfo; set => _ticketInfo.Assign(value); }
    private readonly BicepValue<RoleEligibilityScheduleRequestPropertiesTicketInfo> _ticketInfo;

    /// <summary>
    /// The approvalId of the role eligibility schedule request.
    /// </summary>
    public BicepValue<string> ApprovalId { get => _approvalId; }
    private readonly BicepValue<string> _approvalId;

    /// <summary>
    /// DateTime when role eligibility schedule request was created.
    /// </summary>
    public BicepValue<DateTimeOffset> CreatedOn { get => _createdOn; }
    private readonly BicepValue<DateTimeOffset> _createdOn;

    /// <summary>
    /// Additional properties of principal, scope and role definition.
    /// </summary>
    public BicepValue<RoleManagementExpandedProperties> ExpandedProperties { get => _expandedProperties; }
    private readonly BicepValue<RoleManagementExpandedProperties> _expandedProperties;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// The principal type of the assigned principal ID.
    /// </summary>
    public BicepValue<RoleManagementPrincipalType> PrincipalType { get => _principalType; }
    private readonly BicepValue<RoleManagementPrincipalType> _principalType;

    /// <summary>
    /// Id of the user who created this request.
    /// </summary>
    public BicepValue<Guid> RequestorId { get => _requestorId; }
    private readonly BicepValue<Guid> _requestorId;

    /// <summary>
    /// The role eligibility schedule request scope.
    /// </summary>
    public BicepValue<string> Scope { get => _scope; }
    private readonly BicepValue<string> _scope;

    /// <summary>
    /// The status of the role eligibility schedule request.
    /// </summary>
    public BicepValue<RoleManagementScheduleStatus> Status { get => _status; }
    private readonly BicepValue<RoleManagementScheduleStatus> _status;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// Creates a new RoleEligibilityScheduleRequest.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the RoleEligibilityScheduleRequest
    /// resource.  This can be used to refer to the resource in expressions,
    /// but is not the Azure name of the resource.  This value can contain
    /// letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the RoleEligibilityScheduleRequest.</param>
    public RoleEligibilityScheduleRequest(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.Authorization/roleEligibilityScheduleRequests", resourceVersion ?? "2020-10-01")
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isRequired: true);
        _condition = BicepValue<string>.DefineProperty(this, "Condition", ["properties", "condition"]);
        _conditionVersion = BicepValue<string>.DefineProperty(this, "ConditionVersion", ["properties", "conditionVersion"]);
        _duration = BicepValue<TimeSpan>.DefineProperty(this, "Duration", ["properties", "duration"], format: "P");
        _endOn = BicepValue<DateTimeOffset>.DefineProperty(this, "EndOn", ["properties", "endDateTime"]);
        _expirationType = BicepValue<RoleManagementScheduleExpirationType>.DefineProperty(this, "ExpirationType", ["properties", "type"]);
        _justification = BicepValue<string>.DefineProperty(this, "Justification", ["properties", "justification"]);
        _principalId = BicepValue<Guid>.DefineProperty(this, "PrincipalId", ["properties", "principalId"]);
        _requestType = BicepValue<RoleManagementScheduleRequestType>.DefineProperty(this, "RequestType", ["properties", "requestType"]);
        _roleDefinitionId = BicepValue<ResourceIdentifier>.DefineProperty(this, "RoleDefinitionId", ["properties", "roleDefinitionId"]);
        _startOn = BicepValue<DateTimeOffset>.DefineProperty(this, "StartOn", ["properties", "startDateTime"]);
        _targetRoleEligibilityScheduleId = BicepValue<ResourceIdentifier>.DefineProperty(this, "TargetRoleEligibilityScheduleId", ["properties", "targetRoleEligibilityScheduleId"]);
        _targetRoleEligibilityScheduleInstanceId = BicepValue<ResourceIdentifier>.DefineProperty(this, "TargetRoleEligibilityScheduleInstanceId", ["properties", "targetRoleEligibilityScheduleInstanceId"]);
        _ticketInfo = BicepValue<RoleEligibilityScheduleRequestPropertiesTicketInfo>.DefineProperty(this, "TicketInfo", ["properties", "ticketInfo"]);
        _approvalId = BicepValue<string>.DefineProperty(this, "ApprovalId", ["properties", "approvalId"], isOutput: true);
        _createdOn = BicepValue<DateTimeOffset>.DefineProperty(this, "CreatedOn", ["properties", "createdOn"], isOutput: true);
        _expandedProperties = BicepValue<RoleManagementExpandedProperties>.DefineProperty(this, "ExpandedProperties", ["properties", "expandedProperties"], isOutput: true);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _principalType = BicepValue<RoleManagementPrincipalType>.DefineProperty(this, "PrincipalType", ["properties", "principalType"], isOutput: true);
        _requestorId = BicepValue<Guid>.DefineProperty(this, "RequestorId", ["properties", "requestorId"], isOutput: true);
        _scope = BicepValue<string>.DefineProperty(this, "Scope", ["properties", "scope"], isOutput: true);
        _status = BicepValue<RoleManagementScheduleStatus>.DefineProperty(this, "Status", ["properties", "status"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
    }

    /// <summary>
    /// Supported RoleEligibilityScheduleRequest resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2020-10-01.
        /// </summary>
        public static readonly string V2020_10_01 = "2020-10-01";
    }

    /// <summary>
    /// Creates a reference to an existing RoleEligibilityScheduleRequest.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the RoleEligibilityScheduleRequest
    /// resource.  This can be used to refer to the resource in expressions,
    /// but is not the Azure name of the resource.  This value can contain
    /// letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the RoleEligibilityScheduleRequest.</param>
    /// <returns>The existing RoleEligibilityScheduleRequest resource.</returns>
    public static RoleEligibilityScheduleRequest FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };
}
