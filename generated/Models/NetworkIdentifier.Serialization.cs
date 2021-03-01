// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Rosetta.Models
{
    public partial class NetworkIdentifier : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("blockchain");
            writer.WriteStringValue(Blockchain);
            writer.WritePropertyName("network");
            writer.WriteStringValue(Network);
            if (Optional.IsDefined(SubNetworkIdentifier))
            {
                writer.WritePropertyName("sub_network_identifier");
                writer.WriteObjectValue(SubNetworkIdentifier);
            }
            writer.WriteEndObject();
        }

        internal static NetworkIdentifier DeserializeNetworkIdentifier(JsonElement element)
        {
            string blockchain = default;
            string network = default;
            Optional<SubNetworkIdentifier> subNetworkIdentifier = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("blockchain"))
                {
                    blockchain = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("network"))
                {
                    network = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sub_network_identifier"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    subNetworkIdentifier = SubNetworkIdentifier.DeserializeSubNetworkIdentifier(property.Value);
                    continue;
                }
            }
            return new NetworkIdentifier(blockchain, network, subNetworkIdentifier.Value);
        }
    }
}
