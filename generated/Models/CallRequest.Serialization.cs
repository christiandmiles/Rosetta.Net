// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Rosetta.Models
{
    public partial class CallRequest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("network_identifier");
            writer.WriteObjectValue(NetworkIdentifier);
            writer.WritePropertyName("method");
            writer.WriteStringValue(Method);
            writer.WritePropertyName("parameters");
            writer.WriteObjectValue(Parameters);
            writer.WriteEndObject();
        }
    }
}
