namespace Recruitment.ExampleTask.Test
{
    using System;
    using NUnit.Framework;
    using Recruitment.ExampleTask.Core;
    using Recruitment.ExampleTask.Model;
    using System.Collections.Generic;

    [TestFixture]
    public class FooFactory_Test
    {
        private Dictionary<string, string> _testData { get; set; }
        private Dictionary<string, string> _testFalseData { get; set; }
        private FooModel _foo { get; set; }


        [SetUp]
        public void Init()
        {
            //Correct data
            _testData = new Dictionary<string, string>()
            {
             {"Id","1"} ,
             {"Name","Foo"},
             {"Surname", "FooSurname"}
            };

            //Wrong data 
            _testFalseData = new Dictionary<string, string>()
            {
             {"Id","a2967b08-4105-4670-afdd-d1b511906f77"} 
            };

            _foo = new FooFactory<FooModel>()
                       .Build(_testData);
        }


        /// <summary>
        /// It should validate the data
        /// </summary>
        [Test]
        public void FooFactory_Should_Correctly_Instanciete()
        {
            Assert.AreEqual(_testData["Id"], _foo.Id.ToString());
            Assert.AreEqual(_testData["Name"], _foo.Name);
            Assert.AreEqual(_testData["Surname"], _foo.Surname);
        }


        /// <summary>
        /// It should throw an FormatException exception 
        /// </summary>
        [Test]
        [ExpectedException(typeof(FormatException))]
        public void FooFactory_Should_Throw_A_FormatException()
        {
            _foo = new FooFactory<FooModel>()
                        .Build(_testFalseData);
        }
    }
}
