// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Rosetta.Models
{
    /// <summary> BlockTransaction contains a populated Transaction and the BlockIdentifier that contains it. </summary>
    public partial class BlockTransaction
    {
        /// <summary> Initializes a new instance of BlockTransaction. </summary>
        /// <param name="blockIdentifier"> The block_identifier uniquely identifies a block in a particular network. </param>
        /// <param name="transaction"> Transactions contain an array of Operations that are attributable to the same TransactionIdentifier. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="blockIdentifier"/> or <paramref name="transaction"/> is null. </exception>
        internal BlockTransaction(BlockIdentifier blockIdentifier, Transaction transaction)
        {
            if (blockIdentifier == null)
            {
                throw new ArgumentNullException(nameof(blockIdentifier));
            }
            if (transaction == null)
            {
                throw new ArgumentNullException(nameof(transaction));
            }

            BlockIdentifier = blockIdentifier;
            Transaction = transaction;
        }

        /// <summary> The block_identifier uniquely identifies a block in a particular network. </summary>
        public BlockIdentifier BlockIdentifier { get; }
        /// <summary> Transactions contain an array of Operations that are attributable to the same TransactionIdentifier. </summary>
        public Transaction Transaction { get; }
    }
}
