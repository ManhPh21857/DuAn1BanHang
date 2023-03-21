using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _1DAL.Models;
using _2BUS.IService;
using _2BUS.Service;
namespace _3PL.View
{
    public partial class FrmImei : Form
    {
        private IImeiService _ISV = new IMeiService();
        public Imei _IM;
        public FrmImei()
        {
            InitializeComponent();
        }

        public void LoadTodata()
        {
            dtgv_DT.Rows.Clear();
            foreach (var item in _ISV.GetAll())
            {
                dtgv_DT.Rows.Add(item.MaImei, item.TenImei,
                    item.TrangThai == true ? "Còn hàng" : "Hết hàng");
            }
        }

        private void dtgv_DT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgv_DT.Rows[e.RowIndex];
                _IM = _ISV.GetAll().FirstOrDefault(x => x.MaImei == Convert.ToInt32(row.Cells[0].Value));
                tbt_TenDT.Text = row.Cells[1].Value.ToString();
                rb_HoatDong.Checked = row.Cells[2].Value.ToString() == "Còn hàng" ? true : false;
                rb_KHD.Checked = row.Cells[2].Value.ToString() == "Hết hàng" ? true : false;
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            Imei accDT = _ISV.GetAll().FirstOrDefault
           (p => p.TenImei == tbt_TenDT.Text);
            if (tbt_TenDT.Text == "")
            {
                MessageBox.Show("Không được để trống thông tin");
            }
            else if(tbt_TenDT.Text.Length >= 50)
            {
                MessageBox.Show("Nhập quá Ký tự cho phép vui lòng nhập lại");
            }
            else if (rb_HoatDong.Checked != true && rb_KHD.Checked != true)
            {
                MessageBox.Show("Vui lòng chọn trạng thái");
            }
            else if (accDT != null)
            {
                MessageBox.Show("Imei đã tồn tại");
            }
            else
            {
                Imei IM = new Imei()
                {
                    TenImei = tbt_TenDT.Text,
                    TrangThai = rb_HoatDong.Checked ? true : false,
                };
                _ISV.Add(IM);
                MessageBox.Show("Thêm Điện Thoại thành công");
                LoadTodata();
            }
        }

        private void btb_CapNhat_Click(object sender, EventArgs e)
        {
            if (_IM == null)
            {
                MessageBox.Show("Vui lòng chọn Điện Thoại");
            }
            else if (tbt_TenDT.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên Điện thoại");
            }
            else if(tbt_TenDT.Text.Length >= 50)
            {
                MessageBox.Show("Nhập quá ký tự cho phép vui lòng nhập lại");
            }
            else
            {
                if (_IM.TenImei == tbt_TenDT.Text || (_IM.TenImei != tbt_TenDT.Text && _ISV.GetAll().FirstOrDefault(x => x.TenImei == tbt_TenDT.Text) == null))
                {
                    _IM.TenImei = tbt_TenDT.Text;
                    _IM.TrangThai = rb_HoatDong.Checked ? true : false;
                    _ISV.Update(_IM);
                    MessageBox.Show("Cập nhật thành công");
                    LoadTodata();
                }
                else
                {
                    MessageBox.Show("Tên Điện Thoại đã tồn tại");
                }
            }
        }

        private void btn_lamMoi_Click(object sender, EventArgs e)
        {
            _IM = null;
            LoadTodata();
            tbt_TenDT.Text = "";
            rb_HoatDong.Checked = false;
            rb_KHD.Checked = false;
        }
    }
}
