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
    public class CapBacBLL
    {
        CapBacDAL _CapBacDAL;

        public CapBacBLL()
        {
            _CapBacDAL = new CapBacDAL();
        }

        public List<CapBacDTO> getAll()
        {
            DataTable dt = _CapBacDAL.getAll();
            List<CapBacDTO> listCapBac = Utility.ToList<CapBacDTO>(dt);
            return listCapBac;
        }
    }
}
