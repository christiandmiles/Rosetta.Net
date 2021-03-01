// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Rosetta.Models
{
    public partial class SubAccountIdentifier : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("address");
            writer.WriteStringValue(Address);
            if (Optional.IsDefined(Metadata))
            {
                writer.WritePropertyName("metadata");
                writer.WriteObjectValue(Metadata);
            }
            writer.WriteEndObject();
        }

        internal static SubAccountIdentifier DeserializeSubAccountIdentifier(JsonElement element)
        {
            string address = default;
            Optional<object> metadata = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("address"))
                {
                    address = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("metadata"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    metadata = property.Value.GetObject();
                    continue;
                }
            }
            return new SubAccountIdentifier(address, metadata.Value);
        }
    }
}
