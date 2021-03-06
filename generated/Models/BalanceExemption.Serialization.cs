// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Rosetta.Models
{
    public partial class BalanceExemption
    {
        internal static BalanceExemption DeserializeBalanceExemption(JsonElement element)
        {
            Optional<string> subAccountAddress = default;
            Optional<Currency> currency = default;
            Optional<ExemptionType> exemptionType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sub_account_address"))
                {
                    subAccountAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("currency"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    currency = Currency.DeserializeCurrency(property.Value);
                    continue;
                }
                if (property.NameEquals("exemption_type"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    exemptionType = new ExemptionType(property.Value.GetString());
                    continue;
                }
            }
            return new BalanceExemption(subAccountAddress.Value, currency.Value, Optional.ToNullable(exemptionType));
        }
    }
}
