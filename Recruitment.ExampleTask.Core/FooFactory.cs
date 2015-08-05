namespace Recruitment.ExampleTask.Core
{
    using Recruitment.ExampleTask.Model;

    /// <summary>
    /// Foo factory
    /// </summary>
    /// <typeparam name="T">Should be FooModel</typeparam>
    public class FooFactory<T> : AbstractFactory<T>
        where T : FooModel, new()
    {
    }
}
