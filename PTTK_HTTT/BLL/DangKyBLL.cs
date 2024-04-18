using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BLL
{
    public class DangKyBLL
    {
        private DAL.DangKyDAL dkDAL = new();
        public DangKyBLL() { }

        public bool check_Valid_DangKy_UV_Infor(DTO.UngVienDTO uv, string password)
        {
            if (uv.EMAIL == null || uv.EMAIL == "")
                MessageBox.Show("Email không được để trống");
            else if (uv.HOTEN == null || uv.HOTEN == "")
                MessageBox.Show("Họ tên không được để trống");
            else if (uv.PHAI == null || uv.PHAI == "")
                MessageBox.Show("Phái không được để trống");
            else if (uv.DIACHI == null || uv.DIACHI == "")
                MessageBox.Show("Địa chỉ không được để trống");
            else if (uv.SDT == null || uv.SDT == "")
                MessageBox.Show("Số điện thoại không được để trống");
            else if (password == null || password == "")
                MessageBox.Show("Mật khẩu không được để trống");
            else if (uv.EMAIL.Contains('@') == false)
                MessageBox.Show("Email không hợp lệ");
            else if (uv.EMAIL.Contains(' '))
                MessageBox.Show("Email không được chứa khoảng trắng");
            else if (uv.SDT.Any(c => c < '0' || c > '9'))
                MessageBox.Show("Số điện thoại chỉ chứa số");
            else if (uv.SDT.Contains(' '))
                MessageBox.Show("Số điện thoại không được chứa khoảng trắng");
            else if (password.Contains(' '))
                MessageBox.Show("Mật khẩu không được chứa khoảng trắng");
            else 
                return true;
            return false;
        }

        public bool check_Valid_DangKy_DN_Infor(DoanhNghiepDTO dn, string password)
        {
            if (dn.EMAIL == null || dn.EMAIL == "")
                MessageBox.Show("Email không được để trống");
            else if (dn.TENDN == null || dn.TENDN == "")
                MessageBox.Show("Tên doanh nghiệp không được để trống");
            else if (dn.MSTHUE == null || dn.MSTHUE == "")
                MessageBox.Show("Mã số thuế không được để trống");
            else if (dn.NGDAIDIEN == null || dn.NGDAIDIEN == "")
                MessageBox.Show("Người đại diện không được để trống");
            else if (dn.DIACHI == null || dn.DIACHI == "")
                MessageBox.Show("Địa chỉ không được để trống");
            else if (dn.SDT == null || dn.SDT == "")
                MessageBox.Show("Số điện thoại không được để trống");
            else if (password == null || password == "")
                MessageBox.Show("Mật khẩu không được để trống");
            else if (dn.EMAIL.Contains('@') == false)
                MessageBox.Show("Email không hợp lệ");
            else if (dn.EMAIL.Contains(' '))
                MessageBox.Show("Email không được chứa khoảng trắng");
            else if (dn.SDT.Any(c => c < '0' || c > '9'))
                MessageBox.Show("Số điện thoại chỉ chứa số");
            else if (dn.SDT.Contains(' '))
                MessageBox.Show("Số điện thoại không được chứa khoảng trắng");
            else if (password.Contains(' '))
                MessageBox.Show("Mật khẩu không được chứa khoảng trắng");
            else if (dn.MSTHUE.Length != 10)
                MessageBox.Show("Mã số thuế phải có 10 kí tự");
            else 
                return true;
            return false;
        }
        public bool checkExist(string email, string sdt)
        {
            string emailTmp = dkDAL.checkExist(email);
            if (emailTmp != null && emailTmp != "")
            {
                MessageBox.Show("Email đã tồn tại");
                return true;
            }

            string sdtTmp = dkDAL.checkExist(sdt);
            if (sdtTmp != null && sdtTmp != "")
            {
                MessageBox.Show("SDT đã tồn tại");
                return true;
            }
            return false;
        }
        public bool DangKy_UV(UngVienDTO uv, string password)
        {
            if (!check_Valid_DangKy_UV_Infor(uv, password))
                return false;
            if (checkExist(uv.EMAIL, uv.SDT))
            {
                return false;
            }

            dkDAL.DangKy_UV(uv, password);
            return true;
        }

        public bool DangKy_DN(DoanhNghiepDTO dn, string password)
        {
            if (!check_Valid_DangKy_DN_Infor(dn, password))
                return false;
            if (checkExist(dn.EMAIL, dn.SDT))
            {
                return false;
            }
            dkDAL.DangKy_DN(dn, password);
            return true;
        }
    }
}
