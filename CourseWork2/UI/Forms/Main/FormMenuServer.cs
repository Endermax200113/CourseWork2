using CourseWork2.Components;
using CourseWork2.Properties;
using CourseWork2.Simulation;
using CourseWork2.UI.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Animations;

namespace CourseWork2.UI.Forms.Main
{
	public partial class FormMenuServer : ShadowForm
	{
		#region [Переменные]
		#region -> Общие
		private PrivateFontCollection _pfc = new PrivateFontCollection();
		private List<ComputerServer> _listCompsForServer = new List<ComputerServer>();
		private StringFormat _sf = new StringFormat();
		private Simulator _simulator;
		#endregion

		#region -> Кнопки
		#region -[Старт]-
		private Point _clLocationSimStart = new Point();
		private Animation _animWavePressSimStart = new Animation();
		private bool _mousePressedSimStart = false;
		#endregion

		#region -[Стоп]-
		private Point _clLocationSimStop = new Point();
		private Animation _animWavePressSimStop = new Animation();
		private bool _mousePressedSimStop = false;
		#endregion
		#endregion

		#region -> Окно
		private FormMain _parentForm;
		#endregion
		#endregion

		public FormMenuServer(FormMain form)
		{
			InitializeComponent();
			SetDoubleBuffered(this);

			_parentForm = form;

			_listCompsForServer.Add(new ComputerServer(1, "HPE ProLiant DL20 Gen10", new Bitmap(Resources.pc_server_1), 83_999.00m));
			_listCompsForServer.Add(new ComputerServer(2, "Lenovo ThinkSystem SR250", new Bitmap(Resources.pc_server_2), 129_999.00m));
			_listCompsForServer.Add(new ComputerServer(3, "HPE ProLiant DL160 Gen10", new Bitmap(Resources.pc_server_3), 169_999.00m));
			_listCompsForServer.Add(new ComputerServer(4, "Dell PowerEdge R340", new Bitmap(Resources.pc_server_4), 172_999.00m));
			_listCompsForServer.Add(new ComputerServer(5, "HPE ProLiant DL360 Gen10", new Bitmap(Resources.pc_server_5), 324_999.00m));
			_listCompsForServer.Add(new ComputerServer(6, "HPE ProLiant DL380 Gen10", new Bitmap(Resources.pc_server_6), 329_999.00m));
			_listCompsForServer.Add(new ComputerServer(7, "HPE ProLiant DL180 Gen10", new Bitmap(Resources.pc_server_7), 179_999.00m));
			_listCompsForServer.Add(new ComputerServer(8, "HPE ProLiant ML350 Gen10", new Bitmap(Resources.pc_server_8), 379_999.00m));
			_listCompsForServer.Add(new ComputerServer(9, "Dell PowerEdge T40", new Bitmap(Resources.pc_server_9), 51_999.00m));
			_listCompsForServer.Add(new ComputerServer(10, "Lenovo ThinkSystem ST550", new Bitmap(Resources.pc_server_10), 197_999.00m));

			_sf.Alignment = StringAlignment.Center;
			_sf.LineAlignment = StringAlignment.Center;

			_simulator = new Simulator(_listCompsForServer, this);
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
			foreach (ComputerServer comp in _listCompsForServer)
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
				lblTotal.Size = new Size(175, 20);
				lblTotal.TabIndex = 2;
				lblTotal.Text = $"На складе осталось: {comp.Count}";
				lblTotal.TextAlign = ContentAlignment.MiddleLeft;
				pnlMain.Controls.Add(lblTotal);

				FlatButton btnOrder = new FlatButton();
				btnOrder.Anchor = AnchorStyles.Right;
				btnOrder.BackColor = Color.FromArgb(i % 2 == 0 ? 60 : 90, 0, 0, 0);
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

				FlatLabel lblPrice = new FlatLabel();
				lblPrice.Anchor = AnchorStyles.Left | AnchorStyles.Right;
				lblPrice.BackColor = Color.FromArgb(0, 0, 0, 0);
				lblPrice.Font = new Font(_pfc.Families[0], 10, FontStyle.Regular);
				lblPrice.ForeColor = Color.White;
				lblPrice.Location = new Point(265, 41);
				lblPrice.Name = $"lblPrice{i + 1}";
				lblPrice.Size = new Size(pnlMain.Width - 395, 20);
				lblPrice.TabIndex = 4;
				lblPrice.Text = $"Цена: {comp.Price} р.";
				lblPrice.TextAlign = ContentAlignment.MiddleRight;
				pnlMain.Controls.Add(lblPrice);

				Animation animWavePressOrder = new Animation();
				Point clLocationOrder = new Point();
				bool mousePressedOrder = false;

				void BtnOrder_OnPaint(object sender1, PaintEventArgs e1)
				{
					Graphics g = e1.Graphics;
					g.SmoothingMode = SmoothingMode.HighQuality;
					g.Clear(Color.FromArgb(32, 34, 50));

					Rectangle rectWave = new Rectangle(
						clLocationOrder.X - (int)animWavePressOrder.Value / 2,
						clLocationOrder.Y - (int)animWavePressOrder.Value / 2,
						(int)animWavePressOrder.Value,
						(int)animWavePressOrder.Value
					);
					Rectangle rect = new Rectangle(0, 0, btnOrder.Width, btnOrder.Height);

					if (animWavePressOrder.Value > 0 && animWavePressOrder.Value < animWavePressOrder.TargetValue)
						g.FillEllipse(new SolidBrush(Color.FromArgb(25, Color.Black)), rectWave);
					else if (animWavePressOrder.Value == animWavePressOrder.TargetValue)
					{
						animWavePressOrder.Value = -1;

						if (mousePressedOrder)
							g.FillRectangle(new SolidBrush(Color.FromArgb(25, 0, 0, 0)), rect);
					}

					g.DrawString(btnOrder.Text, new Font(_pfc.Families[0], 10), new SolidBrush(Color.White), rect, _sf);
				}
				btnOrder.Paint += BtnOrder_OnPaint;

				void BtnOrder_OnMouseDown(object sender1, MouseEventArgs e1)
				{
					if (e1.Button == MouseButtons.Left)
					{
						mousePressedOrder = true;
						clLocationOrder = e1.Location;

						animWavePressOrder = new Animation("btnOrderPress_" + btnOrder.Handle, btnOrder.Invalidate, 0, btnOrder.Width * 2);
						Animator.Request(animWavePressOrder, true);
					}
				}
				btnOrder.MouseDown += BtnOrder_OnMouseDown;

				void BtnOrder_OnMouseUp(object sender1, MouseEventArgs e1)
				{
					if (e1.Button == MouseButtons.Left)
						mousePressedOrder = false;
				}
				btnOrder.MouseUp += BtnOrder_OnMouseUp;

				void BtnOrder_OnClick(object sender1, EventArgs e1)
				{
					FormFill ff = new FormFill(comp, this);
					ff.ShowDialog();
				}
				btnOrder.Click += BtnOrder_OnClick;

				i++;
			}
		}
		#endregion

