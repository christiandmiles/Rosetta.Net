// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Rosetta.Models
{
    /// <summary> CoinActions are different state changes that a Coin can undergo. When a Coin is created, it is coin_created. When a Coin is spent, it is coin_spent. It is assumed that a single Coin cannot be created or spent more than once. </summary>
    public readonly partial struct CoinAction : IEquatable<CoinAction>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="CoinAction"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CoinAction(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CoinCreatedValue = "coin_created";
        private const string CoinSpentValue = "coin_spent";

        /// <summary> coin_created. </summary>
        public static CoinAction CoinCreated { get; } = new CoinAction(CoinCreatedValue);
        /// <summary> coin_spent. </summary>
        public static CoinAction CoinSpent { get; } = new CoinAction(CoinSpentValue);
        /// <summary> Determines if two <see cref="CoinAction"/> values are the same. </summary>
        public static bool operator ==(CoinAction left, CoinAction right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CoinAction"/> values are not the same. </summary>
        public static bool operator !=(CoinAction left, CoinAction right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="CoinAction"/>. </summary>
        public static implicit operator CoinAction(string value) => new CoinAction(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CoinAction other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CoinAction other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}