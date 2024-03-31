using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.DAO
{
	internal class ShipperDAO
	{
		private DataProvider dataProvider;
		public ShipperDAO() 
		{
			dataProvider = new DataProvider();
			

		}

		public DataTable getAll()
		{
			DataTable dt = new DataTable();
			string query = "Select * from Shippers";
			try
			{
				dt = dataProvider.ExecuteSelectAllQuery(query);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}

			return dt;

		}
	}
}
