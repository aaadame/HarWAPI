using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using HarWAPI.Models;
using HttpArchive;
using Newtonsoft.Json;

namespace HarWAPI.Utility
{
    /// <summary>
    /// Provides methods for converting between HTTP Archive Format (HAR) and HAR entities.
    /// </summary>
    public static class HarConvert
    {
        #region Public methods
        /// <summary>
        /// Deserialize HAR content to a HAR entity.
        /// </summary>
        /// <param name="har">The HAR content to be deserialized.</param>
        /// <returns>The HAR entity.</returns>
        public static IHar Deserialize(string har)
        {
            var result = DeserializeEntity(har);

            return (IHar)result;
        }

        /// <summary>
        /// Deserializes the entity.
        /// </summary>
        /// <param name="harent">The harent.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentNullException">HarEntity</exception>
        public static HarEntity DeserializeEntity(string harent)
        {
            if (string.IsNullOrWhiteSpace(harent))
            {
                throw new ArgumentNullException("HarEntity");
            }

            var result = JsonConvert.DeserializeObject<HarEntity>(harent);

            ConvertUrlToFull((IHar)result);

            return result;
        }

        /// <summary>
        /// Deserialize a HAR file to a HAR entity.
        /// </summary>
        /// <param name="fileName">The HAR file name to be deserialized.</param>
        /// <returns>The HAR entity.</returns>
        public static IHar DeserializeFromFile(string fileName)
        {
            return Deserialize(File.ReadAllText(fileName));
        }
        #endregion

        #region Private methods
        /// <summary>
        /// Transform the partial redirect URL to a full one.
        /// </summary>
        /// <param name="har">The HAR.</param>
        private static void ConvertUrlToFull(IHar har)
        {
            var PartUrl = har.log.entries
                .Where(e => e.response.redirectURL != null && 
                        e.response.redirectURL.OriginalString.StartsWith("/", StringComparison.OrdinalIgnoreCase));

            foreach (var item in PartUrl)
            {
                var requestUrl = item.request.url;
                item.response.redirectURL = new Uri(string.Format("{0}{1}",requestUrl.GetLeftPart(UriPartial.Authority),item.response.redirectURL));
            }
        }
        #endregion
    }
}