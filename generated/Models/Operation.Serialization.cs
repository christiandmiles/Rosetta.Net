// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Rosetta.Models
{
    public partial class Operation : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("operation_identifier");
            writer.WriteObjectValue(OperationIdentifier);
            if (Optional.IsCollectionDefined(RelatedOperations))
            {
                writer.WritePropertyName("related_operations");
                writer.WriteStartArray();
                foreach (var item in RelatedOperations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("type");
            writer.WriteStringValue(Type);
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status");
                writer.WriteStringValue(Status);
            }
            if (Optional.IsDefined(Account))
            {
                writer.WritePropertyName("account");
                writer.WriteObjectValue(Account);
            }
            if (Optional.IsDefined(Amount))
            {
                writer.WritePropertyName("amount");
                writer.WriteObjectValue(Amount);
            }
            if (Optional.IsDefined(CoinChange))
            {
                writer.WritePropertyName("coin_change");
                writer.WriteObjectValue(CoinChange);
            }
            if (Optional.IsDefined(Metadata))
            {
                writer.WritePropertyName("metadata");
                writer.WriteObjectValue(Metadata);
            }
            writer.WriteEndObject();
        }

        internal static Operation DeserializeOperation(JsonElement element)
        {
            OperationIdentifier operationIdentifier = default;
            Optional<IList<OperationIdentifier>> relatedOperations = default;
            string type = default;
            Optional<string> status = default;
            Optional<AccountIdentifier> account = default;
            Optional<Amount> amount = default;
            Optional<CoinChange> coinChange = default;
            Optional<object> metadata = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("operation_identifier"))
                {
                    operationIdentifier = OperationIdentifier.DeserializeOperationIdentifier(property.Value);
                    continue;
                }
                if (property.NameEquals("related_operations"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<OperationIdentifier> array = new List<OperationIdentifier>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(OperationIdentifier.DeserializeOperationIdentifier(item));
                    }
                    relatedOperations = array;
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("account"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    account = AccountIdentifier.DeserializeAccountIdentifier(property.Value);
                    continue;
                }
                if (property.NameEquals("amount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    amount = Amount.DeserializeAmount(property.Value);
                    continue;
                }
                if (property.NameEquals("coin_change"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    coinChange = CoinChange.DeserializeCoinChange(property.Value);
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
            return new Operation(operationIdentifier, Optional.ToList(relatedOperations), type, status.Value, account.Value, amount.Value, coinChange.Value, metadata.Value);
        }
    }
}
