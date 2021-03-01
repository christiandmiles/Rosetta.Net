// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Rosetta.Models
{
    public partial class MempoolResponse
    {
        internal static MempoolResponse DeserializeMempoolResponse(JsonElement element)
        {
            IReadOnlyList<TransactionIdentifier> transactionIdentifiers = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("transaction_identifiers"))
                {
                    List<TransactionIdentifier> array = new List<TransactionIdentifier>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TransactionIdentifier.DeserializeTransactionIdentifier(item));
                    }
                    transactionIdentifiers = array;
                    continue;
                }
            }
            return new MempoolResponse(transactionIdentifiers);
        }
    }
}
