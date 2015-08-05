namespace Recruitment.ExampleTask.Core
{
    /// <summary>
    /// Base Factory class
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class AbstractFactory<T> : ClassMetadataValueAssigner<T>
        where T: new()
    {
        /// <summary>
        /// Provides an empty object
        /// </summary>
        /// <returns>An empty object based on the generic type</returns>
        public virtual T Build()
        {
            return new T();
        }
    }
}
