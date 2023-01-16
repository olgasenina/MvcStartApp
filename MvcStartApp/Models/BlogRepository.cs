using Microsoft.EntityFrameworkCore;
using MvcStartApp.Models.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcStartApp.Models
{
    public class BlogRepository : IBlogRepository
    {
        // ссылка на контекст
        private readonly BlogContext _context;

        // Метод-конструктор для инициализации
        public BlogRepository(BlogContext context)
        {
            _context = context;
        }

        public async Task AddUser(User user)
        {
            // Добавление пользователя
            var entry = _context.Entry(user);
            if (entry.State == EntityState.Detached)
                await _context.Users.AddAsync(user);

            // Сохранение изенений
            await _context.SaveChangesAsync();
        }
    }
}


// MvcStartApp.Models.BlogRepository': Невозможно использовать сервис с ограниченным объемом 'MvcStartApp.Models.DB.BlogContext' из singleton 'MvcStartApp.Models.IBlogRepository".)"