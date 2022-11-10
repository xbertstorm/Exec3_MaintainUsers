using ISpan.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delete
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string sql = @"DELETE FROM UsersTable WHERE Height <= @Height";

			var dbHelper = new SqlDbHelper("default");
			try
			{
				var parameters = new SqlParameterBuilder()
					.AddNVarchar("Height", 50, "170")
					.Build();
				dbHelper.ExecuteNonQuery(sql, parameters);
				Console.WriteLine("Success");
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Error Reason：{ex.Message}");
			}
		}
	}
}
