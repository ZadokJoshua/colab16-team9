using AutoFixture;
using DrCarQuotes_Domain.Entities;
using DrCarQuotes_WebAPI.Controllers;
using DrCarQuotes_WebAPI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace DrCarQuotes_MSTest.Controller;

[TestClass]
public class RepairServicesControllerTests
{
    private Mock<IRepairServiceRepository> _repairServiceRepositoryMock;
    private Fixture _fixture;
    private RepairServicesController _controller;

    public RepairServicesControllerTests()
    {
        _fixture = new Fixture();
        _repairServiceRepositoryMock = new Mock<IRepairServiceRepository>();
    }

    [TestMethod]
    public async Task Get_All_Repair_Services_Return_Ok()
    {
        var repairServiceslist = _fixture.CreateMany<RepairService>(6).ToList();

        _repairServiceRepositoryMock.Setup(repo => repo.GetRepairServicesAsync()).ReturnsAsync(repairServiceslist.AsEnumerable());

        _controller = new RepairServicesController(_repairServiceRepositoryMock.Object);

        var result = await _controller.GetRepairServices();
        var obj = result as ObjectResult;

        Assert.AreEqual(200, obj.StatusCode);
    }

    [TestMethod]
    public async Task Get_Repair_Service_Return_Ok()
    {
        var repairService = _fixture.Create<RepairService>();

        _repairServiceRepositoryMock.Setup(repo => repo.GetRepairServiceByIdAsync(repairService.Id)).ReturnsAsync(repairService);

        _controller = new RepairServicesController(_repairServiceRepositoryMock.Object);

        var result = await _controller.GetRepairServiceById(repairService.Id);
        var obj = result as ObjectResult;

        Assert.AreEqual(200, obj.StatusCode);
    }
}
