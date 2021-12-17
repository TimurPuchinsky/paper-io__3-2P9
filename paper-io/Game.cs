using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace paper_io
{
    /// <summary>
    /// Основной класс, использьзуется для создания поля и отслеживания количества игроков
    /// </summary>
    public class Game
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
        public Player[,] OblastKoordinat(Point point)
        {
            Player[,] array = new Player[31, 17];
            Point TopLeft = new Point(point.X - 8, point.Y - 15);
            int x = 0;
            int y = 0;
            for (int i = (int)TopLeft.X; i < (int)TopLeft.X + 31; i++)
            {
                for (int j = (int)TopLeft.Y; i < (int)TopLeft.Y + 17; i++)
                {
                    array[x, y] = Room[i, j];
                    y++;
                }
                x++;
            }
            return array;
        }
    }
}
