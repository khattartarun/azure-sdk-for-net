// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Xml;
using System.Xml.Linq;
using Azure.Core;

namespace Azure.Storage.Queues.Models
{
    public partial class QueueRetentionPolicy : IXmlSerializable
    {
        void IXmlSerializable.Write(XmlWriter writer, string nameHint)
        {
            writer.WriteStartElement(nameHint ?? "RetentionPolicy");
            writer.WriteStartElement("Enabled");
            writer.WriteValue(Enabled);
            writer.WriteEndElement();
            if (Days.HasValue)
            {
                writer.WriteStartElement("Days");
                writer.WriteValue(Days.Value);
                writer.WriteEndElement();
            }
            writer.WriteEndElement();
        }

        internal static QueueRetentionPolicy DeserializeQueueRetentionPolicy(XElement element)
        {
            bool enabled = default;
            int? days = default;
            if (element.Element("Enabled") is XElement enabledElement)
            {
                enabled = (bool)enabledElement;
            }
            if (element.Element("Days") is XElement daysElement)
            {
                days = (int?)daysElement;
            }
            return new QueueRetentionPolicy(enabled, days);
        }
    }
}
