using System.Collections.Generic;
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

        public Task<IList<Order>> GetAllAsync()
        {
            Order[] orders = {new Order()};
            return Task.FromResult((IList<Order>)new List<Order>(orders));
        }
    }
}
