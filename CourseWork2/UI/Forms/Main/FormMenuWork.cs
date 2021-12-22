using CourseWork2.Components;
using CourseWork2.Properties;
using CourseWork2.UI.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork2.UI.Forms.Main
{
	public partial class FormMenuWork : Form
	{
		#region [Переменные]
		#region -> Общие
		private PrivateFontCollection _pfc = new PrivateFontCollection();
		private List<ComputerWork> _listCompsForWork = new List<ComputerWork>();
		#endregion

		#region -> Окно
		private FormMain _formParent;
		#endregion
		#endregion

		public FormMenuWork(FormMain form)
		{
			InitializeComponent();

			_formParent = form;

			_listCompsForWork.Add(new ComputerWork(1, "DEXP Aquilon O234", Computer.TypeComputer.ForWork, new Bitmap(Resources.pc_work_1)));
			_listCompsForWork.Add(new ComputerWork(2, "Acer Aspire XC-830 [DT.BE8ER.003]", Computer.TypeComputer.ForWork, new Bitmap(Resources.pc_work_2)));
			_listCompsForWork.Add(new ComputerWork(3, "DEXP Atlas H306", Computer.TypeComputer.ForWork, new Bitmap(Resources.pc_work_3)));
			_listCompsForWork.Add(new ComputerWork(4, "HP Slim Desktop S01-aF0036ur [4D8N2EA]", Computer.TypeComputer.ForWork, new Bitmap(Resources.pc_work_4)));
			_listCompsForWork.Add(new ComputerWork(5, "ASUS ExpertCenter D5 SFF D500SC [90PF02K1-M006Y0]", Computer.TypeComputer.ForWork, new Bitmap(Resources.pc_work_5)));
			_listCompsForWork.Add(new ComputerWork(6, "DEXP Atlas H322", Computer.TypeComputer.ForWork, new Bitmap(Resources.pc_work_6)));
			_listCompsForWork.Add(new ComputerWork(7, "Lenovo IdeaCentre 3 07IMB05 [90NB004WRS]", Computer.TypeComputer.ForWork, new Bitmap(Resources.pc_work_7)));
			_listCompsForWork.Add(new ComputerWork(8, "ASUS ExpertCenter D5 SFF D500SC [90PF02K1-M02870]", Computer.TypeComputer.ForWork, new Bitmap(Resources.pc_work_8)));
			_listCompsForWork.Add(new ComputerWork(9, "ASUS U500MA-R4300G0040 [90PF02F2-M07900]", Computer.TypeComputer.ForWork, new Bitmap(Resources.pc_work_9)));
			_listCompsForWork.Add(new ComputerWork(10, "DEXP Mars E329", Computer.TypeComputer.ForWork, new Bitmap(Resources.pc_work_10)));
		}

		#region [Слушатели]
		#region -> Окно
		private void FormMenuWork_OnLoad(object sender, EventArgs e)
		{
			using (MemoryStream fontStream = new MemoryStream(Resources.Montserrat_Regular))
			{
				IntPtr data = Marshal.AllocCoTaskMem((int)fontStream.Length);
				byte[] fontData = new byte[fontStream.Length];

				fontStream.Read(fontData, 0, (int)fontStream.Length);
				Marshal.Copy(fontData, 0, data, (int)fontStream.Length);
				_pfc.AddMemoryFont(data, (int)fontStream.Length);
				fontStream.Close();
				Marshal.FreeCoTaskMem(data);
			}

			lblPointer.Font = new Font(_pfc.Families[0], 16);
			btnSimulationStart.Font = new Font(_pfc.Families[0], 12);
			btnSimulationStop.Font = new Font(_pfc.Families[0], 12);
			lblSimulationInfo.Font = new Font(_pfc.Families[0], 10);

			int i = 0;
			foreach (ComputerWork comp in _listCompsForWork)
			{
				FlatPanel pnlMain = new FlatPanel();
				pnlMain.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
				pnlMain.BackColor = Color.FromArgb(i % 2 == 0 ? 60 : 30, 0, 0, 0);
				pnlMain.Location = new Point(0, i * 70);
				pnlMain.Margin = new Padding(0);
				pnlMain.Name = $"pnlMain{i + 1}";
				pnlMain.Size = new Size(pnlComponents.Size.Width, 70);
				pnlMain.TabIndex = i;
				pnlComponents.Controls.Add(pnlMain);

				PictureBox imgPC = new PictureBox();
				imgPC.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Bottom;
				imgPC.Image = comp.ImageComp;
				imgPC.Location = new Point(0, 0);
				imgPC.Margin = new Padding(0);
				imgPC.Name = $"imgPC{i + 1}";
				imgPC.Size = new Size(70, 70);
				imgPC.SizeMode = PictureBoxSizeMode.Zoom;
				imgPC.TabIndex = 0;
				imgPC.TabStop = false;
				pnlMain.Controls.Add(imgPC);

				FlatLabel lblTitle = new FlatLabel();
				lblTitle.Anchor = AnchorStyles.Left | AnchorStyles.Right;
				lblTitle.BackColor = Color.FromArgb(0, 0, 0, 0);
				lblTitle.Font = new Font(_pfc.Families[0], 12F, FontStyle.Regular);
				lblTitle.ForeColor = Color.White;
				lblTitle.Location = new Point(90, 8);
				lblTitle.Name = $"lblTitle{i + 1}";
				lblTitle.Size = new Size(pnlMain.Width - 110, 25);
				lblTitle.TabIndex = 1;
				lblTitle.Text = comp.Name;
				lblTitle.TextAlign = ContentAlignment.MiddleLeft;
				pnlMain.Controls.Add(lblTitle);

				FlatLabel lblTotal = new FlatLabel();
				lblTotal.Anchor = AnchorStyles.Left;
				lblTotal.BackColor = Color.FromArgb(0, 0, 0, 0);
				lblTotal.Font = new Font(_pfc.Families[0], 10, FontStyle.Regular);
				lblTotal.ForeColor = Color.White;
				lblTotal.Location = new Point(90, 41);
				lblTotal.Name = $"lblTotal{i + 1}";
				lblTotal.Size = new Size(220, 20);
				lblTotal.TabIndex = 2;
				lblTotal.Text = $"На складе осталось: {comp.Count}";
				lblTotal.TextAlign = ContentAlignment.MiddleLeft;
				pnlMain.Controls.Add(lblTotal);

				FlatButton btnOrder = new FlatButton();
				btnOrder.Anchor = AnchorStyles.Right;
				btnOrder.BackColor = Color.FromArgb(90, 0, 0, 0);
				btnOrder.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
				btnOrder.FlatAppearance.BorderSize = 0;
				btnOrder.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 0, 0);
				btnOrder.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 0, 0);
				btnOrder.FlatStyle = FlatStyle.Flat;
				btnOrder.Font = new Font(_pfc.Families[0], 10, FontStyle.Regular);
				btnOrder.ForeColor = Color.White;
				btnOrder.Location = new Point(pnlMain.Width - 110, 36);
				btnOrder.Margin = new Padding(0);
				btnOrder.Name = $"btnOrder{i + 1}";
				btnOrder.Size = new Size(90, 23);
				btnOrder.TabIndex = 3;
				btnOrder.Text = "Заказать";
				btnOrder.UseVisualStyleBackColor = false;
				pnlMain.Controls.Add(btnOrder);

				i++;
			}
		}
		#endregion
		#endregion
	}
}
