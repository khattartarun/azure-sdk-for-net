// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network
{
    public partial class FirewallPolicyData : IUtf8JsonSerializable, IJsonModel<FirewallPolicyData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FirewallPolicyData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<FirewallPolicyData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FirewallPolicyData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FirewallPolicyData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && ETag.HasValue)
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            if (Identity != null)
            {
                writer.WritePropertyName("identity"u8);
                JsonSerializer.Serialize(writer, Identity);
            }
            if (Id != null)
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W" && Name != null)
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W" && ResourceType.HasValue)
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType.Value);
            }
            if (Location.HasValue)
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location.Value);
            }
            if (!(Tags is ChangeTrackingDictionary<string, string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Size != null)
            {
                writer.WritePropertyName("size"u8);
                writer.WriteStringValue(Size);
            }
            if (options.Format != "W" && !(RuleCollectionGroups is ChangeTrackingList<WritableSubResource> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("ruleCollectionGroups"u8);
                writer.WriteStartArray();
                foreach (var item in RuleCollectionGroups)
                {
                    JsonSerializer.Serialize(writer, item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && ProvisioningState.HasValue)
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (BasePolicy != null)
            {
                writer.WritePropertyName("basePolicy"u8);
                JsonSerializer.Serialize(writer, BasePolicy);
            }
            if (options.Format != "W" && !(Firewalls is ChangeTrackingList<WritableSubResource> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("firewalls"u8);
                writer.WriteStartArray();
                foreach (var item in Firewalls)
                {
                    JsonSerializer.Serialize(writer, item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && !(ChildPolicies is ChangeTrackingList<WritableSubResource> collection2 && collection2.IsUndefined))
            {
                writer.WritePropertyName("childPolicies"u8);
                writer.WriteStartArray();
                foreach (var item in ChildPolicies)
                {
                    JsonSerializer.Serialize(writer, item);
                }
                writer.WriteEndArray();
            }
            if (ThreatIntelMode.HasValue)
            {
                writer.WritePropertyName("threatIntelMode"u8);
                writer.WriteStringValue(ThreatIntelMode.Value.ToString());
            }
            if (ThreatIntelWhitelist != null)
            {
                writer.WritePropertyName("threatIntelWhitelist"u8);
                writer.WriteObjectValue(ThreatIntelWhitelist);
            }
            if (Insights != null)
            {
                writer.WritePropertyName("insights"u8);
                writer.WriteObjectValue(Insights);
            }
            if (Snat != null)
            {
                writer.WritePropertyName("snat"u8);
                writer.WriteObjectValue(Snat);
            }
            if (Sql != null)
            {
                writer.WritePropertyName("sql"u8);
                writer.WriteObjectValue(Sql);
            }
            if (DnsSettings != null)
            {
                writer.WritePropertyName("dnsSettings"u8);
                writer.WriteObjectValue(DnsSettings);
            }
            if (ExplicitProxy != null)
            {
                writer.WritePropertyName("explicitProxy"u8);
                writer.WriteObjectValue(ExplicitProxy);
            }
            if (IntrusionDetection != null)
            {
                writer.WritePropertyName("intrusionDetection"u8);
                writer.WriteObjectValue(IntrusionDetection);
            }
            if (TransportSecurity != null)
            {
                writer.WritePropertyName("transportSecurity"u8);
                writer.WriteObjectValue(TransportSecurity);
            }
            if (Sku != null)
            {
                writer.WritePropertyName("sku"u8);
                writer.WriteObjectValue(Sku);
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

        FirewallPolicyData IJsonModel<FirewallPolicyData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FirewallPolicyData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FirewallPolicyData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFirewallPolicyData(document.RootElement, options);
        }

        internal static FirewallPolicyData DeserializeFirewallPolicyData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ETag> etag = default;
            Optional<ManagedServiceIdentity> identity = default;
            Optional<ResourceIdentifier> id = default;
            Optional<string> name = default;
            Optional<ResourceType> type = default;
            Optional<AzureLocation> location = default;
            Optional<IDictionary<string, string>> tags = default;
            Optional<string> size = default;
            Optional<IReadOnlyList<WritableSubResource>> ruleCollectionGroups = default;
            Optional<NetworkProvisioningState> provisioningState = default;
            Optional<WritableSubResource> basePolicy = default;
            Optional<IReadOnlyList<WritableSubResource>> firewalls = default;
            Optional<IReadOnlyList<WritableSubResource>> childPolicies = default;
            Optional<AzureFirewallThreatIntelMode> threatIntelMode = default;
            Optional<FirewallPolicyThreatIntelWhitelist> threatIntelWhitelist = default;
            Optional<FirewallPolicyInsights> insights = default;
            Optional<FirewallPolicySnat> snat = default;
            Optional<FirewallPolicySQL> sql = default;
            Optional<DnsSettings> dnsSettings = default;
            Optional<FirewallPolicyExplicitProxy> explicitProxy = default;
            Optional<FirewallPolicyIntrusionDetection> intrusionDetection = default;
            Optional<FirewallPolicyTransportSecurity> transportSecurity = default;
            Optional<FirewallPolicySku> sku = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identity = JsonSerializer.Deserialize<ManagedServiceIdentity>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
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
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tags"u8))
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
                    tags = dictionary;
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
                        if (property0.NameEquals("size"u8))
                        {
                            size = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("ruleCollectionGroups"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<WritableSubResource> array = new List<WritableSubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(JsonSerializer.Deserialize<WritableSubResource>(item.GetRawText()));
                            }
                            ruleCollectionGroups = array;
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new NetworkProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("basePolicy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            basePolicy = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("firewalls"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<WritableSubResource> array = new List<WritableSubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(JsonSerializer.Deserialize<WritableSubResource>(item.GetRawText()));
                            }
                            firewalls = array;
                            continue;
                        }
                        if (property0.NameEquals("childPolicies"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<WritableSubResource> array = new List<WritableSubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(JsonSerializer.Deserialize<WritableSubResource>(item.GetRawText()));
                            }
                            childPolicies = array;
                            continue;
                        }
                        if (property0.NameEquals("threatIntelMode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            threatIntelMode = new AzureFirewallThreatIntelMode(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("threatIntelWhitelist"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            threatIntelWhitelist = FirewallPolicyThreatIntelWhitelist.DeserializeFirewallPolicyThreatIntelWhitelist(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("insights"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            insights = FirewallPolicyInsights.DeserializeFirewallPolicyInsights(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("snat"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            snat = FirewallPolicySnat.DeserializeFirewallPolicySnat(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("sql"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sql = FirewallPolicySQL.DeserializeFirewallPolicySQL(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("dnsSettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            dnsSettings = DnsSettings.DeserializeDnsSettings(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("explicitProxy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            explicitProxy = FirewallPolicyExplicitProxy.DeserializeFirewallPolicyExplicitProxy(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("intrusionDetection"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            intrusionDetection = FirewallPolicyIntrusionDetection.DeserializeFirewallPolicyIntrusionDetection(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("transportSecurity"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            transportSecurity = FirewallPolicyTransportSecurity.DeserializeFirewallPolicyTransportSecurity(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("sku"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sku = FirewallPolicySku.DeserializeFirewallPolicySku(property0.Value, options);
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
            return new FirewallPolicyData(id.Value, name.Value, Optional.ToNullable(type), Optional.ToNullable(location), Optional.ToDictionary(tags), serializedAdditionalRawData, Optional.ToNullable(etag), identity, size.Value, Optional.ToList(ruleCollectionGroups), Optional.ToNullable(provisioningState), basePolicy, Optional.ToList(firewalls), Optional.ToList(childPolicies), Optional.ToNullable(threatIntelMode), threatIntelWhitelist.Value, insights.Value, snat.Value, sql.Value, dnsSettings.Value, explicitProxy.Value, intrusionDetection.Value, transportSecurity.Value, sku.Value);
        }

        BinaryData IPersistableModel<FirewallPolicyData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FirewallPolicyData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(FirewallPolicyData)} does not support '{options.Format}' format.");
            }
        }

        FirewallPolicyData IPersistableModel<FirewallPolicyData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FirewallPolicyData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeFirewallPolicyData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FirewallPolicyData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<FirewallPolicyData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
