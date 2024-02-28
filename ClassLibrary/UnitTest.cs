using NUnit.Framework;
using Phase4EndProject.Controllers;
using Phase4EndProject.Models;
using Microsoft.AspNetCore.Mvc;


namespace ClassLibrary
{
    public class Tests
    {
        [TestFixture]
        public class PizzaControllerTests
        {
            private PizzaController pizzaController;

            [SetUp]
            public void Setup()
            {
                // Assuming you have any necessary setup logic here 
                pizzaController = new PizzaController();
            }

            [Test]
            public void Index_ReturnsViewWithPizzaDetails()
            {
               
                var result = pizzaController.Index() as ViewResult;

          
                Assert.IsNotNull(result);
                Assert.IsInstanceOf<IEnumerable<Pizza>>(result.Model);
            }
            [Test]
            public void Index_ReturnsFirstPizza()
            {
                var result = pizzaController.Index();

                
                Assert.IsNotNull(result);

            }

            [Test]
            public void Checkout_ReturnsViewWithOrderDetails()
            {
                
                var result = pizzaController.Checkout() as ViewResult;

                
                Assert.IsNotNull(result);
                Assert.IsInstanceOf<IEnumerable<OrderInfo>>(result.Model);
            }

        }
    }
}