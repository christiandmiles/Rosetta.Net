// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Rosetta.Models
{
    /// <summary> The operation_identifier uniquely identifies an operation within a transaction. </summary>
    public partial class OperationIdentifier
    {
        /// <summary> Initializes a new instance of OperationIdentifier. </summary>
        /// <param name="index"> The operation index is used to ensure each operation has a unique identifier within a transaction. This index is only relative to the transaction and NOT GLOBAL. The operations in each transaction should start from index 0. To clarify, there may not be any notion of an operation index in the blockchain being described. </param>
        public OperationIdentifier(long index)
        {
            Index = index;
        }

        /// <summary> Initializes a new instance of OperationIdentifier. </summary>
        /// <param name="index"> The operation index is used to ensure each operation has a unique identifier within a transaction. This index is only relative to the transaction and NOT GLOBAL. The operations in each transaction should start from index 0. To clarify, there may not be any notion of an operation index in the blockchain being described. </param>
        /// <param name="networkIndex"> Some blockchains specify an operation index that is essential for client use. For example, Bitcoin uses a network_index to identify which UTXO was used in a transaction. network_index should not be populated if there is no notion of an operation index in a blockchain (typically most account-based blockchains). </param>
        internal OperationIdentifier(long index, long? networkIndex)
        {
            Index = index;
            NetworkIndex = networkIndex;
        }

        /// <summary> The operation index is used to ensure each operation has a unique identifier within a transaction. This index is only relative to the transaction and NOT GLOBAL. The operations in each transaction should start from index 0. To clarify, there may not be any notion of an operation index in the blockchain being described. </summary>
        public long Index { get; set; }
        /// <summary> Some blockchains specify an operation index that is essential for client use. For example, Bitcoin uses a network_index to identify which UTXO was used in a transaction. network_index should not be populated if there is no notion of an operation index in a blockchain (typically most account-based blockchains). </summary>
        public long? NetworkIndex { get; set; }
    }
}