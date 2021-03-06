// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Rosetta.Models
{
    public partial class PublicKey : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("hex_bytes");
            writer.WriteStringValue(HexBytes);
            writer.WritePropertyName("curve_type");
            writer.WriteStringValue(CurveType.ToString());
            writer.WriteEndObject();
        }
    }
}
