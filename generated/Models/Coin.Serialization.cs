// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Rosetta.Models
{
    public partial class Coin
    {
        internal static Coin DeserializeCoin(JsonElement element)
        {
            CoinIdentifier coinIdentifier = default;
            Amount amount = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("coin_identifier"))
                {
                    coinIdentifier = CoinIdentifier.DeserializeCoinIdentifier(property.Value);
                    continue;
                }
                if (property.NameEquals("amount"))
                {
                    amount = Amount.DeserializeAmount(property.Value);
                    continue;
                }
            }
            return new Coin(coinIdentifier, amount);
        }
    }
}
