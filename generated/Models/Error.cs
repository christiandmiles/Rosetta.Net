// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Rosetta.Models
{
    /// <summary> Instead of utilizing HTTP status codes to describe node errors (which often do not have a good analog), rich errors are returned using this object. Both the code and message fields can be individually used to correctly identify an error. Implementations MUST use unique values for both fields. </summary>
    public partial class Error
    {
        /// <summary> Initializes a new instance of Error. </summary>
        /// <param name="code"> Code is a network-specific error code. If desired, this code can be equivalent to an HTTP status code. </param>
        /// <param name="message"> Message is a network-specific error message. The message MUST NOT change for a given code. In particular, this means that any contextual information should be included in the details field. </param>
        /// <param name="retriable"> An error is retriable if the same request may succeed if submitted again. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="message"/> is null. </exception>
        internal Error(int code, string message, bool retriable)
        {
            if (message == null)
            {
                throw new ArgumentNullException(nameof(message));
            }

            Code = code;
            Message = message;
            Retriable = retriable;
        }

        /// <summary> Initializes a new instance of Error. </summary>
        /// <param name="code"> Code is a network-specific error code. If desired, this code can be equivalent to an HTTP status code. </param>
        /// <param name="message"> Message is a network-specific error message. The message MUST NOT change for a given code. In particular, this means that any contextual information should be included in the details field. </param>
        /// <param name="description"> Description allows the implementer to optionally provide additional information about an error. In many cases, the content of this field will be a copy-and-paste from existing developer documentation. Description can ONLY be populated with generic information about a particular type of error. It MUST NOT be populated with information about a particular instantiation of an error (use `details` for this). Whereas the content of Error.Message should stay stable across releases, the content of Error.Description will likely change across releases (as implementers improve error documentation). For this reason, the content in this field is not part of any type assertion (unlike Error.Message). </param>
        /// <param name="retriable"> An error is retriable if the same request may succeed if submitted again. </param>
        /// <param name="details"> Often times it is useful to return context specific to the request that caused the error (i.e. a sample of the stack trace or impacted account) in addition to the standard error message. </param>
        internal Error(int code, string message, string description, bool retriable, object details)
        {
            Code = code;
            Message = message;
            Description = description;
            Retriable = retriable;
            Details = details;
        }

        /// <summary> Code is a network-specific error code. If desired, this code can be equivalent to an HTTP status code. </summary>
        public int Code { get; }
        /// <summary> Message is a network-specific error message. The message MUST NOT change for a given code. In particular, this means that any contextual information should be included in the details field. </summary>
        public string Message { get; }
        /// <summary> Description allows the implementer to optionally provide additional information about an error. In many cases, the content of this field will be a copy-and-paste from existing developer documentation. Description can ONLY be populated with generic information about a particular type of error. It MUST NOT be populated with information about a particular instantiation of an error (use `details` for this). Whereas the content of Error.Message should stay stable across releases, the content of Error.Description will likely change across releases (as implementers improve error documentation). For this reason, the content in this field is not part of any type assertion (unlike Error.Message). </summary>
        public string Description { get; }
        /// <summary> An error is retriable if the same request may succeed if submitted again. </summary>
        public bool Retriable { get; }
        /// <summary> Often times it is useful to return context specific to the request that caused the error (i.e. a sample of the stack trace or impacted account) in addition to the standard error message. </summary>
        public object Details { get; }
    }
}
