// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> The DependencyCondition. </summary>
    public readonly partial struct DependencyCondition : IEquatable<DependencyCondition>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="DependencyCondition"/> values are the same. </summary>
        public DependencyCondition(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string SkippedValue = "Skipped";
        private const string CompletedValue = "Completed";

        /// <summary> Succeeded. </summary>
        public static DependencyCondition Succeeded { get; } = new DependencyCondition(SucceededValue);
        /// <summary> Failed. </summary>
        public static DependencyCondition Failed { get; } = new DependencyCondition(FailedValue);
        /// <summary> Skipped. </summary>
        public static DependencyCondition Skipped { get; } = new DependencyCondition(SkippedValue);
        /// <summary> Completed. </summary>
        public static DependencyCondition Completed { get; } = new DependencyCondition(CompletedValue);
        /// <summary> Determines if two <see cref="DependencyCondition"/> values are the same. </summary>
        public static bool operator ==(DependencyCondition left, DependencyCondition right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DependencyCondition"/> values are not the same. </summary>
        public static bool operator !=(DependencyCondition left, DependencyCondition right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DependencyCondition"/>. </summary>
        public static implicit operator DependencyCondition(string value) => new DependencyCondition(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DependencyCondition other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DependencyCondition other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
