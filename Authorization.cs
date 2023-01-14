using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace project
{
	public class Users
	{
		public string username;
		public string password;

		public Users(string username, string password)
		{
			this.username = username;
			this.password = password;
		}

	}
	public class Authorization
	{
		public void Login(string input)
		{
			var arrUsers = new Users[]
	   {
			new Users("Gera","1337"),
			new Users("Vladka", "1466"),
			new Users("Ilya", "1277")
	   };
			bool login_success = false;
			while (!login_success)
			{

				if (input == "1")
				{
					Console.WriteLine("Welcome aboard. Write your username:");
					var username = Console.ReadLine();
					Console.WriteLine("Enter your password:");
					var password = Console.ReadLine();


					foreach (Users user in arrUsers)
					{
						if (username == user.username && password == user.password)
						{
							Console.WriteLine("You have successfully logged in");
							Console.ReadLine();
							login_success = true;
							break;
						}
					}

					if (!login_success)
					{
						Console.WriteLine("Your username or password is incorect, try again");
					}

				}
				else if (input == "2")
				{

					Console.WriteLine("Create your username:");
					var username = Console.ReadLine();

					Console.WriteLine("Create your password:");
					var password = Console.ReadLine();

					Array.Resize(ref arrUsers, arrUsers.Length + 1);
					arrUsers[arrUsers.Length - 1] = new Users(username, password);
					Console.WriteLine("Account created");
					input = "1";
				}
				else
				{
					Console.WriteLine("Vrong Login/Password");
					break;
				}

			}
		}
	}
}
