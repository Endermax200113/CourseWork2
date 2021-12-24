using CourseWork2.Database;
using CourseWork2.Properties;
using CourseWork2.Components;
using MySql.Data.MySqlClient;
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
using System.Drawing.Drawing2D;
using UI.Animations;
using System.Text.RegularExpressions;
using CourseWork2.UI.Controls;
using CourseWork2.Components.ComputerGame;

namespace CourseWork2.UI.Forms.Main
{
	public partial class FormFill : ShadowForm
	{
		#region [Переменные]
		#region -> Общие
		private PrivateFontCollection _pfc = new PrivateFontCollection();
		private StringFormat _sf = new StringFormat();
		private Computer _comp;
		private Form _formParent;
		private Mothercard _mothercard;
		private CPU _cpu;
		private RAM _ram;
		private GPU _gpu;
		private HDD _hdd;
		private Power _power;
		#endregion

		#region -> Кнопки
		#region -[Закрыть окно]-
		private Animation _animBtnCloseA = new Animation();
		private Animation _animBtnCloseR = new Animation();
		private Animation _animBtnCloseG = new Animation();
		private Animation _animBtnCloseB = new Animation();
		#endregion

		#region -[Оформить заказ]-
		private Point _clLocationOrder = new Point();
		private Animation _animWavePressOrder = new Animation();
		private bool _mousePressedOrder = false;
		#endregion
		#endregion
		#endregion

		public FormFill(Computer comp, Form form)
		{
			InitializeComponent();

			_comp = comp;
			_formParent = form;

			_animBtnCloseA.Value = 255;
			_animBtnCloseR.Value = 26;
			_animBtnCloseG.Value = 28;
			_animBtnCloseB.Value = 41;

			_sf.Alignment = StringAlignment.Center;
			_sf.LineAlignment = StringAlignment.Center;
		}

		public FormFill(Mothercard mothercard, CPU cpu, RAM ram, GPU gpu, HDD hdd, Power power, Form form)
		{
			InitializeComponent();

			_mothercard = mothercard;
			_cpu = cpu;
			_ram = ram;
			_gpu = gpu;
			_hdd = hdd;
			_power = power;
			_formParent = form;

			_animBtnCloseA.Value = 255;
			_animBtnCloseR.Value = 26;
			_animBtnCloseG.Value = 28;
			_animBtnCloseB.Value = 41;

			_sf.Alignment = StringAlignment.Center;
			_sf.LineAlignment = StringAlignment.Center;
		}

		#region [Слушатели]
		#region -> Окна
		private void FormFill_OnLoad(object sender, EventArgs e)
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

			lblTitle.Font = new Font(_pfc.Families[0], 10);
			tbName.Font = new Font("Montserrat", 12);
			tbLastname.Font = new Font("Montserrat", 12);
			btnOrder.Font = new Font(_pfc.Families[0], 12);
		}
		#endregion

		#region -> Поля
		#region -[Имя]-
		private void TbNameFalse_OnFocusEnter(object sender, EventArgs e)
		{
			tbName.Focus();
		}

		private void TbName_OnFocusEnter(object sender, EventArgs e)
		{
			if (tbName.ForeColor == Color.FromArgb(154, 154, 154))
			{
				tbName.Text = "";
				tbName.ForeColor = Color.White;
			}
		}

		private void TbName_OnFocusLeave(object sender, EventArgs e)
		{
			if (tbName.Text == "")
			{
				tbName.Text = "Имя";
				tbName.ForeColor = Color.FromArgb(154, 154, 154);
			}
		}

