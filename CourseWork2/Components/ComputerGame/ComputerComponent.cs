using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork2.Components.ComputerGame
{
	public class ComputerComponent
	{
		#region [Переменные]
		private decimal _price;
		private Bitmap _imgComp;
		private string _name;
		private int _ID;
		private TypeCompoment _type;
		#endregion

		#region [Свойства]
		public decimal Price { get => _price; }
		public Bitmap ImageComponent { get => _imgComp; }
		public string Name { get => _name; }
		public int ID { get => _ID; }
		public TypeCompoment TypeComp { get => _type; }
		#endregion

		public enum TypeCompoment
		{
			Mothercard, CPU, RAM, GPU, HDD, Power
		}

		public ComputerComponent(int id, string name, Bitmap img, decimal price, TypeCompoment type)
		{
			_ID = id;
			_name = name;
			_imgComp = img;
			_price = price;
			_type = type;
		}
	}
}
