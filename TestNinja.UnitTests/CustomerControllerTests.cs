using NUnit.Framework;
using System.Runtime.Remoting;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    internal class CustomerControllerTests
    {
        [Test]
        public void GetCustomer_IdIsZero_ReturnNotFound()
        {
            var customer = new CustomerController();

            var result = customer.GetCustomer(0);

            //Exactly NotFound
            Assert.That(result, Is.TypeOf<NotFound>());

            //NotFound or instance of it
            //Assert.That(result, Is.InstanceOf<NotFound>());
        }
    }
}
