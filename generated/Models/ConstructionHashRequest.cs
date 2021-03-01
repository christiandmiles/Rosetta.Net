// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Rosetta.Models
{
    /// <summary> ConstructionHashRequest is the input to the `/construction/hash` endpoint. </summary>
    public partial class ConstructionHashRequest
    {
        /// <summary> Initializes a new instance of ConstructionHashRequest. </summary>
        /// <param name="networkIdentifier"> The network_identifier specifies which network a particular object is associated with. </param>
        /// <param name="signedTransaction"> . </param>
        /// <exception cref="ArgumentNullException"> <paramref name="networkIdentifier"/> or <paramref name="signedTransaction"/> is null. </exception>
        public ConstructionHashRequest(NetworkIdentifier networkIdentifier, string signedTransaction)
        {
            if (networkIdentifier == null)
            {
                throw new ArgumentNullException(nameof(networkIdentifier));
            }
            if (signedTransaction == null)
            {
                throw new ArgumentNullException(nameof(signedTransaction));
            }

            NetworkIdentifier = networkIdentifier;
            SignedTransaction = signedTransaction;
        }

        /// <summary> The network_identifier specifies which network a particular object is associated with. </summary>
        public NetworkIdentifier NetworkIdentifier { get; }
        public string SignedTransaction { get; }
    }
}
