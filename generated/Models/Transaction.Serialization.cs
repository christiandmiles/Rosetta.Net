// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Rosetta.Models
{
    public partial class Transaction
    {
        internal static Transaction DeserializeTransaction(JsonElement element)
        {
            TransactionIdentifier transactionIdentifier = default;
            IReadOnlyList<Operation> operations = default;
            Optional<IReadOnlyList<RelatedTransaction>> relatedTransactions = default;
            Optional<object> metadata = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("transaction_identifier"))
                {
                    transactionIdentifier = TransactionIdentifier.DeserializeTransactionIdentifier(property.Value);
                    continue;
                }
                if (property.NameEquals("operations"))
                {
                    List<Operation> array = new List<Operation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Operation.DeserializeOperation(item));
                    }
                    operations = array;
                    continue;
                }
                if (property.NameEquals("related_transactions"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<RelatedTransaction> array = new List<RelatedTransaction>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RelatedTransaction.DeserializeRelatedTransaction(item));
                    }
                    relatedTransactions = array;
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
            return new Transaction(transactionIdentifier, operations, Optional.ToList(relatedTransactions), metadata.Value);
        }
    }
}