namespace SimpleJsonTests.PocoJsonSerializerTests
{
#if NUNIT
    using TestClass = NUnit.Framework.TestFixtureAttribute;
    using TestMethod = NUnit.Framework.TestAttribute;
    using TestCleanup = NUnit.Framework.TearDownAttribute;
    using TestInitialize = NUnit.Framework.SetUpAttribute;
    using ClassCleanup = NUnit.Framework.TestFixtureTearDownAttribute;
    using ClassInitialize = NUnit.Framework.TestFixtureSetUpAttribute;
    using NUnit.Framework;
#else
    using Microsoft.VisualStudio.TestTools.UnitTesting;
#endif

    using SimpleJson;
    using SimpleJsonTests.DataContractTests;

    public class PrivateFieldsSerializeTests
    {
        private DataContractPrivateFields _dataContractPrivateFields;

        public PrivateFieldsSerializeTests()
        {
            _dataContractPrivateFields = new DataContractPrivateFields();
        }

        [Test]
        public void SerializesCorrectly()
        {
            var result = SimpleJson.SerializeObject(_dataContractPrivateFields,
                                                    SimpleJson.PocoJsonSerializerStrategy);

            Assert.AreEqual("{}", result);
        }
    }
}