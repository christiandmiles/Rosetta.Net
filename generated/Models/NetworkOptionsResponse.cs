// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Rosetta.Models
{
    /// <summary> NetworkOptionsResponse contains information about the versioning of the node and the allowed operation statuses, operation types, and errors. </summary>
    public partial class NetworkOptionsResponse
    {
        /// <summary> Initializes a new instance of NetworkOptionsResponse. </summary>
        /// <param name="version"> The Version object is utilized to inform the client of the versions of different components of the Rosetta implementation. </param>
        /// <param name="allow"> Allow specifies supported Operation status, Operation types, and all possible error statuses. This Allow object is used by clients to validate the correctness of a Rosetta Server implementation. It is expected that these clients will error if they receive some response that contains any of the above information that is not specified here. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> or <paramref name="allow"/> is null. </exception>
        internal NetworkOptionsResponse(Version version, Allow allow)
        {
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }
            if (allow == null)
            {
                throw new ArgumentNullException(nameof(allow));
            }

            Version = version;
            Allow = allow;
        }

        /// <summary> The Version object is utilized to inform the client of the versions of different components of the Rosetta implementation. </summary>
        public Version Version { get; }
        /// <summary> Allow specifies supported Operation status, Operation types, and all possible error statuses. This Allow object is used by clients to validate the correctness of a Rosetta Server implementation. It is expected that these clients will error if they receive some response that contains any of the above information that is not specified here. </summary>
        public Allow Allow { get; }
    }
}