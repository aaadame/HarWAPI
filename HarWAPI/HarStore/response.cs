using System;
using System.Diagnostics;
using System.Collections.Generic;

namespace HttpArchive
{

    /// <summary>
    /// Response information.
    /// <remarks>
    /// <see cref="!:https://w3c.github.io/web-performance/specs/HAR/Overview.html#sec-object-types-response" />
    /// </remarks>
    /// </summary>
    public partial class response
    {

        #region Properties

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        /// <value>
        /// The status.
        /// </value>
        public int status { get; set; }

        /// <summary>
        /// Gets or sets the status text.
        /// </summary>
        /// <value>
        /// The status text.
        /// </value>
        public string statusText { get; set; }

        /// <summary>
        /// Gets or sets the HTTP version.
        /// </summary>
        /// <value>
        /// The HTTP version.
        /// </value>
        public string httpVersion { get; set; }

        /// <summary>
        /// Gets or sets the cookies.
        /// </summary>
        /// <value>
        /// The cookies.
        /// </value>
        public IList<cookie> cookies { get; set; }

        /// <summary>
        /// Gets or sets the headers.
        /// </summary>
        /// <value>
        /// The headers.
        /// </value>
        public IList<header> headers { get; set; }

        /// <summary>
        /// Gets or sets the content.
        /// </summary>
        /// <value>
        /// The content.
        /// </value>
        public content content { get; set; }

        /// <summary>
        /// Gets or sets the redirect URL.
        /// </summary>
        /// <value>
        /// The redirect URL.
        /// </value>
        public Uri redirectURL { get; set; }

        /// <summary>
        /// Gets or sets the size of the headers.
        /// </summary>
        /// <value>
        /// The size of the headers.
        /// </value>
        public int headersSize { get; set; }

        /// <summary>
        /// Gets or sets the size of the body.
        /// </summary>
        /// <value>
        /// The size of the body.
        /// </value>
        public int bodySize { get; set; }

        /// <summary>
        /// Gets or sets the comment.
        /// </summary>
        /// <value>
        /// The comment.
        /// </value>
        public string comment { get; set; }

        #endregion Properties

        #region Constructor

        public response()
        {
            this.content = new content();
            this.headers = new List<header>();
            this.cookies = new List<cookie>();
        }

        #endregion Constructor

    }
}