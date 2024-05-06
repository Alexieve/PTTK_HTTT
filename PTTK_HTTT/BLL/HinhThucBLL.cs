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
    public class HinhThucBLL
    {
        HinhThucDAL _HinhThucDAL;

        public HinhThucBLL()
        {
            _HinhThucDAL = new HinhThucDAL();
        }

        public List<HinhThucDTO> getAll()
        {
            DataTable dt = _HinhThucDAL.getAll();
            List<HinhThucDTO> listHinhThuc = Utility.ToList<HinhThucDTO>(dt);
            return listHinhThuc;
        }
    }
}
