using System;
using System.Collections.Generic;

namespace OmniSharp.Models
{
    public class PackageVersionRequest
    {
        /// <summary>
        /// The path to the project file
        /// </summary>
        public string ProjectPath { get; set; }

        /// <summary>
        /// The sources to search for the given package
        /// </summary>
        public IEnumerable<string> Sources { get; set; }

        /// <summary>
        /// The id of the package to look up the versions
        /// </summary>
        public string Id { get; set; }
    }
}
