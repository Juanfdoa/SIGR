using Microsoft.AspNetCore.Mvc;
using SIGR.Controllers;
using SIGR.DTOs;
using System.Reflection;

namespace SIGR.Tests
{
    public class UnitTest1
    {
        public UnitTest1()
        {
            // 🔥 RESET DEL ESTADO ANTES DE CADA TEST
            var field = typeof(ReservationController)
                .GetField("_reservations", BindingFlags.Static | BindingFlags.NonPublic);

            if (field != null)
            {
                field.SetValue(null, new List<ReservationDto>
                {
                    new ReservationDto { Id = 1, Customer = "Juan", Table = 5 }
                });
            }
        }

        [Fact]
        public void GetAll_Should_Return_Ok()
        {
            // Arrange
            var controller = new ReservationController();

            // Act
            var result = controller.GetAll();

            // Assert
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public void GetById_Should_Return_Reservation()
        {
            // Arrange
            var controller = new ReservationController();

            // Act
            var result = controller.GetById(1);

            // Assert
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public void GetById_Should_Return_NotFound_When_Invalid()
        {
            // Arrange
            var controller = new ReservationController();

            // Act
            var result = controller.GetById(999);

            // Assert
            Assert.IsType<NotFoundResult>(result);
        }

        [Fact]
        public void Create_Should_Add_Reservation()
        {
            // Arrange
            var controller = new ReservationController();
            var newItem = new ReservationDto
            {
                Customer = "Pedro",
                Table = 10
            };

            // Act
            var result = controller.Create(newItem) as OkObjectResult;

            // Assert
            Assert.NotNull(result);
            var value = result.Value as ReservationDto;
            Assert.Equal("Pedro", value.Customer);
        }

        [Fact]
        public void Update_Should_Modify_Reservation()
        {
            // Arrange
            var controller = new ReservationController();
            var update = new ReservationDto
            {
                Customer = "Carlos",
                Table = 20
            };

            // Act
            var result = controller.Update(1, update) as OkObjectResult;

            // Assert
            Assert.NotNull(result);
            var value = result.Value as ReservationDto;
            Assert.Equal("Carlos", value.Customer);
        }

        [Fact]
        public void Delete_Should_Return_Ok()
        {
            // Arrange
            var controller = new ReservationController();

            // Act
            var result = controller.Delete(1);

            // Assert
            Assert.IsType<OkResult>(result);
        }
    }
}