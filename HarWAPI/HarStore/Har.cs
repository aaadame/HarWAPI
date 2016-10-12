using System;
using System.Collections.Generic;
using System.Linq;

namespace HttpArchive
{
    /// <summary>
    /// HTTP Archive Format entity, version 1.2 as defined in https://w3c.github.io/web-performance/specs/HAR/Overview.html
    /// Naming convention is the same as established in the 1.2 spec, except where conflicts.
    /// </summary>
    public class Har
    {

        #region Properties

        /// <summary>
        /// Gets or sets the log.
        /// </summary>
        /// <value>
        /// The log.
        /// </value>
        public log log { get; set; }

        #endregion Properties

    }
}