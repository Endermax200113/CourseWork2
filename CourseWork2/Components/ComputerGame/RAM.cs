using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork2.Components.ComputerGame
{
	public class RAM : ComputerComponent
	{
		#region [Переменные]
		private int _count = 0;
		private static int _lastRandCount = -1;
		#endregion

		#region [Свойства]
		public int Count { get => _count; set { _count = value; } }
		#endregion

		public RAM(int id, string name, Bitmap img, decimal price) : base(id, name, img, price, TypeCompoment.RAM)
		{
			do
			{
				Random rand = new Random();
				_count = rand.Next(200);
			}
			while (_lastRandCount == _count);

			_lastRandCount = _count;
		}
	}
}
