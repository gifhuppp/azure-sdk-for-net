// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Communication.Models
{
    /// <summary> List of VerificationStatusRecord. </summary>
    public partial class DomainPropertiesVerificationStates
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

        /// <summary> Initializes a new instance of <see cref="DomainPropertiesVerificationStates"/>. </summary>
        internal DomainPropertiesVerificationStates()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DomainPropertiesVerificationStates"/>. </summary>
        /// <param name="domain"> A class that represents a VerificationStatus record. </param>
        /// <param name="spf"> A class that represents a VerificationStatus record. </param>
        /// <param name="dkim"> A class that represents a VerificationStatus record. </param>
        /// <param name="dkim2"> A class that represents a VerificationStatus record. </param>
        /// <param name="dmarc"> A class that represents a VerificationStatus record. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DomainPropertiesVerificationStates(DomainVerificationStatusRecord domain, DomainVerificationStatusRecord spf, DomainVerificationStatusRecord dkim, DomainVerificationStatusRecord dkim2, DomainVerificationStatusRecord dmarc, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Domain = domain;
            Spf = spf;
            Dkim = dkim;
            Dkim2 = dkim2;
            Dmarc = dmarc;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> A class that represents a VerificationStatus record. </summary>
        [WirePath("Domain")]
        public DomainVerificationStatusRecord Domain { get; }
        /// <summary> A class that represents a VerificationStatus record. </summary>
        [WirePath("SPF")]
        public DomainVerificationStatusRecord Spf { get; }
        /// <summary> A class that represents a VerificationStatus record. </summary>
        [WirePath("DKIM")]
        public DomainVerificationStatusRecord Dkim { get; }
        /// <summary> A class that represents a VerificationStatus record. </summary>
        [WirePath("DKIM2")]
        public DomainVerificationStatusRecord Dkim2 { get; }
        /// <summary> A class that represents a VerificationStatus record. </summary>
        [WirePath("DMARC")]
        public DomainVerificationStatusRecord Dmarc { get; }
    }
}
