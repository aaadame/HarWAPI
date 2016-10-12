using System;
using System.Diagnostics;

namespace HttpArchive
{

    /// <summary>
    /// Page load timing information.
    /// <remarks>
    /// <see cref="!:https://w3c.github.io/web-performance/specs/HAR/Overview.html#sec-object-types-timings" />
    /// </remarks>
    /// </summary>
    public partial class pageTimings
    {

        #region Properties

        /// <summary>
        /// Gets or sets the on content load.
        /// </summary>
        /// <value>
        /// The on content load.
        /// </value>
        public double? onContentLoad { get; set; }

        /// <summary>
        /// Gets or sets the on load.
        /// </summary>
        /// <value>
        /// The on load.
        /// </value>
        public double? onLoad { get; set; }

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