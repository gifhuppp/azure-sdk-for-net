// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.Avs.Samples
{
    public partial class Sample_WorkloadNetworkPublicIPCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_WorkloadNetworksCreatePublicIP()
        {
            // Generated from example definition: 2024-09-01/WorkloadNetworks_CreatePublicIP.json
            // this example is just showing the usage of "WorkloadNetworkPublicIP_CreatePublicIP" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WorkloadNetworkResource created on azure
            // for more information of creating WorkloadNetworkResource, please refer to the document of WorkloadNetworkResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "group1";
            string privateCloudName = "cloud1";
            ResourceIdentifier workloadNetworkResourceId = WorkloadNetworkResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, privateCloudName);
            WorkloadNetworkResource workloadNetwork = client.GetWorkloadNetworkResource(workloadNetworkResourceId);

            // get the collection of this WorkloadNetworkPublicIPResource
            WorkloadNetworkPublicIPCollection collection = workloadNetwork.GetWorkloadNetworkPublicIPs();

            // invoke the operation
            string publicIPId = "publicIP1";
            WorkloadNetworkPublicIPData data = new WorkloadNetworkPublicIPData();
            ArmOperation<WorkloadNetworkPublicIPResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, publicIPId, data);
            WorkloadNetworkPublicIPResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            WorkloadNetworkPublicIPData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_WorkloadNetworksGetPublicIP()
        {
            // Generated from example definition: 2024-09-01/WorkloadNetworks_GetPublicIP.json
            // this example is just showing the usage of "WorkloadNetworkPublicIP_GetPublicIP" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WorkloadNetworkResource created on azure
            // for more information of creating WorkloadNetworkResource, please refer to the document of WorkloadNetworkResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "group1";
            string privateCloudName = "cloud1";
            ResourceIdentifier workloadNetworkResourceId = WorkloadNetworkResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, privateCloudName);
            WorkloadNetworkResource workloadNetwork = client.GetWorkloadNetworkResource(workloadNetworkResourceId);

            // get the collection of this WorkloadNetworkPublicIPResource
            WorkloadNetworkPublicIPCollection collection = workloadNetwork.GetWorkloadNetworkPublicIPs();

            // invoke the operation
            string publicIPId = "publicIP1";
            WorkloadNetworkPublicIPResource result = await collection.GetAsync(publicIPId);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            WorkloadNetworkPublicIPData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_WorkloadNetworksListPublicIPs()
        {
            // Generated from example definition: 2024-09-01/WorkloadNetworks_ListPublicIPs.json
            // this example is just showing the usage of "WorkloadNetworkPublicIP_ListPublicIPs" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WorkloadNetworkResource created on azure
            // for more information of creating WorkloadNetworkResource, please refer to the document of WorkloadNetworkResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "group1";
            string privateCloudName = "cloud1";
            ResourceIdentifier workloadNetworkResourceId = WorkloadNetworkResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, privateCloudName);
            WorkloadNetworkResource workloadNetwork = client.GetWorkloadNetworkResource(workloadNetworkResourceId);

            // get the collection of this WorkloadNetworkPublicIPResource
            WorkloadNetworkPublicIPCollection collection = workloadNetwork.GetWorkloadNetworkPublicIPs();

            // invoke the operation and iterate over the result
            await foreach (WorkloadNetworkPublicIPResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                WorkloadNetworkPublicIPData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_WorkloadNetworksGetPublicIP()
        {
            // Generated from example definition: 2024-09-01/WorkloadNetworks_GetPublicIP.json
            // this example is just showing the usage of "WorkloadNetworkPublicIP_GetPublicIP" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WorkloadNetworkResource created on azure
            // for more information of creating WorkloadNetworkResource, please refer to the document of WorkloadNetworkResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "group1";
            string privateCloudName = "cloud1";
            ResourceIdentifier workloadNetworkResourceId = WorkloadNetworkResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, privateCloudName);
            WorkloadNetworkResource workloadNetwork = client.GetWorkloadNetworkResource(workloadNetworkResourceId);

            // get the collection of this WorkloadNetworkPublicIPResource
            WorkloadNetworkPublicIPCollection collection = workloadNetwork.GetWorkloadNetworkPublicIPs();

            // invoke the operation
            string publicIPId = "publicIP1";
            bool result = await collection.ExistsAsync(publicIPId);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_WorkloadNetworksGetPublicIP()
        {
            // Generated from example definition: 2024-09-01/WorkloadNetworks_GetPublicIP.json
            // this example is just showing the usage of "WorkloadNetworkPublicIP_GetPublicIP" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WorkloadNetworkResource created on azure
            // for more information of creating WorkloadNetworkResource, please refer to the document of WorkloadNetworkResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "group1";
            string privateCloudName = "cloud1";
            ResourceIdentifier workloadNetworkResourceId = WorkloadNetworkResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, privateCloudName);
            WorkloadNetworkResource workloadNetwork = client.GetWorkloadNetworkResource(workloadNetworkResourceId);

            // get the collection of this WorkloadNetworkPublicIPResource
            WorkloadNetworkPublicIPCollection collection = workloadNetwork.GetWorkloadNetworkPublicIPs();

            // invoke the operation
            string publicIPId = "publicIP1";
            NullableResponse<WorkloadNetworkPublicIPResource> response = await collection.GetIfExistsAsync(publicIPId);
            WorkloadNetworkPublicIPResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                WorkloadNetworkPublicIPData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
