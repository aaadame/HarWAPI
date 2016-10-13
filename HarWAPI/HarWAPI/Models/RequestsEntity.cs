using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HttpArchive;

namespace HarWAPI.Models
{
    
    public class Requests
    {

        #region Properties
        
        /// <summary>
        /// Gets or sets the entries.
        /// </summary>
        /// <value>
        /// The entries.
        /// </value>
        public IList<Request> requests { get; set; }

        #endregion Properties


        #region Constructor

        public Requests()
        {
            this.requests = new List<Request>();
            
        }

        #endregion Constructor

    }

}