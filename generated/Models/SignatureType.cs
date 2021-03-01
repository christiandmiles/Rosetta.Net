// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Rosetta.Models
{
    /// <summary> SignatureType is the type of a cryptographic signature. * ecdsa: `r (32-bytes) || s (32-bytes)` - `64 bytes` * ecdsa_recovery: `r (32-bytes) || s (32-bytes) || v (1-byte)` - `65 bytes` * ed25519: `R (32-byte) || s (32-bytes)` - `64 bytes` * schnorr_1: `r (32-bytes) || s (32-bytes)` - `64 bytes`  (schnorr signature implemented by Zilliqa where both `r` and `s` are scalars encoded as `32-bytes` values, most significant byte first.) * schnorr_poseidon: `r (32-bytes) || s (32-bytes)` where s = Hash(1st pk || 2nd pk || r) - `64 bytes`  (schnorr signature w/ Poseidon hash function implemented by O(1) Labs where both `r` and `s` are scalars encoded as `32-bytes` values, least significant byte first. https://github.com/CodaProtocol/signer-reference/blob/master/schnorr.ml ). </summary>
    public readonly partial struct SignatureType : IEquatable<SignatureType>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="SignatureType"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SignatureType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EcdsaValue = "ecdsa";
        private const string EcdsaRecoveryValue = "ecdsa_recovery";
        private const string Ed25519Value = "ed25519";
        private const string Schnorr1Value = "schnorr_1";
        private const string SchnorrPoseidonValue = "schnorr_poseidon";

        /// <summary> ecdsa. </summary>
        public static SignatureType Ecdsa { get; } = new SignatureType(EcdsaValue);
        /// <summary> ecdsa_recovery. </summary>
        public static SignatureType EcdsaRecovery { get; } = new SignatureType(EcdsaRecoveryValue);
        /// <summary> ed25519. </summary>
        public static SignatureType Ed25519 { get; } = new SignatureType(Ed25519Value);
        /// <summary> schnorr_1. </summary>
        public static SignatureType Schnorr1 { get; } = new SignatureType(Schnorr1Value);
        /// <summary> schnorr_poseidon. </summary>
        public static SignatureType SchnorrPoseidon { get; } = new SignatureType(SchnorrPoseidonValue);
        /// <summary> Determines if two <see cref="SignatureType"/> values are the same. </summary>
        public static bool operator ==(SignatureType left, SignatureType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SignatureType"/> values are not the same. </summary>
        public static bool operator !=(SignatureType left, SignatureType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SignatureType"/>. </summary>
        public static implicit operator SignatureType(string value) => new SignatureType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SignatureType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SignatureType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
