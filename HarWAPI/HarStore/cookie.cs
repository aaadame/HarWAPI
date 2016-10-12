using System;
using System.Diagnostics;

namespace HttpArchive
{

    /// <summary>
    /// Cookie content information.
    /// <remarks>
    /// <see cref="!:https://w3c.github.io/web-performance/specs/HAR/Overview.html#sec-object-types-cookies" />
    /// </remarks>
    /// </summary>
    public partial class cookie
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
        /// Gets or sets the value.
        /// </summary>
        /// <value>
        /// The value.
        /// </value>
        public string value { get; set; }

        /// <summary>
        /// Gets or sets the path.
        /// </summary>
        /// <value>
        /// The path.
        /// </value>
        public string path { get; set; }

        /// <summary>
        /// Gets or sets the domain.
        /// </summary>
        /// <value>
        /// The domain.
        /// </value>
        public string domain { get; set; }

        /// <summary>
        /// Gets or sets the expires.
        /// </summary>
        /// <value>
        /// The expires.
        /// </value>
        public DateTime? expires { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [HTTP only].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [HTTP only]; otherwise, <c>false</c>.
        /// </value>
        public bool httpOnly { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="cookie"/> is secure.
        /// </summary>
        /// <value>
        ///   <c>true</c> if secure; otherwise, <c>false</c>.
        /// </value>
        public bool secure { get; set; }

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
