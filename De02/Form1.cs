namespace De02
{
    public partial class frmSanpham : Form
    {
        public frmSanpham()
        {
            InitializeComponent();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            ListViewItem listItem = new ListViewItem(txtMaSP.Text);
            listItem.SubItems.Add(txtTenSP.Text);
            listItem.SubItems.Add(dtNgaynhap.Text);
            listItem.SubItems.Add(cboLoaiSP.Text);
            lvSanpham.Items.Add(listItem);
            MessageBox.Show("Đã thêm sản phẩm thành công", "Thông báo");
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (lvSanpham.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvSanpham.SelectedItems[0];
                if (lvSanpham.SelectedItems.Count >= 0)
                {
                    selectedItem.SubItems[0].Text = txtMaSP.Text;
                    selectedItem.SubItems[1].Text = txtTenSP.Text;
                    selectedItem.SubItems[2].Text = dtNgaynhap.Text;
                    selectedItem.SubItems[3].Text = cboLoaiSP.Text;
                }
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo);
            if (lvSanpham.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvSanpham.SelectedItems[0];
                lvSanpham.Items.Remove(selectedItem);
            }


        }

        private void frmSanpham_Load(object sender, EventArgs e)
        {
            btLuu.Enabled = false;
            btKLuu.Enabled = false;
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo);
            Application.Exit();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
           

        }
    }
}
