using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace paper_io
{
    /// <summary>
    /// Класс, отвечающий за логику игрока
    /// </summary>
    public class Player
    {
        /// <summary>
        /// положение игрока
        /// </summary>
        public Point location = new Point();
        /// <summary>
        /// координаты шлейфа
        /// </summary>
        List<Point> plume = new List<Point>();
    }
}
