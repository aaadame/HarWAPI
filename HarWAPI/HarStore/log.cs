using System;
using System.Diagnostics;
using System.Collections.Generic;


namespace HttpArchive
{

    /// <summary>
    ///  HTTP Archive data root.
    /// <remarks>
    /// <see cref="!:https://w3c.github.io/web-performance/specs/HAR/Overview.html#sec-object-types-log" />
    /// </remarks>
    /// </summary>
    public partial class log
    {

        #region Properties

        /// <summary>
        /// Gets or sets the version.
        /// </summary>
        /// <value>
        /// The version.
        /// </value>
        public string version { get; set; }

        /// <summary>
        /// Gets or sets the creator.
        /// </summary>
        /// <value>
        /// The creator.
        /// </value>
        public creator creator { get; set; }

        /// <summary>
        /// Gets or sets the browser.
        /// </summary>
        /// <value>
        /// The browser.
        /// </value>
        public browser browser { get; set; }

        /// <summary>
        /// Gets or sets the pages.
        /// </summary>
        /// <value>
        /// The pages.
        /// </value>
        public IList<page> pages { get; set; }

        /// <summary>
        /// Gets or sets the entries.
        /// </summary>
        /// <value>
        /// The entries.
        /// </value>
        public IList<entry> entries { get; set; }

        /// <summary>
        /// Gets or sets the comment.
        /// </summary>
        /// <value>
        /// The comment.
        /// </value>
        public string comment { get; set; }

        #endregion Properties

        #region Constructor

        public log()
        {
            this.entries = new List<entry>();
            this.pages = new List<page>();
            this.browser = new browser();
            this.creator = new creator();
        }

        #endregion Constructor

    }
}