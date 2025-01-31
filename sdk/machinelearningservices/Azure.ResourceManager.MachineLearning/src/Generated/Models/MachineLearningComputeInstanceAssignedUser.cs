// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> A user that can be assigned to a compute instance. </summary>
    public partial class MachineLearningComputeInstanceAssignedUser
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

        /// <summary> Initializes a new instance of <see cref="MachineLearningComputeInstanceAssignedUser"/>. </summary>
        /// <param name="objectId"> User’s AAD Object Id. </param>
        /// <param name="tenantId"> User’s AAD Tenant Id. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="objectId"/> is null. </exception>
        public MachineLearningComputeInstanceAssignedUser(string objectId, Guid tenantId)
        {
            if (objectId == null)
            {
                throw new ArgumentNullException(nameof(objectId));
            }

            ObjectId = objectId;
            TenantId = tenantId;
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningComputeInstanceAssignedUser"/>. </summary>
        /// <param name="objectId"> User’s AAD Object Id. </param>
        /// <param name="tenantId"> User’s AAD Tenant Id. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MachineLearningComputeInstanceAssignedUser(string objectId, Guid tenantId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ObjectId = objectId;
            TenantId = tenantId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningComputeInstanceAssignedUser"/> for deserialization. </summary>
        internal MachineLearningComputeInstanceAssignedUser()
        {
        }

        /// <summary> User’s AAD Object Id. </summary>
        public string ObjectId { get; set; }
        /// <summary> User’s AAD Tenant Id. </summary>
        public Guid TenantId { get; set; }
    }
}
