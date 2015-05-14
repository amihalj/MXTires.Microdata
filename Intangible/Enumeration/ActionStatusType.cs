﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace MXTires.Microdata.Intangible.Enumeration
{
    /// <summary>
    /// The status of an Action.
    /// </summary>
    [Flags]
    public enum ActionStatusType
    {
        /// <summary>
        /// An in-progress action (e.g, while watching the movie, or driving to a location).
        /// </summary>
        [EnumMember(Value = "ActiveActionStatus")]
        ActiveActionStatus = 1 << 0,

        /// <summary>
        /// An action that has already taken place.
        /// </summary>
        [EnumMember(Value = "CompletedActionStatus")]
        CompletedActionStatus = 1 << 1,

        /// <summary>
        /// An action that failed to complete. 
        /// The action's error property and the HTTP return code contain more information about the failure.
        /// </summary>
        [EnumMember(Value = "FailedActionStatus")]
        FailedActionStatus = 1 << 2,

        /// <summary>
        /// A description of an action that is supported.
        /// </summary>
        [EnumMember(Value = "PotentialActionStatus")]
        PotentialActionStatus = 1 << 3
    }
}
