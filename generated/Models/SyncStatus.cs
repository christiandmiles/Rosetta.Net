// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Rosetta.Models
{
    /// <summary> SyncStatus is used to provide additional context about an implementation&apos;s sync status. This object is often used by implementations to indicate healthiness when block data cannot be queried until some sync phase completes or cannot be determined by comparing the timestamp of the most recent block with the current time. </summary>
    public partial class SyncStatus
    {
        /// <summary> Initializes a new instance of SyncStatus. </summary>
        internal SyncStatus()
        {
        }

        /// <summary> Initializes a new instance of SyncStatus. </summary>
        /// <param name="currentIndex"> CurrentIndex is the index of the last synced block in the current stage. This is a separate field from current_block_identifier in NetworkStatusResponse because blocks with indices up to and including the current_index may not yet be queryable by the caller. To reiterate, all indices up to and including current_block_identifier in NetworkStatusResponse must be queryable via the /block endpoint (excluding indices less than oldest_block_identifier). </param>
        /// <param name="targetIndex"> TargetIndex is the index of the block that the implementation is attempting to sync to in the current stage. </param>
        /// <param name="stage"> Stage is the phase of the sync process. </param>
        /// <param name="synced"> sycned is a boolean that indicates if an implementation has synced up to the most recent block. If this field is not populated, the caller should rely on a traditional tip timestamp comparison to determine if an implementation is synced. This field is particularly useful for quiescent blockchains (blocks only produced when there are pending transactions). In these blockchains, the most recent block could have a timestamp far behind the current time but the node could be healthy and at tip. </param>
        internal SyncStatus(long? currentIndex, long? targetIndex, string stage, bool? synced)
        {
            CurrentIndex = currentIndex;
            TargetIndex = targetIndex;
            Stage = stage;
            Synced = synced;
        }

        /// <summary> CurrentIndex is the index of the last synced block in the current stage. This is a separate field from current_block_identifier in NetworkStatusResponse because blocks with indices up to and including the current_index may not yet be queryable by the caller. To reiterate, all indices up to and including current_block_identifier in NetworkStatusResponse must be queryable via the /block endpoint (excluding indices less than oldest_block_identifier). </summary>
        public long? CurrentIndex { get; }
        /// <summary> TargetIndex is the index of the block that the implementation is attempting to sync to in the current stage. </summary>
        public long? TargetIndex { get; }
        /// <summary> Stage is the phase of the sync process. </summary>
        public string Stage { get; }
        /// <summary> sycned is a boolean that indicates if an implementation has synced up to the most recent block. If this field is not populated, the caller should rely on a traditional tip timestamp comparison to determine if an implementation is synced. This field is particularly useful for quiescent blockchains (blocks only produced when there are pending transactions). In these blockchains, the most recent block could have a timestamp far behind the current time but the node could be healthy and at tip. </summary>
        public bool? Synced { get; }
    }
}