		private void TbName_OnKeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
				tbLastname.Focus();
		}
		#endregion

		#region -[Фамилия]-
		private void TbLastnameFalse_OnFocusEnter(object sender, EventArgs e)
		{
			tbLastname.Focus();
		}

		private void TbLastname_OnFocusEnter(object sender, EventArgs e)
		{
			if (tbLastname.ForeColor == Color.FromArgb(154, 154, 154))
			{
				tbLastname.Text = "";
				tbLastname.ForeColor = Color.White;
			}
		}

		private void TbLastname_OnFocusLeave(object sender, EventArgs e)
		{
			if (tbLastname.Text == "")
			{
				tbLastname.Text = "Фамилия";
				tbLastname.ForeColor = Color.FromArgb(154, 154, 154);
			}
		}

		private void TbLastname_OnKeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
				TryOrder();
		}
		#endregion
		#endregion

		#region -> Кнопки
		#region -[Закрыть окно]-
		private void BtnClose_OnPaint(object sender, PaintEventArgs e)
		{
			Graphics g = e.Graphics;
			g.SmoothingMode = SmoothingMode.HighQuality;
			g.Clear(Color.FromArgb(26, 28, 41));

			Rectangle rect = new Rectangle(5, 5, btnClose.Width - 10, btnClose.Height - 10);
			Rectangle rectFill = new Rectangle(6, 6, btnClose.Width - 12, btnClose.Height - 12);
			Pen p = new Pen(Color.White, 2);

			g.FillEllipse(new SolidBrush(Color.FromArgb((int)_animBtnCloseA.Value, (int)_animBtnCloseR.Value, (int)_animBtnCloseG.Value, (int)_animBtnCloseB.Value)), rectFill);
			g.DrawEllipse(p, rect);
		}

		private void BtnClose_OnMouseDown(object sender, MouseEventArgs e)
		{
			_animBtnCloseA = new Animation("btnCloseA_" + btnClose.Handle, btnClose.Invalidate, _animBtnCloseA.Value, 200);

			_animBtnCloseA.StepDivider = 5;
			Animator.Request(_animBtnCloseA, true);
		}

		private void BtnClose_OnMouseEnter(object sender, EventArgs e)
		{
			_animBtnCloseR = new Animation("btnCloseR_" + btnClose.Handle, btnClose.Invalidate, _animBtnCloseR.Value, FlatColor.Red.R);
			_animBtnCloseG = new Animation("btnCloseG_" + btnClose.Handle, btnClose.Invalidate, _animBtnCloseG.Value, FlatColor.Red.G);
			_animBtnCloseB = new Animation("btnCloseB_" + btnClose.Handle, btnClose.Invalidate, _animBtnCloseB.Value, FlatColor.Red.B);

			_animBtnCloseR.StepDivider = 5;
			_animBtnCloseG.StepDivider = 5;
			_animBtnCloseB.StepDivider = 5;
			Animator.Request(_animBtnCloseR, true);
			Animator.Request(_animBtnCloseG, true);
			Animator.Request(_animBtnCloseB, true);
		}

		private void BtnClose_OnMouseLeave(object sender, EventArgs e)
		{
			_animBtnCloseR = new Animation("btnCloseR_" + btnClose.Handle, btnClose.Invalidate, _animBtnCloseR.Value, 26);
			_animBtnCloseG = new Animation("btnCloseG_" + btnClose.Handle, btnClose.Invalidate, _animBtnCloseG.Value, 28);
			_animBtnCloseB = new Animation("btnCloseB_" + btnClose.Handle, btnClose.Invalidate, _animBtnCloseB.Value, 41);

			_animBtnCloseR.StepDivider = 5;
			_animBtnCloseG.StepDivider = 5;
			_animBtnCloseB.StepDivider = 5;
			Animator.Request(_animBtnCloseR, true);
			Animator.Request(_animBtnCloseG, true);
			Animator.Request(_animBtnCloseB, true);
		}

		private void BtnClose_OnClick(object sender, EventArgs e)
		{
			Close();
		}
		#endregion

		#region -[Оформить заказ]-
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

			g.DrawString(btnOrder.Text, new Font(_pfc.Families[0], 13), new SolidBrush(Color.White), rect, _sf);
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
			TryOrder();
		}
		#endregion
		#endregion

		#region -> Тексты
		private void LblTitle_OnDown(object sender, MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(Handle, 0x112, 0xF012, 0);
		}
		#endregion
		#endregion

		#region [Методы]
		private bool Order()
		{
			string compFor = "";
			ComputerWork compWork = (ComputerWork)_comp;

			if (compWork.Count <= 0)
			{
				MessageBox.Show("На складе больше нет таких компьютеров", "Нет компьютеров", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

			DB db = new DB();

			if (!db.Connect("coursework"))
				return false;

			if (_comp.TypeComp == Computer.TypeComputer.ForWork)
				compFor = "For Work";
			else if (_comp.TypeComp == Computer.TypeComputer.ForGaming)
				compFor = "For Gaming";
			else if (_comp.TypeComp == Computer.TypeComputer.ServerSolutions)
				compFor = "For Server";

			MySqlCommand cmd = new MySqlCommand("INSERT INTO `orders`(`username`, `computer`, `type`, `price`) VALUES(@username, @computer, @type, @price)");
			cmd.Parameters.Add("@username", MySqlDbType.VarChar).Value = $"{tbName.Text} {tbLastname.Text}";
			cmd.Parameters.Add("@computer", MySqlDbType.VarChar).Value = _comp.Name;
			cmd.Parameters.Add("@type", MySqlDbType.VarChar).Value = compFor;
			cmd.Parameters.Add("@price", MySqlDbType.Decimal).Value = compWork.Price;

			db.ExecuteCommand(cmd);
			db.Disconnect();

			FormMenuWork formWork = (FormMenuWork)_formParent;
			int id = _comp.ID;
			FlatPanel pnlMain = (FlatPanel)formWork.pnlComponents.Controls[id - 1];
			FlatLabel lblTotal = (FlatLabel)pnlMain.Controls[2];
			lblTotal.Text = $"На складе осталось: {--compWork.Count}";

			return true;
		}

		private void TryOrder()
		{
			if (tbName.Text.Length < 2)
			{
				MessageBox.Show("Вы ввели менее 2 символов своего имени", "Слишком мало символов", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			else if (tbName.Text.Length > 64)
			{
				MessageBox.Show("Вы ввели более 64 символов своего имени", "Слишком много символов", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			else if (tbName.ForeColor == Color.FromArgb(154, 154, 154))
			{
				MessageBox.Show("Вы ещё не ввели имя", "Нет имени", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			else
			{
				string pattern = @"^[А-ЯЁа-яё]{2,64}$";

				if (!Regex.IsMatch(tbName.Text, pattern))
				{
					MessageBox.Show("У вас введены некорректные символы. Пожалуйста, введите только русские буквы", "Некорректные символы", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
			}

			if (tbLastname.Text.Length < 2)
			{
				MessageBox.Show("Вы ввели менее 2 символов своей фамилии", "Слишком мало символов", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			else if (tbLastname.Text.Length > 64)
			{
				MessageBox.Show("Вы ввели более 64 символов своей фамилии", "Слишком много символов", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			else if (tbLastname.ForeColor == Color.FromArgb(154, 154, 154))
			{
				MessageBox.Show("Вы ещё не ввели фамилию", "Нет фамилии", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			else
			{
				string pattern = @"^[А-ЯЁа-яё]{2,64}$";

				if (!Regex.IsMatch(tbLastname.Text, pattern))
				{
					MessageBox.Show("У вас введены некорректные символы. Пожалуйста, введите только русские буквы", "Некорректные символы", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
			}

			if (_formParent is FormMenuWork)
			{
				if (!Order())
					return;
			}
			else if (_formParent is FormMenuGame)
			{
				if (!OrderComponents())
					return;
			}

			if (_formParent is FormMenuWork)
				MessageBox.Show($"Заказ {_comp.Name} успешно оформлен", "Заказ оформлен", MessageBoxButtons.OK, MessageBoxIcon.Information);
			else if (_formParent is FormMenuGame)
				MessageBox.Show($"Заказ игровых компонентов для компьютера успешно оформлен", "Заказ оформлен", MessageBoxButtons.OK, MessageBoxIcon.Information);
			
			Close();
		}

		private bool OrderComponents()
		{
			if (_mothercard.Count <= 0)
			{
				MessageBox.Show("На складе нет такой материнской платы", "Нет материнской платы", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			else if (_cpu.Count <= 0)
			{
				MessageBox.Show("На складе нет такого процессора", "Нет процессора", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			else if (_ram.Count <= 0)
			{
				MessageBox.Show("На складе нет такой оперативной памяти", "Нет оперативной памяти", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			else if (_gpu.Count <= 0)
			{
				MessageBox.Show("На складе нет такой видеокарты", "Нет видеокарты", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			else if (_hdd.Count <= 0)
			{
				MessageBox.Show("На складе нет такого жёсткого диска", "Нет жёсткого диска", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			else if (_cpu.Count <= 0)
			{
				MessageBox.Show("На складе нет такого блока питания", "Нет блока питания", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

			DB db = new DB();

			if (!db.Connect("coursework"))
				return false;

			decimal total = _mothercard.Price + _cpu.Price + _ram.Price + _gpu.Price + _hdd.Price + _power.Price;

			MySqlCommand cmd = new MySqlCommand("INSERT INTO `game_components`(`username`, `motherboard`, `cpu`, `ram`, `gpu`, `hdd`, `power`, `price`) VALUES(@username, @motherboard, @cpu, @ram, @gpu, @hdd, @power, @price)");
			cmd.Parameters.Add("@username", MySqlDbType.VarChar).Value = $"{tbName.Text} {tbLastname.Text}";
			cmd.Parameters.Add("@motherboard", MySqlDbType.VarChar).Value = _mothercard.Name;
			cmd.Parameters.Add("@cpu", MySqlDbType.VarChar).Value = _cpu.Name;
			cmd.Parameters.Add("@ram", MySqlDbType.VarChar).Value = _ram.Name;
			cmd.Parameters.Add("@gpu", MySqlDbType.VarChar).Value = _gpu.Name;
			cmd.Parameters.Add("@hdd", MySqlDbType.VarChar).Value = _hdd.Name;
			cmd.Parameters.Add("@power", MySqlDbType.VarChar).Value = _power.Name;
			cmd.Parameters.Add("@price", MySqlDbType.Decimal).Value = total;
			
			db.ExecuteCommand(cmd);
			db.Disconnect();

			FormMenuGame formGame = (FormMenuGame)_formParent;
			int idMothercard = _mothercard.ID;
			int idCPU = _cpu.ID;
			int idRAM = _ram.ID;
			int idGPU = _gpu.ID;
			int idHDD = _hdd.ID;
			int idPower = _power.ID;

			formGame.cbCompMothercard.Items[idMothercard] = $"{_mothercard.Name} Цена: {_mothercard.Price} [{--_mothercard.Count}]";
			formGame.cbCompCPU.Items[idCPU] = $"{_cpu.Name} Цена: {_cpu.Price} [{--_cpu.Count}]";
			formGame.cbCompRAM.Items[idRAM] = $"{_ram.Name} Цена: {_ram.Price} [{--_ram.Count}]";
			formGame.cbCompGPU.Items[idGPU] = $"{_gpu.Name} Цена: {_gpu.Price} [{--_gpu.Count}]";
			formGame.cbCompHDD.Items[idHDD] = $"{_hdd.Name} Цена: {_hdd.Price} [{--_hdd.Count}]";
			formGame.cbCompPower.Items[idPower] = $"{_power.Name} Цена: {_power.Price} [{--_power.Count}]";

			return true;
		}
		#endregion
	}
}
