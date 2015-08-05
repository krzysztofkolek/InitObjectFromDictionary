namespace Recruitment.ExampleTask.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Used to extract all needed metadata form the class
    /// </summary>
    /// <typeparam name="T">Based type</typeparam>
    public abstract class ClassMetadataExtractor<T>
    {
        /// <summary>
        /// All properties based on get_  - all getters
        /// </summary>
        protected List<String> PropertiesNames { get; private set; }

        /// <summary>
        /// All the data should be extracted in the constructor based on the generic type 
        /// </summary>
        public ClassMetadataExtractor()
        {
            GetPropertiesByGet();
        }

        /// <summary>
        /// Extracts all the properties names
        /// </summary>
        protected void GetPropertiesByGet()
        {
            PropertiesNames = typeof(T).GetMembers()
                                .Where(item => item.Name.Contains("get"))
                                .Select(item => item.Name.Replace("get_", string.Empty))
                                .ToList();
        }
    }
}
