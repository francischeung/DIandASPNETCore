using System.Collections.Generic;
using System.Threading.Tasks;
using DependencyInjectionAndASPNETCore.Models;

namespace DependencyInjectionAndASPNETCore.Services
{
    public interface IOrderStore
    {
        Task<IList<Order>> GetAllAsync(); 
    }
}
