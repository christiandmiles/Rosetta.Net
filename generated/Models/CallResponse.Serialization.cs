// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Rosetta.Models
{
    public partial class CallResponse
    {
        internal static CallResponse DeserializeCallResponse(JsonElement element)
        {
            object result = default;
            bool idempotent = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("result"))
                {
                    result = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("idempotent"))
                {
                    idempotent = property.Value.GetBoolean();
                    continue;
                }
            }
            return new CallResponse(result, idempotent);
        }
    }
}
