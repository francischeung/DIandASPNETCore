using System.Threading.Tasks;
using DependencyInjectionAndASPNETCore.Models;

namespace DependencyInjectionAndASPNETCore.Services
{
    interface IOrderStore
    {
        Task<Order> GetAsync(string orderId); 
        Task SaveAsync(Order newOrder);
    }
}
