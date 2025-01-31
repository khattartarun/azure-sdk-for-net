// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DesktopVirtualization.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DesktopVirtualization
{
    public partial class SessionHostData : IUtf8JsonSerializable, IJsonModel<SessionHostData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SessionHostData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SessionHostData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SessionHostData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SessionHostData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && SystemData != null)
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && ObjectId != null)
            {
                writer.WritePropertyName("objectId"u8);
                writer.WriteStringValue(ObjectId);
            }
            if (LastHeartBeatOn.HasValue)
            {
                writer.WritePropertyName("lastHeartBeat"u8);
                writer.WriteStringValue(LastHeartBeatOn.Value, "O");
            }
            if (Sessions.HasValue)
            {
                writer.WritePropertyName("sessions"u8);
                writer.WriteNumberValue(Sessions.Value);
            }
            if (AgentVersion != null)
            {
                writer.WritePropertyName("agentVersion"u8);
                writer.WriteStringValue(AgentVersion);
            }
            if (AllowNewSession.HasValue)
            {
                writer.WritePropertyName("allowNewSession"u8);
                writer.WriteBooleanValue(AllowNewSession.Value);
            }
            if (options.Format != "W" && VmId != null)
            {
                writer.WritePropertyName("virtualMachineId"u8);
                writer.WriteStringValue(VmId);
            }
            if (options.Format != "W" && ResourceId != null)
            {
                writer.WritePropertyName("resourceId"u8);
                writer.WriteStringValue(ResourceId);
            }
            if (AssignedUser != null)
            {
                writer.WritePropertyName("assignedUser"u8);
                writer.WriteStringValue(AssignedUser);
            }
            if (FriendlyName != null)
            {
                writer.WritePropertyName("friendlyName"u8);
                writer.WriteStringValue(FriendlyName);
            }
            if (Status.HasValue)
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (options.Format != "W" && StatusTimestamp.HasValue)
            {
                writer.WritePropertyName("statusTimestamp"u8);
                writer.WriteStringValue(StatusTimestamp.Value, "O");
            }
            if (OSVersion != null)
            {
                writer.WritePropertyName("osVersion"u8);
                writer.WriteStringValue(OSVersion);
            }
            if (SxsStackVersion != null)
            {
                writer.WritePropertyName("sxSStackVersion"u8);
                writer.WriteStringValue(SxsStackVersion);
            }
            if (UpdateState.HasValue)
            {
                writer.WritePropertyName("updateState"u8);
                writer.WriteStringValue(UpdateState.Value.ToString());
            }
            if (options.Format != "W" && LastUpdatedOn.HasValue)
            {
                writer.WritePropertyName("lastUpdateTime"u8);
                writer.WriteStringValue(LastUpdatedOn.Value, "O");
            }
            if (UpdateErrorMessage != null)
            {
                writer.WritePropertyName("updateErrorMessage"u8);
                writer.WriteStringValue(UpdateErrorMessage);
            }
            if (options.Format != "W" && !(SessionHostHealthCheckResults is ChangeTrackingList<SessionHostHealthCheckReport> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("sessionHostHealthCheckResults"u8);
                writer.WriteStartArray();
                foreach (var item in SessionHostHealthCheckResults)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        SessionHostData IJsonModel<SessionHostData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SessionHostData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SessionHostData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSessionHostData(document.RootElement, options);
        }

        internal static SessionHostData DeserializeSessionHostData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> objectId = default;
            Optional<DateTimeOffset> lastHeartBeat = default;
            Optional<int> sessions = default;
            Optional<string> agentVersion = default;
            Optional<bool> allowNewSession = default;
            Optional<string> virtualMachineId = default;
            Optional<ResourceIdentifier> resourceId = default;
            Optional<string> assignedUser = default;
            Optional<string> friendlyName = default;
            Optional<SessionHostStatus> status = default;
            Optional<DateTimeOffset> statusTimestamp = default;
            Optional<string> osVersion = default;
            Optional<string> sxsStackVersion = default;
            Optional<SessionHostUpdateState> updateState = default;
            Optional<DateTimeOffset> lastUpdateTime = default;
            Optional<string> updateErrorMessage = default;
            Optional<IReadOnlyList<SessionHostHealthCheckReport>> sessionHostHealthCheckResults = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("objectId"u8))
                        {
                            objectId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("lastHeartBeat"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastHeartBeat = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("sessions"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sessions = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("agentVersion"u8))
                        {
                            agentVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("allowNewSession"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            allowNewSession = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("virtualMachineId"u8))
                        {
                            virtualMachineId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("resourceId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            resourceId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("assignedUser"u8))
                        {
                            assignedUser = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("friendlyName"u8))
                        {
                            friendlyName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("status"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            status = new SessionHostStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("statusTimestamp"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            statusTimestamp = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("osVersion"u8))
                        {
                            osVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("sxSStackVersion"u8))
                        {
                            sxsStackVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("updateState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            updateState = new SessionHostUpdateState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("lastUpdateTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastUpdateTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("updateErrorMessage"u8))
                        {
                            updateErrorMessage = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("sessionHostHealthCheckResults"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<SessionHostHealthCheckReport> array = new List<SessionHostHealthCheckReport>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(SessionHostHealthCheckReport.DeserializeSessionHostHealthCheckReport(item, options));
                            }
                            sessionHostHealthCheckResults = array;
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SessionHostData(id, name, type, systemData.Value, objectId.Value, Optional.ToNullable(lastHeartBeat), Optional.ToNullable(sessions), agentVersion.Value, Optional.ToNullable(allowNewSession), virtualMachineId.Value, resourceId.Value, assignedUser.Value, friendlyName.Value, Optional.ToNullable(status), Optional.ToNullable(statusTimestamp), osVersion.Value, sxsStackVersion.Value, Optional.ToNullable(updateState), Optional.ToNullable(lastUpdateTime), updateErrorMessage.Value, Optional.ToList(sessionHostHealthCheckResults), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SessionHostData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SessionHostData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SessionHostData)} does not support '{options.Format}' format.");
            }
        }

        SessionHostData IPersistableModel<SessionHostData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SessionHostData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSessionHostData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SessionHostData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SessionHostData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
