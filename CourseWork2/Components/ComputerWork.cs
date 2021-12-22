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
		private bool _existsComps = true;
		#endregion

		#region [Свойства]
		public int Count { get => _count; }
		#endregion

		public ComputerWork(int id, string name, TypeComputer type, Bitmap bmp) : base(id, name, type, bmp)
		{	
			Random rand = new Random();
			_count = rand.Next(150);
		}
	}
}
