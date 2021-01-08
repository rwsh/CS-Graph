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

namespace Graph
{
	/// <summary>
	/// Логика взаимодействия для MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void cmDraw(object sender, RoutedEventArgs e)
		{
			Line L; // объект линия
			L = new Line(); // создаем объект линия
			L.X1 = 0; // координаты 
			L.Y1 = 0;
			L.X2 = 100;
			L.Y2 = 100;
			L.Stroke = Brushes.Blue; // цвет линии
			L.StrokeThickness = 5; // толщина линии

			g.Children.Add(L); // рисуем линию на холсте

			Rectangle R; // объект прямоугольник
			R = new Rectangle(); // создаем объект прямоугольник
			R.Width = 200; // ширина
			R.Height = 100; // высота
			R.Margin = new Thickness(150, 150, 0, 0); // координаты верхнего левого угла
			R.Fill = Brushes.Red; // цвет прямоугольника 
			R.Stroke = Brushes.Yellow; // цвет контура
			R.StrokeThickness = 10; // толщина контура

			g.Children.Add(R); // рисуем прямоугольник

			Ellipse O; 
			O = new Ellipse();
			O.Width = 150;
			O.Height = 150;
			O.Margin = new Thickness(400, 100, 0, 0);
			O.Fill = Brushes.DarkCyan;
			O.Stroke = Brushes.BurlyWood;
			O.StrokeThickness = 5;

			g.Children.Add(O);

		}

		private void cmLines(object sender, RoutedEventArgs e)
		{
			Random rnd = new Random(); // создаем генератор случайных чисел
			Line L; // объект линия
			for (int i = 0; i < 100; i++)
			{
				L = new Line(); // создаем новую линию
				L.X1 = rnd.NextDouble() * g.Width; // задаем случайные координаты
				L.Y1 = rnd.NextDouble() * g.Height;
				L.X2 = rnd.NextDouble() * g.Width;
				L.Y2 = rnd.NextDouble() * g.Height;
				L.Stroke = Brushes.Blue; // цвет линии
				L.StrokeThickness = 1; // толщина линии
				g.Children.Add(L); // добавляем линию
			}
		}
	}
}
