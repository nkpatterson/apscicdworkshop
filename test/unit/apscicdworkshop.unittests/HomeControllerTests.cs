using System;
using apscicdworkshop.Controllers;
using Xunit;

namespace apscicdworkshop.unittests
{
    public class UnitTest1
    {
        [Fact]
        public void AboutReturnsCorrectMessage()
        {
            // Arrange
            var controller = new HomeController();

            // Act
            controller.About();

            // Assert
            Assert.Equal("Your application description page.", controller.ViewData["Message"].ToString());
        }

        [Fact]
        public void ContactReturnsCorrectMessage()
        {
            // Arrange
            var controller = new HomeController();

            // Act
            controller.Contact();

            // Assert
            Assert.Equal("Your contact page.", controller.ViewData["Message"].ToString());
        }
    }
}
