using MvcStartApp.Models.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcStartApp.Models.Repository
{
    /// <summary>
    /// Логирование запросов к приложению
    /// </summary>
    public interface IRequestRepository
    {
        Task AddRequest(Request request);

        Task<Request[]> GetRequests();
    }
}
