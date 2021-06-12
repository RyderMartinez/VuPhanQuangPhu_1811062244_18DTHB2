using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap1
{
    public partial class frmSanPham : Form
    {
        public frmSanPham()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            DefineListView();

        }


        void DefineListView()
        {

            lvSanPham.View = View.Details;
            lvSanPham.GridLines = true;
            lvSanPham.FullRowSelect = true;
            lvSanPham.Columns.Add("Mã SP", 80);
            lvSanPham.Columns.Add("Tên Sản Phẩm", 180);
            lvSanPham.Columns.Add("Ngày Nhập", 120);
            lvSanPham.Columns.Add("Loại SP", 150);
             
        }

        private void lvSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {

        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {

        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {


        }

        private void btn_KLuu_Click(object sender, EventArgs e)
        {

        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát ? ", "Thông Báo ", MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Close();
        }

        
    }
}
