using System;
using System.Diagnostics;
using System.Collections.Generic;

namespace HttpArchive
{

    /// <summary>
    /// Request post data.
    /// <remarks>
    /// <see cref="!:https://w3c.github.io/web-performance/specs/HAR/Overview.html#sec-object-types-postData" />
    /// </remarks>
    /// </summary>
    public partial class postData
    {

        #region Properties

        /// <summary>
        /// Gets or sets the type of the MIME.
        /// </summary>
        /// <value>
        /// The type of the MIME.
        /// </value>
        public string mimeType { get; set; }

        /// <summary>
        /// Gets or sets the text.
        /// </summary>
        /// <value>
        /// The text.
        /// </value>
        public string text { get; set; }

        /// <summary>
        /// Gets or sets the parameters.
        /// </summary>
        /// <value>
        /// The parameters.
        /// </value>
        public IList<param> Params { get; set; }

        /// <summary>
        /// Gets or sets the comment.
        /// </summary>
        /// <value>
        /// The comment.
        /// </value>
        public string comment { get; set; }

        #endregion Properties

        #region Constructor

        public postData()
        {
            this.Params = new List<param>();
        }

        #endregion Constructor
    }
}