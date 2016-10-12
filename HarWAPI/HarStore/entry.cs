using System;
using System.Diagnostics;

namespace HttpArchive
{

    /// <summary>
    /// HTTP request information.
    /// <remarks>
    /// <see cref="!:https://w3c.github.io/web-performance/specs/HAR/Overview.html#sec-har-object-types-entry" />
    /// </remarks>
    /// </summary>
    public partial class entry
    {

        #region Properties

        /// <summary>
        /// Gets or sets the pageref.
        /// </summary>
        /// <value>
        /// The pageref.
        /// </value>
        public string pageref { get; set; }

        /// <summary>
        /// Gets or sets the started date time.
        /// </summary>
        /// <value>
        /// The started date time.
        /// </value>
        public DateTime startedDateTime { get; set; }

        /// <summary>
        /// Gets or sets the time.
        /// </summary>
        /// <value>
        /// The time.
        /// </value>
        public double time { get; set; }

        /// <summary>
        /// Gets or sets the request.
        /// </summary>
        /// <value>
        /// The request.
        /// </value>
        public request request { get; set; }

        /// <summary>
        /// Gets or sets the response.
        /// </summary>
        /// <value>
        /// The response.
        /// </value>
        public response response { get; set; }

        /// <summary>
        /// Gets or sets the cache.
        /// </summary>
        /// <value>
        /// The cache.
        /// </value>
        public cache cache { get; set; }

        /// <summary>
        /// Gets or sets the timings.
        /// </summary>
        /// <value>
        /// The timings.
        /// </value>
        public timings timings { get; set; }

        /// <summary>
        /// Gets or sets the server ip address.
        /// </summary>
        /// <value>
        /// The server ip address.
        /// </value>
        public string serverIPAddress { get; set; }

        /// <summary>
        /// Gets or sets the connection.
        /// </summary>
        /// <value>
        /// The connection.
        /// </value>
        public string connection { get; set; }

        /// <summary>
        /// Gets or sets the comment.
        /// </summary>
        /// <value>
        /// The comment.
        /// </value>
        public string comment { get; set; }

        #endregion Properties

        #region Constructor

        public entry()
        {
            this.timings = new timings();
            this.cache = new cache();
            this.response = new response();
            this.request = new request();
        }

        #endregion Constructor
    }
}