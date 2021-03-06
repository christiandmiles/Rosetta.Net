// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Rosetta.Models
{
    /// <summary> Allow specifies supported Operation status, Operation types, and all possible error statuses. This Allow object is used by clients to validate the correctness of a Rosetta Server implementation. It is expected that these clients will error if they receive some response that contains any of the above information that is not specified here. </summary>
    public partial class Allow
    {
        /// <summary> Initializes a new instance of Allow. </summary>
        /// <param name="operationStatuses"> All Operation.Status this implementation supports. Any status that is returned during parsing that is not listed here will cause client validation to error. </param>
        /// <param name="operationTypes"> All Operation.Type this implementation supports. Any type that is returned during parsing that is not listed here will cause client validation to error. </param>
        /// <param name="errors"> All Errors that this implementation could return. Any error that is returned during parsing that is not listed here will cause client validation to error. </param>
        /// <param name="historicalBalanceLookup"> Any Rosetta implementation that supports querying the balance of an account at any height in the past should set this to true. </param>
        /// <param name="callMethods"> All methods that are supported by the /call endpoint. Communicating which parameters should be provided to /call is the responsibility of the implementer (this is en lieu of defining an entire type system and requiring the implementer to define that in Allow). </param>
        /// <param name="balanceExemptions"> BalanceExemptions is an array of BalanceExemption indicating which account balances could change without a corresponding Operation. BalanceExemptions should be used sparingly as they may introduce significant complexity for integrators that attempt to reconcile all account balance changes. If your implementation relies on any BalanceExemptions, you MUST implement historical balance lookup (the ability to query an account balance at any BlockIdentifier). </param>
        /// <param name="mempoolCoins"> Any Rosetta implementation that can update an AccountIdentifier&apos;s unspent coins based on the contents of the mempool should populate this field as true. If false, requests to `/account/coins` that set `include_mempool` as true will be automatically rejected. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="operationStatuses"/>, <paramref name="operationTypes"/>, <paramref name="errors"/>, <paramref name="callMethods"/>, or <paramref name="balanceExemptions"/> is null. </exception>
        internal Allow(IEnumerable<OperationStatus> operationStatuses, IEnumerable<string> operationTypes, IEnumerable<Error> errors, bool historicalBalanceLookup, IEnumerable<string> callMethods, IEnumerable<BalanceExemption> balanceExemptions, bool mempoolCoins)
        {
            if (operationStatuses == null)
            {
                throw new ArgumentNullException(nameof(operationStatuses));
            }
            if (operationTypes == null)
            {
                throw new ArgumentNullException(nameof(operationTypes));
            }
            if (errors == null)
            {
                throw new ArgumentNullException(nameof(errors));
            }
            if (callMethods == null)
            {
                throw new ArgumentNullException(nameof(callMethods));
            }
            if (balanceExemptions == null)
            {
                throw new ArgumentNullException(nameof(balanceExemptions));
            }

            OperationStatuses = operationStatuses.ToList();
            OperationTypes = operationTypes.ToList();
            Errors = errors.ToList();
            HistoricalBalanceLookup = historicalBalanceLookup;
            CallMethods = callMethods.ToList();
            BalanceExemptions = balanceExemptions.ToList();
            MempoolCoins = mempoolCoins;
        }

        /// <summary> Initializes a new instance of Allow. </summary>
        /// <param name="operationStatuses"> All Operation.Status this implementation supports. Any status that is returned during parsing that is not listed here will cause client validation to error. </param>
        /// <param name="operationTypes"> All Operation.Type this implementation supports. Any type that is returned during parsing that is not listed here will cause client validation to error. </param>
        /// <param name="errors"> All Errors that this implementation could return. Any error that is returned during parsing that is not listed here will cause client validation to error. </param>
        /// <param name="historicalBalanceLookup"> Any Rosetta implementation that supports querying the balance of an account at any height in the past should set this to true. </param>
        /// <param name="timestampStartIndex"> If populated, `timestamp_start_index` indicates the first block index where block timestamps are considered valid (i.e. all blocks less than `timestamp_start_index` could have invalid timestamps). This is useful when the genesis block (or blocks) of a network have timestamp 0. If not populated, block timestamps are assumed to be valid for all available blocks. </param>
        /// <param name="callMethods"> All methods that are supported by the /call endpoint. Communicating which parameters should be provided to /call is the responsibility of the implementer (this is en lieu of defining an entire type system and requiring the implementer to define that in Allow). </param>
        /// <param name="balanceExemptions"> BalanceExemptions is an array of BalanceExemption indicating which account balances could change without a corresponding Operation. BalanceExemptions should be used sparingly as they may introduce significant complexity for integrators that attempt to reconcile all account balance changes. If your implementation relies on any BalanceExemptions, you MUST implement historical balance lookup (the ability to query an account balance at any BlockIdentifier). </param>
        /// <param name="mempoolCoins"> Any Rosetta implementation that can update an AccountIdentifier&apos;s unspent coins based on the contents of the mempool should populate this field as true. If false, requests to `/account/coins` that set `include_mempool` as true will be automatically rejected. </param>
        internal Allow(IReadOnlyList<OperationStatus> operationStatuses, IReadOnlyList<string> operationTypes, IReadOnlyList<Error> errors, bool historicalBalanceLookup, long? timestampStartIndex, IReadOnlyList<string> callMethods, IReadOnlyList<BalanceExemption> balanceExemptions, bool mempoolCoins)
        {
            OperationStatuses = operationStatuses;
            OperationTypes = operationTypes;
            Errors = errors;
            HistoricalBalanceLookup = historicalBalanceLookup;
            TimestampStartIndex = timestampStartIndex;
            CallMethods = callMethods;
            BalanceExemptions = balanceExemptions;
            MempoolCoins = mempoolCoins;
        }

        /// <summary> All Operation.Status this implementation supports. Any status that is returned during parsing that is not listed here will cause client validation to error. </summary>
        public IReadOnlyList<OperationStatus> OperationStatuses { get; }
        /// <summary> All Operation.Type this implementation supports. Any type that is returned during parsing that is not listed here will cause client validation to error. </summary>
        public IReadOnlyList<string> OperationTypes { get; }
        /// <summary> All Errors that this implementation could return. Any error that is returned during parsing that is not listed here will cause client validation to error. </summary>
        public IReadOnlyList<Error> Errors { get; }
        /// <summary> Any Rosetta implementation that supports querying the balance of an account at any height in the past should set this to true. </summary>
        public bool HistoricalBalanceLookup { get; }
        /// <summary> If populated, `timestamp_start_index` indicates the first block index where block timestamps are considered valid (i.e. all blocks less than `timestamp_start_index` could have invalid timestamps). This is useful when the genesis block (or blocks) of a network have timestamp 0. If not populated, block timestamps are assumed to be valid for all available blocks. </summary>
        public long? TimestampStartIndex { get; }
        /// <summary> All methods that are supported by the /call endpoint. Communicating which parameters should be provided to /call is the responsibility of the implementer (this is en lieu of defining an entire type system and requiring the implementer to define that in Allow). </summary>
        public IReadOnlyList<string> CallMethods { get; }
        /// <summary> BalanceExemptions is an array of BalanceExemption indicating which account balances could change without a corresponding Operation. BalanceExemptions should be used sparingly as they may introduce significant complexity for integrators that attempt to reconcile all account balance changes. If your implementation relies on any BalanceExemptions, you MUST implement historical balance lookup (the ability to query an account balance at any BlockIdentifier). </summary>
        public IReadOnlyList<BalanceExemption> BalanceExemptions { get; }
        /// <summary> Any Rosetta implementation that can update an AccountIdentifier&apos;s unspent coins based on the contents of the mempool should populate this field as true. If false, requests to `/account/coins` that set `include_mempool` as true will be automatically rejected. </summary>
        public bool MempoolCoins { get; }
    }
}
