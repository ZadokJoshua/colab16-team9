using AutoFixture;
using DrCarQuotes_Domain.Entities;
using DrCarQuotes_WebAPI.Controllers;
using DrCarQuotes_WebAPI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace DrCarQuotes_Test.Controller;

[TestClass]
public class CarsControllerTests
{
    private Mock<ICarRepository> _carRepositoryMock;
    private Fixture _fixture;
    private CarsController _controller;

    public CarsControllerTests()
    {
        _fixture = new Fixture();
        _carRepositoryMock = new Mock<ICarRepository>();
    }

    [TestMethod]
    public async Task Get_All_Cars_Return_Ok()
    {
        var carlist = _fixture.CreateMany<Car>(10).ToList(); 

        _carRepositoryMock.Setup(repo => repo.GetCarsAsync()).ReturnsAsync(carlist.AsEnumerable());

        _controller = new CarsController(_carRepositoryMock.Object);

        var result = await _controller.GetCars();
        var obj = result as ObjectResult;

        Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(200, obj.StatusCode);
    }
}
