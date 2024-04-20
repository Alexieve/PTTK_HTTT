using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class HopDongBLL
    {
        private HopDongDAL hopDongDAL = new HopDongDAL();
        public HopDongBLL() { }

        public List<HopDongDTO> Get_All_For_DuyetHS()
        {
            DataTable dt = hopDongDAL.Get_All_For_DuyetHS();
            List<HopDongDTO> listHD = Utility.ToList<HopDongDTO>(dt);
            return listHD;
        }

        public List<HopDongDTO> Get_All_For_PhanHoiHS()
        {
            DataTable dt = hopDongDAL.Get_All_For_PhanHoiHS();
            List<HopDongDTO> listHD = Utility.ToList<HopDongDTO>(dt);
            return listHD;
        }

        public string Get_YeuCauDN(string MAHOPDONG)
        {
            DataTable dt = hopDongDAL.Get_YeuCauDN(MAHOPDONG);
            return dt.Rows[0]["YEUCAU"].ToString();
        }
    }
}
