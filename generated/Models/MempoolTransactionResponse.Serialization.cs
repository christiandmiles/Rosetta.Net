// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Rosetta.Models
{
    public partial class MempoolTransactionResponse
    {
        internal static MempoolTransactionResponse DeserializeMempoolTransactionResponse(JsonElement element)
        {
            Transaction transaction = default;
            Optional<object> metadata = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("transaction"))
                {
                    transaction = Transaction.DeserializeTransaction(property.Value);
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
            return new MempoolTransactionResponse(transaction, metadata.Value);
        }
    }
}
