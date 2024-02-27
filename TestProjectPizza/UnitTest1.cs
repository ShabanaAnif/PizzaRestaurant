
using PizzaLibrary;

namespace TestProjectPizza
{
    [TestFixture]
    public class Tests
    {
        PizzaConfirmationpage pfp;
        [SetUp]
        public void Setup()
        {
            pfp = new PizzaConfirmationpage();
        }

        [Test]
        public void AllPizzaNotNullTest()
        {
            foreach (PizzaSelectionpage psp in pfp.AllPizzas())
            {
                Assert.IsNotNull(psp.Cid);
                Assert.IsNotNull(psp.Typeofpizza);
                Assert.IsNotNull(psp.Quantity);
                Assert.IsNotNull(psp.Amount);
                Assert.IsNotNull(psp.Price);
            }
        }
        [Test]
        public void SearchPizzaTest()
        {

        }
    }
}