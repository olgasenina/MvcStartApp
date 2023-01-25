using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcStartApp.Models
{
    /// <summary>
    /// Модель для хранерия отзывов, оставленных на сайте
    /// </summary>
    public class Feedback
    {
        public string From { get; set; }
        public string Text { get; set; }
    }
}
