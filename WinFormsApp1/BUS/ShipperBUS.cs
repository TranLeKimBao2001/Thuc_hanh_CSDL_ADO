using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.DAO;
using WinFormsApp1.DTO;

namespace WinFormsApp1.BUS
{
	internal class ShipperBUS
	{
		private ShipperDAO shipperDAO = new ShipperDAO();

		public ShipperBUS() 
		{
			shipperDAO = new ShipperDAO();

		}

		public List<DTO.Shipper> getAll()
		{
			DataTable dt = new DataTable();

			try
			{
				dt = shipperDAO.getAll();
			}
			catch(Exception ex)  
			{
				Console.WriteLine(ex.Message);
			}

			List<Shipper> list = new List<Shipper>();
			if(dt.Rows.Count > 0)
			{
				foreach(DataRow dr in dt.Rows)
				{
					Shipper shipper = new Shipper();
					shipper.Id = Int32.Parse(dr["ShipperId"].ToString());
					//shipper.Name = dr["CompanyName"].ToString();
					shipper.Phone = dr["Phone"].ToString();
					list.Add(shipper);
				}
			}
			return list;

		}

		
	}
}
