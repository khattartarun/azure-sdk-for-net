// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Models
{
    /// <summary> Maintenance window properties of a server. </summary>
    public partial class PostgreSqlFlexibleServerMaintenanceWindow
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

        /// <summary> Initializes a new instance of <see cref="PostgreSqlFlexibleServerMaintenanceWindow"/>. </summary>
        public PostgreSqlFlexibleServerMaintenanceWindow()
        {
        }

        /// <summary> Initializes a new instance of <see cref="PostgreSqlFlexibleServerMaintenanceWindow"/>. </summary>
        /// <param name="customWindow"> indicates whether custom window is enabled or disabled. </param>
        /// <param name="startHour"> start hour for maintenance window. </param>
        /// <param name="startMinute"> start minute for maintenance window. </param>
        /// <param name="dayOfWeek"> day of week for maintenance window. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PostgreSqlFlexibleServerMaintenanceWindow(string customWindow, int? startHour, int? startMinute, int? dayOfWeek, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            CustomWindow = customWindow;
            StartHour = startHour;
            StartMinute = startMinute;
            DayOfWeek = dayOfWeek;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> indicates whether custom window is enabled or disabled. </summary>
        public string CustomWindow { get; set; }
        /// <summary> start hour for maintenance window. </summary>
        public int? StartHour { get; set; }
        /// <summary> start minute for maintenance window. </summary>
        public int? StartMinute { get; set; }
        /// <summary> day of week for maintenance window. </summary>
        public int? DayOfWeek { get; set; }
    }
}
