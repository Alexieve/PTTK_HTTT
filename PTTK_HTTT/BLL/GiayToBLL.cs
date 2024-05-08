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
    public class GiayToBLL
    {
        private GiayToDAL giayToDAL = new();
        public GiayToBLL() { }

        public string checkValid(GiayToDTO gt)
        {
            if (gt.LOAI == "")
            {
                return "Loại giấy tờ không được để trống";
            }

            if (gt.NOIDUNG == "")
            {
                return "Nội dung không được để trống";
            }
            return "";
        }

        public string checkDuplicate(List<DTO.GiayToDTO> listGT)
        {
            for (int i = 0; i < listGT.Count - 1; i++)
            {
                for (int j = i + 1; j < listGT.Count; j++)
                {
                    if (listGT[i].LOAI == listGT[j].LOAI)
                    {
                        return "Loại giấy tờ bị trùng";
                    }
                }
            }
            return "";
        }

        public void Insert(List<GiayToDTO> listGT)
        {
            foreach (GiayToDTO gt in listGT)
            {
                giayToDAL.Insert(gt);
            }
        }
        public void Insert(GiayToDTO gt)
        {
            giayToDAL.Insert(gt);
        }
        public void Update(GiayToDTO gt)
        {
            giayToDAL.Update(gt);
        }

        public void Delete(GiayToDTO gt)
        {
            giayToDAL.Delete(gt);
        }

        public List<GiayToDTO> Get_GiayTo_By_MAUV_MAHOPDONG(string MAUV, string MAHOPDONG)
        {
            DataTable dt = giayToDAL.Get_GiayTo_By_MAUV_MAHOPDONG(MAUV, MAHOPDONG);
            List<GiayToDTO> listGT = Utility.ToList<GiayToDTO>(dt);
            return listGT;
        }

        
    }
}
