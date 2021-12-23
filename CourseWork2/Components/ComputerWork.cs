using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork2.Components
{
	public class ComputerWork : Computer
	{
		#region [Переменные]
		private int _count = 0;
		private static int _lastRandCount = -1;
		private bool _existsComps = true;
		private decimal _price;
		#endregion

		#region [Свойства]
		public int Count { get => _count; set { _count = value; } }
		public decimal Price { get => _price; }
		#endregion

		public ComputerWork(int id, string name, TypeComputer type, Bitmap bmp, decimal price) : base(id, name, type, bmp)
		{
			_price = price;

			do
			{
				Random rand = new Random();
				_count = rand.Next(150);
			}
			while (_lastRandCount == _count);

			_lastRandCount = _count;
		}
	}
}
