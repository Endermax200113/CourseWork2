using CourseWork2.Components;
using CourseWork2.Components.ComputerGame;
using CourseWork2.Database;
using CourseWork2.UI.Controls;
using CourseWork2.UI.Forms.Main;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork2.Simulation
{
	public class Simulator
	{
		#region [Переменные]
		private bool _isWorking = false;
		private int _countUser = 0;
		private List<ComputerWork> _listCompWork;
		private List<ComputerServer> _listCompServer;
		private List<Mothercard> _listMothercard;
		private List<CPU> _listCPU;
		private List<RAM> _listRAM;
		private List<GPU> _listGPU;
		private List<HDD> _listHDD;
		private List<Power> _listPower;
		private Form _parentForm;
		#endregion

		#region [Свойства]
		public int CountUser { get => _countUser; set { _countUser = value; } }
		#endregion

		public Simulator(List<ComputerWork> listComp, Form form)
		{
			_listCompWork = listComp;
			_parentForm = form;

			GeneratorUser.FillFull();
		}

		public Simulator(List<Mothercard> mothercard, List<CPU> cpu, List<RAM> ram, List<GPU> gpu, List<HDD> hdd,
			List<Power> power, Form form)
		{
			_listMothercard = mothercard;
			_listCPU = cpu;
			_listRAM = ram;
			_listGPU = gpu;
			_listHDD = hdd;
			_listPower = power;
			_parentForm = form;

			GeneratorUser.FillFull();
		}

		public Simulator(List<ComputerServer> listComp, Form form)
		{
			_listCompServer = listComp;
			_parentForm = form;

			GeneratorUser.FillFull();
		}

		private void Loop()
		{
			while (_isWorking)
			{
				string username = GeneratorUser.GetRandomUsername();

				if (Submit(username))
					_countUser++;
				else
					Stop();
				
				Thread.Sleep(1000);
			}
		}

		public void Start()
		{
			if (!_isWorking)
			{
				_isWorking = true;
				Task.Run(() => Loop());
			}
		}

		public void Stop()
		{
			if (_isWorking)
				_isWorking = false;
		}

		private bool Submit(string username)
		{
			Random rand = new Random();

			if (_parentForm is FormMenuWork)
			{
				FormMenuWork formWork = (FormMenuWork)_parentForm;
				ComputerWork comp = _listCompWork[rand.Next(0, _listCompWork.Count)];

				if (comp.Count <= 0)
				{
					formWork.Invoke(new Action(() => formWork.lblSimulationInfo.Text = $"На складе нет компьютера {comp.Name}"));
					return false;
				}

				DB db = new DB();

				if (!db.Connect("coursework"))
					return false;

				string compFor = "For Work";

				MySqlCommand cmd = new MySqlCommand("INSERT INTO `orders`(`username`, `computer`, `type`, `price`) VALUES(@username, @computer, @type, @price)");
				cmd.Parameters.Add("@username", MySqlDbType.VarChar).Value = username;
				cmd.Parameters.Add("@computer", MySqlDbType.VarChar).Value = comp.Name;
				cmd.Parameters.Add("@type", MySqlDbType.VarChar).Value = compFor;
				cmd.Parameters.Add("@price", MySqlDbType.Decimal).Value = comp.Price;

				db.ExecuteCommand(cmd);
				db.Disconnect();

				int id = comp.ID;
				FlatPanel pnlMain = (FlatPanel)formWork.pnlComponents.Controls[id - 1];
				FlatLabel lblTotal = (FlatLabel)pnlMain.Controls[2];
				lblTotal.Invoke(new Action(() => lblTotal.Text = $"На складе осталось: {--comp.Count}"));

				formWork.Invoke(new Action(() => formWork.lblSimulationInfo.Text = $"{_countUser + 1}: {username} -> {comp.Name}"));
			}
			else if (_parentForm is FormMenuGame)
			{
				FormMenuGame formGame = (FormMenuGame)_parentForm;
				Mothercard mothercard = _listMothercard[rand.Next(0, _listMothercard.Count)];
				CPU cpu = _listCPU[rand.Next(0, _listCPU.Count)];
				RAM ram = _listRAM[rand.Next(0, _listRAM.Count)];
				GPU gpu = _listGPU[rand.Next(0, _listGPU.Count)];
				HDD hdd = _listHDD[rand.Next(0, _listHDD.Count)];
				Power power = _listPower[rand.Next(0, _listPower.Count)];

				if (mothercard.Count <= 0)
				{
					formGame.Invoke(new Action(() => formGame.lblSimulationInfo.Text = $"На складе нет материнской платы {mothercard.Name}"));
					return false;
				}
				else if (cpu.Count <= 0)
				{
					formGame.Invoke(new Action(() => formGame.lblSimulationInfo.Text = $"На складе нет процессора {cpu.Name}"));
					return false;
				}
				else if (ram.Count <= 0)
				{
					formGame.Invoke(new Action(() => formGame.lblSimulationInfo.Text = $"На складе нет оперативной памяти {ram.Name}"));
					return false;
				}
				else if (gpu.Count <= 0)
				{
					formGame.Invoke(new Action(() => formGame.lblSimulationInfo.Text = $"На складе нет видеокарты {gpu.Name}"));
					return false;
				}
				else if (hdd.Count <= 0)
				{
					formGame.Invoke(new Action(() => formGame.lblSimulationInfo.Text = $"На складе нет жёсткого диска {hdd.Name}"));
					return false;
				}
				else if (power.Count <= 0)
				{
					formGame.Invoke(new Action(() => formGame.lblSimulationInfo.Text = $"На складе нет блока питания {power.Name}"));
					return false;
				}

				DB db = new DB();

				if (!db.Connect("coursework"))
					return false;

				decimal total = mothercard.Price + cpu.Price + ram.Price + gpu.Price + hdd.Price + power.Price;

				MySqlCommand cmd = new MySqlCommand("INSERT INTO `game_components`(`username`, `motherboard`, `cpu`, `ram`, `gpu`, `hdd`, `power`, `price`) VALUES(@username, @motherboard, @cpu, @ram, @gpu, @hdd, @power, @price)");
				cmd.Parameters.Add("@username", MySqlDbType.VarChar).Value = username;
				cmd.Parameters.Add("@motherboard", MySqlDbType.VarChar).Value = mothercard.Name;
				cmd.Parameters.Add("@cpu", MySqlDbType.VarChar).Value = cpu.Name;
				cmd.Parameters.Add("@ram", MySqlDbType.VarChar).Value = ram.Name;
				cmd.Parameters.Add("@gpu", MySqlDbType.VarChar).Value = gpu.Name;
				cmd.Parameters.Add("@hdd", MySqlDbType.VarChar).Value = hdd.Name;
				cmd.Parameters.Add("@power", MySqlDbType.VarChar).Value = power.Name;
				cmd.Parameters.Add("@price", MySqlDbType.Decimal).Value = total;

				db.ExecuteCommand(cmd);
				db.Disconnect();

				int idMothercard = mothercard.ID;
				int idCPU = cpu.ID;
				int idRAM = ram.ID;
				int idGPU = gpu.ID;
				int idHDD = hdd.ID;
				int idPower = power.ID;

				formGame.Invoke(new Action(() => formGame.cbCompMothercard.Items[idMothercard] = $"{mothercard.Name} Цена: {mothercard.Price} [{--mothercard.Count}]"));
				formGame.Invoke(new Action(() => formGame.cbCompCPU.Items[idCPU] = $"{cpu.Name} Цена: {cpu.Price} [{--cpu.Count}]"));
				formGame.Invoke(new Action(() => formGame.cbCompRAM.Items[idRAM] = $"{ram.Name} Цена: {ram.Price} [{--ram.Count}]"));
				formGame.Invoke(new Action(() => formGame.cbCompGPU.Items[idGPU] = $"{gpu.Name} Цена: {gpu.Price} [{--gpu.Count}]"));
				formGame.Invoke(new Action(() => formGame.cbCompHDD.Items[idHDD] = $"{hdd.Name} Цена: {hdd.Price} [{--hdd.Count}]"));
				formGame.Invoke(new Action(() => formGame.cbCompPower.Items[idPower] = $"{power.Name} Цена: {power.Price} [{--power.Count}]"));

				formGame.Invoke(new Action(() => formGame.lblSimulationInfo.Text = $"{_countUser + 1}: {username} -> {total} р."));

				return true;
			}
			else if (_parentForm is FormMenuServer)
			{
				FormMenuServer formServer = (FormMenuServer)_parentForm;
				ComputerServer comp = _listCompServer[rand.Next(0, _listCompServer.Count)];

				if (comp.Count <= 0)
				{
					formServer.Invoke(new Action(() => formServer.lblSimulationInfo.Text = $"На складе нет компьютера {comp.Name}"));
					return false;
				}

				DB db = new DB();

				if (!db.Connect("coursework"))
					return false;

				string compFor = "For Server";

				MySqlCommand cmd = new MySqlCommand("INSERT INTO `orders`(`username`, `computer`, `type`, `price`) VALUES(@username, @computer, @type, @price)");
				cmd.Parameters.Add("@username", MySqlDbType.VarChar).Value = username;
				cmd.Parameters.Add("@computer", MySqlDbType.VarChar).Value = comp.Name;
				cmd.Parameters.Add("@type", MySqlDbType.VarChar).Value = compFor;
				cmd.Parameters.Add("@price", MySqlDbType.Decimal).Value = comp.Price;

				db.ExecuteCommand(cmd);
				db.Disconnect();

				int id = comp.ID;
				FlatPanel pnlMain = (FlatPanel)formServer.pnlComponents.Controls[id - 1];
				FlatLabel lblTotal = (FlatLabel)pnlMain.Controls[2];
				lblTotal.Invoke(new Action(() => lblTotal.Text = $"На складе осталось: {--comp.Count}"));

				formServer.Invoke(new Action(() => formServer.lblSimulationInfo.Text = $"{_countUser + 1}: {username} -> {comp.Name}"));
			}

			return true;
		}
	}
}
