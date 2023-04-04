using _1DAL.Models;
using _2BUS.IService;
using _2BUS.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3PL.View
{
    public partial class FrmKhuyenMai : Form
    {
        IKhuyenMaiService _ikhuyenMaiService = new KhuyenMaiService();
        KhuyenMai _km = new KhuyenMai();
        public FrmKhuyenMai()
        {
            InitializeComponent();
            LoadDgrid();
        }
        public void LoadDgrid()
        {
            dgrid_KhuyenMai.ColumnCount = 6;
            dgrid_KhuyenMai.Columns[0].Name = "Mã KM";
            dgrid_KhuyenMai.Columns[0].Visible = false;
            dgrid_KhuyenMai.Columns[1].Name = "Tên KM";
            dgrid_KhuyenMai.Columns[2].Name = "Ngày bắt đầu";
            dgrid_KhuyenMai.Columns[3].Name = "Ngày kết thúc";
            dgrid_KhuyenMai.Columns[4].Name = "Giảm giá";
            dgrid_KhuyenMai.Columns[5].Name = "Trạng thái";
            dgrid_KhuyenMai.Rows.Clear();
            foreach (var x in _ikhuyenMaiService.GetAll())
            {
                dgrid_KhuyenMai.Rows.Add(x.MaKM, x.TenKM, x.NgayBatDau, x.NgayKetThuc, x.GiamGia, x.TrangThai == 0 ? "Đang khuyến mại" : "Ngừng khuyến mại");
            }
        }

        private void dgrid_KhuyenMai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dgrid_KhuyenMai.Rows[e.RowIndex];
                _km = _ikhuyenMaiService.GetAll().FirstOrDefault(p => p.MaKM == Convert.ToInt32(r.Cells[0].Value.ToString()));
                txt_TenKM.Text = r.Cells[1].Value.ToString();
                dtPicker_NgayBatDau.Text = r.Cells[2].Value.ToString();
                dtPicker_NgayKetThuc.Text = r.Cells[3].Value.ToString();
                txt_GiamGia.Text = r.Cells[4].Value.ToString();
                rbtn_KhuyenMai.Checked = r.Cells[5].Value.ToString() == "Đang khuyến mại" ? true : false;
                rbtn_NgungKM.Checked = r.Cells[5].Value.ToString() == "Ngừng khuyến mại" ? true : false;
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (txt_TenKM.Text == "" || dtPicker_NgayBatDau.Text == "" || dtPicker_NgayKetThuc.Text == "" || txt_GiamGia.Text == "" || rbtn_KhuyenMai.Checked == false && rbtn_NgungKM.Checked == false)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else if (Convert.ToDateTime(dtPicker_NgayBatDau.Text) > Convert.ToDateTime(dtPicker_NgayKetThuc.Text) || DateTime.Now < Convert.ToDateTime(dtPicker_NgayBatDau.Text) || Convert.ToDateTime(dtPicker_NgayKetThuc.Text)<DateTime.Now)
            {
                MessageBox.Show("Không thể thêm vì ngày bắt đầu lớn hơn ngày kết thúc hoặc ngày hiện tại");
            }
            else
            {
                if (_ikhuyenMaiService.GetAll().Any(x => x.TenKM == txt_TenKM.Text))
                {
                    MessageBox.Show("Khuyến mại đã tồn tại");
                }
                else
                {
                    var p = new KhuyenMai()
                    {
                        //MaKH = Convert.ToInt32
                        TenKM = txt_TenKM.Text,
                        NgayBatDau = Convert.ToDateTime(dtPicker_NgayBatDau.Text),
                        NgayKetThuc = Convert.ToDateTime(dtPicker_NgayKetThuc.Text),
                        GiamGia = Convert.ToDecimal(txt_GiamGia.Text),
                        TrangThai = rbtn_KhuyenMai.Checked ? 0 : 1,
                    };
                    _ikhuyenMaiService.Add(p);
                    MessageBox.Show("Thêm thành công");
                    LoadDgrid();
                }
            }
        }

        private void btb_CapNhat_Click(object sender, EventArgs e)
        {
            if (_km == null)
            {
                MessageBox.Show("Vui lòng chọn Khuyến Mại");
            }
            else if (txt_TenKM.Text == "" || dtPicker_NgayBatDau.Text == "" || dtPicker_NgayKetThuc.Text == "" || txt_GiamGia.Text == "" || rbtn_KhuyenMai.Checked == false && rbtn_NgungKM.Checked == false)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else if (Convert.ToDateTime(dtPicker_NgayBatDau.Text) > Convert.ToDateTime(dtPicker_NgayKetThuc.Text) || DateTime.Now < Convert.ToDateTime(dtPicker_NgayBatDau.Text) || Convert.ToDateTime(dtPicker_NgayKetThuc.Text) < DateTime.Now)
            {
                MessageBox.Show("Không thể thêm vì ngày bắt đầu lớn hơn ngày kết thúc hoặc ngày hiện tại");
            }
            else
            {
                if (_km.TenKM == txt_TenKM.Text || (_km.TenKM != txt_TenKM.Text && _ikhuyenMaiService.GetAll().FirstOrDefault(x => x.TenKM == txt_TenKM.Text) == null))
                {
                    _km.TenKM = txt_TenKM.Text;
                    _km.NgayBatDau = Convert.ToDateTime(dtPicker_NgayBatDau.Text);
                    _km.NgayKetThuc = Convert.ToDateTime(dtPicker_NgayKetThuc.Text);
                    _km.GiamGia = Convert.ToInt32(txt_GiamGia.Text);
                    _km.TrangThai = rbtn_KhuyenMai.Checked == true ? 0 : 1;
                    _ikhuyenMaiService.Update(_km);
                    MessageBox.Show("Sửa Khuyến Mại thành công");
                    LoadDgrid();
                }
                else
                {
                    MessageBox.Show("Mã khuyến mại đã tồn tại");
                }
            }
        }

        private void btn_lamMoi_Click(object sender, EventArgs e)
        {
            txt_TenKM.Text = "";
            dtPicker_NgayBatDau.Text = "";
            dtPicker_NgayKetThuc.Text = "";
            txt_GiamGia.Text = "";
            rbtn_KhuyenMai.Checked = false;
            rbtn_NgungKM.Checked = false;
        }
    }
}
