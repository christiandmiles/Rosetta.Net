// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Rosetta.Models
{
    public partial class TransactionIdentifier : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("hash");
            writer.WriteStringValue(Hash);
            writer.WriteEndObject();
        }

        internal static TransactionIdentifier DeserializeTransactionIdentifier(JsonElement element)
        {
            string hash = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("hash"))
                {
                    hash = property.Value.GetString();
                    continue;
                }
            }
            return new TransactionIdentifier(hash);
        }
    }
}