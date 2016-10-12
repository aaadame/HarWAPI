using System;
using System.Diagnostics;

namespace HttpArchive
{
    /// <summary>
    /// Cache information before and after request.
    /// <remarks>    
    /// <see cref="!:https://w3c.github.io/web-performance/specs/HAR/Overview.html#sec-object-types-cache" />
    /// </remarks>
    /// </summary>
    public partial class cacheEntry
    {

        #region Properties

        /// <summary>
        /// Gets or sets the expires.
        /// </summary>
        /// <value>
        /// The expires.
        /// </value>
        public DateTime? expires { get; set; }

        /// <summary>
        /// Gets or sets the last access.
        /// </summary>
        /// <value>
        /// The last access.
        /// </value>
        public DateTime lastAccess { get; set; }

        /// <summary>
        /// Gets or sets the e tag.
        /// </summary>
        /// <value>
        /// The e tag.
        /// </value>
        public string eTag { get; set; }

        /// <summary>
        /// Gets or sets the hit count.
        /// </summary>
        /// <value>
        /// The hit count.
        /// </value>
        public int hitCount { get; set; }

        /// <summary>
        /// Gets or sets the comment.
        /// </summary>
        /// <value>
        /// The comment.
        /// </value>
        public string comment { get; set; }

        #endregion Properties

    }
}
