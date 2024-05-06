using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;

namespace BLL
{
    public class HoaDonBLL
    {
        HoaDonDAL _HoaDonDAL;
        public HoaDonBLL() 
        {
            _HoaDonDAL = new HoaDonDAL();
        }

        public List<HoaDonDTO> GET_BY_MAHOPDONG(string MAHOPDONG)
        {
            DataTable dt = _HoaDonDAL.GET_BY_MAHOPDONG(MAHOPDONG);
            List<HoaDonDTO> listHoaDon = Utility.ToList<HoaDonDTO>(dt);
            return listHoaDon;
        }

        public string THANH_TOAN(float SOTIEN, string HINHTHUCTT, string MAHOPDONG)
        {
            return _HoaDonDAL.THANH_TOAN(SOTIEN, HINHTHUCTT, MAHOPDONG);
        }
    }
}
