using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace paper_io
{
    /// <summary>
    /// Логика взаимодействия для Start.xaml
    /// </summary>
    public partial class Room : Window
    {
        #region 2
        ///// <summary>
        ///// перечисление которое обрабатывает нажатия на клавиши и задает направление движения игроку
        ///// </summary>
        //enum Direction { left, right, up, down }
        //double x = 0;
        //double y = 0;
        //double x1 = 0;
        //double y1 = 0;
        //public Room()
        //{
        //    InitializeComponent();
        //    DispatcherTimer timer = new DispatcherTimer();
        //    timer.Tick += new EventHandler(MovePlayer);
        //    timer.Start();
        //}

        ///// <summary>
        ///// движение игрока (как будут меняться координаты игрока при нажатии)
        ///// </summary>
        ///// <param name="sender">
        ///// генерация нажатия на клавиши
        ///// </param>
        ///// <param name="e">
        ///// обработка нажатия на клавиши
        ///// </param>
        //private void MovePlayer(object sender, EventArgs e)
        //{
        //    if (Keyboard.IsKeyDown(Key.Left))
        //    {
        //        x -= .025;
        //        Canvas.SetLeft(Player, x);
        //        x1 -= .025;
        //        UpdatePlayerPositionAndCamera();
        //    }
        //    if (Keyboard.IsKeyDown(Key.Up))
        //    {
        //        y -= .025;
        //        Canvas.SetTop(Player, y);
        //        y1 -= .025;
        //        UpdatePlayerPositionAndCamera();
        //    }
        //    if (Keyboard.IsKeyDown(Key.Down))
        //    {
        //        y += .025;
        //        Canvas.SetTop(Player, y);
        //        y1 += .025;
        //        UpdatePlayerPositionAndCamera();
        //    }
        //    if (Keyboard.IsKeyDown(Key.Right))
        //    {
        //        x += .025;
        //        Canvas.SetLeft(Player, x);
        //        x1 += .025;
        //        UpdatePlayerPositionAndCamera();
        //    }
        //}

        ///// <summary>
        ///// методы обновления позиции игрока и камеры
        ///// </summary>
        //private void UpdatePlayerPositionAndCamera()
        //{
        //    UpdatePlayerPosition();
        //    //UpdateCamera();
        //}

        ///// <summary>
        ///// обновление позиции игрока
        ///// </summary>
        //private void UpdatePlayerPosition()
        //{
        //    int x2 = (int)x1;
        //    int y2 = (int)y1;
        //    //int[,] PlayerPosition = new int[x2, y2];
        //    CanvasViewer.PointToScreen(new Point(x2, x2));
        //    //View.Margin = new Thickness(1, 1, 1, 1);
        //}

        ///// <summary>
        ///// обновление позиции камеры 
        ///// </summary>
        //private void UpdateCamera()
        //{
        //    int x2 = (int)x1;
        //    int y2 = (int)y1;
        //    int[,] PlayerPosition = new int[x2, y2];
        //}
        #endregion

        Game game;
        public Room(byte n)
        {
            InitializeComponent();
            game = new Game(n);
            Canvas();
            //canvas.Source = Im
        }
        public void Canvas()
        {
            GeometryGroup gg = new GeometryGroup();
            gg.Children.Add(
                new RectangleGeometry(
                    new Rect() { X = 10, Y = 20, Height = 31, Width = 17 },
                    0, 0));
            GeometryDrawing gd = new GeometryDrawing();
            gd.Geometry = gg;
            gd.Pen = new Pen(Brushes.Black, 0.05);
            DrawingImage gi = new DrawingImage(gd);

            canvas.Source = gi;

            //foreach(Player in canvas)
            //{

            //}
        }
    }
}
