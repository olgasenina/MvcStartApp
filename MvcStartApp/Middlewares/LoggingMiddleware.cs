using Microsoft.AspNetCore.Http;
using MvcStartApp.Models.DB;
using MvcStartApp.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcStartApp.Middlewares
{
    public class LoggingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly IRequestRepository _requestRepo;

        /// <summary>
        ///  Middleware-компонент должен иметь конструктор, принимающий RequestDelegate
        /// </summary>
        public LoggingMiddleware(RequestDelegate next, IRequestRepository requestRepo)
        {
            _next = next;
            _requestRepo = requestRepo;
        }

        /// <summary>
        ///  Необходимо реализовать метод Invoke  или InvokeAsync
        /// </summary>
        public async Task InvokeAsync(HttpContext context)
        {
            var url = context.Request.Host.Value + context.Request.Path;

            var newRequest = new Request() { Id = Guid.NewGuid(), Date = DateTime.Now, Url = url };

            await _requestRepo.AddRequest(newRequest);

            // Для логирования данных о запросе используем свойста объекта HttpContext
            Console.WriteLine($"[{DateTime.Now}]: New request to http://{url}");

            // Передача запроса далее по конвейеру
            await _next.Invoke(context);
        }
    }
}
