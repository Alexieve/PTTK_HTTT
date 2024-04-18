using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace BLL
{
    public class DangNhapBLL
    {
        // private DAL in DAL namespace
        private DangNhapDAL dangNhapDAL = new DangNhapDAL();
        public DangNhapBLL() { }

        public string GetUsernameByEmailSDT(string username, string password)
        {
            if (username == "" || password == "")
            {
                MessageBox.Show("Không được để trống username hoặc mật khẩu");
                return null;
            }
            if (username.Length > 50 || password.Length > 50)
            {
                MessageBox.Show("Username hoặc mật khẩu không hợp lệ");
                return null;
            }
            if (username.Contains(" ") || password.Contains(" "))
            {
                MessageBox.Show("Username hoặc mật khẩu không hợp lệ");
                return null;
            }

            username = dangNhapDAL.GetUsernameByEmailSDT(username);
            if (username == null)
            {
                MessageBox.Show("Username hoặc mật khẩu không đúng");
                return null;
            }
            return username;
        }

        public string Connect(string username, string password)
        {
            return dangNhapDAL.Connect(username, password);
        }
    }
}
