using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Shapes;

namespace paper_io
{
    /// <summary>
    /// Основной класс, использьзуется для создания поля и отслеживания количества игроков
    /// </summary>
    class Game
    {
        /// <summary>
        /// Список всех игроков
        /// </summary>
        public Player[] Players;
        /// <summary>
        /// Хранит территорию игроков
        /// </summary>
        public Player[,] Room;
        /// <summary>
        /// Принимает количество игроков и делает поле размерностью n*n, где n- количество игроков * 10
        /// </summary>
        /// <param name="n">Количество игроков</param>
        public Game(byte n)
        {
            Players = new Player[n];
            Room = new Player[n * 10, n * 10];
        }
        /// <summary>
        /// Метод получающий область по указанным координатам
        /// </summary>
        public void OblastKoordinat()
        {
            Player[,] array = new Player[31, 17];
        }
        /// <summary>
        /// Конструктор для вычисления координат верхнего левого угла прямоугольника
        /// </summary>
        public Rectangle(Point location)
        {
            Point point = new Point();
            point = location;
        }
        /// <summary>
        /// Тип Player
        /// </summary>
        public struct Player
        {

        }
    }
}
