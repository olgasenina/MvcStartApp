using Microsoft.AspNetCore.Mvc;
using MvcStartApp.Models;
using MvcStartApp.Models.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcStartApp.Controllers
{
    public class UsersController: Controller
    {
        private readonly IBlogRepository _repo;

        public UsersController(IBlogRepository repo)
        {
            _repo = repo;
        }

        public async Task<IActionResult> Index()
        {
            var authors = await _repo.GetUsers();
            return View(authors);
        }

        /// <summary>
        /// Он просто возвращает обычное представление. Собственно, его работу мы видим, когда заходим на форму регистрации.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        // Атрибут HttpPost указывает на то, что этот метод Edit может вызываться только для запросов POST

        // В программировании POST — один из многих методов запроса, поддерживаемых HTTP протоколом, используемым во Всемирной паутине.
        // Метод запроса POST предназначен для запроса, при котором веб-сервер принимает данные, заключённые в тело сообщения, для хранения.
        // Он часто используется для загрузки файла или представления заполненной веб-формы.
        // В отличие от него, метод HTTP GET предназначен для получения информации от сервера. 

        // Метод GET передает параметр запроса в строке URL, а метод POST передает параметр запроса в теле запроса.
        // Запрос GET может передавать только ограниченный объем данных, в то время как метод POST может передавать большой объем данных на сервер.

        /// <summary>
        /// Он точно так же добавляет пользователя в базу, но после этого возвращает не строковый результат, а то же представление, что и метод выше.
        /// </summary>
        /// <param name="newUser"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Register(User newUser)
        {
            await _repo.AddUser(newUser);
            return View(newUser);
        }

    }
}
