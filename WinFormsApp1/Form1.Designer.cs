namespace WinFormsApp1
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			splitContainer1 = new SplitContainer();
			grbTienNghi = new GroupBox();
			radioButton1 = new RadioButton();
			grbDichVu = new GroupBox();
			cklbCacGoiDichVu = new CheckedListBox();
			btnThoat = new Button();
			textBox6 = new TextBox();
			txtSoLuotNguoi = new TextBox();
			label6 = new Label();
			label7 = new Label();
			label8 = new Label();
			button1 = new Button();
			txtThanhTien = new TextBox();
			label5 = new Label();
			btnNhapMoi = new Button();
			btnThanhToan = new Button();
			label1 = new Label();
			label4 = new Label();
			label2 = new Label();
			label3 = new Label();
			txtNhapten = new TextBox();
			txtDiaChi = new TextBox();
			txtSoNgayO = new TextBox();
			((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
			splitContainer1.Panel1.SuspendLayout();
			splitContainer1.Panel2.SuspendLayout();
			splitContainer1.SuspendLayout();
			grbTienNghi.SuspendLayout();
			grbDichVu.SuspendLayout();
			SuspendLayout();
			// 
			// splitContainer1
			// 
			splitContainer1.Dock = DockStyle.Bottom;
			splitContainer1.Location = new Point(0, 156);
			splitContainer1.Margin = new Padding(3, 2, 3, 2);
			splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			splitContainer1.Panel1.Controls.Add(grbTienNghi);
			splitContainer1.Panel1.Controls.Add(grbDichVu);
			splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
			// 
			// splitContainer1.Panel2
			// 
			splitContainer1.Panel2.Controls.Add(btnThoat);
			splitContainer1.Panel2.Controls.Add(textBox6);
			splitContainer1.Panel2.Controls.Add(txtSoLuotNguoi);
			splitContainer1.Panel2.Controls.Add(label6);
			splitContainer1.Panel2.Controls.Add(label7);
			splitContainer1.Panel2.Controls.Add(label8);
			splitContainer1.Panel2.Controls.Add(button1);
			splitContainer1.Panel2.Controls.Add(txtThanhTien);
			splitContainer1.Panel2.Controls.Add(label5);
			splitContainer1.Panel2.Controls.Add(btnNhapMoi);
			splitContainer1.Panel2.Controls.Add(btnThanhToan);
			splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
			splitContainer1.Size = new Size(892, 284);
			splitContainer1.SplitterDistance = 546;
			splitContainer1.TabIndex = 0;
			// 
			// grbTienNghi
			// 
			grbTienNghi.Controls.Add(radioButton1);
			grbTienNghi.Location = new Point(266, 11);
			grbTienNghi.Margin = new Padding(3, 2, 3, 2);
			grbTienNghi.Name = "grbTienNghi";
			grbTienNghi.Padding = new Padding(3, 2, 3, 2);
			grbTienNghi.Size = new Size(140, 235);
			grbTienNghi.TabIndex = 5;
			grbTienNghi.TabStop = false;
			grbTienNghi.Text = "Loại phòng";
			// 
			// radioButton1
			// 
			radioButton1.AutoSize = true;
			radioButton1.Location = new Point(13, 33);
			radioButton1.Margin = new Padding(3, 2, 3, 2);
			radioButton1.Name = "radioButton1";
			radioButton1.Size = new Size(94, 19);
			radioButton1.TabIndex = 0;
			radioButton1.TabStop = true;
			radioButton1.Text = "radioButton1";
			radioButton1.UseVisualStyleBackColor = true;
			// 
			// grbDichVu
			// 
			grbDichVu.Controls.Add(cklbCacGoiDichVu);
			grbDichVu.Location = new Point(10, 11);
			grbDichVu.Margin = new Padding(3, 2, 3, 2);
			grbDichVu.Name = "grbDichVu";
			grbDichVu.Padding = new Padding(3, 2, 3, 2);
			grbDichVu.Size = new Size(233, 235);
			grbDichVu.TabIndex = 4;
			grbDichVu.TabStop = false;
			grbDichVu.Text = "Dịch vụ";
			// 
			// cklbCacGoiDichVu
			// 
			cklbCacGoiDichVu.BackColor = SystemColors.Control;
			cklbCacGoiDichVu.FormattingEnabled = true;
			cklbCacGoiDichVu.Location = new Point(23, 33);
			cklbCacGoiDichVu.Margin = new Padding(3, 2, 3, 2);
			cklbCacGoiDichVu.Name = "cklbCacGoiDichVu";
			cklbCacGoiDichVu.Size = new Size(185, 112);
			cklbCacGoiDichVu.TabIndex = 0;
			// 
			// btnThoat
			// 
			btnThoat.Enabled = false;
			btnThoat.Location = new Point(28, 236);
			btnThoat.Margin = new Padding(3, 2, 3, 2);
			btnThoat.Name = "btnThoat";
			btnThoat.Size = new Size(98, 31);
			btnThoat.TabIndex = 15;
			btnThoat.Text = "Thoát";
			btnThoat.UseVisualStyleBackColor = true;
			btnThoat.Click += btnThoat_Click;
			// 
			// textBox6
			// 
			textBox6.BorderStyle = BorderStyle.FixedSingle;
			textBox6.Location = new Point(131, 171);
			textBox6.Margin = new Padding(3, 2, 3, 2);
			textBox6.Name = "textBox6";
			textBox6.Size = new Size(189, 23);
			textBox6.TabIndex = 14;
			// 
			// txtSoLuotNguoi
			// 
			txtSoLuotNguoi.BorderStyle = BorderStyle.FixedSingle;
			txtSoLuotNguoi.Location = new Point(131, 143);
			txtSoLuotNguoi.Margin = new Padding(3, 2, 3, 2);
			txtSoLuotNguoi.Name = "txtSoLuotNguoi";
			txtSoLuotNguoi.Size = new Size(189, 23);
			txtSoLuotNguoi.TabIndex = 13;
			txtSoLuotNguoi.TextChanged += textBox5_TextChanged;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
			label6.ForeColor = SystemColors.ActiveCaptionText;
			label6.Location = new Point(15, 171);
			label6.Name = "label6";
			label6.Size = new Size(95, 19);
			label6.TabIndex = 10;
			label6.Text = "Tổng số tiền:";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
			label7.ForeColor = SystemColors.ActiveCaptionText;
			label7.Location = new Point(15, 146);
			label7.Name = "label7";
			label7.Size = new Size(104, 19);
			label7.TabIndex = 11;
			label7.Text = "Số lượt người:";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
			label8.ForeColor = SystemColors.ActiveCaptionText;
			label8.Location = new Point(15, 124);
			label8.Name = "label8";
			label8.Size = new Size(132, 19);
			label8.TabIndex = 12;
			label8.Text = "Thông tin tổng kết";
			// 
			// button1
			// 
			button1.Location = new Point(15, 94);
			button1.Margin = new Padding(3, 2, 3, 2);
			button1.Name = "button1";
			button1.Size = new Size(98, 28);
			button1.TabIndex = 11;
			button1.Text = "Tổng kết";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// txtThanhTien
			// 
			txtThanhTien.BorderStyle = BorderStyle.FixedSingle;
			txtThanhTien.Location = new Point(120, 63);
			txtThanhTien.Margin = new Padding(3, 2, 3, 2);
			txtThanhTien.Name = "txtThanhTien";
			txtThanhTien.Size = new Size(201, 23);
			txtThanhTien.TabIndex = 10;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
			label5.ForeColor = SystemColors.ActiveCaptionText;
			label5.Location = new Point(15, 63);
			label5.Name = "label5";
			label5.Size = new Size(82, 19);
			label5.TabIndex = 10;
			label5.Text = "Thành tiền:";
			// 
			// btnNhapMoi
			// 
			btnNhapMoi.Enabled = false;
			btnNhapMoi.Location = new Point(143, 11);
			btnNhapMoi.Margin = new Padding(3, 2, 3, 2);
			btnNhapMoi.Name = "btnNhapMoi";
			btnNhapMoi.Size = new Size(98, 31);
			btnNhapMoi.TabIndex = 7;
			btnNhapMoi.Text = "Nhập mới";
			btnNhapMoi.UseVisualStyleBackColor = true;
			btnNhapMoi.Click += btnNhapMoi_Click;
			// 
			// btnThanhToan
			// 
			btnThanhToan.Enabled = false;
			btnThanhToan.Location = new Point(15, 11);
			btnThanhToan.Margin = new Padding(3, 2, 3, 2);
			btnThanhToan.Name = "btnThanhToan";
			btnThanhToan.Size = new Size(98, 31);
			btnThanhToan.TabIndex = 5;
			btnThanhToan.Text = "Thanh toán";
			btnThanhToan.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
			label1.ForeColor = Color.FromArgb(255, 128, 0);
			label1.Location = new Point(327, 7);
			label1.Name = "label1";
			label1.Size = new Size(314, 20);
			label1.TabIndex = 1;
			label1.Text = "KHÁCH SẠN THANH THANH - TRẢ PHÒNG";
			label1.Click += label1_Click;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
			label4.ForeColor = SystemColors.ActiveCaptionText;
			label4.Location = new Point(25, 49);
			label4.Name = "label4";
			label4.Size = new Size(78, 19);
			label4.TabIndex = 4;
			label4.Text = "Họ và tên:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
			label2.ForeColor = SystemColors.ActiveCaptionText;
			label2.Location = new Point(25, 113);
			label2.Name = "label2";
			label2.Size = new Size(80, 19);
			label2.TabIndex = 5;
			label2.Text = "Số ngày ở:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
			label3.ForeColor = SystemColors.ActiveCaptionText;
			label3.Location = new Point(25, 82);
			label3.Name = "label3";
			label3.Size = new Size(58, 19);
			label3.TabIndex = 6;
			label3.Text = "Địa chỉ:";
			// 
			// txtNhapten
			// 
			txtNhapten.BorderStyle = BorderStyle.FixedSingle;
			txtNhapten.Location = new Point(126, 49);
			txtNhapten.Margin = new Padding(3, 2, 3, 2);
			txtNhapten.Name = "txtNhapten";
			txtNhapten.Size = new Size(214, 23);
			txtNhapten.TabIndex = 1;
			txtNhapten.TextChanged += txtNhapten_TextChanged;
			// 
			// txtDiaChi
			// 
			txtDiaChi.BorderStyle = BorderStyle.FixedSingle;
			txtDiaChi.Location = new Point(126, 82);
			txtDiaChi.Margin = new Padding(3, 2, 3, 2);
			txtDiaChi.Name = "txtDiaChi";
			txtDiaChi.Size = new Size(300, 23);
			txtDiaChi.TabIndex = 2;
			// 
			// txtSoNgayO
			// 
			txtSoNgayO.BorderStyle = BorderStyle.FixedSingle;
			txtSoNgayO.Location = new Point(126, 113);
			txtSoNgayO.Margin = new Padding(3, 2, 3, 2);
			txtSoNgayO.Name = "txtSoNgayO";
			txtSoNgayO.Size = new Size(110, 23);
			txtSoNgayO.TabIndex = 3;
			txtSoNgayO.TextChanged += txtSoNgayO_TextChanged;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(892, 440);
			Controls.Add(txtSoNgayO);
			Controls.Add(txtDiaChi);
			Controls.Add(txtNhapten);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label4);
			Controls.Add(label1);
			Controls.Add(splitContainer1);
			Margin = new Padding(3, 2, 3, 2);
			Name = "Form1";
			Text = "Form1";
			Load += Form1_Load;
			splitContainer1.Panel1.ResumeLayout(false);
			splitContainer1.Panel2.ResumeLayout(false);
			splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
			splitContainer1.ResumeLayout(false);
			grbTienNghi.ResumeLayout(false);
			grbTienNghi.PerformLayout();
			grbDichVu.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private SplitContainer splitContainer1;
		private GroupBox grbDichVu;
		private CheckedListBox cklbCacGoiDichVu;
		private GroupBox grbTienNghi;
		private RadioButton radioButton1;
		private Button btnThanhToan;
		private Label label1;
		private Label label4;
		private Label label2;
		private Label label3;
		private Label label5;
		private Button btnNhapMoi;
		private TextBox txtNhapten;
		private TextBox txtDiaChi;
		private TextBox txtSoNgayO;
		private Button btnThoat;
		private TextBox textBox6;
		private TextBox txtSoLuotNguoi;
		private Label label6;
		private Label label7;
		private Label label8;
		private TextBox txtThanhTien;
		private Button button1;
	}
}