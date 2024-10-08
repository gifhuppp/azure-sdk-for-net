// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> The parameters required to execute an expand operation on the given bookmark. </summary>
    public partial class BookmarkExpandContent
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

        /// <summary> Initializes a new instance of <see cref="BookmarkExpandContent"/>. </summary>
        public BookmarkExpandContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="BookmarkExpandContent"/>. </summary>
        /// <param name="endOn"> The end date filter, so the only expansion results returned are before this date. </param>
        /// <param name="expansionId"> The Id of the expansion to perform. </param>
        /// <param name="startOn"> The start date filter, so the only expansion results returned are after this date. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BookmarkExpandContent(DateTimeOffset? endOn, Guid? expansionId, DateTimeOffset? startOn, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            EndOn = endOn;
            ExpansionId = expansionId;
            StartOn = startOn;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The end date filter, so the only expansion results returned are before this date. </summary>
        [WirePath("endTime")]
        public DateTimeOffset? EndOn { get; set; }
        /// <summary> The Id of the expansion to perform. </summary>
        [WirePath("expansionId")]
        public Guid? ExpansionId { get; set; }
        /// <summary> The start date filter, so the only expansion results returned are after this date. </summary>
        [WirePath("startTime")]
        public DateTimeOffset? StartOn { get; set; }
    }
}
