// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Rosetta.Models
{
    /// <summary> When fetching data by BlockIdentifier, it may be possible to only specify the index or hash. If neither property is specified, it is assumed that the client is making a request at the current block. </summary>
    public partial class PartialBlockIdentifier
    {
        /// <summary> Initializes a new instance of PartialBlockIdentifier. </summary>
        public PartialBlockIdentifier()
        {
        }

        public long? Index { get; set; }
        public string Hash { get; set; }
    }
}
