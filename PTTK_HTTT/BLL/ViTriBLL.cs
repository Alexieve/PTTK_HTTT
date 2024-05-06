using DAL;
using DTO;
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
    public class ViTriBLL
    {
        ViTriDAL _ViTriDAL;

        public ViTriBLL()
        {
            _ViTriDAL = new ViTriDAL();
        }

        public List<ViTriDTO> getAll()
        {
            DataTable dt = _ViTriDAL.getAll();
            List<ViTriDTO> listViTri = Utility.ToList<ViTriDTO>(dt);
            return listViTri;
        }
    }
}
