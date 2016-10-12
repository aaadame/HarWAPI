using System;
using System.Diagnostics;

namespace HttpArchive
{
    /// <summary>
    /// Browser information that created the log.
    /// <remarks>    
    /// <see cref="!:https://w3c.github.io/web-performance/specs/HAR/Overview.html#sec-object-types-browser" />
    /// </remarks>
    /// </summary>
    public partial class browser
    {

        #region Properties

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string name { get; set; }

        /// <summary>
        /// Gets or sets the version.
        /// </summary>
        /// <value>
        /// The version.
        /// </value>
        public string version { get; set; }

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

