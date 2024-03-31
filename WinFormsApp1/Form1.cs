using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using WinFormsApp1.BUS;
using WinFormsApp1.DTO;

namespace WinFormsApp1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			shipperBUS = new ShipperBUS();
		}

		private ShipperBUS shipperBUS;

		private void Form1_Load(object sender, EventArgs e)
		{
			//loadDataWithReader();
			List<Shipper> shipperlist = shipperBUS.getAll();
			int i = 0;
			foreach (Shipper shipper in shipperlist)
			{
				cklbCacGoiDichVu.Items.Add(shipper.Name);

				cklbCacGoiDichVu.SelectedIndexChanged += enableBtnThanhToan;

				RadioButton radioButton = new RadioButton();
				radioButton.AutoSize = true;
				radioButton.Location = new Point(15, 22 + i * 50);
				radioButton.Name = "rd" + shipper.Id.ToString();
				radioButton.Size = new Size(94, 19);
				radioButton.TabIndex = i;
				radioButton.TabStop = true;
				radioButton.Text = shipper.Name;
				radioButton.UseVisualStyleBackColor = true;
				radioButton.CheckedChanged += enableBtnThanhToan;
				grbTienNghi.Controls.Add(radioButton);
				i++;
			}

			
		}
		public void loadDataWithReader()
		{
			string constr = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ABC;Integrated Security=True";
			SqlConnection conn = new(constr);
			SqlCommand cmd = new();
			cmd.Connection = conn;
			cmd.CommandText = "select * from Servies";
			try
			{
				if (conn.State == ConnectionState.Closed ||
					conn.State == ConnectionState.Broken)
				{
					conn.Open();
				}
				SqlDataReader reader = cmd.ExecuteReader();

				int i = 0;
				while (reader.Read())
				{

					cklbCacGoiDichVu.Items.Add(reader["Name"].ToString());

					cklbCacGoiDichVu.SelectedIndexChanged += enableBtnThanhToan;

					RadioButton radioButton = new RadioButton();
					radioButton.AutoSize = true;
					radioButton.Location = new Point(15, 22 + i * 50);
					radioButton.Name = "rd" + reader["Id"].ToString();
					radioButton.Size = new Size(94, 19);
					radioButton.TabIndex = i;
					radioButton.TabStop = true;
					radioButton.Text = reader["Name"].ToString();
					radioButton.UseVisualStyleBackColor = true;
					radioButton.CheckedChanged += enableBtnThanhToan;
					grbTienNghi.Controls.Add(radioButton);
					i++;
				}
				reader.Close();
				conn.Close();
			}
			catch (Exception ex)
			{

			}
		}

		public void enableBtnThanhToan(object sender, EventArgs e)
		{
			if (cklbCacGoiDichVu.CheckedIndices.Count > 0)
			{
				//cklbCacGoiDichVu.
				foreach (RadioButton radio in grbTienNghi.Controls)
				{
					if (radio.Checked)
					{
						btnThanhToan.Enabled = true;
						break;
					}

				}
			}
			else
			{
				btnThanhToan.Enabled = false;

			}
		}
		private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
		{

		}
		private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}




		private void txtNhapten_TextChanged(object sender, EventArgs e)
		{

			if (txtNhapten.Text.Length > 0)
			{
				btnNhapMoi.Enabled = true;
				//btnNhapLai.Enabled = true;
				//btnThanhToan.Enabled = true;
			}
			else
			{
				btnNhapMoi.Enabled = false;
				//btnNhapLai.Enabled = false;
				//btnThanhToan.Enabled = false;
			}

		}
		int dem;
		private void btnNhapMoi_Click(object sender, EventArgs e)
		{
			dem++;
			//txtSoLuotNguoi.Text = dem.ToString();
			txtNhapten.Clear();
			txtDiaChi.Clear();
			txtSoNgayO.Clear();


		}

		private void textBox5_TextChanged(object sender, EventArgs e)
		{
			//txtSoLuotNguoi.Text = dem.ToString();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			txtSoLuotNguoi.Text = dem.ToString();

		}

		private void txtSoNgayO_TextChanged(object sender, EventArgs e)
		{
			//string data = txtSoNgayO.Text;
			//float soNgay = Int32.Parse(data);
		}
	}
}