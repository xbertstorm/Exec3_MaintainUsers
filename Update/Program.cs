using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISpan.Utility;

namespace Update
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string sql = @"UPDATE UsersTable SET Name=@Name, Password=@Password WHERE Id=@Id";

			var dbHelper = new SqlDbHelper("default");
			try
			{
				var parameters = new SqlParameterBuilder()
					.AddNVarchar("Name", 50, "Jerry")
					.AddNVarchar("Password", 50, "abcdjerry")
					.AddInt("id", 2)
					.Build();

				dbHelper.ExecuteNonQuery(sql, parameters);
				Console.WriteLine("Successful Update");
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Update Fail Reason：{ex.Message}");
			}

			string sql2 = @"UPDATE UsersTable SET Account=@Account, Password=@Password WHERE Name=@Name";

			try
			{
				var parameters = new SqlParameterBuilder()
					.AddNVarchar("Name", 50, "Jerry")
					.AddNVarchar("Account", 50, "Jerry")
					.AddNVarchar("Password", 50, "abcdjerry")
					.Build();

				dbHelper.ExecuteNonQuery(sql2, parameters);
				Console.WriteLine("Successful Update");
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Update Fail Reason：{ex.Message}");
			}
		}
	}
}
