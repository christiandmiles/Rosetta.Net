// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Rosetta.Models
{
    /// <summary> ConstructionParseRequest is the input to the `/construction/parse` endpoint. It allows the caller to parse either an unsigned or signed transaction. </summary>
    public partial class ConstructionParseRequest
    {
        /// <summary> Initializes a new instance of ConstructionParseRequest. </summary>
        /// <param name="networkIdentifier"> The network_identifier specifies which network a particular object is associated with. </param>
        /// <param name="signed"> Signed is a boolean indicating whether the transaction is signed. </param>
        /// <param name="transaction"> This must be either the unsigned transaction blob returned by `/construction/payloads` or the signed transaction blob returned by `/construction/combine`. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="networkIdentifier"/> or <paramref name="transaction"/> is null. </exception>
        public ConstructionParseRequest(NetworkIdentifier networkIdentifier, bool signed, string transaction)
        {
            if (networkIdentifier == null)
            {
                throw new ArgumentNullException(nameof(networkIdentifier));
            }
            if (transaction == null)
            {
                throw new ArgumentNullException(nameof(transaction));
            }

            NetworkIdentifier = networkIdentifier;
            Signed = signed;
            Transaction = transaction;
        }

        /// <summary> The network_identifier specifies which network a particular object is associated with. </summary>
        public NetworkIdentifier NetworkIdentifier { get; }
        /// <summary> Signed is a boolean indicating whether the transaction is signed. </summary>
        public bool Signed { get; }
        /// <summary> This must be either the unsigned transaction blob returned by `/construction/payloads` or the signed transaction blob returned by `/construction/combine`. </summary>
        public string Transaction { get; }
    }
}
