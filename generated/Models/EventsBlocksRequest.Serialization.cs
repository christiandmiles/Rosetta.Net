// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Rosetta.Models
{
    public partial class EventsBlocksRequest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("network_identifier");
            writer.WriteObjectValue(NetworkIdentifier);
            if (Optional.IsDefined(Offset))
            {
                writer.WritePropertyName("offset");
                writer.WriteNumberValue(Offset.Value);
            }
            if (Optional.IsDefined(Limit))
            {
                writer.WritePropertyName("limit");
                writer.WriteNumberValue(Limit.Value);
            }
            writer.WriteEndObject();
        }
    }
}
