using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HttpArchive;

namespace HarWAPI.Models
{
    public class Request
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

        #endregion Properties


    }

}