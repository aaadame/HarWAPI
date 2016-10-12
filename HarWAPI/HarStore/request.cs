using System;
using System.Diagnostics;
using System.Collections.Generic;

namespace HttpArchive
{

    /// <summary>
    /// Request information.
    /// <remarks>
    /// <see cref="!:https://w3c.github.io/web-performance/specs/HAR/Overview.html#sec-object-types-request" />
    /// </remarks>
    /// </summary>
    public partial class request
    {

        #region Properties

        /// <summary>
        /// Gets or sets the method.
        /// </summary>
        /// <value>
        /// The method.
        /// </value>
        public string Method { get; set; }

        /// <summary>
        /// Gets or sets the URL.
        /// </summary>
        /// <value>
        /// The URL.
        /// </value>
        public Uri url { get; set; }

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
        /// Gets or sets the query string.
        /// </summary>
        /// <value>
        /// The query string.
        /// </value>
        public IList<param> queryString { get; set; }

        /// <summary>
        /// Gets or sets the post data.
        /// </summary>
        /// <value>
        /// The post data.
        /// </value>
        public postData postData { get; set; }

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

        public request()
        {
            this.postData = new postData();
            this.queryString = new List<param>();
            this.headers = new List<header>();
            this.cookies = new List<cookie>();
        }

        #endregion Constructor
    }
}