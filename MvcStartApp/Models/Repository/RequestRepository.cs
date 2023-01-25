using Microsoft.EntityFrameworkCore;
using MvcStartApp.Models.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcStartApp.Models.Repository
{
    public class RequestRepository : IRequestRepository
    {
        private readonly BlogContext _context;

        public RequestRepository(BlogContext context)
        {
            _context = context;
        }
        public async Task AddRequest(Request request)
        {
            var entry = _context.Entry(request); // создаем новую сущность

            if (entry.State == EntityState.Detached)
                await _context.Requests.AddAsync(request); // добавляем новую запись в таблицу

            // Сохранение изменений в БД
            await _context.SaveChangesAsync();
        }
    }
}
