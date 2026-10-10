namespace QuanLySinhVien
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
            lblMaSV = new Label();
            txtMaSV = new TextBox();
            lblHoten = new Label();
            txtHoTen = new TextBox();
            txtNgaysinh = new Label();
            dtpNgaySinh = new DateTimePicker();
            lblGioiTinh = new Label();
            comboBox1 = new ComboBox();
            lblMaLop = new Label();
            txtMaLop = new TextBox();
            this.btnThem = new Button();
            this.btnSua = new Button();
            this.btnXoa = new Button();
            btnLamMoi = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblMaSV
            // 
            lblMaSV.AutoSize = true;
            lblMaSV.Location = new Point(34, 29);
            lblMaSV.Name = "lblMaSV";
            lblMaSV.Size = new Size(95, 20);
            lblMaSV.TabIndex = 0;
            lblMaSV.Text = "Mã Sinh Viên";
            lblMaSV.Click += label1_Click;
            // 
            // txtMaSV
            // 
            txtMaSV.Location = new Point(144, 26);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new Size(125, 27);
            txtMaSV.TabIndex = 1;
            // 
            // lblHoten
            // 
            lblHoten.AutoSize = true;
            lblHoten.Location = new Point(34, 71);
            lblHoten.Name = "lblHoten";
            lblHoten.Size = new Size(54, 20);
            lblHoten.TabIndex = 2;
            lblHoten.Text = "Họ tên";
            lblHoten.Click += lblHoten_Click;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(144, 68);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(125, 27);
            txtHoTen.TabIndex = 3;
            // 
            // txtNgaysinh
            // 
            txtNgaysinh.AutoSize = true;
            txtNgaysinh.Location = new Point(34, 116);
            txtNgaysinh.Name = "txtNgaysinh";
            txtNgaysinh.Size = new Size(74, 20);
            txtNgaysinh.TabIndex = 4;
            txtNgaysinh.Text = "Ngày sinh";
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Location = new Point(144, 116);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(250, 27);
            dtpNgaySinh.TabIndex = 5;
            dtpNgaySinh.TabStop = false;
            dtpNgaySinh.Value = new DateTime(2026, 10, 10, 15, 34, 0, 0);
            // 
            // lblGioiTinh
            // 
            lblGioiTinh.AutoSize = true;
            lblGioiTinh.Location = new Point(34, 164);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Size = new Size(65, 20);
            lblGioiTinh.TabIndex = 6;
            lblGioiTinh.Text = "Giới tính";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(144, 161);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 7;
            comboBox1.Text = "Nữ";
            comboBox1.SelectedIndexChanged += this.comboBox1_SelectedIndexChanged;
            // 
            // lblMaLop
            // 
            lblMaLop.AutoSize = true;
            lblMaLop.Location = new Point(34, 208);
            lblMaLop.Name = "lblMaLop";
            lblMaLop.Size = new Size(59, 20);
            lblMaLop.TabIndex = 8;
            lblMaLop.Text = "Mã Lớp";
            // 
            // txtMaLop
            // 
            txtMaLop.Location = new Point(144, 205);
            txtMaLop.Name = "txtMaLop";
            txtMaLop.Size = new Size(125, 27);
            txtMaLop.TabIndex = 9;
            // 
            // btnThem
            // 
            this.btnThem.Location = new Point(83, 262);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new Size(94, 29);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new Point(260, 262);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new Size(94, 29);
            this.btnSua.TabIndex = 11;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += this.button2_Click;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new Point(442, 262);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new Size(94, 29);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(624, 262);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(94, 29);
            btnLamMoi.TabIndex = 13;
            btnLamMoi.Text = "Làm Mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(83, 309);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(635, 188);
            dataGridView1.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btnLamMoi);
            Controls.Add(this.btnXoa);
            Controls.Add(this.btnSua);
            Controls.Add(this.btnThem);
            Controls.Add(txtMaLop);
            Controls.Add(lblMaLop);
            Controls.Add(comboBox1);
            Controls.Add(lblGioiTinh);
            Controls.Add(dtpNgaySinh);
            Controls.Add(txtNgaysinh);
            Controls.Add(txtHoTen);
            Controls.Add(lblHoten);
            Controls.Add(txtMaSV);
            Controls.Add(lblMaSV);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMaSV;
        private TextBox txtMaSV;
        private Label lblHoten;
        private TextBox txtHoTen;
        private Label txtNgaysinh;
        private DateTimePicker dtpNgaySinh;
        private Label lblGioiTinh;
        private ComboBox comboBox1;
        private Label lblMaLop;
        private TextBox txtMaLop;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button btnLamMoi;
        private DataGridView dataGridView1;
    }
}
