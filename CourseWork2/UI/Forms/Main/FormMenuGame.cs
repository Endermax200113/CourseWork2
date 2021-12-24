using CourseWork2.Components.ComputerGame;
using CourseWork2.Properties;
using CourseWork2.Simulation;
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
	public partial class FormMenuGame : ShadowForm
	{
		#region [Переменные]
		#region -> Общие
		private PrivateFontCollection _pfc = new PrivateFontCollection();
		private List<Mothercard> _listMothercard = new List<Mothercard>();
		private List<CPU> _listCPU = new List<CPU>();
		private List<RAM> _listRAM = new List<RAM>();
		private List<GPU> _listGPU = new List<GPU>();
		private List<HDD> _listHDD = new List<HDD>();
		private List<Power> _listPower = new List<Power>();
		private decimal _totalPrice = 0;
		private StringFormat _sf = new StringFormat();
		private Simulator _simulator;
		#endregion

		#region -> Кнопки
		#region -[Оформить заказ]-
		private Point _clLocationOrder = new Point();
		private Animation _animWavePressOrder = new Animation();
		private bool _mousePressedOrder = false;
		#endregion

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
		private FormMain _formParent;
		#endregion
		#endregion

		public FormMenuGame(FormMain form)
		{
			InitializeComponent();
			SetDoubleBuffered(this);

			_formParent = form;

			#region Компоненты
			#region Материнская плата
			_listMothercard.Add(new Mothercard(1, "GIGABYTE Z590 GAMING X", new Bitmap(Resources.game_mothercard_1), 13_599.00m));
			_listMothercard.Add(new Mothercard(2, "GIGABYTE Z690 GAMING X DDR4", new Bitmap(Resources.game_mothercard_2), 17_999.00m));
			_listMothercard.Add(new Mothercard(3, "ASUS TUF GAMING B450-PLUS II", new Bitmap(Resources.game_mothercard_3), 6_999.00m));
			_listMothercard.Add(new Mothercard(4, "GIGABYTE B450 Gaming X", new Bitmap(Resources.game_mothercard_4), 6_099.00m));
			_listMothercard.Add(new Mothercard(5, "ASUS TUF GAMING Z590-PLUS WIFI", new Bitmap(Resources.game_mothercard_5), 19_999.00m));
			_listMothercard.Add(new Mothercard(6, "GIGABYTE B550 GAMING X V2", new Bitmap(Resources.game_mothercard_6), 9_599.00m));
			_listMothercard.Add(new Mothercard(7, "ASUS TUF Z390-PLUS GAMING (WI-FI)", new Bitmap(Resources.game_mothercard_7), 13_999.00m));
			_listMothercard.Add(new Mothercard(8, "ASUS TUF GAMING B560-PLUS WIFI", new Bitmap(Resources.game_mothercard_8), 14_299.00m));
			_listMothercard.Add(new Mothercard(9, "MSI B450 GAMING PLUS MAX", new Bitmap(Resources.game_mothercard_9), 6_999.00m));
			_listMothercard.Add(new Mothercard(10, "ASUS ROG STRIX Z590-F GAMING WIFI", new Bitmap(Resources.game_mothercard_10), 23_499.00m));
			#endregion

			#region Процессор
			_listCPU.Add(new CPU(1, "AMD Ryzen 5 3600", new Bitmap(Resources.game_cpu_1), 20_399.00m));
			_listCPU.Add(new CPU(2, "Intel Core i5-10400F", new Bitmap(Resources.game_cpu_2), 12_199.00m));
			_listCPU.Add(new CPU(3, "AMD Ryzen 5 5600X", new Bitmap(Resources.game_cpu_3), 25_999.00m));
			_listCPU.Add(new CPU(4, "Intel Core i5-11400", new Bitmap(Resources.game_cpu_4), 16_299.00m));
			_listCPU.Add(new CPU(5, "Intel Core i7-11700K", new Bitmap(Resources.game_cpu_5), 31_999.00m));
			_listCPU.Add(new CPU(6, "AMD Ryzen 7 5800X", new Bitmap(Resources.game_cpu_6), 32_999.00m));
			_listCPU.Add(new CPU(7, "Intel Core i5-11600", new Bitmap(Resources.game_cpu_7), 19_299.00m));
			_listCPU.Add(new CPU(8, "Intel Core i7-11700", new Bitmap(Resources.game_cpu_8), 27_999.00m));
			_listCPU.Add(new CPU(9, "AMD Ryzen 9 5900X", new Bitmap(Resources.game_cpu_9), 45_299.00m));
			_listCPU.Add(new CPU(10, "Intel Core i7-11700F", new Bitmap(Resources.game_cpu_10), 26_199.00m));
			#endregion

			#region Оперативная память
			_listRAM.Add(new RAM(1, "Kingston FURY Beast Black 16 ГБ", new Bitmap(Resources.game_ram_1), 6_299.00m));
			_listRAM.Add(new RAM(2, "AMD Radeon R9 Gamer Series 16 ГБ", new Bitmap(Resources.game_ram_2), 5_699.00m));
			_listRAM.Add(new RAM(3, "Crucial Ballistix Black 16 ГБ", new Bitmap(Resources.game_ram_3), 6_799.00m));
			_listRAM.Add(new RAM(4, "A-Data XPG Gammix D10 16 ГБ", new Bitmap(Resources.game_ram_4), 5_699.00m));
			_listRAM.Add(new RAM(5, "Goodram Iridium 16 ГБ", new Bitmap(Resources.game_ram_5), 5_499.00m));
			_listRAM.Add(new RAM(6, "Kingston FURY Beast Black 64 ГБ", new Bitmap(Resources.game_ram_6), 23_499.00m));
			_listRAM.Add(new RAM(7, "Corsair Vengeance LPX 16 ГБ", new Bitmap(Resources.game_ram_7), 6_499.00m));
			_listRAM.Add(new RAM(8, "Kingston HyperX FURY Black 16 ГБ", new Bitmap(Resources.game_ram_8), 7_099.00m));
			_listRAM.Add(new RAM(9, "Kingston FURY Renegade RGB 32 ГБ", new Bitmap(Resources.game_ram_9), 14_799.00m));
			_listRAM.Add(new RAM(10, "Kingston FURY Renegade 32 ГБ", new Bitmap(Resources.game_ram_10), 12_499.00m));
			#endregion

			#region Видеокарта
			_listGPU.Add(new GPU(1, "Palit GeForce GTX 1660 Ti Dual", new Bitmap(Resources.game_gpu_1), 64_999.00m));
			_listGPU.Add(new GPU(2, "Palit GeForce RTX 2060 Super Dual", new Bitmap(Resources.game_gpu_2), 99_999.00m));
			_listGPU.Add(new GPU(3, "GIGABYTE GeForce GTX 1660 Ti OC", new Bitmap(Resources.game_gpu_3), 65_599.00m));
			_listGPU.Add(new GPU(4, "Palit GeForce GTX 1050 Ti STORMX", new Bitmap(Resources.game_gpu_4), 24_599.00m));
			_listGPU.Add(new GPU(5, "Palit GeForce RTX 3090 GamingPro OC", new Bitmap(Resources.game_gpu_5), 309_999.00m));
			_listGPU.Add(new GPU(6, "Palit GeForce RTX 3080 GameRock (LHR)", new Bitmap(Resources.game_gpu_6), 172_999.00m));
			_listGPU.Add(new GPU(7, "MSI GeForce GTX 1660 SUPER Gaming X", new Bitmap(Resources.game_gpu_7), 70_999.00m));
			_listGPU.Add(new GPU(8, "ASRock AMD Radeon RX 6900 XT Phantom Gaming D OC", new Bitmap(Resources.game_gpu_8), 159_999.00m));
			_listGPU.Add(new GPU(9, "MSI GeForce RTX 3090 VENTUS 3X OC", new Bitmap(Resources.game_gpu_9), 309_999.00m));
			_listGPU.Add(new GPU(10, "ASUS GeForce RTX 3090 TURBO", new Bitmap(Resources.game_gpu_10), 304_999.00m));
			#endregion

			#region Жёсткий диск
			_listHDD.Add(new HDD(1, "WD Blue 1 ТБ", new Bitmap(Resources.game_hdd_1), 3_499.00m));
			_listHDD.Add(new HDD(2, "WD Black 1 ТБ", new Bitmap(Resources.game_hdd_2), 3_799.00m));
			_listHDD.Add(new HDD(3, "Toshiba L200 2 ТБ", new Bitmap(Resources.game_hdd_3), 4_850.00m));
			_listHDD.Add(new HDD(4, "Seagate BarraCuda 1 ТБ", new Bitmap(Resources.game_hdd_4), 3_599.00m));
			_listHDD.Add(new HDD(5, "Seagate BarraCuda 4 ТБ", new Bitmap(Resources.game_hdd_5), 13_999.00m));
			_listHDD.Add(new HDD(6, "WD Purple Surveillance 6 ТБ", new Bitmap(Resources.game_hdd_6), 15_999.00m));
			_listHDD.Add(new HDD(7, "Toshiba P300 6 ТБ", new Bitmap(Resources.game_hdd_7), 10_499.00m));
			_listHDD.Add(new HDD(8, "Seagate SkyHawk 6 ТБ", new Bitmap(Resources.game_hdd_8), 13_999.00m));
			_listHDD.Add(new HDD(9, "Toshiba Enterprise Capacity 8 ТБ", new Bitmap(Resources.game_hdd_9), 16_899.00m));
			_listHDD.Add(new HDD(10, "WD Ultrastar DC HC550 18 ТБ", new Bitmap(Resources.game_hdd_10), 34_199.00m));
			#endregion

			#region Блок питания
			_listPower.Add(new Power(1, "GIGABYTE AORUS P1200W", new Bitmap(Resources.game_power_1), 28_999.00m));
			_listPower.Add(new Power(2, "Corsair CX750F RGB", new Bitmap(Resources.game_power_2), 9_250.00m));
			_listPower.Add(new Power(3, "Thermaltake Toughpower i RGB PLUS 850W Digital", new Bitmap(Resources.game_power_3), 12_999.00m));
			_listPower.Add(new Power(4, "Corsair CX650F RGB White", new Bitmap(Resources.game_power_4), 8_299.00m));
			_listPower.Add(new Power(5, "Thermaltake Toughpower PF1 ARGB 1050W", new Bitmap(Resources.game_power_5), 25_999.00m));
			_listPower.Add(new Power(6, "ASUS ROG THOR 850P RGB OLED 850W", new Bitmap(Resources.game_power_6), 25_999.00m));
			_listPower.Add(new Power(7, "Super Flower Leadex Platinum 1200W", new Bitmap(Resources.game_power_7), 30_999.00m));
			_listPower.Add(new Power(8, "Thermaltake Toughpower Grand RGB 850W", new Bitmap(Resources.game_power_8), 18_999.00m));
			_listPower.Add(new Power(9, "AeroCool VX PLUS 600 RGB", new Bitmap(Resources.game_power_9), 2_950.00m));
			_listPower.Add(new Power(10, "AeroCool Cylon 700W", new Bitmap(Resources.game_power_10), 4_099.00m));
			#endregion
			#endregion

			_sf.Alignment = StringAlignment.Center;
			_sf.LineAlignment = StringAlignment.Center;

			_simulator = new Simulator(_listMothercard, _listCPU, _listRAM, _listGPU, _listHDD, _listPower, this);
		}

		#region [Слушатели]
		#region -> Окно
		private void FormMenuGame_OnLoad(object sender, EventArgs e)
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

			foreach (Mothercard mothercard in _listMothercard)
				cbCompMothercard.Items.Add($"{mothercard.Name} Цена: {mothercard.Price} руб. [{mothercard.Count}]");

			foreach (CPU cpu in _listCPU)
				cbCompCPU.Items.Add($"{cpu.Name} Цена: {cpu.Price} руб. [{cpu.Count}]");

			foreach (RAM ram in _listRAM)
				cbCompRAM.Items.Add($"{ram.Name} Цена: {ram.Price} руб. [{ram.Count}]");

			foreach (GPU gpu in _listGPU)
				cbCompGPU.Items.Add($"{gpu.Name} Цена: {gpu.Price} руб. [{gpu.Count}]");

			foreach (HDD hdd in _listHDD)
				cbCompHDD.Items.Add($"{hdd.Name} Цена: {hdd.Price} руб. [{hdd.Count}]");

			foreach (Power power in _listPower)
				cbCompPower.Items.Add($"{power.Name} Цена: {power.Price} руб. [{power.Count}]");
		}

		private void FormMenuGame_OnShown(object sender, EventArgs e)
		{
			cbCompMothercard.SelectedIndex = 0;
			cbCompCPU.SelectedIndex = 0;
			cbCompRAM.SelectedIndex = 0;
			cbCompGPU.SelectedIndex = 0;
			cbCompHDD.SelectedIndex = 0;
			cbCompPower.SelectedIndex = 0;
		}

		private void FormMenuGame_OnResize(object sender, EventArgs e)
		{
			int width = pnlComponents.Width;
			int height = pnlComponents.Height;
			int panelW = (width - 80) / 3;
			int panelH = (height - 20) / 2;

			pnlCompMothercard.Top = 0;
			pnlCompCPU.Top = 0;
			pnlCompRAM.Top = 0;

			pnlCompMothercard.Width = panelW;
			pnlCompCPU.Width = panelW;
			pnlCompRAM.Width = panelW;

			pnlCompMothercard.Left = 20;
			pnlCompCPU.Left = 40 + panelW;
			pnlCompRAM.Left = 60 + panelW * 2;

			pnlCompMothercard.Height = panelH;
			pnlCompCPU.Height = panelH;
			pnlCompRAM.Height = panelH;

			pnlCompGPU.Top = panelH + 20;
			pnlCompHDD.Top = panelH + 20;
			pnlCompPower.Top = panelH + 20;

			pnlCompGPU.Width = panelW;
			pnlCompHDD.Width = panelW;
			pnlCompPower.Width = panelW;

			pnlCompGPU.Left = 20;
			pnlCompHDD.Left = 40 + panelW;
			pnlCompPower.Left = 60 + panelW * 2;

			pnlCompGPU.Height = panelH;
			pnlCompHDD.Height = panelH;
			pnlCompPower.Height = panelH;
		}
		#endregion

		#region -> Поля со списками
		#region -[Материнская плата]-
		private void CbCompMothercard_OnSelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbCompMothercard.SelectedIndex == 0)
			{
				imgCompMothercard.Image = Resources.img_game_mothercard;
				Recalc();
				return;
			}

			int id = cbCompMothercard.SelectedIndex;
			Mothercard mothercard = _listMothercard[id - 1];
			imgCompMothercard.Image = mothercard.ImageComponent;
			Recalc();
		}
		#endregion

		#region -[Процессор]-
		private void CbCompCPU_OnSelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbCompCPU.SelectedIndex == 0)
			{
				imgCompCPU.Image = Resources.img_game_CPU;
				Recalc();
				return;
			}

			int id = cbCompCPU.SelectedIndex;
			CPU cpu = _listCPU[id - 1];
			imgCompCPU.Image = cpu.ImageComponent;
			Recalc();
		}
		#endregion

		#region -[Оперативная память]-
		private void CbCompRAM_OnSelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbCompRAM.SelectedIndex == 0)
			{
				imgCompRAM.Image = Resources.img_game_RAM;
				Recalc();
				return;
			}

			int id = cbCompRAM.SelectedIndex;
			RAM ram = _listRAM[id - 1];
			imgCompRAM.Image = ram.ImageComponent;
			Recalc();
		}
		#endregion

		#region -[Видеокарта]-
		private void CbCompGPU_OnSelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbCompGPU.SelectedIndex == 0)
			{
				imgCompGPU.Image = Resources.img_game_GPU;
				Recalc();
				return;
			}

			int id = cbCompGPU.SelectedIndex;
			GPU gpu = _listGPU[id - 1];
			imgCompGPU.Image = gpu.ImageComponent;
			Recalc();
		}
		#endregion

		#region -[Жёсткий диск]-
		private void CbCompHDD_OnSelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbCompHDD.SelectedIndex == 0)
			{
				imgCompHDD.Image = Resources.img_game_HDD;
				Recalc();
				return;
			}

			int id = cbCompHDD.SelectedIndex;
			HDD hdd = _listHDD[id - 1];
			imgCompHDD.Image = hdd.ImageComponent;
			Recalc();
		}
		#endregion

		#region -[Блок питания]-
		private void CbCompPower_OnSelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbCompPower.SelectedIndex == 0)
			{
				imgCompPower.Image = Resources.img_game_power;
				Recalc();
				return;
			}

			int id = cbCompPower.SelectedIndex;
			Power power = _listPower[id - 1];
			imgCompPower.Image = power.ImageComponent;
			Recalc();
		}
		#endregion
		#endregion

		#region -> Кнопки
		#region -[Заказать]-
		private void BtnOrder_OnPaint(object sender, PaintEventArgs e)
		{
			Graphics g = e.Graphics;
			g.SmoothingMode = SmoothingMode.HighQuality;
			g.Clear(Color.FromArgb(32, 34, 50));

			Rectangle rectWave = new Rectangle(
				_clLocationOrder.X - (int)_animWavePressOrder.Value / 2,
				_clLocationOrder.Y - (int)_animWavePressOrder.Value / 2,
				(int)_animWavePressOrder.Value,
				(int)_animWavePressOrder.Value
			);
			Rectangle rect = new Rectangle(0, 0, btnOrder.Width, btnOrder.Height);

			if (_animWavePressOrder.Value > 0 && _animWavePressOrder.Value < _animWavePressOrder.TargetValue)
				g.FillEllipse(new SolidBrush(Color.FromArgb(25, Color.Black)), rectWave);
			else if (_animWavePressOrder.Value == _animWavePressOrder.TargetValue)
			{
				_animWavePressOrder.Value = -1;

				if (_mousePressedOrder)
					g.FillRectangle(new SolidBrush(Color.FromArgb(25, 0, 0, 0)), rect);
			}

			g.DrawString(btnOrder.Text, new Font(_pfc.Families[0], 12), new SolidBrush(Color.White), rect, _sf);
		}

		private void BtnOrder_OnMouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				_mousePressedOrder = true;
				_clLocationOrder = e.Location;

				_animWavePressOrder = new Animation("btnOrderPress_" + btnOrder.Handle, btnOrder.Invalidate, 0, btnOrder.Width * 2);
				Animator.Request(_animWavePressOrder, true);
			}
		}

		private void BtnOrder_OnMouseUp(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
				_mousePressedOrder = false;
		}

		private void BtnOrder_OnClick(object sender, EventArgs e)
		{
			int idMotherboard = cbCompMothercard.SelectedIndex - 1;
			int idCPU = cbCompCPU.SelectedIndex - 1;
			int idRAM = cbCompRAM.SelectedIndex - 1;
			int idGPU = cbCompGPU.SelectedIndex - 1;
			int idHDD = cbCompHDD.SelectedIndex - 1;
			int idPower = cbCompPower.SelectedIndex - 1;

			if (idMotherboard < 0 || idCPU < 0 || idRAM < 0 || idGPU < 0 || idHDD < 0 || idPower < 0)
			{
				MessageBox.Show("Пожалуйста, выберите все нужные компоненты", "Не всё выбрано", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			FormFill ff = new FormFill(_listMothercard[idMotherboard], _listCPU[idCPU], _listRAM[idRAM], _listGPU[idGPU],
				_listHDD[idHDD], _listPower[idPower], this);
			ff.ShowDialog();
		}
		#endregion

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

		#region [Методы]
		private void Recalc()
		{
			int idMotherboard = cbCompMothercard.SelectedIndex;
			int idCPU = cbCompCPU.SelectedIndex;
			int idRAM = cbCompRAM.SelectedIndex;
			int idGPU = cbCompGPU.SelectedIndex;
			int idHDD = cbCompHDD.SelectedIndex;
			int idPower = cbCompPower.SelectedIndex;

			if (idMotherboard < 0 || idCPU < 0 || idRAM < 0 || idGPU < 0 || idHDD < 0 || idPower < 0)
				return;

			decimal priceMotherboard = idMotherboard != 0 ? _listMothercard[idMotherboard - 1].Price : 0;
			decimal priceCPU = idCPU != 0 ? _listCPU[idCPU - 1].Price : 0;
			decimal priceRAM = idRAM != 0 ? _listRAM[idRAM - 1].Price : 0;
			decimal priceGPU = idGPU != 0 ? _listGPU[idGPU - 1].Price : 0;
			decimal priceHDD = idHDD != 0 ? _listHDD[idHDD - 1].Price : 0;
			decimal pricePower = idPower != 0 ? _listPower[idPower - 1].Price : 0;

			_totalPrice = priceMotherboard + priceCPU + priceRAM + priceGPU + priceHDD + pricePower;
			btnOrder.Text = $"{_totalPrice} р.";
		}
		#endregion
	}
}
