using System;
using System.Net.Http;
using System.Threading.Tasks;
using DependencyInjectionAndASPNETCore.Models;

namespace DependencyInjectionAndASPNETCore.Services
{
    public class OrderStore : IOrderStore
    {
        private readonly HttpClient _httpClient;

        public OrderStore(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public Task<Order> GetAsync(string orderId)
        {
            return Task.FromResult(new Order());
        }

        public Task SaveAsync(Order newOrder)
        {
            return Task.FromResult(0);
        }
    }
}
