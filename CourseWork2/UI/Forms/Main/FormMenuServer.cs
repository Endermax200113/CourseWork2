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
	public partial class FormMenuServer : Form
	{
		private FormMain _parentForm;

		public FormMenuServer(FormMain form)
		{
			InitializeComponent();

			_parentForm = form;
		}
	}
}
