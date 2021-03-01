// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Rosetta.Models
{
    /// <summary> TransactionIdentifierResponse contains the transaction_identifier of a transaction that was submitted to either `/construction/hash` or `/construction/submit`. </summary>
    public partial class TransactionIdentifierResponse
    {
        /// <summary> Initializes a new instance of TransactionIdentifierResponse. </summary>
        /// <param name="transactionIdentifier"> The transaction_identifier uniquely identifies a transaction in a particular network and block or in the mempool. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="transactionIdentifier"/> is null. </exception>
        internal TransactionIdentifierResponse(TransactionIdentifier transactionIdentifier)
        {
            if (transactionIdentifier == null)
            {
                throw new ArgumentNullException(nameof(transactionIdentifier));
            }

            TransactionIdentifier = transactionIdentifier;
        }

        /// <summary> Initializes a new instance of TransactionIdentifierResponse. </summary>
        /// <param name="transactionIdentifier"> The transaction_identifier uniquely identifies a transaction in a particular network and block or in the mempool. </param>
        /// <param name="metadata"> Any object. </param>
        internal TransactionIdentifierResponse(TransactionIdentifier transactionIdentifier, object metadata)
        {
            TransactionIdentifier = transactionIdentifier;
            Metadata = metadata;
        }

        /// <summary> The transaction_identifier uniquely identifies a transaction in a particular network and block or in the mempool. </summary>
        public TransactionIdentifier TransactionIdentifier { get; }
        /// <summary> Any object. </summary>
        public object Metadata { get; }
    }
}