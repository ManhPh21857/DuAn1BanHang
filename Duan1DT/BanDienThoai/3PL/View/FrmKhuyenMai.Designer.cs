namespace _3PL.View
{
    partial class FrmKhuyenMai
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKhuyenMai));
            groupBox3 = new GroupBox();
            dgrid_KhuyenMai = new DataGridView();
            groupBox2 = new GroupBox();
            btn_lamMoi = new Button();
            btb_CapNhat = new Button();
            btn_them = new Button();
            groupBox1 = new GroupBox();
            txt_GiamGia = new TextBox();
            dtPicker_NgayKetThuc = new DateTimePicker();
            dtPicker_NgayBatDau = new DateTimePicker();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            rbtn_NgungKM = new RadioButton();
            rbtn_KhuyenMai = new RadioButton();
            label3 = new Label();
            txt_TenKM = new TextBox();
            label2 = new Label();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgrid_KhuyenMai).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgrid_KhuyenMai);
            groupBox3.Location = new Point(55, 247);
            groupBox3.Margin = new Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 2, 3, 2);
            groupBox3.Size = new Size(688, 248);
            groupBox3.TabIndex = 17;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh sách diện thoại";
            // 
            // dgrid_KhuyenMai
            // 
            dgrid_KhuyenMai.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgrid_KhuyenMai.Location = new Point(18, 21);
            dgrid_KhuyenMai.Name = "dgrid_KhuyenMai";
            dgrid_KhuyenMai.RowTemplate.Height = 25;
            dgrid_KhuyenMai.Size = new Size(648, 178);
            dgrid_KhuyenMai.TabIndex = 0;
            dgrid_KhuyenMai.CellClick += dgrid_KhuyenMai_CellClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_lamMoi);
            groupBox2.Controls.Add(btb_CapNhat);
            groupBox2.Controls.Add(btn_them);
            groupBox2.Location = new Point(520, 11);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(293, 182);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức năng";
            // 
            // btn_lamMoi
            // 
            btn_lamMoi.Image = (Image)resources.GetObject("btn_lamMoi.Image");
            btn_lamMoi.ImageAlign = ContentAlignment.MiddleLeft;
            btn_lamMoi.Location = new Point(80, 139);
            btn_lamMoi.Margin = new Padding(3, 2, 3, 2);
            btn_lamMoi.Name = "btn_lamMoi";
            btn_lamMoi.Size = new Size(121, 38);
            btn_lamMoi.TabIndex = 2;
            btn_lamMoi.Text = "Làm mới";
            btn_lamMoi.UseVisualStyleBackColor = true;
            btn_lamMoi.Click += btn_lamMoi_Click;
            // 
            // btb_CapNhat
            // 
            btb_CapNhat.Image = (Image)resources.GetObject("btb_CapNhat.Image");
            btb_CapNhat.ImageAlign = ContentAlignment.MiddleLeft;
            btb_CapNhat.Location = new Point(80, 86);
            btb_CapNhat.Margin = new Padding(3, 2, 3, 2);
            btb_CapNhat.Name = "btb_CapNhat";
            btb_CapNhat.Size = new Size(121, 38);
            btb_CapNhat.TabIndex = 1;
            btb_CapNhat.Text = "Cập nhật";
            btb_CapNhat.UseVisualStyleBackColor = true;
            btb_CapNhat.Click += btb_CapNhat_Click;
            // 
            // btn_them
            // 
            btn_them.BackgroundImageLayout = ImageLayout.None;
            btn_them.Image = (Image)resources.GetObject("btn_them.Image");
            btn_them.ImageAlign = ContentAlignment.MiddleLeft;
            btn_them.Location = new Point(80, 28);
            btn_them.Margin = new Padding(3, 2, 3, 2);
            btn_them.Name = "btn_them";
            btn_them.Size = new Size(121, 38);
            btn_them.TabIndex = 0;
            btn_them.Text = "Thêm";
            btn_them.UseVisualStyleBackColor = true;
            btn_them.Click += btn_them_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txt_GiamGia);
            groupBox1.Controls.Add(dtPicker_NgayKetThuc);
            groupBox1.Controls.Add(dtPicker_NgayBatDau);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(rbtn_NgungKM);
            groupBox1.Controls.Add(rbtn_KhuyenMai);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txt_TenKM);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(55, 6);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(423, 237);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin điện thoại";
            // 
            // txt_GiamGia
            // 
            txt_GiamGia.Location = new Point(136, 130);
            txt_GiamGia.Margin = new Padding(3, 2, 3, 2);
            txt_GiamGia.Name = "txt_GiamGia";
            txt_GiamGia.Size = new Size(185, 23);
            txt_GiamGia.TabIndex = 12;
            // 
            // dtPicker_NgayKetThuc
            // 
            dtPicker_NgayKetThuc.Location = new Point(136, 92);
            dtPicker_NgayKetThuc.Name = "dtPicker_NgayKetThuc";
            dtPicker_NgayKetThuc.Size = new Size(200, 23);
            dtPicker_NgayKetThuc.TabIndex = 11;
            // 
            // dtPicker_NgayBatDau
            // 
            dtPicker_NgayBatDau.Location = new Point(136, 57);
            dtPicker_NgayBatDau.Name = "dtPicker_NgayBatDau";
            dtPicker_NgayBatDau.Size = new Size(200, 23);
            dtPicker_NgayBatDau.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 133);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 9;
            label5.Text = "Giảm giá";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 98);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 8;
            label4.Text = "Ngày kết thúc";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 63);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 7;
            label1.Text = "Ngày bắt đầu";
            // 
            // rbtn_NgungKM
            // 
            rbtn_NgungKM.AutoSize = true;
            rbtn_NgungKM.Location = new Point(264, 182);
            rbtn_NgungKM.Margin = new Padding(3, 2, 3, 2);
            rbtn_NgungKM.Name = "rbtn_NgungKM";
            rbtn_NgungKM.Size = new Size(127, 19);
            rbtn_NgungKM.TabIndex = 6;
            rbtn_NgungKM.TabStop = true;
            rbtn_NgungKM.Text = "Ngừng khuyến mại";
            rbtn_NgungKM.UseVisualStyleBackColor = true;
            // 
            // rbtn_KhuyenMai
            // 
            rbtn_KhuyenMai.AutoSize = true;
            rbtn_KhuyenMai.Location = new Point(123, 182);
            rbtn_KhuyenMai.Margin = new Padding(3, 2, 3, 2);
            rbtn_KhuyenMai.Name = "rbtn_KhuyenMai";
            rbtn_KhuyenMai.Size = new Size(118, 19);
            rbtn_KhuyenMai.TabIndex = 5;
            rbtn_KhuyenMai.TabStop = true;
            rbtn_KhuyenMai.Text = "Đang khuyến mại";
            rbtn_KhuyenMai.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 186);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 4;
            label3.Text = "Trạng thái";
            // 
            // txt_TenKM
            // 
            txt_TenKM.Location = new Point(136, 25);
            txt_TenKM.Margin = new Padding(3, 2, 3, 2);
            txt_TenKM.Name = "txt_TenKM";
            txt_TenKM.Size = new Size(185, 23);
            txt_TenKM.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 28);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 1;
            label2.Text = "Tên KM";
            // 
            // FrmKhuyenMai
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 458);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmKhuyenMai";
            Text = "FrmKhuyenMai";
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgrid_KhuyenMai).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private Button btn_lamMoi;
        private Button btb_CapNhat;
        private Button btn_them;
        private GroupBox groupBox1;
        private DateTimePicker dtPicker_NgayKetThuc;
        private DateTimePicker dtPicker_NgayBatDau;
        private Label label5;
        private Label label4;
        private Label label1;
        private RadioButton rbtn_NgungKM;
        private RadioButton rbtn_KhuyenMai;
        private Label label3;
        private TextBox txt_TenKM;
        private Label label2;
        private TextBox txt_GiamGia;
        private DataGridView dgrid_KhuyenMai;
    }
}