// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Rosetta.Models
{
    public partial class OperationStatus
    {
        internal static OperationStatus DeserializeOperationStatus(JsonElement element)
        {
            string status = default;
            bool successful = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("successful"))
                {
                    successful = property.Value.GetBoolean();
                    continue;
                }
            }
            return new OperationStatus(status, successful);
        }
    }
}
