namespace Recruitment.ExampleTask.Core
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Assigns the data to an new object
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ClassMetadataValueAssigner<T> : ClassMetadataExtractor<T>
        where T: new()
    {
        /// <summary>
        /// Generates a type based on a directory.
        /// It is necessary that the types are simple!
        /// </summary>
        /// <param name="data">Dictionary providing data</param>
        /// <returns>The generic type</returns>
        public T Build(Dictionary<string, string> data)
        {
            T temp = new T();

            foreach (string item in PropertiesNames)
            {
                dynamic value = Convert.ChangeType(data[item], Type.GetType((temp.GetType().GetProperty(item).PropertyType).FullName));
                temp.GetType().GetProperty(item).SetValue(temp, value);
            }

            return temp;
        }
    }
}
