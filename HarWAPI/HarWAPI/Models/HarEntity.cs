using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HttpArchive;

namespace HarWAPI.Models
{
    public class HarEntity: IHar
    {
        #region Properties


        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Id { get; set; }


        /// <summary>
        /// Gets or sets the log.
        /// </summary>
        /// <value>
        /// The log.
        /// </value>
        public log log { get; set; }

        #endregion Properties

    }

    public interface IHar
    {
        log log { get; set; } 
    }
}