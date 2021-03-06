// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Rosetta.Models
{
    /// <summary> Operator is used by query-related endpoints to determine how to apply conditions. If this field is not populated, the default `and` value will be used. </summary>
    public readonly partial struct Operator : IEquatable<Operator>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="Operator"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public Operator(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string OrValue = "or";
        private const string AndValue = "and";

        /// <summary> or. </summary>
        public static Operator Or { get; } = new Operator(OrValue);
        /// <summary> and. </summary>
        public static Operator And { get; } = new Operator(AndValue);
        /// <summary> Determines if two <see cref="Operator"/> values are the same. </summary>
        public static bool operator ==(Operator left, Operator right) => left.Equals(right);
        /// <summary> Determines if two <see cref="Operator"/> values are not the same. </summary>
        public static bool operator !=(Operator left, Operator right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="Operator"/>. </summary>
        public static implicit operator Operator(string value) => new Operator(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is Operator other && Equals(other);
        /// <inheritdoc />
        public bool Equals(Operator other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
