using ISpan.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insert
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string sql = @"INSERT INTO UsersTable(Name, Account, Password, Height)VALUES(@Name, @Account, @Password, @Height)";
			var dbHelper = new SqlDbHelper("default");

			try
			{
				var parameters = new SqlParameterBuilder()
					.AddNVarchar("name", 50, "Jerry")
					.AddNVarchar("account", 50, "Jerryabc")
					.AddNVarchar("password", 50, "yrrej")
					.AddInt("height", 175)
					.Build();

				dbHelper.ExecuteNonQuery(sql, parameters);
				Console.WriteLine("Success Added");
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Error Reason message：{ex.Message}");
			}

			try
			{
				var parameters = new SqlParameterBuilder()
					.AddNVarchar("name", 50, "Bob")
					.AddNVarchar("account", 50, "Bobxyz")
					.AddNVarchar("password", 50, "bobob")
					.AddInt("height", 160)
					.Build();

				dbHelper.ExecuteNonQuery(sql, parameters);
				Console.WriteLine("Success Added");
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Error Reason message：{ex.Message}");
			}
		}
	}
}
