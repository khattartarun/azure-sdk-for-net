// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Messaging.EventGrid.Models
{
    internal partial class CloudEventInternal : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("id"u8);
            writer.WriteStringValue(Id);
            writer.WritePropertyName("source"u8);
            writer.WriteStringValue(Source);
            if (Data.ValueKind != JsonValueKind.Undefined)
            {
                writer.WritePropertyName("data"u8);
                Data.WriteTo(writer);
            }
            if (DataBase64 != null)
            {
                writer.WritePropertyName("data_base64"u8);
                writer.WriteBase64StringValue(DataBase64, "D");
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type);
            if (Time.HasValue)
            {
                writer.WritePropertyName("time"u8);
                writer.WriteStringValue(Time.Value, "O");
            }
            writer.WritePropertyName("specversion"u8);
            writer.WriteStringValue(Specversion);
            if (Dataschema != null)
            {
                writer.WritePropertyName("dataschema"u8);
                writer.WriteStringValue(Dataschema);
            }
            if (Datacontenttype != null)
            {
                writer.WritePropertyName("datacontenttype"u8);
                writer.WriteStringValue(Datacontenttype);
            }
            if (Subject != null)
            {
                writer.WritePropertyName("subject"u8);
                writer.WriteStringValue(Subject);
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }
    }
}
