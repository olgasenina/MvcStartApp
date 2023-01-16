using MvcStartApp.Models.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcStartApp.Models
{
    public interface IBlogRepository
    {
        Task AddUser(User user);
    }
}
