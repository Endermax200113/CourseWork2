using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork2.Components
{
	public class Computer
	{
		#region [Переменые]
		private int _ID;
		private string _name;
		private TypeComputer _typeComputer;
		private Bitmap _bmpComp;
		#endregion

		#region [Свойства]
		public int ID { get => _ID; }
		public string Name { get => _name; }
		public TypeComputer TypeComp { get => _typeComputer; }
		public Bitmap ImageComp { get => _bmpComp; }
		#endregion

		public enum TypeComputer
		{
			ForWork, ForGaming, ServerSolutions
		}

		public Computer(int id, string name, TypeComputer type, Bitmap bmp)
		{
			_ID = id;
			_name = name;
			_typeComputer = type;
			_bmpComp = bmp;
		}
	}
}
