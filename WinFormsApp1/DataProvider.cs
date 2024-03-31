using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace WinFormsApp1
{
	internal class DataProvider
	{
		SqlConnection conn;
		SqlDataAdapter adapter;

		public DataProvider()
		{
			string constr = "Data Source=DESKTOP-RDT7MOC\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True"; 

			conn = new SqlConnection(constr);
			adapter = new SqlDataAdapter();
		}

		private SqlConnection OpenConnection()
		{
			if(conn.State == ConnectionState.Closed || 
				conn.State == ConnectionState.Broken) 
			{
				conn.Open();
			}
			return conn;
		}
		public DataTable ExecuteSelectAllQuery(string _query)
		{
			SqlCommand myCommand = new SqlCommand();
			DataTable dataTable = new DataTable();
			DataSet ds = new DataSet();

			try
			{
				myCommand.Connection = OpenConnection();
				myCommand.CommandText = _query;
				adapter.SelectCommand = myCommand;
				adapter.Fill(ds);
				dataTable = ds.Tables[0];

			}
			catch(SqlException e)
			{
				Console.Write("Error - Connection.executeSelectQuery - Query: " + _query
					+ "\nException: " + e.StackTrace.ToString());
				return null;
			}
			finally
			{

			}
			return dataTable;
		}
	}
}
//     Hello
// Chàoooooooooooooooooooooooooo