		#region -> Кнопки
		#region -[Старт]-
		private void BtnSimulationStart_OnPaint(object sender, PaintEventArgs e)
		{
			Graphics g = e.Graphics;
			g.SmoothingMode = SmoothingMode.HighQuality;
			g.Clear(Color.FromArgb(32, 34, 50));

			Rectangle rectWave = new Rectangle(
				_clLocationSimStart.X - (int)_animWavePressSimStart.Value / 2,
				_clLocationSimStart.Y - (int)_animWavePressSimStart.Value / 2,
				(int)_animWavePressSimStart.Value,
				(int)_animWavePressSimStart.Value
			);
			Rectangle rect = new Rectangle(0, 0, btnSimulationStart.Width, btnSimulationStart.Height);

			if (_animWavePressSimStart.Value > 0 && _animWavePressSimStart.Value < _animWavePressSimStart.TargetValue)
				g.FillEllipse(new SolidBrush(Color.FromArgb(25, Color.Black)), rectWave);
			else if (_animWavePressSimStart.Value == _animWavePressSimStart.TargetValue)
			{
				_animWavePressSimStart.Value = -1;

				if (_mousePressedSimStart)
					g.FillRectangle(new SolidBrush(Color.FromArgb(25, 0, 0, 0)), rect);
			}

			g.DrawString(btnSimulationStart.Text, new Font(_pfc.Families[0], 12), new SolidBrush(Color.White), rect, _sf);
		}

		private void BtnSimulationStart_OnMouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				_mousePressedSimStart = true;
				_clLocationSimStart = e.Location;

				_animWavePressSimStart = new Animation("btnSimStartPress_" + btnSimulationStart.Handle, btnSimulationStart.Invalidate, 0, btnSimulationStart.Width * 2);
				Animator.Request(_animWavePressSimStart, true);
			}
		}

		private void BtnSimulationStart_OnMouseUp(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
				_mousePressedSimStart = false;
		}

		private void BtnSimulationStart_OnClick(object sender, EventArgs e)
		{
			_simulator.Start();
		}
		#endregion

		#region -[Стоп]-
		private void BtnSimulationStop_OnPaint(object sender, PaintEventArgs e)
		{
			Graphics g = e.Graphics;
			g.SmoothingMode = SmoothingMode.HighQuality;
			g.Clear(Color.FromArgb(32, 34, 50));

			Rectangle rectWave = new Rectangle(
				_clLocationSimStop.X - (int)_animWavePressSimStop.Value / 2,
				_clLocationSimStop.Y - (int)_animWavePressSimStop.Value / 2,
				(int)_animWavePressSimStop.Value,
				(int)_animWavePressSimStop.Value
			);
			Rectangle rect = new Rectangle(0, 0, btnSimulationStop.Width, btnSimulationStop.Height);

			if (_animWavePressSimStop.Value > 0 && _animWavePressSimStop.Value < _animWavePressSimStop.TargetValue)
				g.FillEllipse(new SolidBrush(Color.FromArgb(25, Color.Black)), rectWave);
			else if (_animWavePressSimStop.Value == _animWavePressSimStop.TargetValue)
			{
				_animWavePressSimStop.Value = -1;

				if (_mousePressedSimStop)
					g.FillRectangle(new SolidBrush(Color.FromArgb(25, 0, 0, 0)), rect);
			}

			g.DrawString(btnSimulationStop.Text, new Font(_pfc.Families[0], 12), new SolidBrush(Color.White), rect, _sf);
		}

		private void BtnSimulationStop_OnMouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				_mousePressedSimStop = true;
				_clLocationSimStop = e.Location;

				_animWavePressSimStop = new Animation("btnSimStopPress_" + btnSimulationStop.Handle, btnSimulationStop.Invalidate, 0, btnSimulationStop.Width * 2);
				Animator.Request(_animWavePressSimStop, true);
			}
		}

		private void BtnSimulationStop_OnMouseUp(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
				_mousePressedSimStop = false;
		}

		private void BtnSimulationStop_OnClick(object sender, EventArgs e)
		{
			_simulator.Stop();
		}
		#endregion
		#endregion
		#endregion
	}
}
