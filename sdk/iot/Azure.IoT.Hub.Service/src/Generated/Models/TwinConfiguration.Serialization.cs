// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.IoT.Hub.Service.Models
{
    public partial class TwinConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Id != null)
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (SchemaVersion != null)
            {
                writer.WritePropertyName("schemaVersion"u8);
                writer.WriteStringValue(SchemaVersion);
            }
            if (!(Labels is ChangeTrackingDictionary<string, string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("labels"u8);
                writer.WriteStartObject();
                foreach (var item in Labels)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Content != null)
            {
                writer.WritePropertyName("content"u8);
                writer.WriteObjectValue(Content);
            }
            if (TargetCondition != null)
            {
                writer.WritePropertyName("targetCondition"u8);
                writer.WriteStringValue(TargetCondition);
            }
            if (CreatedTimeUtc.HasValue)
            {
                writer.WritePropertyName("createdTimeUtc"u8);
                writer.WriteStringValue(CreatedTimeUtc.Value, "O");
            }
            if (LastUpdatedTimeUtc.HasValue)
            {
                writer.WritePropertyName("lastUpdatedTimeUtc"u8);
                writer.WriteStringValue(LastUpdatedTimeUtc.Value, "O");
            }
            if (Priority.HasValue)
            {
                writer.WritePropertyName("priority"u8);
                writer.WriteNumberValue(Priority.Value);
            }
            if (SystemMetrics != null)
            {
                writer.WritePropertyName("systemMetrics"u8);
                writer.WriteObjectValue(SystemMetrics);
            }
            if (Metrics != null)
            {
                writer.WritePropertyName("metrics"u8);
                writer.WriteObjectValue(Metrics);
            }
            if (Etag != null)
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(Etag);
            }
            writer.WriteEndObject();
        }

        internal static TwinConfiguration DeserializeTwinConfiguration(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> id = default;
            Optional<string> schemaVersion = default;
            Optional<IDictionary<string, string>> labels = default;
            Optional<ConfigurationContent> content = default;
            Optional<string> targetCondition = default;
            Optional<DateTimeOffset> createdTimeUtc = default;
            Optional<DateTimeOffset> lastUpdatedTimeUtc = default;
            Optional<int> priority = default;
            Optional<ConfigurationMetrics> systemMetrics = default;
            Optional<ConfigurationMetrics> metrics = default;
            Optional<string> etag = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("schemaVersion"u8))
                {
                    schemaVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("labels"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    labels = dictionary;
                    continue;
                }
                if (property.NameEquals("content"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    content = ConfigurationContent.DeserializeConfigurationContent(property.Value);
                    continue;
                }
                if (property.NameEquals("targetCondition"u8))
                {
                    targetCondition = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("createdTimeUtc"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    createdTimeUtc = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastUpdatedTimeUtc"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastUpdatedTimeUtc = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("priority"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    priority = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("systemMetrics"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemMetrics = ConfigurationMetrics.DeserializeConfigurationMetrics(property.Value);
                    continue;
                }
                if (property.NameEquals("metrics"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    metrics = ConfigurationMetrics.DeserializeConfigurationMetrics(property.Value);
                    continue;
                }
                if (property.NameEquals("etag"u8))
                {
                    etag = property.Value.GetString();
                    continue;
                }
            }
            return new TwinConfiguration(id.Value, schemaVersion.Value, Optional.ToDictionary(labels), content.Value, targetCondition.Value, Optional.ToNullable(createdTimeUtc), Optional.ToNullable(lastUpdatedTimeUtc), Optional.ToNullable(priority), systemMetrics.Value, metrics.Value, etag.Value);
        }
    }
}
