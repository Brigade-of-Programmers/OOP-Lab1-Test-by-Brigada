
namespace TestingApp
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
			bool Login_success = false;
			while (!Login_success)
			{

				if (input == "1")
				{
					Console.WriteLine("Write your username:");
					var username = Console.ReadLine();
					Console.WriteLine("Enter your password:");
					var password = Console.ReadLine();


					foreach (Users user in arrUsers)
					{
						if (username == user.username && password == user.password)
						{
							Console.WriteLine("You have successfully logged in !!!");
							Console.ReadLine();
							Login_success = true;
							break;
						}
					}

					if (!Login_success)
					{
						Console.WriteLine("Your username or password is incorect, try again !!!");
					}

				}
				else if (input == "2")
				{

					Console.WriteLine("Enter your username:");
					var username = Console.ReadLine();

					Console.WriteLine("Enter your password:");
					var password = Console.ReadLine();

					Array.Resize(ref arrUsers, arrUsers.Length + 1);
					arrUsers[arrUsers.Length - 1] = new Users(username, password);
					Login_success = true;
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
