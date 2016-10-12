using System;
using System.Diagnostics;

namespace HttpArchive
{

    /// <summary>
    /// 
    /// </summary>
    public partial class timings
    {

        #region Properties

        /// <summary>
        /// Gets or sets the DNS.
        /// </summary>
        /// <value>
        /// The DNS.
        /// </value>
        public double? dns { get; set; }

        /// <summary>
        /// Gets or sets the connect.
        /// </summary>
        /// <value>
        /// The connect.
        /// </value>
        public double? connect { get; set; }

        /// <summary>
        /// Gets or sets the blocked.
        /// </summary>
        /// <value>
        /// The blocked.
        /// </value>
        public double? blocked { get; set; }

        /// <summary>
        /// Gets or sets the send.
        /// </summary>
        /// <value>
        /// The send.
        /// </value>
        public double send { get; set; }

        /// <summary>
        /// Gets or sets the wait.
        /// </summary>
        /// <value>
        /// The wait.
        /// </value>
        public double wait { get; set; }

        /// <summary>
        /// Gets or sets the receive.
        /// </summary>
        /// <value>
        /// The receive.
        /// </value>
        public double receive { get; set; }

        /// <summary>
        /// Gets or sets the SSL.
        /// </summary>
        /// <value>
        /// The SSL.
        /// </value>
        public double? ssl { get; set; }

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