using CourseWork2.Components;
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
				ComputerWork comp = _listCompWork[rand.Next(0, _listCompWork.Count - 1)];

				if (comp.Count <= 0)
				{
					formWork.lblSimulationInfo.Text = $"На складе нет компьютера {comp.Name}";
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

			return true;
		}
	}
}
