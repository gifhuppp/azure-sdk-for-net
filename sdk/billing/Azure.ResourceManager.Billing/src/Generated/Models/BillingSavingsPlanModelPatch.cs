// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Billing.Models
{
    /// <summary> Savings plan patch request. </summary>
    public partial class BillingSavingsPlanModelPatch
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="BillingSavingsPlanModelPatch"/>. </summary>
        public BillingSavingsPlanModelPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="BillingSavingsPlanModelPatch"/>. </summary>
        /// <param name="properties"> Savings plan patch request. </param>
        /// <param name="sku"> The SKU to be applied for this resource. </param>
        /// <param name="tags"> Tags for this reservation. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BillingSavingsPlanModelPatch(SavingsPlanUpdateRequestProperties properties, BillingSku sku, IDictionary<string, string> tags, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Properties = properties;
            Sku = sku;
            Tags = tags;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Savings plan patch request. </summary>
        [WirePath("properties")]
        public SavingsPlanUpdateRequestProperties Properties { get; set; }
        /// <summary> The SKU to be applied for this resource. </summary>
        internal BillingSku Sku { get; set; }
        /// <summary> Name of the SKU to be applied. </summary>
        [WirePath("sku.name")]
        public string SkuName
        {
            get => Sku is null ? default : Sku.Name;
            set
            {
                if (Sku is null)
                    Sku = new BillingSku();
                Sku.Name = value;
            }
        }

        /// <summary> Tags for this reservation. </summary>
        [WirePath("tags")]
        public IDictionary<string, string> Tags { get; }
    }
}
