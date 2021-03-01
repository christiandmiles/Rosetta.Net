// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Rosetta.Models
{
    public partial class BlockTransaction
    {
        internal static BlockTransaction DeserializeBlockTransaction(JsonElement element)
        {
            BlockIdentifier blockIdentifier = default;
            Transaction transaction = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("block_identifier"))
                {
                    blockIdentifier = BlockIdentifier.DeserializeBlockIdentifier(property.Value);
                    continue;
                }
                if (property.NameEquals("transaction"))
                {
                    transaction = Transaction.DeserializeTransaction(property.Value);
                    continue;
                }
            }
            return new BlockTransaction(blockIdentifier, transaction);
        }
    }
}