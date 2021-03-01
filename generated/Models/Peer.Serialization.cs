// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Rosetta.Models
{
    public partial class Peer
    {
        internal static Peer DeserializePeer(JsonElement element)
        {
            string peerId = default;
            Optional<object> metadata = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("peer_id"))
                {
                    peerId = property.Value.GetString();
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
            return new Peer(peerId, metadata.Value);
        }
    }
}