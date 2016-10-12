using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace HarWAPI.Utility
{
    public class Utils
    {
        /// <summary>
        /// Gets the map path. Checks for relative paths to a file
        /// app and other.
        /// </summary>
        /// <param name="mapsetting">The mapsetting.</param>
        /// <returns></returns>
        public static string GetMapPath(string mapping)
        {
            
            string mappedPath = string.Empty;
            if (mapping.StartsWith(@".\"))
            {
                mappedPath = ResolvePhysicalPath(mapping);
                if (File.Exists(mappedPath))
                {
                    return mappedPath;
                }
                else
                {
                    mappedPath = AppDomain.CurrentDomain.RelativeSearchPath + mapping;
                    if (File.Exists(mappedPath))
                    {
                        return mappedPath;
                    }
                }
            }
            else
            {
                if (File.Exists(mapping))
                {
                    return mapping;
                }
            }
            

            return string.Empty;
        }

        /// <summary>
        /// Resolves the physical path.
        /// </summary>
        /// <param name="relativePath">The relative path.</param>
        /// <returns></returns>
        public static string ResolvePhysicalPath(string relativePath)
        {
            
            string appRoot = AppDomain.CurrentDomain.BaseDirectory;
            if (relativePath.StartsWith(@".\"))
            {
                return Path.Combine(appRoot, relativePath.Substring(2));

            }
            else
            {
                return Path.Combine(appRoot, relativePath);
            }
        }

    }
}