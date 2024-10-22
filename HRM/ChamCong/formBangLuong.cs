using BusinessLayer;
using BusinessLayer.ClassChamCong;
using BusinessLayer.Convert_DTO;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using DevExpress.XtraSplashScreen;
using HRM.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRM.ChamCong
{
    public partial class formBangLuong : DevExpress.XtraEditors.XtraForm
    {
        public formBangLuong()
        {
            InitializeComponent();
        }
        TinhLuong _tinhLuong;
        List<TinhluongDTO> _tinhLuongList;
        void loadMaKyCong()
        {
            _tinhLuong = new TinhLuong();
            comboBoxMaKyCong.DataSource = _tinhLuong.GetMaKyCongList();
        }

        void LoadData()
        {
            _tinhLuong = new TinhLuong();
            _tinhLuongList = _tinhLuong.GetBangTinhluongDTOs(comboBoxMaKyCong.Text);
            if (_tinhLuongList == null || _tinhLuongList.Count == 0)
            {
               // MessageBox.Show("KỲ công này chưa được tính lương!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                gridControBangLuong.DataSource = _tinhLuongList;
                gridViewBangLuong.OptionsBehavior.Editable = false;
            }
            
        }
        private async void formBangLuong_Load(object sender, EventArgs e)
        {
           
            loadMaKyCong();
            LoadData();
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnTinhLuong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(_tinhLuong.checkTinhLuongchua(comboBoxMaKyCong.Text) == true)
            {
               DialogResult result = MessageBox.Show("Mã kỳ công đã được tính! Nếu muốn tính lại Nhấn nút YES", " Thông Báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
               
               if (result == DialogResult.Yes)
                {
                    string makycong = comboBoxMaKyCong.Text;
                    string sql = "DELETE FROM tb_BANGLUONG WHERE MAKYCONG = '" + makycong + "'";
                    Function.excuQuery(sql);
                    
                    SplashScreenManager.ShowForm(typeof(WaitFormLoad), true, true);
                    _tinhLuong.TinhLuongNhanVien(comboBoxMaKyCong.Text);
                    LoadData();
                    SplashScreenManager.CloseForm();
                }

            }
            else
            {
                SplashScreenManager.ShowForm(typeof(WaitFormLoad), true, true);
                _tinhLuong.TinhLuongNhanVien(comboBoxMaKyCong.Text);
                LoadData();
                SplashScreenManager.CloseForm();
            }
            
        }

        private void btnXemBangLuong_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(WaitFormLoad), true, true);
            LoadData();
            SplashScreenManager.CloseForm();
        }

   

        private async void comboBoxMaKyCong_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        
        }

        private void btnPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ReportPhieuLuongNhanVien rpt = new ReportPhieuLuongNhanVien(_tinhLuongList);
            rpt.ShowPreviewDialog();
        }


        List<TinhluongDTO> _LisDataGridView;
        public List<TinhluongDTO> getDanhSachGridView()
        {
            _LisDataGridView = new List<TinhluongDTO>();

            for (int i = 0; i < gridViewBangLuong.RowCount; i++)
            {
                var DTO_HOPDONG = new TinhluongDTO
                {
                    STT = i + 1,
                    MANV = gridViewBangLuong.GetRowCellValue(i, "MANV") != DBNull.Value ? Convert.ToInt32(gridViewBangLuong.GetRowCellValue(i, "MANV")) : 0000,
                    HOTEN = gridViewBangLuong.GetRowCellValue(i, "HOTEN") != DBNull.Value ? Convert.ToString(gridViewBangLuong.GetRowCellValue(i, "HOTEN")) : string.Empty,
                    TENPB = gridViewBangLuong.GetRowCellValue(i, "TENPB") != DBNull.Value ? Convert.ToString(gridViewBangLuong.GetRowCellValue(i, "TENPB")) : string.Empty,
                    MAKYCONG = gridViewBangLuong.GetRowCellValue(i, "MAKYCONG") != DBNull.Value ? Convert.ToString(gridViewBangLuong.GetRowCellValue(i, "MAKYCONG")) : "",
                    NGAYCONGTRONGTHANG = gridViewBangLuong.GetRowCellValue(i, "NGAYCONGTRONGTHANG") != DBNull.Value ? Convert.ToDouble(gridViewBangLuong.GetRowCellValue(i, "NGAYCONGTRONGTHANG")) : 0.0,
                    LUONGNGAYTHUONG = gridViewBangLuong.GetRowCellValue(i, "LUONGNGAYTHUONG") != DBNull.Value ? Convert.ToDouble(gridViewBangLuong.GetRowCellValue(i, "LUONGNGAYTHUONG")) : 0.0,
                    LUONGNGAYPHEP = gridViewBangLuong.GetRowCellValue(i, "LUONGNGAYPHEP") != DBNull.Value ? Convert.ToDouble(gridViewBangLuong.GetRowCellValue(i, "LUONGNGAYPHEP")) : 0.0,
                    LUONGNGAYCHUNHAT = gridViewBangLuong.GetRowCellValue(i, "LUONGNGAYCHUNHAT") != DBNull.Value ? Convert.ToDouble(gridViewBangLuong.GetRowCellValue(i, "LUONGNGAYCHUNHAT")) : 0,
                    LUONGTANGCA = gridViewBangLuong.GetRowCellValue(i, "LUONGTANGCA") != DBNull.Value ? Convert.ToDouble(gridViewBangLuong.GetRowCellValue(i, "LUONGTANGCA")) : 0,
                    PHUCAP = gridViewBangLuong.GetRowCellValue(i, "PHUCAP") != DBNull.Value ? Convert.ToDouble(gridViewBangLuong.GetRowCellValue(i, "PHUCAP")) : 0,
                    UNGLUONG = gridViewBangLuong.GetRowCellValue(i, "UNGLUONG") != DBNull.Value ? Convert.ToDouble(gridViewBangLuong.GetRowCellValue(i, "UNGLUONG")) : 0,
                    SOTIENKHENTHUONG = gridViewBangLuong.GetRowCellValue(i, "SOTIENKHENTHUONG") != DBNull.Value ? Convert.ToDouble(gridViewBangLuong.GetRowCellValue(i, "SOTIENKHENTHUONG")) : 0,
                    SOTIENKYLUAT = gridViewBangLuong.GetRowCellValue(i, "SOTIENKYLUAT") != DBNull.Value ? Convert.ToDouble(gridViewBangLuong.GetRowCellValue(i, "SOTIENKYLUAT")) : 0,
                    LUONGTHUCLANH = gridViewBangLuong.GetRowCellValue(i, "LUONGTHUCLANH") != DBNull.Value ? Convert.ToDouble(gridViewBangLuong.GetRowCellValue(i, "LUONGTHUCLANH")) : 0,
                    //UNGLUONG = gridViewBangLuong.GetRowCellValue(i, "UNGLUONG") != DBNull.Value ? Convert.ToDouble(gridViewBangLuong.GetRowCellValue(i, "UNGLUONG")) : 0,
                };


                _LisDataGridView.Add(DTO_HOPDONG);
            }


            return _LisDataGridView;
        }
        private void btnPrintfilter_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RePortGridViewFilterBangLuong rpt = new RePortGridViewFilterBangLuong(getDanhSachGridView());
            rpt.ShowPreviewDialog();
        }
    }
}