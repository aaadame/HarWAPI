using System;
using System.Diagnostics;
using System.Collections.Generic;


namespace HttpArchive
{
    /// <summary>
    /// Request information coming from browser cache.
    /// <remarks>    
    /// <see cref="!:https://w3c.github.io/web-performance/specs/HAR/Overview.html#sec-object-types-cache" />
    /// </remarks>
    /// </summary>
    public partial class cache
    {
        #region Properties
        /// <summary>
        /// Gets or sets the before request.
        /// </summary>
        /// <value>
        /// The before request.
        /// </value>
        public cacheEntry beforeRequest { get; set; }

        /// <summary>
        /// Gets or sets the after request.
        /// </summary>
        /// <value>
        /// The after request.
        /// </value>
        public cacheEntry afterRequest { get; set; }

        /// <summary>
        /// Gets or sets the comment.
        /// </summary>
        /// <value>
        /// The comment.
        /// </value>
        public string comment { get; set; }
        
        #endregion Properties

        #region Constructor

        public cache()
        {
            this.afterRequest = new cacheEntry();
            this.beforeRequest = new cacheEntry();
        }

        #endregion Constructor
    }
}

