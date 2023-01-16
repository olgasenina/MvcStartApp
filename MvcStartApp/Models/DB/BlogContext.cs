using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcStartApp.Models.DB
{
    /// <summary>
    /// Класс контекста, предоставляющий доступ к сущностям базы данных
    /// </summary>
    public sealed class BlogContext : DbContext
    {
        //Ссылка на таблицу Users
        public DbSet<User> Users { get; set; }

        // Ссылка на таблицу UserPosts
        public DbSet<UserPost> UserPosts { get; set; }

        // Логика взаимодействия с таблицами в БД
        public BlogContext (DbContextOptions<BlogContext> options) : base(options)
        {
            // Эта строчка нужна, чтобы база данных создавалась сразу при необходимости (например, при первом запуске)
            Database.EnsureCreated();
        }
    }
}
