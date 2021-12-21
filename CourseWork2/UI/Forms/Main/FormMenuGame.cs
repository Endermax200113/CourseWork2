using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork2.UI.Forms.Main
{
	public partial class FormMenuGame : Form
	{
		private FormMain _formParent;

		public FormMenuGame(FormMain form)
		{
			InitializeComponent();

			_formParent = form;
		}
	}
}
