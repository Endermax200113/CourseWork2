using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork2.Simulation
{
	class GeneratorUser
	{
		static class Woman
		{
			public static List<string> listNames = new List<string>();
			public static List<string> listLastname = new List<string>();

			public static void FillNames()
			{
				listNames.Add("Надежда");
				listNames.Add("Екатерина");
				listNames.Add("Татьяна");
				listNames.Add("Ольга");
				listNames.Add("Анастасия");
				listNames.Add("Евгения");
				listNames.Add("Анна");
				listNames.Add("Виктория");
				listNames.Add("Ксения");
				listNames.Add("Александра");
			}

			public static void FillLastnames()
			{
				listLastname.Add("Иванова");
				listLastname.Add("Лебедева");
				listLastname.Add("Орлова");
				listLastname.Add("Андреева");
				listLastname.Add("Ленская");
				listLastname.Add("Соколова");
				listLastname.Add("Назарова");
				listLastname.Add("Котова");
				listLastname.Add("Потапова");
				listLastname.Add("Ильина");
			}
		}

		static class Man
		{
			public static List<string> listNames = new List<string>();
			public static List<string> listLastname = new List<string>();

			public static void FillNames()
			{
				listNames.Add("Андрей");
				listNames.Add("Алексей");
				listNames.Add("Вадим");
				listNames.Add("Дмитрий");
				listNames.Add("Руслан");
				listNames.Add("Илья");
				listNames.Add("Констатин");
				listNames.Add("Марк");
				listNames.Add("Михаил");
				listNames.Add("Николай");
			}

			public static void FillLastnames()
			{
				listLastname.Add("Иванов");
				listLastname.Add("Кузнецов");
				listLastname.Add("Морозов");
				listLastname.Add("Соловьёв");
				listLastname.Add("Павлов");
				listLastname.Add("Виноградов");
				listLastname.Add("Орлов");
				listLastname.Add("Степанов");
				listLastname.Add("Яковлев");
				listLastname.Add("Романов");
			}
		}

		enum Gender
		{
			Male, Female
		}

		public static void FillFull()
		{
			Woman.FillNames();
			Woman.FillLastnames();
			Man.FillNames();
			Man.FillLastnames();
		}

		public static string GetRandomUsername()
		{ 
			Random rand = new Random();
			int g = rand.Next(0, 2);
			Gender gender;
			string name, lastname;

			if (g == 0)
				gender = Gender.Male;
			else
				gender = Gender.Female;

			if (gender == Gender.Male)
			{
				name = Woman.listNames[rand.Next(0, Woman.listNames.Count)];
				lastname = Woman.listLastname[rand.Next(0, Woman.listLastname.Count)];
			}
			else
			{
				name = Man.listNames[rand.Next(0, Man.listNames.Count)];
				lastname = Man.listLastname[rand.Next(0, Man.listLastname.Count)];
			}

			return $"{name} {lastname}";
		}
	}
}
