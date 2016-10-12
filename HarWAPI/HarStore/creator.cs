using System;
using System.Diagnostics;

namespace HttpArchive
{

    //// <summary>
    /// Log creator application information.
    /// <remarks>
    /// <see cref="!:https://w3c.github.io/web-performance/specs/HAR/Overview.html#sec-object-types-creator" />
    /// </remarks>
    /// </summary>
    public partial class creator
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

