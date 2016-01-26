using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;
using Moq;
using DependencyInjectionAndASPNETCore.Services;
using DependencyInjectionAndASPNETCore.Models;
using DependencyInjectionAndASPNETCore.Controllers;
using Microsoft.AspNet.Mvc;

namespace DependencyInjectionAndASPNETCore.Tests
{
    public class HomeControllerTests
    {
        //[Fact]
        //public async Task Index_PopulatesViewWithOrders()
        //{
        //    List<Order> orders = new List<Order>();
        //    orders.Add(new Order());
        //    var mockOrderStore = new Mock<IOrderStore>();
        //    mockOrderStore.Setup(orderStore => orderStore.GetAllAsync())
        //        .ReturnsAsync(orders);

        //    var target = new HomeController(mockOrderStore.Object);
        //    var result = await target.Index();
        //    var view = (ViewResult)result;

        //    Assert.Same(view.ViewData.Model, orders);
        //}
    }
}
