using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.IO;

namespace TestingApp
{
	public class Authorization
	{
		public void Login()
		{
			string username, password, username1, password1 = string.Empty;

			Console.Write("Enter a username: ");
			username = Console.ReadLine();
			Console.Write("Enter a password: ");
			password = Console.ReadLine();

			using (StreamReader sr = new StreamReader(File.Open("C:\\LoginInfo.txt", FileMode.Open)))
			{
				username1 = sr.ReadLine();
				password1 = sr.ReadLine();
				sr.Close();
			}

			if (username == username1 && password == password1)
				Console.WriteLine("Login successful");
			else
				Console.WriteLine("Login failed");
		}

		public void Registration()
        {

        }
	}
}
