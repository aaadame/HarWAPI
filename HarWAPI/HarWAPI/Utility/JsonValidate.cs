using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using HarWAPI.Models;
using HttpArchive;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using Newtonsoft.Json.Schema.Generation;


namespace HarWAPI.Utility
{
    /// <summary>
    /// Provides methods for converting between HTTP Archive Format (HAR) and HAR entities.
    /// </summary>
    public static class JsonValidate
    {
        #region Public methods

        /// <summary>
        /// Validates basic entity requirements.
        /// </summary>
        /// <param name="ent">The ent.</param>
        /// <returns></returns>
        public static bool Validate(IHar ent)
        {
            
            if (ent == null)
                return false;
            if (ent.log == null)
                return false;
            if (string.IsNullOrEmpty(ent.log.version) || ent.log.creator == null || ent.log.entries == null)
                return false;

            return true;
        }

        /// <summary>
        /// Validates the schema.
        /// </summary>
        /// <param name="json">The json.</param>
        /// <returns></returns>
        public static bool ValidateSchema(string json)
        {
            bool valid = false;
            JSchemaGenerator generator = new JSchemaGenerator();
            JSchema schema = generator.Generate(typeof(Har));
           
            JObject harent = JObject.Parse(json);
            IList<string> errmsg = new List<string>();

            valid = harent.IsValid(schema, out errmsg);

            return valid;
        }
        
        #endregion

    }
}