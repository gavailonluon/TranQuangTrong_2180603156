namespace De02
{
    partial class frmSanpham
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btSearch = new Button();
            btThem = new Button();
            btSua = new Button();
            btXoa = new Button();
            btLuu = new Button();
            btKLuu = new Button();
            btThoat = new Button();
            lvSanpham = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            txtKeybox = new TextBox();
            txtMaSP = new TextBox();
            txtTenSP = new TextBox();
            dtNgaynhap = new DateTimePicker();
            cboLoaiSP = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(328, 21);
            label1.Name = "label1";
            label1.Size = new Size(313, 38);
            label1.TabIndex = 0;
            label1.Text = "DANH MỤC SẢN PHẨM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(625, 148);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 1;
            label2.Text = "Mã SP:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(623, 199);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 2;
            label3.Text = "Tên SP:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(623, 243);
            label4.Name = "label4";
            label4.Size = new Size(84, 20);
            label4.TabIndex = 3;
            label4.Text = "Ngày nhập:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(623, 298);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 4;
            label5.Text = "Loại SP:";
            // 
            // btSearch
            // 
            btSearch.Location = new Point(230, 71);
            btSearch.Name = "btSearch";
            btSearch.Size = new Size(94, 29);
            btSearch.TabIndex = 6;
            btSearch.Text = "Tìm";
            btSearch.UseVisualStyleBackColor = true;
            btSearch.Click += btSearch_Click;
            // 
            // btThem
            // 
            btThem.Location = new Point(83, 372);
            btThem.Name = "btThem";
            btThem.Size = new Size(94, 29);
            btThem.TabIndex = 7;
            btThem.Text = "Thêm";
            btThem.UseVisualStyleBackColor = true;
            btThem.Click += btThem_Click;
            // 
            // btSua
            // 
            btSua.Location = new Point(208, 372);
            btSua.Name = "btSua";
            btSua.Size = new Size(94, 29);
            btSua.TabIndex = 8;
            btSua.Text = "Sửa";
            btSua.UseVisualStyleBackColor = true;
            btSua.Click += btSua_Click;
            // 
            // btXoa
            // 
            btXoa.Location = new Point(344, 372);
            btXoa.Name = "btXoa";
            btXoa.Size = new Size(94, 29);
            btXoa.TabIndex = 9;
            btXoa.Text = "Xóa";
            btXoa.UseVisualStyleBackColor = true;
            btXoa.Click += btXoa_Click;
            // 
            // btLuu
            // 
            btLuu.Location = new Point(461, 372);
            btLuu.Name = "btLuu";
            btLuu.Size = new Size(94, 29);
            btLuu.TabIndex = 10;
            btLuu.Text = "Lưu";
            btLuu.UseVisualStyleBackColor = true;
            // 
            // btKLuu
            // 
            btKLuu.Location = new Point(579, 372);
            btKLuu.Name = "btKLuu";
            btKLuu.Size = new Size(94, 29);
            btKLuu.TabIndex = 11;
            btKLuu.Text = "K.Lưu";
            btKLuu.UseVisualStyleBackColor = true;
            // 
            // btThoat
            // 
            btThoat.Location = new Point(704, 372);
            btThoat.Name = "btThoat";
            btThoat.Size = new Size(94, 29);
            btThoat.TabIndex = 12;
            btThoat.Text = "Thoát";
            btThoat.UseVisualStyleBackColor = true;
            btThoat.Click += btThoat_Click;
            // 
            // lvSanpham
            // 
            lvSanpham.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lvSanpham.Location = new Point(24, 106);
            lvSanpham.Name = "lvSanpham";
            lvSanpham.Size = new Size(545, 247);
            lvSanpham.TabIndex = 13;
            lvSanpham.UseCompatibleStateImageBehavior = false;
            lvSanpham.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Mã SP";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Tên sản phẩm";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Ngày nhập";
            columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Loại SP";
            columnHeader4.Width = 100;
            // 
            // txtKeybox
            // 
            txtKeybox.Location = new Point(45, 71);
            txtKeybox.Name = "txtKeybox";
            txtKeybox.Size = new Size(179, 27);
            txtKeybox.TabIndex = 14;
            // 
            // txtMaSP
            // 
            txtMaSP.Location = new Point(705, 141);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.Size = new Size(249, 27);
            txtMaSP.TabIndex = 15;
            // 
            // txtTenSP
            // 
            txtTenSP.Location = new Point(704, 196);
            txtTenSP.Name = "txtTenSP";
            txtTenSP.Size = new Size(249, 27);
            txtTenSP.TabIndex = 16;
            // 
            // dtNgaynhap
            // 
            dtNgaynhap.Location = new Point(704, 238);
            dtNgaynhap.Name = "dtNgaynhap";
            dtNgaynhap.Size = new Size(250, 27);
            dtNgaynhap.TabIndex = 17;
            // 
            // cboLoaiSP
            // 
            cboLoaiSP.FormattingEnabled = true;
            cboLoaiSP.Items.AddRange(new object[] { "Bánh kẹo", "Giải khát" });
            cboLoaiSP.Location = new Point(704, 290);
            cboLoaiSP.Name = "cboLoaiSP";
            cboLoaiSP.Size = new Size(250, 28);
            cboLoaiSP.TabIndex = 18;
            // 
            // frmSanpham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1013, 468);
            Controls.Add(cboLoaiSP);
            Controls.Add(dtNgaynhap);
            Controls.Add(txtTenSP);
            Controls.Add(txtMaSP);
            Controls.Add(txtKeybox);
            Controls.Add(lvSanpham);
            Controls.Add(btThoat);
            Controls.Add(btKLuu);
            Controls.Add(btLuu);
            Controls.Add(btXoa);
            Controls.Add(btSua);
            Controls.Add(btThem);
            Controls.Add(btSearch);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmSanpham";
            Text = "QUAN LY SAN PHAM";
            Load += frmSanpham_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btSearch;
        private Button btThem;
        private Button btSua;
        private Button btXoa;
        private Button btLuu;
        private Button btKLuu;
        private Button btThoat;
        private ListView lvSanpham;
        private TextBox txtKeybox;
        private TextBox txtMaSP;
        private TextBox txtTenSP;
        private DateTimePicker dtNgaynhap;
        private ComboBox cboLoaiSP;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
    }
}