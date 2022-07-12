using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Porosed.Models
{
    /// <summary>
    /// Класс для героя
    /// </summary>
    public class Hero
    {
        /// <summary>
        /// Параметр атаки
        /// </summary>
        public int Attack { get; set; }

        /// <summary>
        /// Параметр защиты
        /// </summary>
        public int Defence { get; set; }

        /// <summary>
        /// Сила заклинаний
        /// </summary>
        public int MagicPower { get; set; }

        /// <summary>
        /// Знания
        /// </summary>
        public int Knowledge { get; set; }

        /// <summary>
        /// Класс героя
        /// </summary>
        public HeroClass Class { get; set; }

        /// <summary>
        /// Имя героя
        /// </summary>
        public HeroName Name { get; set; }
    }
}
