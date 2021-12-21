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
	public partial class FormMenuMain : ShadowForm
	{
		#region [Переменные]
		#region -> Общие
		private PrivateFontCollection _pfc = new PrivateFontCollection();
		private StringFormat _sf = new StringFormat();
		private FormMain _formParent;
		#endregion

		#region -> Кнопки
		#region -[Для работы]-
		private Animation _animWavePressWork = new Animation();
		private Point _clLocationWork = new Point();
		private bool _mousePressedWork = false;
		#endregion

		#region -[Для игр]-
		private Animation _animWavePressGame = new Animation();
		private Point _clLocationGame = new Point();
		private bool _mousePressedGame = false;
		#endregion

		#region -[Для сервера]-
		private Animation _animWavePressServer = new Animation();
		private Point _clLocationServer = new Point();
		private bool _mousePressedServer = false;
		#endregion
		#endregion
		#endregion

		public FormMenuMain(FormMain form)
		{
			InitializeComponent();
			SetDoubleBuffered(this);

			_sf.Alignment = StringAlignment.Center;
			_sf.LineAlignment = StringAlignment.Center;

			_formParent = form;
		}

		#region [Слушатели]
		#region -> Окно
		private void FormMenuMain_OnLoad(object sender, EventArgs e)
		{
			using (MemoryStream fontStream = new MemoryStream(Properties.Resources.Montserrat_Regular))
			{
				IntPtr data = Marshal.AllocCoTaskMem((int)fontStream.Length);
				byte[] fontData = new byte[fontStream.Length];

				fontStream.Read(fontData, 0, (int)fontStream.Length);
				Marshal.Copy(fontData, 0, data, (int)fontStream.Length);
				_pfc.AddMemoryFont(data, (int)fontStream.Length);
				fontStream.Close();
				Marshal.FreeCoTaskMem(data);
			}

			lblPointer.Font = new Font(_pfc.Families[0], 15, FontStyle.Regular);
			btnWork.Font = new Font(_pfc.Families[0], 12, FontStyle.Regular);
			btnGame.Font = new Font(_pfc.Families[0], 12, FontStyle.Regular);
			btnServer.Font = new Font(_pfc.Families[0], 11, FontStyle.Regular);
		}

		private void FormMenuMain_OnResize(object sender, EventArgs e)
		{
			int width = Size.Width;
			int height = Size.Height;
			int panel = (width - 60) / 2;

			pnlWork.Left = 20;
			pnlWork.Width = width - 40;
			pnlWork.Top = 80;
			pnlWork.Height = (height - 120) / 2;
			pnlGame.Left = 20;
			pnlGame.Width = panel;
			pnlGame.Top = 100 + pnlWork.Height;
			pnlGame.Height = (height - 120) / 2;
			pnlServer.Left = panel + 40;
			pnlServer.Width = panel;
			pnlServer.Top = 100 + pnlWork.Height;
			pnlServer.Height = (height - 120) / 2;
		}
		#endregion

		#region -> Кнопки
		#region -[Для работы]-
		private void BtnWork_OnPaint(object sender, PaintEventArgs e)
		{
			Graphics g = e.Graphics;
			g.SmoothingMode = SmoothingMode.HighQuality;
			g.Clear(Color.FromArgb(32, 34, 50));

			Rectangle rectWave = new Rectangle(
				_clLocationWork.X - (int)_animWavePressWork.Value / 2,
				_clLocationWork.Y - (int)_animWavePressWork.Value / 2,
				(int)_animWavePressWork.Value,
				(int)_animWavePressWork.Value
			);
			Rectangle rect = new Rectangle(0, 0, btnWork.Width, btnWork.Height);

			if (_animWavePressWork.Value > 0 && _animWavePressWork.Value < _animWavePressWork.TargetValue)
				g.FillEllipse(new SolidBrush(Color.FromArgb(25, Color.Black)), rectWave);
			else if (_animWavePressWork.Value == _animWavePressWork.TargetValue)
			{
				_animWavePressWork.Value = -1;

				if (_mousePressedWork)
					g.FillRectangle(new SolidBrush(Color.FromArgb(25, 0, 0, 0)), rect);
			}

			g.DrawString(btnWork.Text, new Font(_pfc.Families[0], 12), new SolidBrush(Color.White), rect, _sf);
		}

		private void BtnWork_OnMouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				_mousePressedWork = true;
				_clLocationWork = e.Location;

				_animWavePressWork = new Animation("btnWorkPress_" + btnWork.Handle, btnWork.Invalidate, 0, btnWork.Width * 2);
				Animator.Request(_animWavePressWork, true);
			}
		}

		private void BtnWork_OnMouseUp(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
				_mousePressedWork = false;
		}

		private void BtnWork_OnClick(object sender, EventArgs e)
		{
			_formParent.ActiveFormTabs = new FormMenuWork(_formParent);
		}
		#endregion

		#region -[Для игр]-
		private void BtnGame_OnPaint(object sender, PaintEventArgs e)
		{
			Graphics g = e.Graphics;
			g.SmoothingMode = SmoothingMode.HighQuality;
			g.Clear(Color.FromArgb(32, 34, 50));

			Rectangle rectWave = new Rectangle(
				_clLocationGame.X - (int)_animWavePressGame.Value / 2,
				_clLocationGame.Y - (int)_animWavePressGame.Value / 2,
				(int)_animWavePressGame.Value,
				(int)_animWavePressGame.Value
			);
			Rectangle rect = new Rectangle(0, 0, btnGame.Width, btnGame.Height);

			if (_animWavePressGame.Value > 0 && _animWavePressGame.Value < _animWavePressGame.TargetValue)
				g.FillEllipse(new SolidBrush(Color.FromArgb(25, Color.Black)), rectWave);
			else if (_animWavePressGame.Value == _animWavePressGame.TargetValue)
			{
				_animWavePressGame.Value = -1;

				if (_mousePressedGame)
					g.FillRectangle(new SolidBrush(Color.FromArgb(25, 0, 0, 0)), rect);
			}

			g.DrawString(btnGame.Text, new Font(_pfc.Families[0], 12), new SolidBrush(Color.White), rect, _sf);
		}

		private void BtnGame_OnMouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				_mousePressedGame = true;
				_clLocationGame = e.Location;

				_animWavePressGame = new Animation("btnGamePress_" + btnGame.Handle, btnGame.Invalidate, 0, btnGame.Width * 2);
				Animator.Request(_animWavePressGame, true);
			}
		}

		private void BtnGame_OnMouseUp(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
				_mousePressedGame = false;
		}

		private void BtnGame_OnClick(object sender, EventArgs e)
		{
			_formParent.ActiveFormTabs = new FormMenuGame(_formParent);
		}
		#endregion

		#region -[Для сервера]-
		private void BtnServer_OnPaint(object sender, PaintEventArgs e)
		{
			Graphics g = e.Graphics;
			g.SmoothingMode = SmoothingMode.HighQuality;
			g.Clear(Color.FromArgb(32, 34, 50));

			Rectangle rectWave = new Rectangle(
				_clLocationServer.X - (int)_animWavePressServer.Value / 2,
				_clLocationServer.Y - (int)_animWavePressServer.Value / 2,
				(int)_animWavePressServer.Value,
				(int)_animWavePressServer.Value
			);
			Rectangle rect = new Rectangle(0, 0, btnServer.Width, btnServer.Height);

			if (_animWavePressServer.Value > 0 && _animWavePressServer.Value < _animWavePressServer.TargetValue)
				g.FillEllipse(new SolidBrush(Color.FromArgb(25, Color.Black)), rectWave);
			else if (_animWavePressServer.Value == _animWavePressServer.TargetValue)
			{
				_animWavePressServer.Value = -1;

				if (_mousePressedServer)
					g.FillRectangle(new SolidBrush(Color.FromArgb(25, 0, 0, 0)), rect);
			}

			g.DrawString(btnServer.Text, new Font(_pfc.Families[0], 10.5f), new SolidBrush(Color.White), rect, _sf);
		}

		private void BtnServer_OnMouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				_mousePressedServer = true;
				_clLocationServer = e.Location;

				_animWavePressServer = new Animation("btnServerPress_" + btnServer.Handle, btnServer.Invalidate, 0, btnServer.Width * 2);
				Animator.Request(_animWavePressServer, true);
			}
		}

		private void BtnServer_OnMouseUp(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
				_mousePressedServer = false;
		}

		private void BtnServer_OnClick(object sender, EventArgs e)
		{
			_formParent.ActiveFormTabs = new FormMenuServer(_formParent);
		}
		#endregion
		#endregion
		#endregion
	}
}
