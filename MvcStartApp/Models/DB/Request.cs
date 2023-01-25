﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MvcStartApp.Models.DB
{
    /// <summary>
    /// логирование всех запросов к нашему приложению
    /// </summary>
    [Table ("Requests")]
    public class Request
    {

        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public string Url { get; set; }
    }
}
