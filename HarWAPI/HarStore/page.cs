using System;
using System.Diagnostics;

namespace HttpArchive
{
    /// <summary>
    /// Page information.
    /// <remarks>
    /// <see cref="!:https://w3c.github.io/web-performance/specs/HAR/Overview.html#sec-object-types-pages" />
    /// </remarks>
    /// </summary>
    public partial class page
    {

        #region Properties

        /// <summary>
        /// Gets or sets the started date time.
        /// </summary>
        /// <value>
        /// The started date time.
        /// </value>
        public DateTime startedDateTime { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string id { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        public string title { get; set; }

        /// <summary>
        /// Gets or sets the page timings.
        /// </summary>
        /// <value>
        /// The page timings.
        /// </value>
        public pageTimings pageTimings { get; set; }

        /// <summary>
        /// Gets or sets the comment.
        /// </summary>
        /// <value>
        /// The comment.
        /// </value>
        public string comment { get; set; }

        #endregion Properties

        #region Constructor

        public page()
        {
            this.pageTimings = new pageTimings();
        }

        #endregion Constructor
    }
}