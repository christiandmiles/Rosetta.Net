// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Rosetta.Models
{
    public partial class ConstructionCombineResponse
    {
        internal static ConstructionCombineResponse DeserializeConstructionCombineResponse(JsonElement element)
        {
            string signedTransaction = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("signed_transaction"))
                {
                    signedTransaction = property.Value.GetString();
                    continue;
                }
            }
            return new ConstructionCombineResponse(signedTransaction);
        }
    }
}
